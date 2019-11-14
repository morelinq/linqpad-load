// This file is designed to be hash-loaded (#load) into another using the
// [referencing][1] feature added in LINQPad 6. Doing so will add a reference
// to the MoreLINQ package to the loading query as well as import all extensions
// in a non-conflicting manner.
//
// [1]: https://www.linqpad.net/LinqReference.aspx

// The following query generates the list of static imports from MoreLINQ
// where the extension does not have an identially named extension method
// on System.Linq.Enumerable.
//
// For background, see:
// https://github.com/morelinq/MoreLINQ/tree/v3.2.0#usage
