#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem104 : global::System.IEquatable<IncludedItem104>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersions))]
#endif
        public bool IsAppStoreVersions => AppStoreVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersions;
            return IsAppStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions() => AppStoreVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? Apps { get; init; }
#else
        public global::AppStoreConnect.App? Apps { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Apps))]
#endif
        public bool IsApps => Apps != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = Apps;
            return IsApps;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickApps() => Apps is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Apps' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementRelease? GameCenterAchievementReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementRelease? GameCenterAchievementReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementReleases))]
#endif
        public bool IsGameCenterAchievementReleases => GameCenterAchievementReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterAchievementReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementRelease? value)
        {
            value = GameCenterAchievementReleases;
            return IsGameCenterAchievementReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementRelease PickGameCenterAchievementReleases() => GameCenterAchievementReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievements { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievements { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievements))]
#endif
        public bool IsGameCenterAchievements => GameCenterAchievements != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterAchievements(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievement? value)
        {
            value = GameCenterAchievements;
            return IsGameCenterAchievements;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievements() => GameCenterAchievements is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievements' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivity? GameCenterActivities { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivity? GameCenterActivities { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivities))]
#endif
        public bool IsGameCenterActivities => GameCenterActivities != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterActivities(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivity? value)
        {
            value = GameCenterActivities;
            return IsGameCenterActivities;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivity PickGameCenterActivities() => GameCenterActivities is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivities' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivityVersionRelease? GameCenterActivityVersionReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivityVersionRelease? GameCenterActivityVersionReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityVersionReleases))]
#endif
        public bool IsGameCenterActivityVersionReleases => GameCenterActivityVersionReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterActivityVersionReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivityVersionRelease? value)
        {
            value = GameCenterActivityVersionReleases;
            return IsGameCenterActivityVersionReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityVersionRelease PickGameCenterActivityVersionReleases() => GameCenterActivityVersionReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityVersionReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAppVersion? GameCenterAppVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterAppVersion? GameCenterAppVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAppVersions))]
#endif
        public bool IsGameCenterAppVersions => GameCenterAppVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterAppVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAppVersion? value)
        {
            value = GameCenterAppVersions;
            return IsGameCenterAppVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAppVersion PickGameCenterAppVersions() => GameCenterAppVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAppVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallengeVersionRelease? GameCenterChallengeVersionReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallengeVersionRelease? GameCenterChallengeVersionReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeVersionReleases))]
#endif
        public bool IsGameCenterChallengeVersionReleases => GameCenterChallengeVersionReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterChallengeVersionReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallengeVersionRelease? value)
        {
            value = GameCenterChallengeVersionReleases;
            return IsGameCenterChallengeVersionReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeVersionRelease PickGameCenterChallengeVersionReleases() => GameCenterChallengeVersionReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeVersionReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallenge? GameCenterChallenges { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallenge? GameCenterChallenges { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallenges))]
#endif
        public bool IsGameCenterChallenges => GameCenterChallenges != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterChallenges(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallenge? value)
        {
            value = GameCenterChallenges;
            return IsGameCenterChallenges;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterChallenge PickGameCenterChallenges() => GameCenterChallenges is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallenges' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterGroup? GameCenterGroups { get; init; }
#else
        public global::AppStoreConnect.GameCenterGroup? GameCenterGroups { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterGroups))]
#endif
        public bool IsGameCenterGroups => GameCenterGroups != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterGroup? value)
        {
            value = GameCenterGroups;
            return IsGameCenterGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterGroup PickGameCenterGroups() => GameCenterGroups is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterGroups' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardRelease? GameCenterLeaderboardReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardRelease? GameCenterLeaderboardReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardReleases))]
#endif
        public bool IsGameCenterLeaderboardReleases => GameCenterLeaderboardReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardRelease? value)
        {
            value = GameCenterLeaderboardReleases;
            return IsGameCenterLeaderboardReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardRelease PickGameCenterLeaderboardReleases() => GameCenterLeaderboardReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease? GameCenterLeaderboardSetReleases { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease? GameCenterLeaderboardSetReleases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSetReleases))]
