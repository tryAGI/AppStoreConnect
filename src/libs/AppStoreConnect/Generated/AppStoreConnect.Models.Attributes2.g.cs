#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Attributes2 : global::System.IEquatable<Attributes2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState? State { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes? AwaitingUpload { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes? AwaitingUpload { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AwaitingUpload))]
#endif
        public bool IsAwaitingUpload => AwaitingUpload != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAwaitingUpload(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes? value)
        {
            value = AwaitingUpload;
            return IsAwaitingUpload;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes PickAwaitingUpload() => AwaitingUpload is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AwaitingUpload' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes? UploadComplete { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes? UploadComplete { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UploadComplete))]
#endif
        public bool IsUploadComplete => UploadComplete != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUploadComplete(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes? value)
        {
            value = UploadComplete;
            return IsUploadComplete;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes PickUploadComplete() => UploadComplete is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UploadComplete' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes? Failed { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes? Failed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes PickFailed() => Failed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? Complete1 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? Complete1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Complete1))]
#endif
        public bool IsComplete1 => Complete1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComplete1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            value = Complete1;
            return IsComplete1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes PickComplete1() => Complete1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Complete1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? Complete2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? Complete2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Complete2))]
#endif
        public bool IsComplete2 => Complete2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComplete2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            value = Complete2;
            return IsComplete2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes PickComplete2() => Complete2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Complete2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes? ReadyForReview { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes? ReadyForReview { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReadyForReview))]
#endif
        public bool IsReadyForReview => ReadyForReview != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReadyForReview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes? value)
        {
            value = ReadyForReview;
            return IsReadyForReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes PickReadyForReview() => ReadyForReview is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReadyForReview' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes? WaitingForReview { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes? WaitingForReview { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WaitingForReview))]
#endif
        public bool IsWaitingForReview => WaitingForReview != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWaitingForReview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes? value)
        {
            value = WaitingForReview;
            return IsWaitingForReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes PickWaitingForReview() => WaitingForReview is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WaitingForReview' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes? InReview { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes? InReview { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InReview))]
#endif
        public bool IsInReview => InReview != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInReview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes? value)
        {
            value = InReview;
            return IsInReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes PickInReview() => InReview is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InReview' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes? Accepted { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes? Accepted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Accepted))]
#endif
        public bool IsAccepted => Accepted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAccepted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes? value)
        {
            value = Accepted;
            return IsAccepted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes PickAccepted() => Accepted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Accepted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes? Approved { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes? Approved { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Approved))]
