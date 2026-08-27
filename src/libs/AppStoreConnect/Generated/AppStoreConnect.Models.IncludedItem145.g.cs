#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem145 : global::System.IEquatable<IncludedItem145>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot? InAppPurchaseAppStoreReviewScreenshots { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot? InAppPurchaseAppStoreReviewScreenshots { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseAppStoreReviewScreenshots))]
#endif
        public bool IsInAppPurchaseAppStoreReviewScreenshots => InAppPurchaseAppStoreReviewScreenshots != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchaseAppStoreReviewScreenshots(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot? value)
        {
            value = InAppPurchaseAppStoreReviewScreenshots;
            return IsInAppPurchaseAppStoreReviewScreenshots;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot PickInAppPurchaseAppStoreReviewScreenshots() => IsInAppPurchaseAppStoreReviewScreenshots
            ? InAppPurchaseAppStoreReviewScreenshots!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseAppStoreReviewScreenshots' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseAvailability? InAppPurchaseAvailabilities { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseAvailability? InAppPurchaseAvailabilities { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseAvailabilities))]
#endif
        public bool IsInAppPurchaseAvailabilities => InAppPurchaseAvailabilities != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchaseAvailabilities(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseAvailability? value)
        {
            value = InAppPurchaseAvailabilities;
            return IsInAppPurchaseAvailabilities;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseAvailability PickInAppPurchaseAvailabilities() => IsInAppPurchaseAvailabilities
            ? InAppPurchaseAvailabilities!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseAvailabilities' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseContent? InAppPurchaseContents { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseContent? InAppPurchaseContents { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseContents))]
#endif
        public bool IsInAppPurchaseContents => InAppPurchaseContents != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchaseContents(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseContent? value)
        {
            value = InAppPurchaseContents;
            return IsInAppPurchaseContents;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseContent PickInAppPurchaseContents() => IsInAppPurchaseContents
            ? InAppPurchaseContents!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseContents' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseImage? InAppPurchaseImages { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseImage? InAppPurchaseImages { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseImages))]
#endif
        public bool IsInAppPurchaseImages => InAppPurchaseImages != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchaseImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseImage? value)
        {
            value = InAppPurchaseImages;
            return IsInAppPurchaseImages;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseImage PickInAppPurchaseImages() => IsInAppPurchaseImages
            ? InAppPurchaseImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseImages' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseLocalization? InAppPurchaseLocalizations { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseLocalization? InAppPurchaseLocalizations { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseLocalizations))]
#endif
        public bool IsInAppPurchaseLocalizations => InAppPurchaseLocalizations != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchaseLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseLocalization? value)
        {
            value = InAppPurchaseLocalizations;
            return IsInAppPurchaseLocalizations;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseLocalization PickInAppPurchaseLocalizations() => IsInAppPurchaseLocalizations
            ? InAppPurchaseLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseLocalizations' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseOfferCode? InAppPurchaseOfferCodes { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseOfferCode? InAppPurchaseOfferCodes { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseOfferCodes))]
#endif
        public bool IsInAppPurchaseOfferCodes => InAppPurchaseOfferCodes != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchaseOfferCodes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseOfferCode? value)
        {
            value = InAppPurchaseOfferCodes;
            return IsInAppPurchaseOfferCodes;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseOfferCode PickInAppPurchaseOfferCodes() => IsInAppPurchaseOfferCodes
            ? InAppPurchaseOfferCodes!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseOfferCodes' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchasePricePoint? InAppPurchasePricePoints { get; init; }
#else
        public global::AppStoreConnect.InAppPurchasePricePoint? InAppPurchasePricePoints { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchasePricePoints))]
#endif
        public bool IsInAppPurchasePricePoints => InAppPurchasePricePoints != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchasePricePoints(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchasePricePoint? value)
        {
            value = InAppPurchasePricePoints;
            return IsInAppPurchasePricePoints;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchasePricePoint PickInAppPurchasePricePoints() => IsInAppPurchasePricePoints
            ? InAppPurchasePricePoints!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchasePricePoints' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchasePriceSchedule? InAppPurchasePriceSchedules { get; init; }
#else
        public global::AppStoreConnect.InAppPurchasePriceSchedule? InAppPurchasePriceSchedules { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchasePriceSchedules))]
