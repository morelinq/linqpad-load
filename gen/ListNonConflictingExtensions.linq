<Query Kind="Expression">
  <NuGetReference Version="3.2.0">morelinq</NuGetReference>
  <Namespace>System.Runtime.CompilerServices</Namespace>
  <RemoveNamespace>System</RemoveNamespace>
  <RemoveNamespace>System.Collections</RemoveNamespace>
  <RemoveNamespace>System.Collections.Generic</RemoveNamespace>
  <RemoveNamespace>System.Data</RemoveNamespace>
  <RemoveNamespace>System.Diagnostics</RemoveNamespace>
  <RemoveNamespace>System.IO</RemoveNamespace>
  <RemoveNamespace>System.Linq.Expressions</RemoveNamespace>
  <RemoveNamespace>System.Text</RemoveNamespace>
  <RemoveNamespace>System.Text.RegularExpressions</RemoveNamespace>
  <RemoveNamespace>System.Threading</RemoveNamespace>
  <RemoveNamespace>System.Transactions</RemoveNamespace>
  <RemoveNamespace>System.Xml</RemoveNamespace>
  <RemoveNamespace>System.Xml.Linq</RemoveNamespace>
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

from xs in new[]
{
    from e in new[]
    {
        "AggregateExtension",
        nameof(MoreLinq.Extensions.ToDictionaryExtension),
    }
    select string.Join(".", nameof(MoreLinq), nameof(MoreLinq.Extensions), e)
}
select xs.ToHashSet() into xs
from t in typeof(MoreLinq.MoreEnumerable).Assembly.GetExportedTypes()
where t.Namespace == nameof(MoreLinq) + "." + nameof(MoreLinq.Extensions)
join m in
    from ms in new[]
    {
        from m in typeof(Enumerable).GetMethods(BindingFlags.Public | BindingFlags.Static)
        where m.IsDefined(typeof(ExtensionAttribute))
        select m.Name
    }
    from m in ms.Distinct()
    select m
on t.Name[..^"Extension".Length] equals m into j
select new
{
    MoreLinqExtension = t.FullName,
    SystemLinqExtension = j.SingleOrDefault(),
    Excepted = xs.Contains(t.FullName),
}
into e
where e.Excepted
   || e.SystemLinqExtension == null
orderby e.MoreLinqExtension
select e.MoreLinqExtension
