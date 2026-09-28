#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem176 : global::System.IEquatable<IncludedItem176>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.PromotedPurchase PickPromotedPurchases() => PromotedPurchases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PromotedPurchases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot? SubscriptionAppStoreReviewScreenshots { get; init; }
#else
        public global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot? SubscriptionAppStoreReviewScreenshots { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionAppStoreReviewScreenshots))]
#endif
        public bool IsSubscriptionAppStoreReviewScreenshots => SubscriptionAppStoreReviewScreenshots != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionAppStoreReviewScreenshots(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot? value)
        {
            value = SubscriptionAppStoreReviewScreenshots;
            return IsSubscriptionAppStoreReviewScreenshots;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot PickSubscriptionAppStoreReviewScreenshots() => SubscriptionAppStoreReviewScreenshots is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionAppStoreReviewScreenshots' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionAvailability? SubscriptionAvailabilities { get; init; }
#else
        public global::AppStoreConnect.SubscriptionAvailability? SubscriptionAvailabilities { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionAvailabilities))]
#endif
        public bool IsSubscriptionAvailabilities => SubscriptionAvailabilities != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionAvailabilities(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionAvailability? value)
        {
            value = SubscriptionAvailabilities;
            return IsSubscriptionAvailabilities;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionAvailability PickSubscriptionAvailabilities() => SubscriptionAvailabilities is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionAvailabilities' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionGroup? SubscriptionGroups { get; init; }
#else
        public global::AppStoreConnect.SubscriptionGroup? SubscriptionGroups { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionGroups))]
#endif
        public bool IsSubscriptionGroups => SubscriptionGroups != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionGroup? value)
        {
            value = SubscriptionGroups;
            return IsSubscriptionGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroup PickSubscriptionGroups() => SubscriptionGroups is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionGroups' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionImage? SubscriptionImages { get; init; }
#else
        public global::AppStoreConnect.SubscriptionImage? SubscriptionImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionImages))]
#endif
        public bool IsSubscriptionImages => SubscriptionImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionImage? value)
        {
            value = SubscriptionImages;
            return IsSubscriptionImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionImage PickSubscriptionImages() => SubscriptionImages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionIntroductoryOffer? SubscriptionIntroductoryOffers { get; init; }
#else
        public global::AppStoreConnect.SubscriptionIntroductoryOffer? SubscriptionIntroductoryOffers { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionIntroductoryOffers))]
#endif
        public bool IsSubscriptionIntroductoryOffers => SubscriptionIntroductoryOffers != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionIntroductoryOffers(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionIntroductoryOffer? value)
        {
            value = SubscriptionIntroductoryOffers;
            return IsSubscriptionIntroductoryOffers;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionIntroductoryOffer PickSubscriptionIntroductoryOffers() => SubscriptionIntroductoryOffers is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionIntroductoryOffers' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionLocalization? SubscriptionLocalizations { get; init; }
#else
        public global::AppStoreConnect.SubscriptionLocalization? SubscriptionLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionLocalizations))]
#endif
        public bool IsSubscriptionLocalizations => SubscriptionLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionLocalization? value)
        {
            value = SubscriptionLocalizations;
            return IsSubscriptionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionLocalization PickSubscriptionLocalizations() => SubscriptionLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionOfferCode? SubscriptionOfferCodes { get; init; }
#else
        public global::AppStoreConnect.SubscriptionOfferCode? SubscriptionOfferCodes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionOfferCodes))]
#endif
        public bool IsSubscriptionOfferCodes => SubscriptionOfferCodes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionOfferCodes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionOfferCode? value)
        {
            value = SubscriptionOfferCodes;
            return IsSubscriptionOfferCodes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionOfferCode PickSubscriptionOfferCodes() => SubscriptionOfferCodes is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionOfferCodes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionPlanAvailability? SubscriptionPlanAvailabilities { get; init; }
#else
        public global::AppStoreConnect.SubscriptionPlanAvailability? SubscriptionPlanAvailabilities { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionPlanAvailabilities))]
