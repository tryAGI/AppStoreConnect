#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem154 : global::System.IEquatable<IncludedItem154>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AppCustomProductPageVersion PickAppCustomProductPageVersions() => IsAppCustomProductPageVersions
            ? AppCustomProductPageVersions!
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
        public global::AppStoreConnect.AppEvent PickAppEvents() => IsAppEvents
            ? AppEvents!
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
        public global::AppStoreConnect.AppStoreVersionExperiment PickAppStoreVersionExperiments1() => IsAppStoreVersionExperiments1
            ? AppStoreVersionExperiments1!
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
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersionExperiments2() => IsAppStoreVersionExperiments2
            ? AppStoreVersionExperiments2!
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
        public global::AppStoreConnect.BackgroundAssetVersion PickBackgroundAssetVersions() => IsBackgroundAssetVersions
            ? BackgroundAssetVersions!
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
        public global::AppStoreConnect.GameCenterAchievementVersionV2 PickGameCenterAchievementVersions() => IsGameCenterAchievementVersions
            ? GameCenterAchievementVersions!
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
        public global::AppStoreConnect.GameCenterActivityVersion PickGameCenterActivityVersions() => IsGameCenterActivityVersions
            ? GameCenterActivityVersions!
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
        public global::AppStoreConnect.GameCenterChallengeVersion PickGameCenterChallengeVersions() => IsGameCenterChallengeVersions
            ? GameCenterChallengeVersions!
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
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 PickGameCenterLeaderboardSetVersions() => IsGameCenterLeaderboardSetVersions
            ? GameCenterLeaderboardSetVersions!
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
        public global::AppStoreConnect.GameCenterLeaderboardVersionV2 PickGameCenterLeaderboardVersions() => IsGameCenterLeaderboardVersions
            ? GameCenterLeaderboardVersions!
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
        public global::AppStoreConnect.InAppPurchaseVersion PickInAppPurchaseVersions() => IsInAppPurchaseVersions
            ? InAppPurchaseVersions!
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
        public global::AppStoreConnect.SubscriptionGroupVersion PickSubscriptionGroupVersions() => IsSubscriptionGroupVersions
            ? SubscriptionGroupVersions!
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
        public global::AppStoreConnect.SubscriptionVersion PickSubscriptionVersions() => IsSubscriptionVersions
            ? SubscriptionVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.AppCustomProductPageVersion value) => new IncludedItem154((global::AppStoreConnect.AppCustomProductPageVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageVersion?(IncludedItem154 @this) => @this.AppCustomProductPageVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.AppCustomProductPageVersion? value)
        {
            AppCustomProductPageVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromAppCustomProductPageVersions(global::AppStoreConnect.AppCustomProductPageVersion? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.AppEvent value) => new IncludedItem154((global::AppStoreConnect.AppEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEvent?(IncludedItem154 @this) => @this.AppEvents;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.AppEvent? value)
        {
            AppEvents = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromAppEvents(global::AppStoreConnect.AppEvent? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.AppStoreVersionExperiment value) => new IncludedItem154((global::AppStoreConnect.AppStoreVersionExperiment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperiment?(IncludedItem154 @this) => @this.AppStoreVersionExperiments1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.AppStoreVersionExperiment? value)
        {
            AppStoreVersionExperiments1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromAppStoreVersionExperiments1(global::AppStoreConnect.AppStoreVersionExperiment? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem154((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem154 @this) => @this.AppStoreVersionExperiments2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersionExperiments2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromAppStoreVersionExperiments2(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.BackgroundAssetVersion value) => new IncludedItem154((global::AppStoreConnect.BackgroundAssetVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BackgroundAssetVersion?(IncludedItem154 @this) => @this.BackgroundAssetVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.BackgroundAssetVersion? value)
        {
            BackgroundAssetVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromBackgroundAssetVersions(global::AppStoreConnect.BackgroundAssetVersion? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.GameCenterAchievementVersionV2 value) => new IncludedItem154((global::AppStoreConnect.GameCenterAchievementVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementVersionV2?(IncludedItem154 @this) => @this.GameCenterAchievementVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.GameCenterAchievementVersionV2? value)
        {
            GameCenterAchievementVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromGameCenterAchievementVersions(global::AppStoreConnect.GameCenterAchievementVersionV2? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.GameCenterActivityVersion value) => new IncludedItem154((global::AppStoreConnect.GameCenterActivityVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersion?(IncludedItem154 @this) => @this.GameCenterActivityVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.GameCenterActivityVersion? value)
        {
            GameCenterActivityVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromGameCenterActivityVersions(global::AppStoreConnect.GameCenterActivityVersion? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.GameCenterChallengeVersion value) => new IncludedItem154((global::AppStoreConnect.GameCenterChallengeVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeVersion?(IncludedItem154 @this) => @this.GameCenterChallengeVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.GameCenterChallengeVersion? value)
        {
            GameCenterChallengeVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromGameCenterChallengeVersions(global::AppStoreConnect.GameCenterChallengeVersion? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 value) => new IncludedItem154((global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?(IncludedItem154 @this) => @this.GameCenterLeaderboardSetVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value)
        {
            GameCenterLeaderboardSetVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromGameCenterLeaderboardSetVersions(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.GameCenterLeaderboardVersionV2 value) => new IncludedItem154((global::AppStoreConnect.GameCenterLeaderboardVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardVersionV2?(IncludedItem154 @this) => @this.GameCenterLeaderboardVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.GameCenterLeaderboardVersionV2? value)
        {
            GameCenterLeaderboardVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromGameCenterLeaderboardVersions(global::AppStoreConnect.GameCenterLeaderboardVersionV2? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.InAppPurchaseVersion value) => new IncludedItem154((global::AppStoreConnect.InAppPurchaseVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseVersion?(IncludedItem154 @this) => @this.InAppPurchaseVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.InAppPurchaseVersion? value)
        {
            InAppPurchaseVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromInAppPurchaseVersions(global::AppStoreConnect.InAppPurchaseVersion? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.SubscriptionGroupVersion value) => new IncludedItem154((global::AppStoreConnect.SubscriptionGroupVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroupVersion?(IncludedItem154 @this) => @this.SubscriptionGroupVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.SubscriptionGroupVersion? value)
        {
            SubscriptionGroupVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromSubscriptionGroupVersions(global::AppStoreConnect.SubscriptionGroupVersion? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem154(global::AppStoreConnect.SubscriptionVersion value) => new IncludedItem154((global::AppStoreConnect.SubscriptionVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionVersion?(IncludedItem154 @this) => @this.SubscriptionVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(global::AppStoreConnect.SubscriptionVersion? value)
        {
            SubscriptionVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem154 FromSubscriptionVersions(global::AppStoreConnect.SubscriptionVersion? value) => new IncludedItem154(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem154(
            global::AppStoreConnect.ReviewSubmissionItemsResponseIncludedItemDiscriminatorType? type,
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
            AppCustomProductPageVersions as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
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
            return IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && IsSubscriptionGroupVersions && !IsSubscriptionVersions || !IsAppCustomProductPageVersions && !IsAppEvents && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBackgroundAssetVersions && !IsGameCenterAchievementVersions && !IsGameCenterActivityVersions && !IsGameCenterChallengeVersions && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboardVersions && !IsInAppPurchaseVersions && !IsSubscriptionGroupVersions && IsSubscriptionVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
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

            if (IsAppCustomProductPageVersions && appCustomProductPageVersions != null)
            {
                return appCustomProductPageVersions(AppCustomProductPageVersions!);
            }
            else if (IsAppEvents && appEvents != null)
            {
                return appEvents(AppEvents!);
            }
            else if (IsAppStoreVersionExperiments1 && appStoreVersionExperiments1 != null)
            {
                return appStoreVersionExperiments1(AppStoreVersionExperiments1!);
            }
            else if (IsAppStoreVersionExperiments2 && appStoreVersionExperiments2 != null)
            {
                return appStoreVersionExperiments2(AppStoreVersionExperiments2!);
            }
            else if (IsBackgroundAssetVersions && backgroundAssetVersions != null)
            {
                return backgroundAssetVersions(BackgroundAssetVersions!);
            }
            else if (IsGameCenterAchievementVersions && gameCenterAchievementVersions != null)
            {
                return gameCenterAchievementVersions(GameCenterAchievementVersions!);
            }
            else if (IsGameCenterActivityVersions && gameCenterActivityVersions != null)
            {
                return gameCenterActivityVersions(GameCenterActivityVersions!);
            }
            else if (IsGameCenterChallengeVersions && gameCenterChallengeVersions != null)
            {
                return gameCenterChallengeVersions(GameCenterChallengeVersions!);
            }
            else if (IsGameCenterLeaderboardSetVersions && gameCenterLeaderboardSetVersions != null)
            {
                return gameCenterLeaderboardSetVersions(GameCenterLeaderboardSetVersions!);
            }
            else if (IsGameCenterLeaderboardVersions && gameCenterLeaderboardVersions != null)
            {
                return gameCenterLeaderboardVersions(GameCenterLeaderboardVersions!);
            }
            else if (IsInAppPurchaseVersions && inAppPurchaseVersions != null)
            {
                return inAppPurchaseVersions(InAppPurchaseVersions!);
            }
            else if (IsSubscriptionGroupVersions && subscriptionGroupVersions != null)
            {
                return subscriptionGroupVersions(SubscriptionGroupVersions!);
            }
            else if (IsSubscriptionVersions && subscriptionVersions != null)
            {
                return subscriptionVersions(SubscriptionVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
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

            if (IsAppCustomProductPageVersions)
            {
                appCustomProductPageVersions?.Invoke(AppCustomProductPageVersions!);
            }
            else if (IsAppEvents)
            {
                appEvents?.Invoke(AppEvents!);
            }
            else if (IsAppStoreVersionExperiments1)
            {
                appStoreVersionExperiments1?.Invoke(AppStoreVersionExperiments1!);
            }
            else if (IsAppStoreVersionExperiments2)
            {
                appStoreVersionExperiments2?.Invoke(AppStoreVersionExperiments2!);
            }
            else if (IsBackgroundAssetVersions)
            {
                backgroundAssetVersions?.Invoke(BackgroundAssetVersions!);
            }
            else if (IsGameCenterAchievementVersions)
            {
                gameCenterAchievementVersions?.Invoke(GameCenterAchievementVersions!);
            }
            else if (IsGameCenterActivityVersions)
            {
                gameCenterActivityVersions?.Invoke(GameCenterActivityVersions!);
            }
            else if (IsGameCenterChallengeVersions)
            {
                gameCenterChallengeVersions?.Invoke(GameCenterChallengeVersions!);
            }
            else if (IsGameCenterLeaderboardSetVersions)
            {
                gameCenterLeaderboardSetVersions?.Invoke(GameCenterLeaderboardSetVersions!);
            }
            else if (IsGameCenterLeaderboardVersions)
            {
                gameCenterLeaderboardVersions?.Invoke(GameCenterLeaderboardVersions!);
            }
            else if (IsInAppPurchaseVersions)
            {
                inAppPurchaseVersions?.Invoke(InAppPurchaseVersions!);
            }
            else if (IsSubscriptionGroupVersions)
            {
                subscriptionGroupVersions?.Invoke(SubscriptionGroupVersions!);
            }
            else if (IsSubscriptionVersions)
            {
                subscriptionVersions?.Invoke(SubscriptionVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
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

            if (IsAppCustomProductPageVersions)
            {
                appCustomProductPageVersions?.Invoke(AppCustomProductPageVersions!);
            }
            else if (IsAppEvents)
            {
                appEvents?.Invoke(AppEvents!);
            }
            else if (IsAppStoreVersionExperiments1)
            {
                appStoreVersionExperiments1?.Invoke(AppStoreVersionExperiments1!);
            }
            else if (IsAppStoreVersionExperiments2)
            {
                appStoreVersionExperiments2?.Invoke(AppStoreVersionExperiments2!);
            }
            else if (IsBackgroundAssetVersions)
            {
                backgroundAssetVersions?.Invoke(BackgroundAssetVersions!);
            }
            else if (IsGameCenterAchievementVersions)
            {
                gameCenterAchievementVersions?.Invoke(GameCenterAchievementVersions!);
            }
            else if (IsGameCenterActivityVersions)
            {
                gameCenterActivityVersions?.Invoke(GameCenterActivityVersions!);
            }
            else if (IsGameCenterChallengeVersions)
            {
                gameCenterChallengeVersions?.Invoke(GameCenterChallengeVersions!);
            }
            else if (IsGameCenterLeaderboardSetVersions)
            {
                gameCenterLeaderboardSetVersions?.Invoke(GameCenterLeaderboardSetVersions!);
            }
            else if (IsGameCenterLeaderboardVersions)
            {
                gameCenterLeaderboardVersions?.Invoke(GameCenterLeaderboardVersions!);
            }
            else if (IsInAppPurchaseVersions)
            {
                inAppPurchaseVersions?.Invoke(InAppPurchaseVersions!);
            }
            else if (IsSubscriptionGroupVersions)
            {
                subscriptionGroupVersions?.Invoke(SubscriptionGroupVersions!);
            }
            else if (IsSubscriptionVersions)
            {
                subscriptionVersions?.Invoke(SubscriptionVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
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
        public bool Equals(IncludedItem154 other)
        {
            return
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
        public static bool operator ==(IncludedItem154 obj1, IncludedItem154 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem154>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem154 obj1, IncludedItem154 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem154 o && Equals(o);
        }
    }
}
