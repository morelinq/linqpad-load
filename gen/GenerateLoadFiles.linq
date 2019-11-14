<Query Kind="Statements">
  <NuGetReference Version="1.3.1">Dsv</NuGetReference>
  <NuGetReference Version="5.3.1">NuGet.Versioning</NuGetReference>
  <Namespace>Dsv</Namespace>
  <Namespace>NuGet.Versioning</Namespace>
  <RemoveNamespace>System.Collections</RemoveNamespace>
  <RemoveNamespace>System.Data</RemoveNamespace>
  <RemoveNamespace>System.Linq.Expressions</RemoveNamespace>
  <RemoveNamespace>System.Reflection</RemoveNamespace>
  <RemoveNamespace>System.Transactions</RemoveNamespace>
  <RemoveNamespace>System.Xml.XPath</RemoveNamespace>
</Query>

// MIT License
//
// Copyright (c) 2019 Atif Aziz
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

var queryDirPath = Path.GetDirectoryName(Util.CurrentQueryPath);
var templatePath = Path.Combine(queryDirPath, "ListNonConflictingExtensions.linq");
var template = File.ReadAllText(templatePath);

var versions =
    Enumerable.ToArray(
        from v in new[]
        {
            "3.2.0",
            "3.1.1",
            "3.1.0",
            "3.0.0",
        }
        select NuGetVersion.Parse(v));

var latestVersion = versions.Max();

foreach (var e in
    from v in versions
    select new
    {
        Version    = v,
        TempPath   = Path.Combine(Path.GetTempPath(), $"MoreLinq-{v}.linq"),
        OutputPath = Path.Combine(queryDirPath, $@"..\MoreLinq-{v}.linq"),
        Content    = Regex.Replace(template,
                                   @"(?<=<NuGetReference +Version="").+?(?="" *> *morelinq *</NuGetReference>)",
                                   v.ToString()),
    })
{
    Console.WriteLine(e.Version);

    File.WriteAllText(e.TempPath, e.Content);
    var csv = await Util.Run(e.TempPath, QueryResultFormat.CultureInvariantCsv).AsStringAsync();

    var imports =
        from s in Regex.Split(csv, @"\r?\n")
                       .ParseCsv(r => r, (hr, dr) => dr.Count > 0 ? dr[0] : null)
        where !string.IsNullOrEmpty(s)
        orderby s
        select s;

    var xml =
        new XElement("Query",
            new XAttribute("Kind", "Expression"),
            new XElement("NuGetReference", new XAttribute("Version", e.Version), "morelinq"),
            new XElement("Namespace", "MoreEnumerable = MoreLinq.MoreEnumerable"),
            from imp in imports
            select new XElement("Namespace", $"static " + imp));
    
    using var os = new StreamWriter(e.OutputPath, append: false, new UTF8Encoding(false));
    using var w = XmlWriter.Create(os, new XmlWriterSettings { OmitXmlDeclaration = true, Indent = true });
    
    xml.Save(w);
    w.Flush();
    os.WriteLine();

    foreach (var line in File.ReadLines(Path.Combine(queryDirPath, "Header.cs")))
        os.WriteLine(line);
}

File.Copy(Path.Combine(queryDirPath, $@"..\MoreLinq-{latestVersion}.linq"),
          Path.Combine(queryDirPath, $@"..\MoreLinq.linq"),
          overwrite: true);