#endif
        public bool IsSubscriptionPlanAvailabilities => SubscriptionPlanAvailabilities != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionPlanAvailabilities(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionPlanAvailability? value)
        {
            value = SubscriptionPlanAvailabilities;
            return IsSubscriptionPlanAvailabilities;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionPlanAvailability PickSubscriptionPlanAvailabilities() => SubscriptionPlanAvailabilities is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionPlanAvailabilities' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionPrice? SubscriptionPrices { get; init; }
#else
        public global::AppStoreConnect.SubscriptionPrice? SubscriptionPrices { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionPrices))]
#endif
        public bool IsSubscriptionPrices => SubscriptionPrices != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionPrices(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionPrice? value)
        {
            value = SubscriptionPrices;
            return IsSubscriptionPrices;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionPrice PickSubscriptionPrices() => SubscriptionPrices is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionPrices' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionPromotionalOffer? SubscriptionPromotionalOffers { get; init; }
#else
        public global::AppStoreConnect.SubscriptionPromotionalOffer? SubscriptionPromotionalOffers { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionPromotionalOffers))]
#endif
        public bool IsSubscriptionPromotionalOffers => SubscriptionPromotionalOffers != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionPromotionalOffers(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionPromotionalOffer? value)
        {
            value = SubscriptionPromotionalOffers;
            return IsSubscriptionPromotionalOffers;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionPromotionalOffer PickSubscriptionPromotionalOffers() => SubscriptionPromotionalOffers is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionPromotionalOffers' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionVersion? SubscriptionVersions { get; init; }
#else
        public global::AppStoreConnect.SubscriptionVersion? SubscriptionVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionVersions))]
#endif
        public bool IsSubscriptionVersions => SubscriptionVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionVersion? value)
        {
            value = SubscriptionVersions;
            return IsSubscriptionVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionVersion PickSubscriptionVersions() => SubscriptionVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.WinBackOffer? WinBackOffers { get; init; }
#else
        public global::AppStoreConnect.WinBackOffer? WinBackOffers { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WinBackOffers))]
