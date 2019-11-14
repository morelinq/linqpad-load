# LINQPad `#load` MoreLINQ

[LINQPad] 6 added a neat feature that allows [one query to reference
another][linqref] using a `#load` directive. This repository contains queries
that can be loaded into others to make MoreLINQ and its extensions available
without having to manually add a NuGet reference and imports each time.

This repository is designed to be cloned directly under your **My Queries**
folder in LINQPad (`Util.MyQueriesFolder`). Keeping up with changes is then as
simple as doing a `git pull` on your local clone.

Suppose you have cloned this repository into a sub-folder **My Queries**
called `MoreLINQ\load`. You can then light-up MoreLINQ in a query by simply
adding the following line at the top:

    #load "MoreLINQ\load\MoreLinq.linq"

`MoreLinq.linq` will always reference the latest version. However, there are
files for different versions if you wish to use or pin to a specific one.
For example, to use [version 3.2.0][v.3.2.0], you would instead load the
corresponding query file:

    #load "MoreLINQ\load\MoreLinq-3.2.0.linq"

Starting with [version 3][v3.x], extensions are imported in a non-conflicting
manner using [static imports]. For background and details on this, see the
[Usage section in MoreLINQ's README][usage] document.


[LINQPad]: https://www.linqpad.net/
[linqref]: https://www.linqpad.net/LinqReference.aspx
[v3.x]: https://github.com/morelinq/MoreLINQ/releases/tag/v3.0.0
[v3.2.0]: https://www.nuget.org/packages/morelinq/3.2.0
[usage]: https://github.com/morelinq/MoreLINQ/tree/v3.2.0#usage
[static imports]: https://docs.microsoft.com/en-us/dotnet/articles/csharp/whats-new/csharp-6#using-static