#endif
        public bool IsApproved => Approved != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApproved(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes? value)
        {
            value = Approved;
            return IsApproved;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes PickApproved() => Approved is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Approved' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes? Rejected { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes? Rejected { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rejected))]
#endif
        public bool IsRejected => Rejected != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRejected(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes? value)
        {
            value = Rejected;
            return IsRejected;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes PickRejected() => Rejected is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Rejected' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes? Archived { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes? Archived { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Archived))]
#endif
        public bool IsArchived => Archived != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArchived(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes? value)
        {
            value = Archived;
            return IsArchived;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes PickArchived() => Archived is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Archived' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes?(Attributes2 @this) => @this.AwaitingUpload;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes? value)
        {
            AwaitingUpload = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromAwaitingUpload(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes?(Attributes2 @this) => @this.UploadComplete;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes? value)
        {
            UploadComplete = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromUploadComplete(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes?(Attributes2 @this) => @this.Failed;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes? value)
        {
            Failed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromFailed(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?(Attributes2 @this) => @this.Complete1;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            Complete1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromComplete1(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes?(Attributes2 @this) => @this.ReadyForReview;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes? value)
        {
            ReadyForReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromReadyForReview(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes?(Attributes2 @this) => @this.WaitingForReview;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes? value)
        {
            WaitingForReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromWaitingForReview(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes?(Attributes2 @this) => @this.InReview;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes? value)
        {
            InReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromInReview(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes?(Attributes2 @this) => @this.Accepted;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes? value)
        {
            Accepted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromAccepted(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes?(Attributes2 @this) => @this.Approved;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes? value)
        {
            Approved = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromApproved(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes?(Attributes2 @this) => @this.Rejected;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes? value)
        {
            Rejected = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromRejected(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes2(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes value) => new Attributes2((global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes?(Attributes2 @this) => @this.Archived;

        /// <summary>
        ///
        /// </summary>
        public Attributes2(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes? value)
        {
            Archived = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes2 FromArchived(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes? value) => new Attributes2(value);

        /// <summary>
        ///
        /// </summary>
        public Attributes2(
            global::AppStoreConnect.AppAssetLibraryVideoAttributesDiscriminatorState? state,
            global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes? awaitingUpload,
            global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes? uploadComplete,
            global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes? failed,
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? complete1,
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? complete2,
            global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes? readyForReview,
            global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes? waitingForReview,
            global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes? inReview,
            global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes? accepted,
            global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes? approved,
            global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes? rejected,
            global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes? archived
            )
        {
            State = state;

            AwaitingUpload = awaitingUpload;
            UploadComplete = uploadComplete;
            Failed = failed;
            Complete1 = complete1;
            Complete2 = complete2;
            ReadyForReview = readyForReview;
            WaitingForReview = waitingForReview;
            InReview = inReview;
            Accepted = accepted;
            Approved = approved;
            Rejected = rejected;
            Archived = archived;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Archived as object ??
            Rejected as object ??
            Approved as object ??
            Accepted as object ??
            InReview as object ??
            WaitingForReview as object ??
            ReadyForReview as object ??
            Complete2 as object ??
            Complete1 as object ??
            Failed as object ??
            UploadComplete as object ??
            AwaitingUpload as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AwaitingUpload?.ToString() ??
            UploadComplete?.ToString() ??
            Failed?.ToString() ??
            Complete1?.ToString() ??
            Complete2?.ToString() ??
            ReadyForReview?.ToString() ??
            WaitingForReview?.ToString() ??
            InReview?.ToString() ??
            Accepted?.ToString() ??
            Approved?.ToString() ??
            Rejected?.ToString() ??
            Archived?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && IsInReview && !IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && IsAccepted && !IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && IsApproved && !IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && IsRejected && !IsArchived || !IsAwaitingUpload && !IsUploadComplete && !IsFailed && !IsComplete1 && !IsComplete2 && !IsReadyForReview && !IsWaitingForReview && !IsInReview && !IsAccepted && !IsApproved && !IsRejected && IsArchived;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes?, TResult>? awaitingUpload = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes?, TResult>? uploadComplete = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes?, TResult>? failed = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes, TResult>? complete1 = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes, TResult>? complete2 = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes?, TResult>? readyForReview = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes?, TResult>? waitingForReview = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes?, TResult>? inReview = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes?, TResult>? accepted = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes?, TResult>? approved = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes?, TResult>? rejected = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes?, TResult>? archived = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AwaitingUpload is { } __value0 && awaitingUpload != null)
            {
                return awaitingUpload(__value0);
            }
            else if (UploadComplete is { } __value1 && uploadComplete != null)
            {
                return uploadComplete(__value1);
            }
            else if (Failed is { } __value2 && failed != null)
            {
                return failed(__value2);
            }
            else if (Complete1 is { } __value3 && complete1 != null)
            {
                return complete1(__value3);
            }
            else if (Complete2 is { } __value4 && complete2 != null)
            {
                return complete2(__value4);
            }
            else if (ReadyForReview is { } __value5 && readyForReview != null)
            {
                return readyForReview(__value5);
            }
            else if (WaitingForReview is { } __value6 && waitingForReview != null)
            {
                return waitingForReview(__value6);
            }
            else if (InReview is { } __value7 && inReview != null)
            {
                return inReview(__value7);
            }
            else if (Accepted is { } __value8 && accepted != null)
            {
                return accepted(__value8);
            }
            else if (Approved is { } __value9 && approved != null)
            {
                return approved(__value9);
            }
            else if (Rejected is { } __value10 && rejected != null)
            {
                return rejected(__value10);
            }
            else if (Archived is { } __value11 && archived != null)
            {
                return archived(__value11);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes?>? awaitingUpload = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes?>? uploadComplete = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes?>? failed = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? complete1 = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? complete2 = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes?>? readyForReview = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes?>? waitingForReview = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes?>? inReview = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes?>? accepted = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes?>? approved = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes?>? rejected = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes?>? archived = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AwaitingUpload is { } __value0)
            {
                awaitingUpload?.Invoke(__value0);
            }
            else if (UploadComplete is { } __value1)
            {
                uploadComplete?.Invoke(__value1);
            }
            else if (Failed is { } __value2)
            {
                failed?.Invoke(__value2);
            }
            else if (Complete1 is { } __value3)
            {
                complete1?.Invoke(__value3);
            }
            else if (Complete2 is { } __value4)
            {
                complete2?.Invoke(__value4);
            }
            else if (ReadyForReview is { } __value5)
            {
                readyForReview?.Invoke(__value5);
            }
            else if (WaitingForReview is { } __value6)
            {
                waitingForReview?.Invoke(__value6);
            }
            else if (InReview is { } __value7)
            {
                inReview?.Invoke(__value7);
            }
            else if (Accepted is { } __value8)
            {
                accepted?.Invoke(__value8);
            }
            else if (Approved is { } __value9)
            {
                approved?.Invoke(__value9);
            }
            else if (Rejected is { } __value10)
            {
                rejected?.Invoke(__value10);
            }
            else if (Archived is { } __value11)
            {
                archived?.Invoke(__value11);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes?>? awaitingUpload = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes?>? uploadComplete = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes?>? failed = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? complete1 = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? complete2 = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes?>? readyForReview = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes?>? waitingForReview = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes?>? inReview = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes?>? accepted = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes?>? approved = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes?>? rejected = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes?>? archived = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AwaitingUpload is { } __value0)
            {
                awaitingUpload?.Invoke(__value0);
            }
            else if (UploadComplete is { } __value1)
            {
                uploadComplete?.Invoke(__value1);
            }
            else if (Failed is { } __value2)
            {
                failed?.Invoke(__value2);
            }
            else if (Complete1 is { } __value3)
            {
                complete1?.Invoke(__value3);
            }
            else if (Complete2 is { } __value4)
            {
                complete2?.Invoke(__value4);
            }
            else if (ReadyForReview is { } __value5)
            {
                readyForReview?.Invoke(__value5);
            }
            else if (WaitingForReview is { } __value6)
            {
                waitingForReview?.Invoke(__value6);
            }
            else if (InReview is { } __value7)
            {
                inReview?.Invoke(__value7);
            }
            else if (Accepted is { } __value8)
            {
                accepted?.Invoke(__value8);
            }
            else if (Approved is { } __value9)
            {
                approved?.Invoke(__value9);
            }
            else if (Rejected is { } __value10)
            {
                rejected?.Invoke(__value10);
            }
            else if (Archived is { } __value11)
            {
                archived?.Invoke(__value11);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AwaitingUpload,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes),
                UploadComplete,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes),
                Failed,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes),
                Complete1,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes),
                Complete2,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes),
                ReadyForReview,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes),
                WaitingForReview,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes),
                InReview,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes),
                Accepted,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes),
                Approved,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes),
                Rejected,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes),
                Archived,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(Attributes2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributes?>.Default.Equals(AwaitingUpload, other.AwaitingUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributes?>.Default.Equals(UploadComplete, other.UploadComplete) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributes?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?>.Default.Equals(Complete1, other.Complete1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?>.Default.Equals(Complete2, other.Complete2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoReadyForReviewAttributes?>.Default.Equals(ReadyForReview, other.ReadyForReview) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoWaitingForReviewAttributes?>.Default.Equals(WaitingForReview, other.WaitingForReview) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoInReviewAttributes?>.Default.Equals(InReview, other.InReview) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoAcceptedAttributes?>.Default.Equals(Accepted, other.Accepted) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoApprovedAttributes?>.Default.Equals(Approved, other.Approved) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoRejectedAttributes?>.Default.Equals(Rejected, other.Rejected) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoArchivedAttributes?>.Default.Equals(Archived, other.Archived)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Attributes2 obj1, Attributes2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Attributes2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Attributes2 obj1, Attributes2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Attributes2 o && Equals(o);
        }
    }
}