#endif
        public bool IsWinBackOffers => WinBackOffers != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWinBackOffers(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.WinBackOffer? value)
        {
            value = WinBackOffers;
            return IsWinBackOffers;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.WinBackOffer PickWinBackOffers() => WinBackOffers is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WinBackOffers' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.PromotedPurchase value) => new IncludedItem176((global::AppStoreConnect.PromotedPurchase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.PromotedPurchase?(IncludedItem176 @this) => @this.PromotedPurchases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.PromotedPurchase? value)
        {
            PromotedPurchases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromPromotedPurchases(global::AppStoreConnect.PromotedPurchase? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot value) => new IncludedItem176((global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot?(IncludedItem176 @this) => @this.SubscriptionAppStoreReviewScreenshots;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot? value)
        {
            SubscriptionAppStoreReviewScreenshots = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionAppStoreReviewScreenshots(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionAvailability value) => new IncludedItem176((global::AppStoreConnect.SubscriptionAvailability?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionAvailability?(IncludedItem176 @this) => @this.SubscriptionAvailabilities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionAvailability? value)
        {
            SubscriptionAvailabilities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionAvailabilities(global::AppStoreConnect.SubscriptionAvailability? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionGroup value) => new IncludedItem176((global::AppStoreConnect.SubscriptionGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroup?(IncludedItem176 @this) => @this.SubscriptionGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionGroup? value)
        {
            SubscriptionGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionGroups(global::AppStoreConnect.SubscriptionGroup? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionImage value) => new IncludedItem176((global::AppStoreConnect.SubscriptionImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionImage?(IncludedItem176 @this) => @this.SubscriptionImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionImage? value)
        {
            SubscriptionImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionImages(global::AppStoreConnect.SubscriptionImage? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionIntroductoryOffer value) => new IncludedItem176((global::AppStoreConnect.SubscriptionIntroductoryOffer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionIntroductoryOffer?(IncludedItem176 @this) => @this.SubscriptionIntroductoryOffers;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionIntroductoryOffer? value)
        {
            SubscriptionIntroductoryOffers = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionIntroductoryOffers(global::AppStoreConnect.SubscriptionIntroductoryOffer? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionLocalization value) => new IncludedItem176((global::AppStoreConnect.SubscriptionLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionLocalization?(IncludedItem176 @this) => @this.SubscriptionLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionLocalization? value)
        {
            SubscriptionLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionLocalizations(global::AppStoreConnect.SubscriptionLocalization? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionOfferCode value) => new IncludedItem176((global::AppStoreConnect.SubscriptionOfferCode?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionOfferCode?(IncludedItem176 @this) => @this.SubscriptionOfferCodes;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionOfferCode? value)
        {
            SubscriptionOfferCodes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionOfferCodes(global::AppStoreConnect.SubscriptionOfferCode? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionPlanAvailability value) => new IncludedItem176((global::AppStoreConnect.SubscriptionPlanAvailability?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionPlanAvailability?(IncludedItem176 @this) => @this.SubscriptionPlanAvailabilities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionPlanAvailability? value)
        {
            SubscriptionPlanAvailabilities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionPlanAvailabilities(global::AppStoreConnect.SubscriptionPlanAvailability? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionPrice value) => new IncludedItem176((global::AppStoreConnect.SubscriptionPrice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionPrice?(IncludedItem176 @this) => @this.SubscriptionPrices;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionPrice? value)
        {
            SubscriptionPrices = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionPrices(global::AppStoreConnect.SubscriptionPrice? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionPromotionalOffer value) => new IncludedItem176((global::AppStoreConnect.SubscriptionPromotionalOffer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionPromotionalOffer?(IncludedItem176 @this) => @this.SubscriptionPromotionalOffers;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionPromotionalOffer? value)
        {
            SubscriptionPromotionalOffers = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionPromotionalOffers(global::AppStoreConnect.SubscriptionPromotionalOffer? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.SubscriptionVersion value) => new IncludedItem176((global::AppStoreConnect.SubscriptionVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionVersion?(IncludedItem176 @this) => @this.SubscriptionVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.SubscriptionVersion? value)
        {
            SubscriptionVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromSubscriptionVersions(global::AppStoreConnect.SubscriptionVersion? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem176(global::AppStoreConnect.WinBackOffer value) => new IncludedItem176((global::AppStoreConnect.WinBackOffer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.WinBackOffer?(IncludedItem176 @this) => @this.WinBackOffers;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(global::AppStoreConnect.WinBackOffer? value)
        {
            WinBackOffers = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem176 FromWinBackOffers(global::AppStoreConnect.WinBackOffer? value) => new IncludedItem176(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem176(
            global::AppStoreConnect.SubscriptionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.PromotedPurchase? promotedPurchases,
            global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot? subscriptionAppStoreReviewScreenshots,
            global::AppStoreConnect.SubscriptionAvailability? subscriptionAvailabilities,
            global::AppStoreConnect.SubscriptionGroup? subscriptionGroups,
            global::AppStoreConnect.SubscriptionImage? subscriptionImages,
            global::AppStoreConnect.SubscriptionIntroductoryOffer? subscriptionIntroductoryOffers,
            global::AppStoreConnect.SubscriptionLocalization? subscriptionLocalizations,
            global::AppStoreConnect.SubscriptionOfferCode? subscriptionOfferCodes,
            global::AppStoreConnect.SubscriptionPlanAvailability? subscriptionPlanAvailabilities,
            global::AppStoreConnect.SubscriptionPrice? subscriptionPrices,
            global::AppStoreConnect.SubscriptionPromotionalOffer? subscriptionPromotionalOffers,
            global::AppStoreConnect.SubscriptionVersion? subscriptionVersions,
            global::AppStoreConnect.WinBackOffer? winBackOffers
            )
        {
            Type = type;

            PromotedPurchases = promotedPurchases;
            SubscriptionAppStoreReviewScreenshots = subscriptionAppStoreReviewScreenshots;
            SubscriptionAvailabilities = subscriptionAvailabilities;
            SubscriptionGroups = subscriptionGroups;
            SubscriptionImages = subscriptionImages;
            SubscriptionIntroductoryOffers = subscriptionIntroductoryOffers;
            SubscriptionLocalizations = subscriptionLocalizations;
            SubscriptionOfferCodes = subscriptionOfferCodes;
            SubscriptionPlanAvailabilities = subscriptionPlanAvailabilities;
            SubscriptionPrices = subscriptionPrices;
            SubscriptionPromotionalOffers = subscriptionPromotionalOffers;
            SubscriptionVersions = subscriptionVersions;
            WinBackOffers = winBackOffers;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WinBackOffers as object ??
            SubscriptionVersions as object ??
            SubscriptionPromotionalOffers as object ??
            SubscriptionPrices as object ??
            SubscriptionPlanAvailabilities as object ??
            SubscriptionOfferCodes as object ??
            SubscriptionLocalizations as object ??
            SubscriptionIntroductoryOffers as object ??
            SubscriptionImages as object ??
            SubscriptionGroups as object ??
            SubscriptionAvailabilities as object ??
            SubscriptionAppStoreReviewScreenshots as object ??
            PromotedPurchases as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PromotedPurchases?.ToString() ??
            SubscriptionAppStoreReviewScreenshots?.ToString() ??
            SubscriptionAvailabilities?.ToString() ??
            SubscriptionGroups?.ToString() ??
            SubscriptionImages?.ToString() ??
            SubscriptionIntroductoryOffers?.ToString() ??
            SubscriptionLocalizations?.ToString() ??
            SubscriptionOfferCodes?.ToString() ??
            SubscriptionPlanAvailabilities?.ToString() ??
            SubscriptionPrices?.ToString() ??
            SubscriptionPromotionalOffers?.ToString() ??
            SubscriptionVersions?.ToString() ??
            WinBackOffers?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && IsSubscriptionVersions && !IsWinBackOffers || !IsPromotedPurchases && !IsSubscriptionAppStoreReviewScreenshots && !IsSubscriptionAvailabilities && !IsSubscriptionGroups && !IsSubscriptionImages && !IsSubscriptionIntroductoryOffers && !IsSubscriptionLocalizations && !IsSubscriptionOfferCodes && !IsSubscriptionPlanAvailabilities && !IsSubscriptionPrices && !IsSubscriptionPromotionalOffers && !IsSubscriptionVersions && IsWinBackOffers;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.PromotedPurchase, TResult>? promotedPurchases = null,
            global::System.Func<global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot, TResult>? subscriptionAppStoreReviewScreenshots = null,
            global::System.Func<global::AppStoreConnect.SubscriptionAvailability, TResult>? subscriptionAvailabilities = null,
            global::System.Func<global::AppStoreConnect.SubscriptionGroup, TResult>? subscriptionGroups = null,
            global::System.Func<global::AppStoreConnect.SubscriptionImage, TResult>? subscriptionImages = null,
            global::System.Func<global::AppStoreConnect.SubscriptionIntroductoryOffer, TResult>? subscriptionIntroductoryOffers = null,
            global::System.Func<global::AppStoreConnect.SubscriptionLocalization, TResult>? subscriptionLocalizations = null,
            global::System.Func<global::AppStoreConnect.SubscriptionOfferCode, TResult>? subscriptionOfferCodes = null,
            global::System.Func<global::AppStoreConnect.SubscriptionPlanAvailability, TResult>? subscriptionPlanAvailabilities = null,
            global::System.Func<global::AppStoreConnect.SubscriptionPrice, TResult>? subscriptionPrices = null,
            global::System.Func<global::AppStoreConnect.SubscriptionPromotionalOffer, TResult>? subscriptionPromotionalOffers = null,
            global::System.Func<global::AppStoreConnect.SubscriptionVersion, TResult>? subscriptionVersions = null,
            global::System.Func<global::AppStoreConnect.WinBackOffer, TResult>? winBackOffers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PromotedPurchases is { } __value0 && promotedPurchases != null)
            {
                return promotedPurchases(__value0);
            }
            else if (SubscriptionAppStoreReviewScreenshots is { } __value1 && subscriptionAppStoreReviewScreenshots != null)
            {
                return subscriptionAppStoreReviewScreenshots(__value1);
            }
            else if (SubscriptionAvailabilities is { } __value2 && subscriptionAvailabilities != null)
            {
                return subscriptionAvailabilities(__value2);
            }
            else if (SubscriptionGroups is { } __value3 && subscriptionGroups != null)
            {
                return subscriptionGroups(__value3);
            }
            else if (SubscriptionImages is { } __value4 && subscriptionImages != null)
            {
                return subscriptionImages(__value4);
            }
            else if (SubscriptionIntroductoryOffers is { } __value5 && subscriptionIntroductoryOffers != null)
            {
                return subscriptionIntroductoryOffers(__value5);
            }
            else if (SubscriptionLocalizations is { } __value6 && subscriptionLocalizations != null)
            {
                return subscriptionLocalizations(__value6);
            }
            else if (SubscriptionOfferCodes is { } __value7 && subscriptionOfferCodes != null)
            {
                return subscriptionOfferCodes(__value7);
            }
            else if (SubscriptionPlanAvailabilities is { } __value8 && subscriptionPlanAvailabilities != null)
            {
                return subscriptionPlanAvailabilities(__value8);
            }
            else if (SubscriptionPrices is { } __value9 && subscriptionPrices != null)
            {
                return subscriptionPrices(__value9);
            }
            else if (SubscriptionPromotionalOffers is { } __value10 && subscriptionPromotionalOffers != null)
            {
                return subscriptionPromotionalOffers(__value10);
            }
            else if (SubscriptionVersions is { } __value11 && subscriptionVersions != null)
            {
                return subscriptionVersions(__value11);
            }
            else if (WinBackOffers is { } __value12 && winBackOffers != null)
            {
                return winBackOffers(__value12);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.PromotedPurchase>? promotedPurchases = null,

            global::System.Action<global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot>? subscriptionAppStoreReviewScreenshots = null,

            global::System.Action<global::AppStoreConnect.SubscriptionAvailability>? subscriptionAvailabilities = null,

            global::System.Action<global::AppStoreConnect.SubscriptionGroup>? subscriptionGroups = null,

            global::System.Action<global::AppStoreConnect.SubscriptionImage>? subscriptionImages = null,

            global::System.Action<global::AppStoreConnect.SubscriptionIntroductoryOffer>? subscriptionIntroductoryOffers = null,

            global::System.Action<global::AppStoreConnect.SubscriptionLocalization>? subscriptionLocalizations = null,

            global::System.Action<global::AppStoreConnect.SubscriptionOfferCode>? subscriptionOfferCodes = null,

            global::System.Action<global::AppStoreConnect.SubscriptionPlanAvailability>? subscriptionPlanAvailabilities = null,

            global::System.Action<global::AppStoreConnect.SubscriptionPrice>? subscriptionPrices = null,

            global::System.Action<global::AppStoreConnect.SubscriptionPromotionalOffer>? subscriptionPromotionalOffers = null,

            global::System.Action<global::AppStoreConnect.SubscriptionVersion>? subscriptionVersions = null,

            global::System.Action<global::AppStoreConnect.WinBackOffer>? winBackOffers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PromotedPurchases is { } __value0)
            {
                promotedPurchases?.Invoke(__value0);
            }
            else if (SubscriptionAppStoreReviewScreenshots is { } __value1)
            {
                subscriptionAppStoreReviewScreenshots?.Invoke(__value1);
            }
            else if (SubscriptionAvailabilities is { } __value2)
            {
                subscriptionAvailabilities?.Invoke(__value2);
            }
            else if (SubscriptionGroups is { } __value3)
            {
                subscriptionGroups?.Invoke(__value3);
            }
            else if (SubscriptionImages is { } __value4)
            {
                subscriptionImages?.Invoke(__value4);
            }
            else if (SubscriptionIntroductoryOffers is { } __value5)
            {
                subscriptionIntroductoryOffers?.Invoke(__value5);
            }
            else if (SubscriptionLocalizations is { } __value6)
            {
                subscriptionLocalizations?.Invoke(__value6);
            }
            else if (SubscriptionOfferCodes is { } __value7)
            {
                subscriptionOfferCodes?.Invoke(__value7);
            }
            else if (SubscriptionPlanAvailabilities is { } __value8)
            {
                subscriptionPlanAvailabilities?.Invoke(__value8);
            }
            else if (SubscriptionPrices is { } __value9)
            {
                subscriptionPrices?.Invoke(__value9);
            }
            else if (SubscriptionPromotionalOffers is { } __value10)
            {
                subscriptionPromotionalOffers?.Invoke(__value10);
            }
            else if (SubscriptionVersions is { } __value11)
            {
                subscriptionVersions?.Invoke(__value11);
            }
            else if (WinBackOffers is { } __value12)
            {
                winBackOffers?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.PromotedPurchase>? promotedPurchases = null,
            global::System.Action<global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot>? subscriptionAppStoreReviewScreenshots = null,
            global::System.Action<global::AppStoreConnect.SubscriptionAvailability>? subscriptionAvailabilities = null,
            global::System.Action<global::AppStoreConnect.SubscriptionGroup>? subscriptionGroups = null,
            global::System.Action<global::AppStoreConnect.SubscriptionImage>? subscriptionImages = null,
            global::System.Action<global::AppStoreConnect.SubscriptionIntroductoryOffer>? subscriptionIntroductoryOffers = null,
            global::System.Action<global::AppStoreConnect.SubscriptionLocalization>? subscriptionLocalizations = null,
            global::System.Action<global::AppStoreConnect.SubscriptionOfferCode>? subscriptionOfferCodes = null,
            global::System.Action<global::AppStoreConnect.SubscriptionPlanAvailability>? subscriptionPlanAvailabilities = null,
            global::System.Action<global::AppStoreConnect.SubscriptionPrice>? subscriptionPrices = null,
            global::System.Action<global::AppStoreConnect.SubscriptionPromotionalOffer>? subscriptionPromotionalOffers = null,
            global::System.Action<global::AppStoreConnect.SubscriptionVersion>? subscriptionVersions = null,
            global::System.Action<global::AppStoreConnect.WinBackOffer>? winBackOffers = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PromotedPurchases is { } __value0)
            {
                promotedPurchases?.Invoke(__value0);
            }
            else if (SubscriptionAppStoreReviewScreenshots is { } __value1)
            {
                subscriptionAppStoreReviewScreenshots?.Invoke(__value1);
            }
            else if (SubscriptionAvailabilities is { } __value2)
            {
                subscriptionAvailabilities?.Invoke(__value2);
            }
            else if (SubscriptionGroups is { } __value3)
            {
                subscriptionGroups?.Invoke(__value3);
            }
            else if (SubscriptionImages is { } __value4)
            {
                subscriptionImages?.Invoke(__value4);
            }
            else if (SubscriptionIntroductoryOffers is { } __value5)
            {
                subscriptionIntroductoryOffers?.Invoke(__value5);
            }
            else if (SubscriptionLocalizations is { } __value6)
            {
                subscriptionLocalizations?.Invoke(__value6);
            }
            else if (SubscriptionOfferCodes is { } __value7)
            {
                subscriptionOfferCodes?.Invoke(__value7);
            }
            else if (SubscriptionPlanAvailabilities is { } __value8)
            {
                subscriptionPlanAvailabilities?.Invoke(__value8);
            }
            else if (SubscriptionPrices is { } __value9)
            {
                subscriptionPrices?.Invoke(__value9);
            }
            else if (SubscriptionPromotionalOffers is { } __value10)
            {
                subscriptionPromotionalOffers?.Invoke(__value10);
            }
            else if (SubscriptionVersions is { } __value11)
            {
                subscriptionVersions?.Invoke(__value11);
            }
            else if (WinBackOffers is { } __value12)
            {
                winBackOffers?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PromotedPurchases,
                typeof(global::AppStoreConnect.PromotedPurchase),
                SubscriptionAppStoreReviewScreenshots,
                typeof(global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot),
                SubscriptionAvailabilities,
                typeof(global::AppStoreConnect.SubscriptionAvailability),
                SubscriptionGroups,
                typeof(global::AppStoreConnect.SubscriptionGroup),
                SubscriptionImages,
                typeof(global::AppStoreConnect.SubscriptionImage),
                SubscriptionIntroductoryOffers,
                typeof(global::AppStoreConnect.SubscriptionIntroductoryOffer),
                SubscriptionLocalizations,
                typeof(global::AppStoreConnect.SubscriptionLocalization),
                SubscriptionOfferCodes,
                typeof(global::AppStoreConnect.SubscriptionOfferCode),
                SubscriptionPlanAvailabilities,
                typeof(global::AppStoreConnect.SubscriptionPlanAvailability),
                SubscriptionPrices,
                typeof(global::AppStoreConnect.SubscriptionPrice),
                SubscriptionPromotionalOffers,
                typeof(global::AppStoreConnect.SubscriptionPromotionalOffer),
                SubscriptionVersions,
                typeof(global::AppStoreConnect.SubscriptionVersion),
                WinBackOffers,
                typeof(global::AppStoreConnect.WinBackOffer),
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
        public bool Equals(IncludedItem176 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.PromotedPurchase?>.Default.Equals(PromotedPurchases, other.PromotedPurchases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionAppStoreReviewScreenshot?>.Default.Equals(SubscriptionAppStoreReviewScreenshots, other.SubscriptionAppStoreReviewScreenshots) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionAvailability?>.Default.Equals(SubscriptionAvailabilities, other.SubscriptionAvailabilities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionGroup?>.Default.Equals(SubscriptionGroups, other.SubscriptionGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionImage?>.Default.Equals(SubscriptionImages, other.SubscriptionImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionIntroductoryOffer?>.Default.Equals(SubscriptionIntroductoryOffers, other.SubscriptionIntroductoryOffers) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionLocalization?>.Default.Equals(SubscriptionLocalizations, other.SubscriptionLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionOfferCode?>.Default.Equals(SubscriptionOfferCodes, other.SubscriptionOfferCodes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionPlanAvailability?>.Default.Equals(SubscriptionPlanAvailabilities, other.SubscriptionPlanAvailabilities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionPrice?>.Default.Equals(SubscriptionPrices, other.SubscriptionPrices) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionPromotionalOffer?>.Default.Equals(SubscriptionPromotionalOffers, other.SubscriptionPromotionalOffers) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionVersion?>.Default.Equals(SubscriptionVersions, other.SubscriptionVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.WinBackOffer?>.Default.Equals(WinBackOffers, other.WinBackOffers)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem176 obj1, IncludedItem176 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem176>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem176 obj1, IncludedItem176 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem176 o && Equals(o);
        }
    }
}
