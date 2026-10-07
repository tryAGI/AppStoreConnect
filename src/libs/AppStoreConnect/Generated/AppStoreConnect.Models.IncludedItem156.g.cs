#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem156 : global::System.IEquatable<IncludedItem156>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImage? AppAssetLibraryImages { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImage? AppAssetLibraryImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryImages))]
#endif
        public bool IsAppAssetLibraryImages => AppAssetLibraryImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryImage? value)
        {
            value = AppAssetLibraryImages;
            return IsAppAssetLibraryImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImage PickAppAssetLibraryImages() => AppAssetLibraryImages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideo? AppAssetLibraryVideos { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideo? AppAssetLibraryVideos { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideos))]
#endif
        public bool IsAppAssetLibraryVideos => AppAssetLibraryVideos != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideos(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideo? value)
        {
            value = AppAssetLibraryVideos;
            return IsAppAssetLibraryVideos;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideo PickAppAssetLibraryVideos() => AppAssetLibraryVideos is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideos' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPageVersion? AppCustomProductPageVersions { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPageVersion? AppCustomProductPageVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageVersions))]
#endif
        public bool IsAppCustomProductPageVersions => AppCustomProductPageVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPageVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPageVersion? value)
        {
            value = AppCustomProductPageVersions;
            return IsAppCustomProductPageVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageVersion PickAppCustomProductPageVersions() => AppCustomProductPageVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEvent? AppEvents { get; init; }
#else
        public global::AppStoreConnect.AppEvent? AppEvents { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEvents))]
#endif
        public bool IsAppEvents => AppEvents != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEvents(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEvent? value)
        {
            value = AppEvents;
            return IsAppEvents;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEvent PickAppEvents() => AppEvents is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEvents' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperiment? AppStoreVersionExperiments1 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperiment? AppStoreVersionExperiments1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperiments1))]
#endif
        public bool IsAppStoreVersionExperiments1 => AppStoreVersionExperiments1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperiments1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            value = AppStoreVersionExperiments1;
            return IsAppStoreVersionExperiments1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperiment PickAppStoreVersionExperiments1() => AppStoreVersionExperiments1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperiments1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersionExperiments2 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersionExperiments2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperiments2))]
#endif
        public bool IsAppStoreVersionExperiments2 => AppStoreVersionExperiments2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperiments2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersionExperiments2;
            return IsAppStoreVersionExperiments2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersionExperiments2() => AppStoreVersionExperiments2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperiments2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BackgroundAssetVersion? BackgroundAssetVersions { get; init; }
#else
        public global::AppStoreConnect.BackgroundAssetVersion? BackgroundAssetVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BackgroundAssetVersions))]
#endif
        public bool IsBackgroundAssetVersions => BackgroundAssetVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBackgroundAssetVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BackgroundAssetVersion? value)
        {
            value = BackgroundAssetVersions;
            return IsBackgroundAssetVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BackgroundAssetVersion PickBackgroundAssetVersions() => BackgroundAssetVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BackgroundAssetVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementVersionV2? GameCenterAchievementVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementVersionV2? GameCenterAchievementVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementVersions))]
#endif
        public bool IsGameCenterAchievementVersions => GameCenterAchievementVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterAchievementVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementVersionV2? value)
        {
            value = GameCenterAchievementVersions;
            return IsGameCenterAchievementVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementVersionV2 PickGameCenterAchievementVersions() => GameCenterAchievementVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivityVersion? GameCenterActivityVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivityVersion? GameCenterActivityVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityVersions))]
#endif
        public bool IsGameCenterActivityVersions => GameCenterActivityVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterActivityVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivityVersion? value)
        {
            value = GameCenterActivityVersions;
            return IsGameCenterActivityVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityVersion PickGameCenterActivityVersions() => GameCenterActivityVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallengeVersion? GameCenterChallengeVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallengeVersion? GameCenterChallengeVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeVersions))]
#endif
        public bool IsGameCenterChallengeVersions => GameCenterChallengeVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterChallengeVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallengeVersion? value)
        {
            value = GameCenterChallengeVersions;
            return IsGameCenterChallengeVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeVersion PickGameCenterChallengeVersions() => GameCenterChallengeVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? GameCenterLeaderboardSetVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? GameCenterLeaderboardSetVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSetVersions))]