#endif
        public bool IsInAppPurchasePriceSchedules => InAppPurchasePriceSchedules != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchasePriceSchedules(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchasePriceSchedule? value)
        {
            value = InAppPurchasePriceSchedules;
            return IsInAppPurchasePriceSchedules;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchasePriceSchedule PickInAppPurchasePriceSchedules() => IsInAppPurchasePriceSchedules
            ? InAppPurchasePriceSchedules!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchasePriceSchedules' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseVersion? InAppPurchaseVersions { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseVersion? InAppPurchaseVersions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchaseVersions))]
#endif
        public bool IsInAppPurchaseVersions => InAppPurchaseVersions != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInAppPurchaseVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseVersion? value)
        {
            value = InAppPurchaseVersions;
            return IsInAppPurchaseVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseVersion PickInAppPurchaseVersions() => IsInAppPurchaseVersions
            ? InAppPurchaseVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseVersions' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.PromotedPurchase? PromotedPurchases { get; init; }
#else
        public global::AppStoreConnect.PromotedPurchase? PromotedPurchases { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromotedPurchases))]
#endif
        public bool IsPromotedPurchases => PromotedPurchases != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPromotedPurchases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.PromotedPurchase? value)
        {
            value = PromotedPurchases;
            return IsPromotedPurchases;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.PromotedPurchase PickPromotedPurchases() => IsPromotedPurchases
            ? PromotedPurchases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PromotedPurchases' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot value) => new IncludedItem145((global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot?(IncludedItem145 @this) => @this.InAppPurchaseAppStoreReviewScreenshots;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot? value)
        {
            InAppPurchaseAppStoreReviewScreenshots = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchaseAppStoreReviewScreenshots(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchaseAvailability value) => new IncludedItem145((global::AppStoreConnect.InAppPurchaseAvailability?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseAvailability?(IncludedItem145 @this) => @this.InAppPurchaseAvailabilities;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchaseAvailability? value)
        {
            InAppPurchaseAvailabilities = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchaseAvailabilities(global::AppStoreConnect.InAppPurchaseAvailability? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchaseContent value) => new IncludedItem145((global::AppStoreConnect.InAppPurchaseContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseContent?(IncludedItem145 @this) => @this.InAppPurchaseContents;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchaseContent? value)
        {
            InAppPurchaseContents = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchaseContents(global::AppStoreConnect.InAppPurchaseContent? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchaseImage value) => new IncludedItem145((global::AppStoreConnect.InAppPurchaseImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseImage?(IncludedItem145 @this) => @this.InAppPurchaseImages;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchaseImage? value)
        {
            InAppPurchaseImages = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchaseImages(global::AppStoreConnect.InAppPurchaseImage? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchaseLocalization value) => new IncludedItem145((global::AppStoreConnect.InAppPurchaseLocalization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseLocalization?(IncludedItem145 @this) => @this.InAppPurchaseLocalizations;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchaseLocalization? value)
        {
            InAppPurchaseLocalizations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchaseLocalizations(global::AppStoreConnect.InAppPurchaseLocalization? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchaseOfferCode value) => new IncludedItem145((global::AppStoreConnect.InAppPurchaseOfferCode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseOfferCode?(IncludedItem145 @this) => @this.InAppPurchaseOfferCodes;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchaseOfferCode? value)
        {
            InAppPurchaseOfferCodes = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchaseOfferCodes(global::AppStoreConnect.InAppPurchaseOfferCode? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchasePricePoint value) => new IncludedItem145((global::AppStoreConnect.InAppPurchasePricePoint?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchasePricePoint?(IncludedItem145 @this) => @this.InAppPurchasePricePoints;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchasePricePoint? value)
        {
            InAppPurchasePricePoints = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchasePricePoints(global::AppStoreConnect.InAppPurchasePricePoint? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchasePriceSchedule value) => new IncludedItem145((global::AppStoreConnect.InAppPurchasePriceSchedule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchasePriceSchedule?(IncludedItem145 @this) => @this.InAppPurchasePriceSchedules;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchasePriceSchedule? value)
        {
            InAppPurchasePriceSchedules = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchasePriceSchedules(global::AppStoreConnect.InAppPurchasePriceSchedule? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.InAppPurchaseVersion value) => new IncludedItem145((global::AppStoreConnect.InAppPurchaseVersion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseVersion?(IncludedItem145 @this) => @this.InAppPurchaseVersions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.InAppPurchaseVersion? value)
        {
            InAppPurchaseVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromInAppPurchaseVersions(global::AppStoreConnect.InAppPurchaseVersion? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem145(global::AppStoreConnect.PromotedPurchase value) => new IncludedItem145((global::AppStoreConnect.PromotedPurchase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.PromotedPurchase?(IncludedItem145 @this) => @this.PromotedPurchases;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(global::AppStoreConnect.PromotedPurchase? value)
        {
            PromotedPurchases = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem145 FromPromotedPurchases(global::AppStoreConnect.PromotedPurchase? value) => new IncludedItem145(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem145(
            global::AppStoreConnect.InAppPurchaseV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot? inAppPurchaseAppStoreReviewScreenshots,
            global::AppStoreConnect.InAppPurchaseAvailability? inAppPurchaseAvailabilities,
            global::AppStoreConnect.InAppPurchaseContent? inAppPurchaseContents,
            global::AppStoreConnect.InAppPurchaseImage? inAppPurchaseImages,
            global::AppStoreConnect.InAppPurchaseLocalization? inAppPurchaseLocalizations,
            global::AppStoreConnect.InAppPurchaseOfferCode? inAppPurchaseOfferCodes,
            global::AppStoreConnect.InAppPurchasePricePoint? inAppPurchasePricePoints,
            global::AppStoreConnect.InAppPurchasePriceSchedule? inAppPurchasePriceSchedules,
            global::AppStoreConnect.InAppPurchaseVersion? inAppPurchaseVersions,
            global::AppStoreConnect.PromotedPurchase? promotedPurchases
            )
        {
            Type = type;

            InAppPurchaseAppStoreReviewScreenshots = inAppPurchaseAppStoreReviewScreenshots;
            InAppPurchaseAvailabilities = inAppPurchaseAvailabilities;
            InAppPurchaseContents = inAppPurchaseContents;
            InAppPurchaseImages = inAppPurchaseImages;
            InAppPurchaseLocalizations = inAppPurchaseLocalizations;
            InAppPurchaseOfferCodes = inAppPurchaseOfferCodes;
            InAppPurchasePricePoints = inAppPurchasePricePoints;
            InAppPurchasePriceSchedules = inAppPurchasePriceSchedules;
            InAppPurchaseVersions = inAppPurchaseVersions;
            PromotedPurchases = promotedPurchases;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PromotedPurchases as object ??
            InAppPurchaseVersions as object ??
            InAppPurchasePriceSchedules as object ??
            InAppPurchasePricePoints as object ??
            InAppPurchaseOfferCodes as object ??
            InAppPurchaseLocalizations as object ??
            InAppPurchaseImages as object ??
            InAppPurchaseContents as object ??
            InAppPurchaseAvailabilities as object ??
            InAppPurchaseAppStoreReviewScreenshots as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InAppPurchaseAppStoreReviewScreenshots?.ToString() ??
            InAppPurchaseAvailabilities?.ToString() ??
            InAppPurchaseContents?.ToString() ??
            InAppPurchaseImages?.ToString() ??
            InAppPurchaseLocalizations?.ToString() ??
            InAppPurchaseOfferCodes?.ToString() ??
            InAppPurchasePricePoints?.ToString() ??
            InAppPurchasePriceSchedules?.ToString() ??
            InAppPurchaseVersions?.ToString() ??
            PromotedPurchases?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && IsInAppPurchaseContents && !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && !IsInAppPurchaseImages && IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && IsInAppPurchaseVersions && !IsPromotedPurchases || !IsInAppPurchaseAppStoreReviewScreenshots && !IsInAppPurchaseAvailabilities && !IsInAppPurchaseContents && !IsInAppPurchaseImages && !IsInAppPurchaseLocalizations && !IsInAppPurchaseOfferCodes && !IsInAppPurchasePricePoints && !IsInAppPurchasePriceSchedules && !IsInAppPurchaseVersions && IsPromotedPurchases;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot, TResult>? inAppPurchaseAppStoreReviewScreenshots = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseAvailability, TResult>? inAppPurchaseAvailabilities = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseContent, TResult>? inAppPurchaseContents = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseImage, TResult>? inAppPurchaseImages = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseLocalization, TResult>? inAppPurchaseLocalizations = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseOfferCode, TResult>? inAppPurchaseOfferCodes = null,
            global::System.Func<global::AppStoreConnect.InAppPurchasePricePoint, TResult>? inAppPurchasePricePoints = null,
            global::System.Func<global::AppStoreConnect.InAppPurchasePriceSchedule, TResult>? inAppPurchasePriceSchedules = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseVersion, TResult>? inAppPurchaseVersions = null,
            global::System.Func<global::AppStoreConnect.PromotedPurchase, TResult>? promotedPurchases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseAppStoreReviewScreenshots && inAppPurchaseAppStoreReviewScreenshots != null)
            {
                return inAppPurchaseAppStoreReviewScreenshots(InAppPurchaseAppStoreReviewScreenshots!);
            }
            else if (IsInAppPurchaseAvailabilities && inAppPurchaseAvailabilities != null)
            {
                return inAppPurchaseAvailabilities(InAppPurchaseAvailabilities!);
            }
            else if (IsInAppPurchaseContents && inAppPurchaseContents != null)
            {
                return inAppPurchaseContents(InAppPurchaseContents!);
            }
            else if (IsInAppPurchaseImages && inAppPurchaseImages != null)
            {
                return inAppPurchaseImages(InAppPurchaseImages!);
            }
            else if (IsInAppPurchaseLocalizations && inAppPurchaseLocalizations != null)
            {
                return inAppPurchaseLocalizations(InAppPurchaseLocalizations!);
            }
            else if (IsInAppPurchaseOfferCodes && inAppPurchaseOfferCodes != null)
            {
                return inAppPurchaseOfferCodes(InAppPurchaseOfferCodes!);
            }
            else if (IsInAppPurchasePricePoints && inAppPurchasePricePoints != null)
            {
                return inAppPurchasePricePoints(InAppPurchasePricePoints!);
            }
            else if (IsInAppPurchasePriceSchedules && inAppPurchasePriceSchedules != null)
            {
                return inAppPurchasePriceSchedules(InAppPurchasePriceSchedules!);
            }
            else if (IsInAppPurchaseVersions && inAppPurchaseVersions != null)
            {
                return inAppPurchaseVersions(InAppPurchaseVersions!);
            }
            else if (IsPromotedPurchases && promotedPurchases != null)
            {
                return promotedPurchases(PromotedPurchases!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot>? inAppPurchaseAppStoreReviewScreenshots = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseAvailability>? inAppPurchaseAvailabilities = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseContent>? inAppPurchaseContents = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseImage>? inAppPurchaseImages = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseLocalization>? inAppPurchaseLocalizations = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseOfferCode>? inAppPurchaseOfferCodes = null,

            global::System.Action<global::AppStoreConnect.InAppPurchasePricePoint>? inAppPurchasePricePoints = null,

            global::System.Action<global::AppStoreConnect.InAppPurchasePriceSchedule>? inAppPurchasePriceSchedules = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseVersion>? inAppPurchaseVersions = null,

            global::System.Action<global::AppStoreConnect.PromotedPurchase>? promotedPurchases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseAppStoreReviewScreenshots)
            {
                inAppPurchaseAppStoreReviewScreenshots?.Invoke(InAppPurchaseAppStoreReviewScreenshots!);
            }
            else if (IsInAppPurchaseAvailabilities)
            {
                inAppPurchaseAvailabilities?.Invoke(InAppPurchaseAvailabilities!);
            }
            else if (IsInAppPurchaseContents)
            {
                inAppPurchaseContents?.Invoke(InAppPurchaseContents!);
            }
            else if (IsInAppPurchaseImages)
            {
                inAppPurchaseImages?.Invoke(InAppPurchaseImages!);
            }
            else if (IsInAppPurchaseLocalizations)
            {
                inAppPurchaseLocalizations?.Invoke(InAppPurchaseLocalizations!);
            }
            else if (IsInAppPurchaseOfferCodes)
            {
                inAppPurchaseOfferCodes?.Invoke(InAppPurchaseOfferCodes!);
            }
            else if (IsInAppPurchasePricePoints)
            {
                inAppPurchasePricePoints?.Invoke(InAppPurchasePricePoints!);
            }
            else if (IsInAppPurchasePriceSchedules)
            {
                inAppPurchasePriceSchedules?.Invoke(InAppPurchasePriceSchedules!);
            }
            else if (IsInAppPurchaseVersions)
            {
                inAppPurchaseVersions?.Invoke(InAppPurchaseVersions!);
            }
            else if (IsPromotedPurchases)
            {
                promotedPurchases?.Invoke(PromotedPurchases!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot>? inAppPurchaseAppStoreReviewScreenshots = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseAvailability>? inAppPurchaseAvailabilities = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseContent>? inAppPurchaseContents = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseImage>? inAppPurchaseImages = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseLocalization>? inAppPurchaseLocalizations = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseOfferCode>? inAppPurchaseOfferCodes = null,
            global::System.Action<global::AppStoreConnect.InAppPurchasePricePoint>? inAppPurchasePricePoints = null,
            global::System.Action<global::AppStoreConnect.InAppPurchasePriceSchedule>? inAppPurchasePriceSchedules = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseVersion>? inAppPurchaseVersions = null,
            global::System.Action<global::AppStoreConnect.PromotedPurchase>? promotedPurchases = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchaseAppStoreReviewScreenshots)
            {
                inAppPurchaseAppStoreReviewScreenshots?.Invoke(InAppPurchaseAppStoreReviewScreenshots!);
            }
            else if (IsInAppPurchaseAvailabilities)
            {
                inAppPurchaseAvailabilities?.Invoke(InAppPurchaseAvailabilities!);
            }
            else if (IsInAppPurchaseContents)
            {
                inAppPurchaseContents?.Invoke(InAppPurchaseContents!);
            }
            else if (IsInAppPurchaseImages)
            {
                inAppPurchaseImages?.Invoke(InAppPurchaseImages!);
            }
            else if (IsInAppPurchaseLocalizations)
            {
                inAppPurchaseLocalizations?.Invoke(InAppPurchaseLocalizations!);
            }
            else if (IsInAppPurchaseOfferCodes)
            {
                inAppPurchaseOfferCodes?.Invoke(InAppPurchaseOfferCodes!);
            }
            else if (IsInAppPurchasePricePoints)
            {
                inAppPurchasePricePoints?.Invoke(InAppPurchasePricePoints!);
            }
            else if (IsInAppPurchasePriceSchedules)
            {
                inAppPurchasePriceSchedules?.Invoke(InAppPurchasePriceSchedules!);
            }
            else if (IsInAppPurchaseVersions)
            {
                inAppPurchaseVersions?.Invoke(InAppPurchaseVersions!);
            }
            else if (IsPromotedPurchases)
            {
                promotedPurchases?.Invoke(PromotedPurchases!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InAppPurchaseAppStoreReviewScreenshots,
                typeof(global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot),
                InAppPurchaseAvailabilities,
                typeof(global::AppStoreConnect.InAppPurchaseAvailability),
                InAppPurchaseContents,
                typeof(global::AppStoreConnect.InAppPurchaseContent),
                InAppPurchaseImages,
                typeof(global::AppStoreConnect.InAppPurchaseImage),
                InAppPurchaseLocalizations,
                typeof(global::AppStoreConnect.InAppPurchaseLocalization),
                InAppPurchaseOfferCodes,
                typeof(global::AppStoreConnect.InAppPurchaseOfferCode),
                InAppPurchasePricePoints,
                typeof(global::AppStoreConnect.InAppPurchasePricePoint),
                InAppPurchasePriceSchedules,
                typeof(global::AppStoreConnect.InAppPurchasePriceSchedule),
                InAppPurchaseVersions,
                typeof(global::AppStoreConnect.InAppPurchaseVersion),
                PromotedPurchases,
                typeof(global::AppStoreConnect.PromotedPurchase),
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
        public bool Equals(IncludedItem145 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseAppStoreReviewScreenshot?>.Default.Equals(InAppPurchaseAppStoreReviewScreenshots, other.InAppPurchaseAppStoreReviewScreenshots) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseAvailability?>.Default.Equals(InAppPurchaseAvailabilities, other.InAppPurchaseAvailabilities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseContent?>.Default.Equals(InAppPurchaseContents, other.InAppPurchaseContents) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseImage?>.Default.Equals(InAppPurchaseImages, other.InAppPurchaseImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseLocalization?>.Default.Equals(InAppPurchaseLocalizations, other.InAppPurchaseLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseOfferCode?>.Default.Equals(InAppPurchaseOfferCodes, other.InAppPurchaseOfferCodes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchasePricePoint?>.Default.Equals(InAppPurchasePricePoints, other.InAppPurchasePricePoints) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchasePriceSchedule?>.Default.Equals(InAppPurchasePriceSchedules, other.InAppPurchasePriceSchedules) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseVersion?>.Default.Equals(InAppPurchaseVersions, other.InAppPurchaseVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.PromotedPurchase?>.Default.Equals(PromotedPurchases, other.PromotedPurchases) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem145 obj1, IncludedItem145 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem145>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem145 obj1, IncludedItem145 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem145 o && Equals(o);
        }
    }
}