#endif
        public bool IsGameCenterLeaderboardSetReleases => GameCenterLeaderboardSetReleases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSetReleases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSetRelease? value)
        {
            value = GameCenterLeaderboardSetReleases;
            return IsGameCenterLeaderboardSetReleases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease PickGameCenterLeaderboardSetReleases() => GameCenterLeaderboardSetReleases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetReleases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSets { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSets { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSets))]
#endif
        public bool IsGameCenterLeaderboardSets => GameCenterLeaderboardSets != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            value = GameCenterLeaderboardSets;
            return IsGameCenterLeaderboardSets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSet PickGameCenterLeaderboardSets() => GameCenterLeaderboardSets is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboards { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboards { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboards))]
#endif
        public bool IsGameCenterLeaderboards => GameCenterLeaderboards != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboards(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            value = GameCenterLeaderboards;
            return IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboards() => GameCenterLeaderboards is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboards' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem104((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem104 @this) => @this.AppStoreVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.App value) => new IncludedItem104((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem104 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromApps(global::AppStoreConnect.App? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterAchievementRelease value) => new IncludedItem104((global::AppStoreConnect.GameCenterAchievementRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementRelease?(IncludedItem104 @this) => @this.GameCenterAchievementReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterAchievementRelease? value)
        {
            GameCenterAchievementReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterAchievementReleases(global::AppStoreConnect.GameCenterAchievementRelease? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem104((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem104 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem104((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem104 @this) => @this.GameCenterActivities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterActivityVersionRelease value) => new IncludedItem104((global::AppStoreConnect.GameCenterActivityVersionRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersionRelease?(IncludedItem104 @this) => @this.GameCenterActivityVersionReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterActivityVersionRelease? value)
        {
            GameCenterActivityVersionReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterActivityVersionReleases(global::AppStoreConnect.GameCenterActivityVersionRelease? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterAppVersion value) => new IncludedItem104((global::AppStoreConnect.GameCenterAppVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAppVersion?(IncludedItem104 @this) => @this.GameCenterAppVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterAppVersion? value)
        {
            GameCenterAppVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterAppVersions(global::AppStoreConnect.GameCenterAppVersion? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterChallengeVersionRelease value) => new IncludedItem104((global::AppStoreConnect.GameCenterChallengeVersionRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeVersionRelease?(IncludedItem104 @this) => @this.GameCenterChallengeVersionReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterChallengeVersionRelease? value)
        {
            GameCenterChallengeVersionReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterChallengeVersionReleases(global::AppStoreConnect.GameCenterChallengeVersionRelease? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterChallenge value) => new IncludedItem104((global::AppStoreConnect.GameCenterChallenge?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallenge?(IncludedItem104 @this) => @this.GameCenterChallenges;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterChallenge? value)
        {
            GameCenterChallenges = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterChallenges(global::AppStoreConnect.GameCenterChallenge? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem104((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem104 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterLeaderboardRelease value) => new IncludedItem104((global::AppStoreConnect.GameCenterLeaderboardRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardRelease?(IncludedItem104 @this) => @this.GameCenterLeaderboardReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterLeaderboardRelease? value)
        {
            GameCenterLeaderboardReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterLeaderboardReleases(global::AppStoreConnect.GameCenterLeaderboardRelease? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterLeaderboardSetRelease value) => new IncludedItem104((global::AppStoreConnect.GameCenterLeaderboardSetRelease?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetRelease?(IncludedItem104 @this) => @this.GameCenterLeaderboardSetReleases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterLeaderboardSetRelease? value)
        {
            GameCenterLeaderboardSetReleases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterLeaderboardSetReleases(global::AppStoreConnect.GameCenterLeaderboardSetRelease? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem104((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem104 @this) => @this.GameCenterLeaderboardSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterLeaderboardSets(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem104(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem104((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem104 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem104 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem104(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem104(
            global::AppStoreConnect.GameCenterDetailResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.GameCenterAchievementRelease? gameCenterAchievementReleases,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievements,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterActivityVersionRelease? gameCenterActivityVersionReleases,
            global::AppStoreConnect.GameCenterAppVersion? gameCenterAppVersions,
            global::AppStoreConnect.GameCenterChallengeVersionRelease? gameCenterChallengeVersionReleases,
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallenges,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups,
            global::AppStoreConnect.GameCenterLeaderboardRelease? gameCenterLeaderboardReleases,
            global::AppStoreConnect.GameCenterLeaderboardSetRelease? gameCenterLeaderboardSetReleases,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards
            )
        {
            Type = type;

            AppStoreVersions = appStoreVersions;
            Apps = apps;
            GameCenterAchievementReleases = gameCenterAchievementReleases;
            GameCenterAchievements = gameCenterAchievements;
            GameCenterActivities = gameCenterActivities;
            GameCenterActivityVersionReleases = gameCenterActivityVersionReleases;
            GameCenterAppVersions = gameCenterAppVersions;
            GameCenterChallengeVersionReleases = gameCenterChallengeVersionReleases;
            GameCenterChallenges = gameCenterChallenges;
            GameCenterGroups = gameCenterGroups;
            GameCenterLeaderboardReleases = gameCenterLeaderboardReleases;
            GameCenterLeaderboardSetReleases = gameCenterLeaderboardSetReleases;
            GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            GameCenterLeaderboards = gameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboards as object ??
            GameCenterLeaderboardSets as object ??
            GameCenterLeaderboardSetReleases as object ??
            GameCenterLeaderboardReleases as object ??
            GameCenterGroups as object ??
            GameCenterChallenges as object ??
            GameCenterChallengeVersionReleases as object ??
            GameCenterAppVersions as object ??
            GameCenterActivityVersionReleases as object ??
            GameCenterActivities as object ??
            GameCenterAchievements as object ??
            GameCenterAchievementReleases as object ??
            Apps as object ??
            AppStoreVersions as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppStoreVersions?.ToString() ??
            Apps?.ToString() ??
            GameCenterAchievementReleases?.ToString() ??
            GameCenterAchievements?.ToString() ??
            GameCenterActivities?.ToString() ??
            GameCenterActivityVersionReleases?.ToString() ??
            GameCenterAppVersions?.ToString() ??
            GameCenterChallengeVersionReleases?.ToString() ??
            GameCenterChallenges?.ToString() ??
            GameCenterGroups?.ToString() ??
            GameCenterLeaderboardReleases?.ToString() ??
            GameCenterLeaderboardSetReleases?.ToString() ??
            GameCenterLeaderboardSets?.ToString() ??
            GameCenterLeaderboards?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsAppStoreVersions && !IsApps && !IsGameCenterAchievementReleases && !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions && !IsGameCenterChallengeVersionReleases && !IsGameCenterChallenges && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases && !IsGameCenterLeaderboardSetReleases && !IsGameCenterLeaderboardSets && IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievementRelease, TResult>? gameCenterAchievementReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievements = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityVersionRelease, TResult>? gameCenterActivityVersionReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterAppVersion, TResult>? gameCenterAppVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallengeVersionRelease, TResult>? gameCenterChallengeVersionReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallenge, TResult>? gameCenterChallenges = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardRelease, TResult>? gameCenterLeaderboardReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetRelease, TResult>? gameCenterLeaderboardSetReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSets = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersions is { } __value0 && appStoreVersions != null)
            {
                return appStoreVersions(__value0);
            }
            else if (Apps is { } __value1 && apps != null)
            {
                return apps(__value1);
            }
            else if (GameCenterAchievementReleases is { } __value2 && gameCenterAchievementReleases != null)
            {
                return gameCenterAchievementReleases(__value2);
            }
            else if (GameCenterAchievements is { } __value3 && gameCenterAchievements != null)
            {
                return gameCenterAchievements(__value3);
            }
            else if (GameCenterActivities is { } __value4 && gameCenterActivities != null)
            {
                return gameCenterActivities(__value4);
            }
            else if (GameCenterActivityVersionReleases is { } __value5 && gameCenterActivityVersionReleases != null)
            {
                return gameCenterActivityVersionReleases(__value5);
            }
            else if (GameCenterAppVersions is { } __value6 && gameCenterAppVersions != null)
            {
                return gameCenterAppVersions(__value6);
            }
            else if (GameCenterChallengeVersionReleases is { } __value7 && gameCenterChallengeVersionReleases != null)
            {
                return gameCenterChallengeVersionReleases(__value7);
            }
            else if (GameCenterChallenges is { } __value8 && gameCenterChallenges != null)
            {
                return gameCenterChallenges(__value8);
            }
            else if (GameCenterGroups is { } __value9 && gameCenterGroups != null)
            {
                return gameCenterGroups(__value9);
            }
            else if (GameCenterLeaderboardReleases is { } __value10 && gameCenterLeaderboardReleases != null)
            {
                return gameCenterLeaderboardReleases(__value10);
            }
            else if (GameCenterLeaderboardSetReleases is { } __value11 && gameCenterLeaderboardSetReleases != null)
            {
                return gameCenterLeaderboardSetReleases(__value11);
            }
            else if (GameCenterLeaderboardSets is { } __value12 && gameCenterLeaderboardSets != null)
            {
                return gameCenterLeaderboardSets(__value12);
            }
            else if (GameCenterLeaderboards is { } __value13 && gameCenterLeaderboards != null)
            {
                return gameCenterLeaderboards(__value13);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,

            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievementRelease>? gameCenterAchievementReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityVersionRelease>? gameCenterActivityVersionReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterAppVersion>? gameCenterAppVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersionRelease>? gameCenterChallengeVersionReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardRelease>? gameCenterLeaderboardReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetRelease>? gameCenterLeaderboardSetReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersions is { } __value0)
            {
                appStoreVersions?.Invoke(__value0);
            }
            else if (Apps is { } __value1)
            {
                apps?.Invoke(__value1);
            }
            else if (GameCenterAchievementReleases is { } __value2)
            {
                gameCenterAchievementReleases?.Invoke(__value2);
            }
            else if (GameCenterAchievements is { } __value3)
            {
                gameCenterAchievements?.Invoke(__value3);
            }
            else if (GameCenterActivities is { } __value4)
            {
                gameCenterActivities?.Invoke(__value4);
            }
            else if (GameCenterActivityVersionReleases is { } __value5)
            {
                gameCenterActivityVersionReleases?.Invoke(__value5);
            }
            else if (GameCenterAppVersions is { } __value6)
            {
                gameCenterAppVersions?.Invoke(__value6);
            }
            else if (GameCenterChallengeVersionReleases is { } __value7)
            {
                gameCenterChallengeVersionReleases?.Invoke(__value7);
            }
            else if (GameCenterChallenges is { } __value8)
            {
                gameCenterChallenges?.Invoke(__value8);
            }
            else if (GameCenterGroups is { } __value9)
            {
                gameCenterGroups?.Invoke(__value9);
            }
            else if (GameCenterLeaderboardReleases is { } __value10)
            {
                gameCenterLeaderboardReleases?.Invoke(__value10);
            }
            else if (GameCenterLeaderboardSetReleases is { } __value11)
            {
                gameCenterLeaderboardSetReleases?.Invoke(__value11);
            }
            else if (GameCenterLeaderboardSets is { } __value12)
            {
                gameCenterLeaderboardSets?.Invoke(__value12);
            }
            else if (GameCenterLeaderboards is { } __value13)
            {
                gameCenterLeaderboards?.Invoke(__value13);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievementRelease>? gameCenterAchievementReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityVersionRelease>? gameCenterActivityVersionReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterAppVersion>? gameCenterAppVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersionRelease>? gameCenterChallengeVersionReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardRelease>? gameCenterLeaderboardReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetRelease>? gameCenterLeaderboardSetReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersions is { } __value0)
            {
                appStoreVersions?.Invoke(__value0);
            }
            else if (Apps is { } __value1)
            {
                apps?.Invoke(__value1);
            }
            else if (GameCenterAchievementReleases is { } __value2)
            {
                gameCenterAchievementReleases?.Invoke(__value2);
            }
            else if (GameCenterAchievements is { } __value3)
            {
                gameCenterAchievements?.Invoke(__value3);
            }
            else if (GameCenterActivities is { } __value4)
            {
                gameCenterActivities?.Invoke(__value4);
            }
            else if (GameCenterActivityVersionReleases is { } __value5)
            {
                gameCenterActivityVersionReleases?.Invoke(__value5);
            }
            else if (GameCenterAppVersions is { } __value6)
            {
                gameCenterAppVersions?.Invoke(__value6);
            }
            else if (GameCenterChallengeVersionReleases is { } __value7)
            {
                gameCenterChallengeVersionReleases?.Invoke(__value7);
            }
            else if (GameCenterChallenges is { } __value8)
            {
                gameCenterChallenges?.Invoke(__value8);
            }
            else if (GameCenterGroups is { } __value9)
            {
                gameCenterGroups?.Invoke(__value9);
            }
            else if (GameCenterLeaderboardReleases is { } __value10)
            {
                gameCenterLeaderboardReleases?.Invoke(__value10);
            }
            else if (GameCenterLeaderboardSetReleases is { } __value11)
            {
                gameCenterLeaderboardSetReleases?.Invoke(__value11);
            }
            else if (GameCenterLeaderboardSets is { } __value12)
            {
                gameCenterLeaderboardSets?.Invoke(__value12);
            }
            else if (GameCenterLeaderboards is { } __value13)
            {
                gameCenterLeaderboards?.Invoke(__value13);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppStoreVersions,
                typeof(global::AppStoreConnect.AppStoreVersion),
                Apps,
                typeof(global::AppStoreConnect.App),
                GameCenterAchievementReleases,
                typeof(global::AppStoreConnect.GameCenterAchievementRelease),
                GameCenterAchievements,
                typeof(global::AppStoreConnect.GameCenterAchievement),
                GameCenterActivities,
                typeof(global::AppStoreConnect.GameCenterActivity),
                GameCenterActivityVersionReleases,
                typeof(global::AppStoreConnect.GameCenterActivityVersionRelease),
                GameCenterAppVersions,
                typeof(global::AppStoreConnect.GameCenterAppVersion),
                GameCenterChallengeVersionReleases,
                typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease),
                GameCenterChallenges,
                typeof(global::AppStoreConnect.GameCenterChallenge),
                GameCenterGroups,
                typeof(global::AppStoreConnect.GameCenterGroup),
                GameCenterLeaderboardReleases,
                typeof(global::AppStoreConnect.GameCenterLeaderboardRelease),
                GameCenterLeaderboardSetReleases,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease),
                GameCenterLeaderboardSets,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSet),
                GameCenterLeaderboards,
                typeof(global::AppStoreConnect.GameCenterLeaderboard),
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
        public bool Equals(IncludedItem104 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementRelease?>.Default.Equals(GameCenterAchievementReleases, other.GameCenterAchievementReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityVersionRelease?>.Default.Equals(GameCenterActivityVersionReleases, other.GameCenterActivityVersionReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAppVersion?>.Default.Equals(GameCenterAppVersions, other.GameCenterAppVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeVersionRelease?>.Default.Equals(GameCenterChallengeVersionReleases, other.GameCenterChallengeVersionReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallenge?>.Default.Equals(GameCenterChallenges, other.GameCenterChallenges) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardRelease?>.Default.Equals(GameCenterLeaderboardReleases, other.GameCenterLeaderboardReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetRelease?>.Default.Equals(GameCenterLeaderboardSetReleases, other.GameCenterLeaderboardSetReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSets, other.GameCenterLeaderboardSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem104 obj1, IncludedItem104 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem104>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem104 obj1, IncludedItem104 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem104 o && Equals(o);
        }
    }
}
