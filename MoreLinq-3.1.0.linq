<Query Kind="Statements">
  <NuGetReference Version="3.1.0">morelinq</NuGetReference>
  <Namespace>MoreEnumerable = MoreLinq.MoreEnumerable</Namespace>
  <Namespace>static MoreLinq.Extensions.AcquireExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.AggregateRightExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.AssertCountExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.AssertExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.AtLeastExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.AtMostExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.BacksertExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.BatchExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.CartesianExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ChooseExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.CompareCountExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ConsumeExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.CountBetweenExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.CountByExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.CountDownExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.DistinctByExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.EndsWithExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.EquiZipExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.EvaluateExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ExactlyExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ExceptByExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ExcludeExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.FallbackIfEmptyExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.FillBackwardExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.FillForwardExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.FlattenExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.FoldExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ForEachExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.FullGroupJoinExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.FullJoinExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.GroupAdjacentExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.IndexExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.InsertExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.InterleaveExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.LagExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.LeadExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.LeftJoinExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.MaxByExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.MinByExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.MoveExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.OrderedMergeExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PadExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PadStartExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PairwiseExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PartialSortByExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PartialSortExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PartitionExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PermutationsExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PipeExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.PreScanExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.RandomSubsetExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.RankByExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.RankExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.RepeatExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.RightJoinExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.RunLengthEncodeExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ScanExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ScanRightExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.SegmentExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ShuffleExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.SkipUntilExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.SliceExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.SortedMergeExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.SplitExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.StartsWithExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.SubsetsExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.TagFirstLastExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.TakeEveryExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.TakeUntilExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ToArrayByIndexExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ToDataTableExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ToDelimitedStringExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ToDictionaryExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.TraceExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.TransposeExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.WindowExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.WindowLeftExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.WindowRightExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ZipLongestExtension</Namespace>
  <Namespace>static MoreLinq.Extensions.ZipShortestExtension</Namespace>
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
