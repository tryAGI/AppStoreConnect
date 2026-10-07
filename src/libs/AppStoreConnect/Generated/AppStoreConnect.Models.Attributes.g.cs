#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Attributes : global::System.IEquatable<Attributes>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState? State { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes? AwaitingUpload { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes? AwaitingUpload { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes? value)
        {
            value = AwaitingUpload;
            return IsAwaitingUpload;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes PickAwaitingUpload() => AwaitingUpload is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AwaitingUpload' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes? UploadComplete { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes? UploadComplete { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes? value)
        {
            value = UploadComplete;
            return IsUploadComplete;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes PickUploadComplete() => UploadComplete is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UploadComplete' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageFailedAttributes? Failed { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageFailedAttributes? Failed { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageFailedAttributes? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageFailedAttributes PickFailed() => Failed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? Complete1 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? Complete1 { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            value = Complete1;
            return IsComplete1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes PickComplete1() => Complete1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Complete1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? Complete2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? Complete2 { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            value = Complete2;
            return IsComplete2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes PickComplete2() => Complete2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Complete2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes? ReadyForReview { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes? ReadyForReview { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes? value)
        {
            value = ReadyForReview;
            return IsReadyForReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes PickReadyForReview() => ReadyForReview is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReadyForReview' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes? WaitingForReview { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes? WaitingForReview { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes? value)
        {
            value = WaitingForReview;
            return IsWaitingForReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes PickWaitingForReview() => WaitingForReview is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WaitingForReview' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes? InReview { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes? InReview { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes? value)
        {
            value = InReview;
            return IsInReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes PickInReview() => InReview is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InReview' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes? Accepted { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes? Accepted { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes? value)
        {
            value = Accepted;
            return IsAccepted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes PickAccepted() => Accepted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Accepted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes? Approved { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes? Approved { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes? value)
        {
            value = Approved;
            return IsApproved;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes PickApproved() => Approved is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Approved' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes? Rejected { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes? Rejected { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes? value)
        {
            value = Rejected;
            return IsRejected;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes PickRejected() => Rejected is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Rejected' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes? Archived { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes? Archived { get; }
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
            out global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes? value)
        {
            value = Archived;
            return IsArchived;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes PickArchived() => Archived is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Archived' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes?(Attributes @this) => @this.AwaitingUpload;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes? value)
        {
            AwaitingUpload = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromAwaitingUpload(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes?(Attributes @this) => @this.UploadComplete;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes? value)
        {
            UploadComplete = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromUploadComplete(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageFailedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageFailedAttributes?(Attributes @this) => @this.Failed;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes? value)
        {
            Failed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromFailed(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?(Attributes @this) => @this.Complete1;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            Complete1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromComplete1(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes?(Attributes @this) => @this.ReadyForReview;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes? value)
        {
            ReadyForReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromReadyForReview(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes?(Attributes @this) => @this.WaitingForReview;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes? value)
        {
            WaitingForReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromWaitingForReview(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes?(Attributes @this) => @this.InReview;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes? value)
        {
            InReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromInReview(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes?(Attributes @this) => @this.Accepted;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes? value)
        {
            Accepted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromAccepted(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes?(Attributes @this) => @this.Approved;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes? value)
        {
            Approved = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromApproved(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes?(Attributes @this) => @this.Rejected;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes? value)
        {
            Rejected = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromRejected(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attributes(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes value) => new Attributes((global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes?(Attributes @this) => @this.Archived;

        /// <summary>
        ///
        /// </summary>
        public Attributes(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes? value)
        {
            Archived = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attributes FromArchived(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes? value) => new Attributes(value);

        /// <summary>
        ///
        /// </summary>
        public Attributes(
            global::AppStoreConnect.AppAssetLibraryImageAttributesDiscriminatorState? state,
            global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes? awaitingUpload,
            global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes? uploadComplete,
            global::AppStoreConnect.AppAssetLibraryImageFailedAttributes? failed,
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? complete1,
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? complete2,
            global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes? readyForReview,
            global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes? waitingForReview,
            global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes? inReview,
            global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes? accepted,
            global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes? approved,
            global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes? rejected,
            global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes? archived
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
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes?, TResult>? awaitingUpload = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes?, TResult>? uploadComplete = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageFailedAttributes?, TResult>? failed = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes, TResult>? complete1 = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes, TResult>? complete2 = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes?, TResult>? readyForReview = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes?, TResult>? waitingForReview = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes?, TResult>? inReview = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes?, TResult>? accepted = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes?, TResult>? approved = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes?, TResult>? rejected = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes?, TResult>? archived = null,
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
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes?>? awaitingUpload = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes?>? uploadComplete = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageFailedAttributes?>? failed = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? complete1 = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? complete2 = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes?>? readyForReview = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes?>? waitingForReview = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes?>? inReview = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes?>? accepted = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes?>? approved = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes?>? rejected = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes?>? archived = null,
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
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes?>? awaitingUpload = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes?>? uploadComplete = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageFailedAttributes?>? failed = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? complete1 = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? complete2 = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes?>? readyForReview = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes?>? waitingForReview = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes?>? inReview = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes?>? accepted = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes?>? approved = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes?>? rejected = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes?>? archived = null,
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
                typeof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes),
                UploadComplete,
                typeof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes),
                Failed,
                typeof(global::AppStoreConnect.AppAssetLibraryImageFailedAttributes),
                Complete1,
                typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes),
                Complete2,
                typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes),
                ReadyForReview,
                typeof(global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes),
                WaitingForReview,
                typeof(global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes),
                InReview,
                typeof(global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes),
                Accepted,
                typeof(global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes),
                Approved,
                typeof(global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes),
                Rejected,
                typeof(global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes),
                Archived,
                typeof(global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes),
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
        public bool Equals(Attributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributes?>.Default.Equals(AwaitingUpload, other.AwaitingUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributes?>.Default.Equals(UploadComplete, other.UploadComplete) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageFailedAttributes?>.Default.Equals(Failed, other.Failed) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?>.Default.Equals(Complete1, other.Complete1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?>.Default.Equals(Complete2, other.Complete2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageReadyForReviewAttributes?>.Default.Equals(ReadyForReview, other.ReadyForReview) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageWaitingForReviewAttributes?>.Default.Equals(WaitingForReview, other.WaitingForReview) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageInReviewAttributes?>.Default.Equals(InReview, other.InReview) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageAcceptedAttributes?>.Default.Equals(Accepted, other.Accepted) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageApprovedAttributes?>.Default.Equals(Approved, other.Approved) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageRejectedAttributes?>.Default.Equals(Rejected, other.Rejected) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageArchivedAttributes?>.Default.Equals(Archived, other.Archived)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Attributes obj1, Attributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Attributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Attributes obj1, Attributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Attributes o && Equals(o);
        }
    }
}
