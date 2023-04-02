<Query Kind="Statements">
  <NuGetReference Version="3.3.2">morelinq</NuGetReference>
</Query>
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

using MoreEnumerable = MoreLinq.MoreEnumerable;
using static MoreLinq.Extensions.AcquireExtension;
using static MoreLinq.Extensions.AggregateExtension;
using static MoreLinq.Extensions.AggregateRightExtension;
using static MoreLinq.Extensions.AssertCountExtension;
using static MoreLinq.Extensions.AssertExtension;
using static MoreLinq.Extensions.AtLeastExtension;
using static MoreLinq.Extensions.AtMostExtension;
using static MoreLinq.Extensions.BacksertExtension;
using static MoreLinq.Extensions.BatchExtension;
using static MoreLinq.Extensions.CartesianExtension;
using static MoreLinq.Extensions.ChooseExtension;
using static MoreLinq.Extensions.CompareCountExtension;
using static MoreLinq.Extensions.ConsumeExtension;
using static MoreLinq.Extensions.CountBetweenExtension;
using static MoreLinq.Extensions.CountByExtension;
using static MoreLinq.Extensions.CountDownExtension;
using static MoreLinq.Extensions.DistinctByExtension;
using static MoreLinq.Extensions.EndsWithExtension;
using static MoreLinq.Extensions.EquiZipExtension;
using static MoreLinq.Extensions.EvaluateExtension;
using static MoreLinq.Extensions.ExactlyExtension;
using static MoreLinq.Extensions.ExceptByExtension;
using static MoreLinq.Extensions.ExcludeExtension;
using static MoreLinq.Extensions.FallbackIfEmptyExtension;
using static MoreLinq.Extensions.FillBackwardExtension;
using static MoreLinq.Extensions.FillForwardExtension;
using static MoreLinq.Extensions.FlattenExtension;
using static MoreLinq.Extensions.FoldExtension;
using static MoreLinq.Extensions.ForEachExtension;
using static MoreLinq.Extensions.FullGroupJoinExtension;
using static MoreLinq.Extensions.FullJoinExtension;
using static MoreLinq.Extensions.GroupAdjacentExtension;
using static MoreLinq.Extensions.IndexByExtension;
using static MoreLinq.Extensions.IndexExtension;
using static MoreLinq.Extensions.InsertExtension;
using static MoreLinq.Extensions.InterleaveExtension;
using static MoreLinq.Extensions.LagExtension;
using static MoreLinq.Extensions.LeadExtension;
using static MoreLinq.Extensions.LeftJoinExtension;
#if !NET6 && !NET7
using static MoreLinq.Extensions.MaxByExtension;
using static MoreLinq.Extensions.MinByExtension;
#endif
using static MoreLinq.Extensions.MoveExtension;
using static MoreLinq.Extensions.OrderedMergeExtension;
using static MoreLinq.Extensions.PadExtension;
using static MoreLinq.Extensions.PadStartExtension;
using static MoreLinq.Extensions.PairwiseExtension;
using static MoreLinq.Extensions.PartialSortByExtension;
using static MoreLinq.Extensions.PartialSortExtension;
using static MoreLinq.Extensions.PartitionExtension;
using static MoreLinq.Extensions.PermutationsExtension;
using static MoreLinq.Extensions.PipeExtension;
using static MoreLinq.Extensions.PreScanExtension;
using static MoreLinq.Extensions.RandomSubsetExtension;
using static MoreLinq.Extensions.RankByExtension;
using static MoreLinq.Extensions.RankExtension;
using static MoreLinq.Extensions.RepeatExtension;
using static MoreLinq.Extensions.RightJoinExtension;
using static MoreLinq.Extensions.RunLengthEncodeExtension;
using static MoreLinq.Extensions.ScanByExtension;
using static MoreLinq.Extensions.ScanExtension;
using static MoreLinq.Extensions.ScanRightExtension;
using static MoreLinq.Extensions.SegmentExtension;
using static MoreLinq.Extensions.ShuffleExtension;
using static MoreLinq.Extensions.SkipUntilExtension;
using static MoreLinq.Extensions.SliceExtension;
using static MoreLinq.Extensions.SortedMergeExtension;
using static MoreLinq.Extensions.SplitExtension;
using static MoreLinq.Extensions.StartsWithExtension;
using static MoreLinq.Extensions.SubsetsExtension;
using static MoreLinq.Extensions.TagFirstLastExtension;
using static MoreLinq.Extensions.TakeEveryExtension;
using static MoreLinq.Extensions.TakeUntilExtension;
using static MoreLinq.Extensions.ToArrayByIndexExtension;
using static MoreLinq.Extensions.ToDataTableExtension;
using static MoreLinq.Extensions.ToDelimitedStringExtension;
using static MoreLinq.Extensions.ToDictionaryExtension;
using static MoreLinq.Extensions.TraceExtension;
using static MoreLinq.Extensions.TransposeExtension;
using static MoreLinq.Extensions.WindowExtension;
using static MoreLinq.Extensions.WindowLeftExtension;
using static MoreLinq.Extensions.WindowRightExtension;
using static MoreLinq.Extensions.ZipLongestExtension;
using static MoreLinq.Extensions.ZipShortestExtension;