#endif
        public bool IsGameCenterLeaderboardSetVersions => GameCenterLeaderboardSetVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSetVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value)
        {
            value = GameCenterLeaderboardSetVersions;
            return IsGameCenterLeaderboardSetVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 PickGameCenterLeaderboardSetVersions() => GameCenterLeaderboardSetVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardVersionV2? GameCenterLeaderboardVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardVersionV2? GameCenterLeaderboardVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardVersions))]
#endif
        public bool IsGameCenterLeaderboardVersions => GameCenterLeaderboardVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardVersionV2? value)
        {
            value = GameCenterLeaderboardVersions;
            return IsGameCenterLeaderboardVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardVersionV2 PickGameCenterLeaderboardVersions() => GameCenterLeaderboardVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardVersions' but the value was {ToString()}.");

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
        public global::AppStoreConnect.InAppPurchaseVersion PickInAppPurchaseVersions() => InAppPurchaseVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchaseVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionGroupVersion? SubscriptionGroupVersions { get; init; }
#else
        public global::AppStoreConnect.SubscriptionGroupVersion? SubscriptionGroupVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionGroupVersions))]
#endif
        public bool IsSubscriptionGroupVersions => SubscriptionGroupVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionGroupVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionGroupVersion? value)
        {
            value = SubscriptionGroupVersions;
            return IsSubscriptionGroupVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroupVersion PickSubscriptionGroupVersions() => SubscriptionGroupVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionGroupVersions' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem156(global::AppStoreConnect.AppAssetLibraryImage value) => new IncludedItem156((global::AppStoreConnect.AppAssetLibraryImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImage?(IncludedItem156 @this) => @this.AppAssetLibraryImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.AppAssetLibraryImage? value)
        {
            AppAssetLibraryImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromAppAssetLibraryImages(global::AppStoreConnect.AppAssetLibraryImage? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.AppAssetLibraryVideo value) => new IncludedItem156((global::AppStoreConnect.AppAssetLibraryVideo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideo?(IncludedItem156 @this) => @this.AppAssetLibraryVideos;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.AppAssetLibraryVideo? value)
        {
            AppAssetLibraryVideos = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromAppAssetLibraryVideos(global::AppStoreConnect.AppAssetLibraryVideo? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.AppCustomProductPageVersion value) => new IncludedItem156((global::AppStoreConnect.AppCustomProductPageVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageVersion?(IncludedItem156 @this) => @this.AppCustomProductPageVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.AppCustomProductPageVersion? value)
        {
            AppCustomProductPageVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromAppCustomProductPageVersions(global::AppStoreConnect.AppCustomProductPageVersion? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.AppEvent value) => new IncludedItem156((global::AppStoreConnect.AppEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEvent?(IncludedItem156 @this) => @this.AppEvents;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.AppEvent? value)
        {
            AppEvents = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromAppEvents(global::AppStoreConnect.AppEvent? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.AppStoreVersionExperiment value) => new IncludedItem156((global::AppStoreConnect.AppStoreVersionExperiment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperiment?(IncludedItem156 @this) => @this.AppStoreVersionExperiments1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            AppStoreVersionExperiments1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromAppStoreVersionExperiments1(global::AppStoreConnect.AppStoreVersionExperiment? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem156((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem156 @this) => @this.AppStoreVersionExperiments2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersionExperiments2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromAppStoreVersionExperiments2(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.BackgroundAssetVersion value) => new IncludedItem156((global::AppStoreConnect.BackgroundAssetVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersion?(IncludedItem156 @this) => @this.BackgroundAssetVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.BackgroundAssetVersion? value)
        {
            BackgroundAssetVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromBackgroundAssetVersions(global::AppStoreConnect.BackgroundAssetVersion? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.GameCenterAchievementVersionV2 value) => new IncludedItem156((global::AppStoreConnect.GameCenterAchievementVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementVersionV2?(IncludedItem156 @this) => @this.GameCenterAchievementVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.GameCenterAchievementVersionV2? value)
        {
            GameCenterAchievementVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromGameCenterAchievementVersions(global::AppStoreConnect.GameCenterAchievementVersionV2? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.GameCenterActivityVersion value) => new IncludedItem156((global::AppStoreConnect.GameCenterActivityVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersion?(IncludedItem156 @this) => @this.GameCenterActivityVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.GameCenterActivityVersion? value)
        {
            GameCenterActivityVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromGameCenterActivityVersions(global::AppStoreConnect.GameCenterActivityVersion? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.GameCenterChallengeVersion value) => new IncludedItem156((global::AppStoreConnect.GameCenterChallengeVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeVersion?(IncludedItem156 @this) => @this.GameCenterChallengeVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.GameCenterChallengeVersion? value)
        {
            GameCenterChallengeVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromGameCenterChallengeVersions(global::AppStoreConnect.GameCenterChallengeVersion? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 value) => new IncludedItem156((global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?(IncludedItem156 @this) => @this.GameCenterLeaderboardSetVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value)
        {
            GameCenterLeaderboardSetVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromGameCenterLeaderboardSetVersions(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.GameCenterLeaderboardVersionV2 value) => new IncludedItem156((global::AppStoreConnect.GameCenterLeaderboardVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardVersionV2?(IncludedItem156 @this) => @this.GameCenterLeaderboardVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.GameCenterLeaderboardVersionV2? value)
        {
            GameCenterLeaderboardVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromGameCenterLeaderboardVersions(global::AppStoreConnect.GameCenterLeaderboardVersionV2? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.InAppPurchaseVersion value) => new IncludedItem156((global::AppStoreConnect.InAppPurchaseVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseVersion?(IncludedItem156 @this) => @this.InAppPurchaseVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.InAppPurchaseVersion? value)
        {
            InAppPurchaseVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromInAppPurchaseVersions(global::AppStoreConnect.InAppPurchaseVersion? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.SubscriptionGroupVersion value) => new IncludedItem156((global::AppStoreConnect.SubscriptionGroupVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroupVersion?(IncludedItem156 @this) => @this.SubscriptionGroupVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.SubscriptionGroupVersion? value)
        {
            SubscriptionGroupVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromSubscriptionGroupVersions(global::AppStoreConnect.SubscriptionGroupVersion? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem156(global::AppStoreConnect.SubscriptionVersion value) => new IncludedItem156((global::AppStoreConnect.SubscriptionVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionVersion?(IncludedItem156 @this) => @this.SubscriptionVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(global::AppStoreConnect.SubscriptionVersion? value)
        {
            SubscriptionVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem156 FromSubscriptionVersions(global::AppStoreConnect.SubscriptionVersion? value) => new IncludedItem156(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem156(
            global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppAssetLibraryImage? appAssetLibraryImages,
            global::AppStoreConnect.AppAssetLibraryVideo? appAssetLibraryVideos,
            global::AppStoreConnect.AppCustomProductPageVersion? appCustomProductPageVersions,
            global::AppStoreConnect.AppEvent? appEvents,
            global::AppStoreConnect.AppStoreVersionExperiment? appStoreVersionExperiments1,
            global::AppStoreConnect.AppStoreVersion? appStoreVersionExperiments2,
            global::AppStoreConnect.BackgroundAssetVersion? backgroundAssetVersions,
            global::AppStoreConnect.GameCenterAchievementVersionV2? gameCenterAchievementVersions,
            global::AppStoreConnect.GameCenterActivityVersion? gameCenterActivityVersions,
            global::AppStoreConnect.GameCenterChallengeVersion? gameCenterChallengeVersions,
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? gameCenterLeaderboardSetVersions,
            global::AppStoreConnect.GameCenterLeaderboardVersionV2? gameCenterLeaderboardVersions,
            global::AppStoreConnect.InAppPurchaseVersion? inAppPurchaseVersions,
            global::AppStoreConnect.SubscriptionGroupVersion? subscriptionGroupVersions,
            global::AppStoreConnect.SubscriptionVersion? subscriptionVersions
            )
        {
            Type = type;

            AppAssetLibraryImages = appAssetLibraryImages;
            AppAssetLibraryVideos = appAssetLibraryVideos;
            AppCustomProductPageVersions = appCustomProductPageVersions;
            AppEvents = appEvents;
            AppStoreVersionExperiments1 = appStoreVersionExperiments1;
            AppStoreVersionExperiments2 = appStoreVersionExperiments2;
            BackgroundAssetVersions = backgroundAssetVersions;
            GameCenterAchievementVersions = gameCenterAchievementVersions;
            GameCenterActivityVersions = gameCenterActivityVersions;
            GameCenterChallengeVersions = gameCenterChallengeVersions;
            GameCenterLeaderboardSetVersions = gameCenterLeaderboardSetVersions;
            GameCenterLeaderboardVersions = gameCenterLeaderboardVersions;
            InAppPurchaseVersions = inAppPurchaseVersions;
            SubscriptionGroupVersions = subscriptionGroupVersions;
            SubscriptionVersions = subscriptionVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SubscriptionVersions as object ??
            SubscriptionGroupVersions as object ??
            InAppPurchaseVersions as object ??
            GameCenterLeaderboardVersions as object ??
            GameCenterLeaderboardSetVersions as object ??
            GameCenterChallengeVersions as object ??
            GameCenterActivityVersions as object ??
            GameCenterAchievementVersions as object ??
            BackgroundAssetVersions as object ??
            AppStoreVersionExperiments2 as object ??
            AppStoreVersionExperiments1 as object ??
            AppEvents as object ??
            AppCustomProductPageVersions as object ??
            AppAssetLibraryVideos as object ??
            AppAssetLibraryImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryImages?.ToString() ??
            AppAssetLibraryVideos?.ToString() ??
            AppCustomProductPageVersions?.ToString() ??
            AppEvents?.ToString() ??
            AppStoreVersionExperiments1?.ToString() ??
            AppStoreVersionExperiments2?.ToString() ??
            BackgroundAssetVersions?.ToString() ??
            GameCenterAchievementVersions?.ToString() ??
            GameCenterActivityVersions?.ToString() ??
            GameCenterChallengeVersions?.ToString() ??
            GameCenterLeaderboardSetVersions?.ToString() ??
            GameCenterLeaderboardVersions?.ToString() ??
            InAppPurchaseVersions?.ToString() ??
            SubscriptionGroupVersions?.ToString() ??
            SubscriptionVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && IsSubscriptionVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImage, TResult>? appAssetLibraryImages = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideo, TResult>? appAssetLibraryVideos = null,
            global::System.Func<global::AppStoreConnect.AppCustomProductPageVersion, TResult>? appCustomProductPageVersions = null,
            global::System.Func<global::AppStoreConnect.AppEvent, TResult>? appEvents = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperiment, TResult>? appStoreVersionExperiments1 = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersionExperiments2 = null,
            global::System.Func<global::AppStoreConnect.BackgroundAssetVersion, TResult>? backgroundAssetVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievementVersionV2, TResult>? gameCenterAchievementVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityVersion, TResult>? gameCenterActivityVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallengeVersion, TResult>? gameCenterChallengeVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2, TResult>? gameCenterLeaderboardSetVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardVersionV2, TResult>? gameCenterLeaderboardVersions = null,
            global::System.Func<global::AppStoreConnect.InAppPurchaseVersion, TResult>? inAppPurchaseVersions = null,
            global::System.Func<global::AppStoreConnect.SubscriptionGroupVersion, TResult>? subscriptionGroupVersions = null,
            global::System.Func<global::AppStoreConnect.SubscriptionVersion, TResult>? subscriptionVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImages is { } __value0 && appAssetLibraryImages != null)
            {
                return appAssetLibraryImages(__value0);
            }
            else if (AppAssetLibraryVideos is { } __value1 && appAssetLibraryVideos != null)
            {
                return appAssetLibraryVideos(__value1);
            }
            else if (AppCustomProductPageVersions is { } __value2 && appCustomProductPageVersions != null)
            {
                return appCustomProductPageVersions(__value2);
            }
            else if (AppEvents is { } __value3 && appEvents != null)
            {
                return appEvents(__value3);
            }
            else if (AppStoreVersionExperiments1 is { } __value4 && appStoreVersionExperiments1 != null)
            {
                return appStoreVersionExperiments1(__value4);
            }
            else if (AppStoreVersionExperiments2 is { } __value5 && appStoreVersionExperiments2 != null)
            {
                return appStoreVersionExperiments2(__value5);
            }
            else if (BackgroundAssetVersions is { } __value6 && backgroundAssetVersions != null)
            {
                return backgroundAssetVersions(__value6);
            }
            else if (GameCenterAchievementVersions is { } __value7 && gameCenterAchievementVersions != null)
            {
                return gameCenterAchievementVersions(__value7);
            }
            else if (GameCenterActivityVersions is { } __value8 && gameCenterActivityVersions != null)
            {
                return gameCenterActivityVersions(__value8);
            }
            else if (GameCenterChallengeVersions is { } __value9 && gameCenterChallengeVersions != null)
            {
                return gameCenterChallengeVersions(__value9);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value10 && gameCenterLeaderboardSetVersions != null)
            {
                return gameCenterLeaderboardSetVersions(__value10);
            }
            else if (GameCenterLeaderboardVersions is { } __value11 && gameCenterLeaderboardVersions != null)
            {
                return gameCenterLeaderboardVersions(__value11);
            }
            else if (InAppPurchaseVersions is { } __value12 && inAppPurchaseVersions != null)
            {
                return inAppPurchaseVersions(__value12);
            }
            else if (SubscriptionGroupVersions is { } __value13 && subscriptionGroupVersions != null)
            {
                return subscriptionGroupVersions(__value13);
            }
            else if (SubscriptionVersions is { } __value14 && subscriptionVersions != null)
            {
                return subscriptionVersions(__value14);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImage>? appAssetLibraryImages = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideo>? appAssetLibraryVideos = null,

            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,

            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperiment>? appStoreVersionExperiments1 = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersionExperiments2 = null,

            global::System.Action<global::AppStoreConnect.BackgroundAssetVersion>? backgroundAssetVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievementVersionV2>? gameCenterAchievementVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityVersion>? gameCenterActivityVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersion>? gameCenterChallengeVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2>? gameCenterLeaderboardSetVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardVersionV2>? gameCenterLeaderboardVersions = null,

            global::System.Action<global::AppStoreConnect.InAppPurchaseVersion>? inAppPurchaseVersions = null,

            global::System.Action<global::AppStoreConnect.SubscriptionGroupVersion>? subscriptionGroupVersions = null,

            global::System.Action<global::AppStoreConnect.SubscriptionVersion>? subscriptionVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImages is { } __value0)
            {
                appAssetLibraryImages?.Invoke(__value0);
            }
            else if (AppAssetLibraryVideos is { } __value1)
            {
                appAssetLibraryVideos?.Invoke(__value1);
            }
            else if (AppCustomProductPageVersions is { } __value2)
            {
                appCustomProductPageVersions?.Invoke(__value2);
            }
            else if (AppEvents is { } __value3)
            {
                appEvents?.Invoke(__value3);
            }
            else if (AppStoreVersionExperiments1 is { } __value4)
            {
                appStoreVersionExperiments1?.Invoke(__value4);
            }
            else if (AppStoreVersionExperiments2 is { } __value5)
            {
                appStoreVersionExperiments2?.Invoke(__value5);
            }
            else if (BackgroundAssetVersions is { } __value6)
            {
                backgroundAssetVersions?.Invoke(__value6);
            }
            else if (GameCenterAchievementVersions is { } __value7)
            {
                gameCenterAchievementVersions?.Invoke(__value7);
            }
            else if (GameCenterActivityVersions is { } __value8)
            {
                gameCenterActivityVersions?.Invoke(__value8);
            }
            else if (GameCenterChallengeVersions is { } __value9)
            {
                gameCenterChallengeVersions?.Invoke(__value9);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value10)
            {
                gameCenterLeaderboardSetVersions?.Invoke(__value10);
            }
            else if (GameCenterLeaderboardVersions is { } __value11)
            {
                gameCenterLeaderboardVersions?.Invoke(__value11);
            }
            else if (InAppPurchaseVersions is { } __value12)
            {
                inAppPurchaseVersions?.Invoke(__value12);
            }
            else if (SubscriptionGroupVersions is { } __value13)
            {
                subscriptionGroupVersions?.Invoke(__value13);
            }
            else if (SubscriptionVersions is { } __value14)
            {
                subscriptionVersions?.Invoke(__value14);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImage>? appAssetLibraryImages = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideo>? appAssetLibraryVideos = null,
            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,
            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperiment>? appStoreVersionExperiments1 = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersionExperiments2 = null,
            global::System.Action<global::AppStoreConnect.BackgroundAssetVersion>? backgroundAssetVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievementVersionV2>? gameCenterAchievementVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityVersion>? gameCenterActivityVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersion>? gameCenterChallengeVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2>? gameCenterLeaderboardSetVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardVersionV2>? gameCenterLeaderboardVersions = null,
            global::System.Action<global::AppStoreConnect.InAppPurchaseVersion>? inAppPurchaseVersions = null,
            global::System.Action<global::AppStoreConnect.SubscriptionGroupVersion>? subscriptionGroupVersions = null,
            global::System.Action<global::AppStoreConnect.SubscriptionVersion>? subscriptionVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImages is { } __value0)
            {
                appAssetLibraryImages?.Invoke(__value0);
            }
            else if (AppAssetLibraryVideos is { } __value1)
            {
                appAssetLibraryVideos?.Invoke(__value1);
            }
            else if (AppCustomProductPageVersions is { } __value2)
            {
                appCustomProductPageVersions?.Invoke(__value2);
            }
            else if (AppEvents is { } __value3)
            {
                appEvents?.Invoke(__value3);
            }
            else if (AppStoreVersionExperiments1 is { } __value4)
            {
                appStoreVersionExperiments1?.Invoke(__value4);
            }
            else if (AppStoreVersionExperiments2 is { } __value5)
            {
                appStoreVersionExperiments2?.Invoke(__value5);
            }
            else if (BackgroundAssetVersions is { } __value6)
            {
                backgroundAssetVersions?.Invoke(__value6);
            }
            else if (GameCenterAchievementVersions is { } __value7)
            {
                gameCenterAchievementVersions?.Invoke(__value7);
            }
            else if (GameCenterActivityVersions is { } __value8)
            {
                gameCenterActivityVersions?.Invoke(__value8);
            }
            else if (GameCenterChallengeVersions is { } __value9)
            {
                gameCenterChallengeVersions?.Invoke(__value9);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value10)
            {
                gameCenterLeaderboardSetVersions?.Invoke(__value10);
            }
            else if (GameCenterLeaderboardVersions is { } __value11)
            {
                gameCenterLeaderboardVersions?.Invoke(__value11);
            }
            else if (InAppPurchaseVersions is { } __value12)
            {
                inAppPurchaseVersions?.Invoke(__value12);
            }
            else if (SubscriptionGroupVersions is { } __value13)
            {
                subscriptionGroupVersions?.Invoke(__value13);
            }
            else if (SubscriptionVersions is { } __value14)
            {
                subscriptionVersions?.Invoke(__value14);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryImages,
                typeof(global::AppStoreConnect.AppAssetLibraryImage),
                AppAssetLibraryVideos,
                typeof(global::AppStoreConnect.AppAssetLibraryVideo),
                AppCustomProductPageVersions,
                typeof(global::AppStoreConnect.AppCustomProductPageVersion),
                AppEvents,
                typeof(global::AppStoreConnect.AppEvent),
                AppStoreVersionExperiments1,
                typeof(global::AppStoreConnect.AppStoreVersionExperiment),
                AppStoreVersionExperiments2,
                typeof(global::AppStoreConnect.AppStoreVersion),
                BackgroundAssetVersions,
                typeof(global::AppStoreConnect.BackgroundAssetVersion),
                GameCenterAchievementVersions,
                typeof(global::AppStoreConnect.GameCenterAchievementVersionV2),
                GameCenterActivityVersions,
                typeof(global::AppStoreConnect.GameCenterActivityVersion),
                GameCenterChallengeVersions,
                typeof(global::AppStoreConnect.GameCenterChallengeVersion),
                GameCenterLeaderboardSetVersions,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2),
                GameCenterLeaderboardVersions,
                typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2),
                InAppPurchaseVersions,
                typeof(global::AppStoreConnect.InAppPurchaseVersion),
                SubscriptionGroupVersions,
                typeof(global::AppStoreConnect.SubscriptionGroupVersion),
                SubscriptionVersions,
                typeof(global::AppStoreConnect.SubscriptionVersion),
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
        public bool Equals(IncludedItem156 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImage?>.Default.Equals(AppAssetLibraryImages, other.AppAssetLibraryImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideo?>.Default.Equals(AppAssetLibraryVideos, other.AppAssetLibraryVideos) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageVersion?>.Default.Equals(AppCustomProductPageVersions, other.AppCustomProductPageVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEvent?>.Default.Equals(AppEvents, other.AppEvents) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperiment?>.Default.Equals(AppStoreVersionExperiments1, other.AppStoreVersionExperiments1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersionExperiments2, other.AppStoreVersionExperiments2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BackgroundAssetVersion?>.Default.Equals(BackgroundAssetVersions, other.BackgroundAssetVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementVersionV2?>.Default.Equals(GameCenterAchievementVersions, other.GameCenterAchievementVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityVersion?>.Default.Equals(GameCenterActivityVersions, other.GameCenterActivityVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeVersion?>.Default.Equals(GameCenterChallengeVersions, other.GameCenterChallengeVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?>.Default.Equals(GameCenterLeaderboardSetVersions, other.GameCenterLeaderboardSetVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardVersionV2?>.Default.Equals(GameCenterLeaderboardVersions, other.GameCenterLeaderboardVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseVersion?>.Default.Equals(InAppPurchaseVersions, other.InAppPurchaseVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionGroupVersion?>.Default.Equals(SubscriptionGroupVersions, other.SubscriptionGroupVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionVersion?>.Default.Equals(SubscriptionVersions, other.SubscriptionVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem156 obj1, IncludedItem156 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem156>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem156 obj1, IncludedItem156 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem156 o && Equals(o);
        }
    }
}
