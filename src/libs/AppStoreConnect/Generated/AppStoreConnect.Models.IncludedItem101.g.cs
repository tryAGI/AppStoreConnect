#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem101 : global::System.IEquatable<IncludedItem101>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions() => IsAppStoreVersions
            ? AppStoreVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? GameCenterAppVersions1 { get; init; }
#else
        public global::AppStoreConnect.App? GameCenterAppVersions1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAppVersions1))]
#endif
        public bool IsGameCenterAppVersions1 => GameCenterAppVersions1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAppVersions1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = GameCenterAppVersions1;
            return IsGameCenterAppVersions1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.App PickGameCenterAppVersions1() => IsGameCenterAppVersions1
            ? GameCenterAppVersions1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAppVersions1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementRelease? GameCenterAchievementReleases1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementRelease? GameCenterAchievementReleases1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementReleases1))]
#endif
        public bool IsGameCenterAchievementReleases1 => GameCenterAchievementReleases1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievementReleases1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementRelease? value)
        {
            value = GameCenterAchievementReleases1;
            return IsGameCenterAchievementReleases1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementRelease PickGameCenterAchievementReleases1() => IsGameCenterAchievementReleases1
            ? GameCenterAchievementReleases1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementReleases1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievementReleases2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievementReleases2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementReleases2))]
#endif
        public bool IsGameCenterAchievementReleases2 => GameCenterAchievementReleases2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievementReleases2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievement? value)
        {
            value = GameCenterAchievementReleases2;
            return IsGameCenterAchievementReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievementReleases2() => IsGameCenterAchievementReleases2
            ? GameCenterAchievementReleases2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementReleases2' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterActivity PickGameCenterActivities() => IsGameCenterActivities
            ? GameCenterActivities!
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
        public global::AppStoreConnect.GameCenterActivityVersionRelease PickGameCenterActivityVersionReleases() => IsGameCenterActivityVersionReleases
            ? GameCenterActivityVersionReleases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityVersionReleases' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAppVersion? GameCenterAppVersions2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterAppVersion? GameCenterAppVersions2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAppVersions2))]
#endif
        public bool IsGameCenterAppVersions2 => GameCenterAppVersions2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAppVersions2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAppVersion? value)
        {
            value = GameCenterAppVersions2;
            return IsGameCenterAppVersions2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAppVersion PickGameCenterAppVersions2() => IsGameCenterAppVersions2
            ? GameCenterAppVersions2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAppVersions2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallengeVersionRelease? GameCenterChallengeVersionReleases1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallengeVersionRelease? GameCenterChallengeVersionReleases1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeVersionReleases1))]
#endif
        public bool IsGameCenterChallengeVersionReleases1 => GameCenterChallengeVersionReleases1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterChallengeVersionReleases1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallengeVersionRelease? value)
        {
            value = GameCenterChallengeVersionReleases1;
            return IsGameCenterChallengeVersionReleases1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterChallengeVersionRelease PickGameCenterChallengeVersionReleases1() => IsGameCenterChallengeVersionReleases1
            ? GameCenterChallengeVersionReleases1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeVersionReleases1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterChallenge? GameCenterChallengeVersionReleases2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterChallenge? GameCenterChallengeVersionReleases2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterChallengeVersionReleases2))]
#endif
        public bool IsGameCenterChallengeVersionReleases2 => GameCenterChallengeVersionReleases2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterChallengeVersionReleases2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterChallenge? value)
        {
            value = GameCenterChallengeVersionReleases2;
            return IsGameCenterChallengeVersionReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterChallenge PickGameCenterChallengeVersionReleases2() => IsGameCenterChallengeVersionReleases2
            ? GameCenterChallengeVersionReleases2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterChallengeVersionReleases2' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterGroup PickGameCenterGroups() => IsGameCenterGroups
            ? GameCenterGroups!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterGroups' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardRelease? GameCenterLeaderboardReleases1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardRelease? GameCenterLeaderboardReleases1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardReleases1))]
#endif
        public bool IsGameCenterLeaderboardReleases1 => GameCenterLeaderboardReleases1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardReleases1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardRelease? value)
        {
            value = GameCenterLeaderboardReleases1;
            return IsGameCenterLeaderboardReleases1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardRelease PickGameCenterLeaderboardReleases1() => IsGameCenterLeaderboardReleases1
            ? GameCenterLeaderboardReleases1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardReleases1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease? GameCenterLeaderboardSetReleases1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease? GameCenterLeaderboardSetReleases1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSetReleases1))]
#endif
        public bool IsGameCenterLeaderboardSetReleases1 => GameCenterLeaderboardSetReleases1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardSetReleases1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSetRelease? value)
        {
            value = GameCenterLeaderboardSetReleases1;
            return IsGameCenterLeaderboardSetReleases1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetRelease PickGameCenterLeaderboardSetReleases1() => IsGameCenterLeaderboardSetReleases1
            ? GameCenterLeaderboardSetReleases1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetReleases1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSetReleases2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSetReleases2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSetReleases2))]
#endif
        public bool IsGameCenterLeaderboardSetReleases2 => GameCenterLeaderboardSetReleases2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardSetReleases2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            value = GameCenterLeaderboardSetReleases2;
            return IsGameCenterLeaderboardSetReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSet PickGameCenterLeaderboardSetReleases2() => IsGameCenterLeaderboardSetReleases2
            ? GameCenterLeaderboardSetReleases2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetReleases2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardReleases2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardReleases2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardReleases2))]
#endif
        public bool IsGameCenterLeaderboardReleases2 => GameCenterLeaderboardReleases2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardReleases2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            value = GameCenterLeaderboardReleases2;
            return IsGameCenterLeaderboardReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboardReleases2() => IsGameCenterLeaderboardReleases2
            ? GameCenterLeaderboardReleases2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardReleases2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem101((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem101 @this) => @this.AppStoreVersions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.App value) => new IncludedItem101((global::AppStoreConnect.App?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem101 @this) => @this.GameCenterAppVersions1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.App? value)
        {
            GameCenterAppVersions1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterAppVersions1(global::AppStoreConnect.App? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterAchievementRelease value) => new IncludedItem101((global::AppStoreConnect.GameCenterAchievementRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementRelease?(IncludedItem101 @this) => @this.GameCenterAchievementReleases1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterAchievementRelease? value)
        {
            GameCenterAchievementReleases1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterAchievementReleases1(global::AppStoreConnect.GameCenterAchievementRelease? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem101((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem101 @this) => @this.GameCenterAchievementReleases2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievementReleases2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterAchievementReleases2(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem101((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem101 @this) => @this.GameCenterActivities;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterActivityVersionRelease value) => new IncludedItem101((global::AppStoreConnect.GameCenterActivityVersionRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersionRelease?(IncludedItem101 @this) => @this.GameCenterActivityVersionReleases;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterActivityVersionRelease? value)
        {
            GameCenterActivityVersionReleases = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterActivityVersionReleases(global::AppStoreConnect.GameCenterActivityVersionRelease? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterAppVersion value) => new IncludedItem101((global::AppStoreConnect.GameCenterAppVersion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAppVersion?(IncludedItem101 @this) => @this.GameCenterAppVersions2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterAppVersion? value)
        {
            GameCenterAppVersions2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterAppVersions2(global::AppStoreConnect.GameCenterAppVersion? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterChallengeVersionRelease value) => new IncludedItem101((global::AppStoreConnect.GameCenterChallengeVersionRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeVersionRelease?(IncludedItem101 @this) => @this.GameCenterChallengeVersionReleases1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterChallengeVersionRelease? value)
        {
            GameCenterChallengeVersionReleases1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterChallengeVersionReleases1(global::AppStoreConnect.GameCenterChallengeVersionRelease? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterChallenge value) => new IncludedItem101((global::AppStoreConnect.GameCenterChallenge?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallenge?(IncludedItem101 @this) => @this.GameCenterChallengeVersionReleases2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterChallenge? value)
        {
            GameCenterChallengeVersionReleases2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterChallengeVersionReleases2(global::AppStoreConnect.GameCenterChallenge? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem101((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem101 @this) => @this.GameCenterGroups;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterLeaderboardRelease value) => new IncludedItem101((global::AppStoreConnect.GameCenterLeaderboardRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardRelease?(IncludedItem101 @this) => @this.GameCenterLeaderboardReleases1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterLeaderboardRelease? value)
        {
            GameCenterLeaderboardReleases1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterLeaderboardReleases1(global::AppStoreConnect.GameCenterLeaderboardRelease? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterLeaderboardSetRelease value) => new IncludedItem101((global::AppStoreConnect.GameCenterLeaderboardSetRelease?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetRelease?(IncludedItem101 @this) => @this.GameCenterLeaderboardSetReleases1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterLeaderboardSetRelease? value)
        {
            GameCenterLeaderboardSetReleases1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterLeaderboardSetReleases1(global::AppStoreConnect.GameCenterLeaderboardSetRelease? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem101((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem101 @this) => @this.GameCenterLeaderboardSetReleases2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSetReleases2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterLeaderboardSetReleases2(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem101((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem101 @this) => @this.GameCenterLeaderboardReleases2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboardReleases2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem101 FromGameCenterLeaderboardReleases2(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem101(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem101(
            global::AppStoreConnect.GameCenterDetailsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions,
            global::AppStoreConnect.App? gameCenterAppVersions1,
            global::AppStoreConnect.GameCenterAchievementRelease? gameCenterAchievementReleases1,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievementReleases2,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterActivityVersionRelease? gameCenterActivityVersionReleases,
            global::AppStoreConnect.GameCenterAppVersion? gameCenterAppVersions2,
            global::AppStoreConnect.GameCenterChallengeVersionRelease? gameCenterChallengeVersionReleases1,
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallengeVersionReleases2,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups,
            global::AppStoreConnect.GameCenterLeaderboardRelease? gameCenterLeaderboardReleases1,
            global::AppStoreConnect.GameCenterLeaderboardSetRelease? gameCenterLeaderboardSetReleases1,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSetReleases2,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboardReleases2
            )
        {
            Type = type;

            AppStoreVersions = appStoreVersions;
            GameCenterAppVersions1 = gameCenterAppVersions1;
            GameCenterAchievementReleases1 = gameCenterAchievementReleases1;
            GameCenterAchievementReleases2 = gameCenterAchievementReleases2;
            GameCenterActivities = gameCenterActivities;
            GameCenterActivityVersionReleases = gameCenterActivityVersionReleases;
            GameCenterAppVersions2 = gameCenterAppVersions2;
            GameCenterChallengeVersionReleases1 = gameCenterChallengeVersionReleases1;
            GameCenterChallengeVersionReleases2 = gameCenterChallengeVersionReleases2;
            GameCenterGroups = gameCenterGroups;
            GameCenterLeaderboardReleases1 = gameCenterLeaderboardReleases1;
            GameCenterLeaderboardSetReleases1 = gameCenterLeaderboardSetReleases1;
            GameCenterLeaderboardSetReleases2 = gameCenterLeaderboardSetReleases2;
            GameCenterLeaderboardReleases2 = gameCenterLeaderboardReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardReleases2 as object ??
            GameCenterLeaderboardSetReleases2 as object ??
            GameCenterLeaderboardSetReleases1 as object ??
            GameCenterLeaderboardReleases1 as object ??
            GameCenterGroups as object ??
            GameCenterChallengeVersionReleases2 as object ??
            GameCenterChallengeVersionReleases1 as object ??
            GameCenterAppVersions2 as object ??
            GameCenterActivityVersionReleases as object ??
            GameCenterActivities as object ??
            GameCenterAchievementReleases2 as object ??
            GameCenterAchievementReleases1 as object ??
            GameCenterAppVersions1 as object ??
            AppStoreVersions as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AppStoreVersions?.ToString() ??
            GameCenterAppVersions1?.ToString() ??
            GameCenterAchievementReleases1?.ToString() ??
            GameCenterAchievementReleases2?.ToString() ??
            GameCenterActivities?.ToString() ??
            GameCenterActivityVersionReleases?.ToString() ??
            GameCenterAppVersions2?.ToString() ??
            GameCenterChallengeVersionReleases1?.ToString() ??
            GameCenterChallengeVersionReleases2?.ToString() ??
            GameCenterGroups?.ToString() ??
            GameCenterLeaderboardReleases1?.ToString() ??
            GameCenterLeaderboardSetReleases1?.ToString() ??
            GameCenterLeaderboardSetReleases2?.ToString() ??
            GameCenterLeaderboardReleases2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && IsGameCenterLeaderboardSetReleases2 && !IsGameCenterLeaderboardReleases2 || !IsAppStoreVersions && !IsGameCenterAppVersions1 && !IsGameCenterAchievementReleases1 && !IsGameCenterAchievementReleases2 && !IsGameCenterActivities && !IsGameCenterActivityVersionReleases && !IsGameCenterAppVersions2 && !IsGameCenterChallengeVersionReleases1 && !IsGameCenterChallengeVersionReleases2 && !IsGameCenterGroups && !IsGameCenterLeaderboardReleases1 && !IsGameCenterLeaderboardSetReleases1 && !IsGameCenterLeaderboardSetReleases2 && IsGameCenterLeaderboardReleases2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? gameCenterAppVersions1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievementRelease, TResult>? gameCenterAchievementReleases1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievementReleases2 = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityVersionRelease, TResult>? gameCenterActivityVersionReleases = null,
            global::System.Func<global::AppStoreConnect.GameCenterAppVersion, TResult>? gameCenterAppVersions2 = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallengeVersionRelease, TResult>? gameCenterChallengeVersionReleases1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallenge, TResult>? gameCenterChallengeVersionReleases2 = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardRelease, TResult>? gameCenterLeaderboardReleases1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetRelease, TResult>? gameCenterLeaderboardSetReleases1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSetReleases2 = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboardReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersions && appStoreVersions != null)
            {
                return appStoreVersions(AppStoreVersions!);
            }
            else if (IsGameCenterAppVersions1 && gameCenterAppVersions1 != null)
            {
                return gameCenterAppVersions1(GameCenterAppVersions1!);
            }
            else if (IsGameCenterAchievementReleases1 && gameCenterAchievementReleases1 != null)
            {
                return gameCenterAchievementReleases1(GameCenterAchievementReleases1!);
            }
            else if (IsGameCenterAchievementReleases2 && gameCenterAchievementReleases2 != null)
            {
                return gameCenterAchievementReleases2(GameCenterAchievementReleases2!);
            }
            else if (IsGameCenterActivities && gameCenterActivities != null)
            {
                return gameCenterActivities(GameCenterActivities!);
            }
            else if (IsGameCenterActivityVersionReleases && gameCenterActivityVersionReleases != null)
            {
                return gameCenterActivityVersionReleases(GameCenterActivityVersionReleases!);
            }
            else if (IsGameCenterAppVersions2 && gameCenterAppVersions2 != null)
            {
                return gameCenterAppVersions2(GameCenterAppVersions2!);
            }
            else if (IsGameCenterChallengeVersionReleases1 && gameCenterChallengeVersionReleases1 != null)
            {
                return gameCenterChallengeVersionReleases1(GameCenterChallengeVersionReleases1!);
            }
            else if (IsGameCenterChallengeVersionReleases2 && gameCenterChallengeVersionReleases2 != null)
            {
                return gameCenterChallengeVersionReleases2(GameCenterChallengeVersionReleases2!);
            }
            else if (IsGameCenterGroups && gameCenterGroups != null)
            {
                return gameCenterGroups(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardReleases1 && gameCenterLeaderboardReleases1 != null)
            {
                return gameCenterLeaderboardReleases1(GameCenterLeaderboardReleases1!);
            }
            else if (IsGameCenterLeaderboardSetReleases1 && gameCenterLeaderboardSetReleases1 != null)
            {
                return gameCenterLeaderboardSetReleases1(GameCenterLeaderboardSetReleases1!);
            }
            else if (IsGameCenterLeaderboardSetReleases2 && gameCenterLeaderboardSetReleases2 != null)
            {
                return gameCenterLeaderboardSetReleases2(GameCenterLeaderboardSetReleases2!);
            }
            else if (IsGameCenterLeaderboardReleases2 && gameCenterLeaderboardReleases2 != null)
            {
                return gameCenterLeaderboardReleases2(GameCenterLeaderboardReleases2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,

            global::System.Action<global::AppStoreConnect.App>? gameCenterAppVersions1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievementRelease>? gameCenterAchievementReleases1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievementReleases2 = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityVersionRelease>? gameCenterActivityVersionReleases = null,

            global::System.Action<global::AppStoreConnect.GameCenterAppVersion>? gameCenterAppVersions2 = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersionRelease>? gameCenterChallengeVersionReleases1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallengeVersionReleases2 = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardRelease>? gameCenterLeaderboardReleases1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetRelease>? gameCenterLeaderboardSetReleases1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSetReleases2 = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersions)
            {
                appStoreVersions?.Invoke(AppStoreVersions!);
            }
            else if (IsGameCenterAppVersions1)
            {
                gameCenterAppVersions1?.Invoke(GameCenterAppVersions1!);
            }
            else if (IsGameCenterAchievementReleases1)
            {
                gameCenterAchievementReleases1?.Invoke(GameCenterAchievementReleases1!);
            }
            else if (IsGameCenterAchievementReleases2)
            {
                gameCenterAchievementReleases2?.Invoke(GameCenterAchievementReleases2!);
            }
            else if (IsGameCenterActivities)
            {
                gameCenterActivities?.Invoke(GameCenterActivities!);
            }
            else if (IsGameCenterActivityVersionReleases)
            {
                gameCenterActivityVersionReleases?.Invoke(GameCenterActivityVersionReleases!);
            }
            else if (IsGameCenterAppVersions2)
            {
                gameCenterAppVersions2?.Invoke(GameCenterAppVersions2!);
            }
            else if (IsGameCenterChallengeVersionReleases1)
            {
                gameCenterChallengeVersionReleases1?.Invoke(GameCenterChallengeVersionReleases1!);
            }
            else if (IsGameCenterChallengeVersionReleases2)
            {
                gameCenterChallengeVersionReleases2?.Invoke(GameCenterChallengeVersionReleases2!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardReleases1)
            {
                gameCenterLeaderboardReleases1?.Invoke(GameCenterLeaderboardReleases1!);
            }
            else if (IsGameCenterLeaderboardSetReleases1)
            {
                gameCenterLeaderboardSetReleases1?.Invoke(GameCenterLeaderboardSetReleases1!);
            }
            else if (IsGameCenterLeaderboardSetReleases2)
            {
                gameCenterLeaderboardSetReleases2?.Invoke(GameCenterLeaderboardSetReleases2!);
            }
            else if (IsGameCenterLeaderboardReleases2)
            {
                gameCenterLeaderboardReleases2?.Invoke(GameCenterLeaderboardReleases2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            global::System.Action<global::AppStoreConnect.App>? gameCenterAppVersions1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievementRelease>? gameCenterAchievementReleases1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievementReleases2 = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityVersionRelease>? gameCenterActivityVersionReleases = null,
            global::System.Action<global::AppStoreConnect.GameCenterAppVersion>? gameCenterAppVersions2 = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersionRelease>? gameCenterChallengeVersionReleases1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallengeVersionReleases2 = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardRelease>? gameCenterLeaderboardReleases1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetRelease>? gameCenterLeaderboardSetReleases1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSetReleases2 = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardReleases2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppStoreVersions)
            {
                appStoreVersions?.Invoke(AppStoreVersions!);
            }
            else if (IsGameCenterAppVersions1)
            {
                gameCenterAppVersions1?.Invoke(GameCenterAppVersions1!);
            }
            else if (IsGameCenterAchievementReleases1)
            {
                gameCenterAchievementReleases1?.Invoke(GameCenterAchievementReleases1!);
            }
            else if (IsGameCenterAchievementReleases2)
            {
                gameCenterAchievementReleases2?.Invoke(GameCenterAchievementReleases2!);
            }
            else if (IsGameCenterActivities)
            {
                gameCenterActivities?.Invoke(GameCenterActivities!);
            }
            else if (IsGameCenterActivityVersionReleases)
            {
                gameCenterActivityVersionReleases?.Invoke(GameCenterActivityVersionReleases!);
            }
            else if (IsGameCenterAppVersions2)
            {
                gameCenterAppVersions2?.Invoke(GameCenterAppVersions2!);
            }
            else if (IsGameCenterChallengeVersionReleases1)
            {
                gameCenterChallengeVersionReleases1?.Invoke(GameCenterChallengeVersionReleases1!);
            }
            else if (IsGameCenterChallengeVersionReleases2)
            {
                gameCenterChallengeVersionReleases2?.Invoke(GameCenterChallengeVersionReleases2!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardReleases1)
            {
                gameCenterLeaderboardReleases1?.Invoke(GameCenterLeaderboardReleases1!);
            }
            else if (IsGameCenterLeaderboardSetReleases1)
            {
                gameCenterLeaderboardSetReleases1?.Invoke(GameCenterLeaderboardSetReleases1!);
            }
            else if (IsGameCenterLeaderboardSetReleases2)
            {
                gameCenterLeaderboardSetReleases2?.Invoke(GameCenterLeaderboardSetReleases2!);
            }
            else if (IsGameCenterLeaderboardReleases2)
            {
                gameCenterLeaderboardReleases2?.Invoke(GameCenterLeaderboardReleases2!);
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
                GameCenterAppVersions1,
                typeof(global::AppStoreConnect.App),
                GameCenterAchievementReleases1,
                typeof(global::AppStoreConnect.GameCenterAchievementRelease),
                GameCenterAchievementReleases2,
                typeof(global::AppStoreConnect.GameCenterAchievement),
                GameCenterActivities,
                typeof(global::AppStoreConnect.GameCenterActivity),
                GameCenterActivityVersionReleases,
                typeof(global::AppStoreConnect.GameCenterActivityVersionRelease),
                GameCenterAppVersions2,
                typeof(global::AppStoreConnect.GameCenterAppVersion),
                GameCenterChallengeVersionReleases1,
                typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease),
                GameCenterChallengeVersionReleases2,
                typeof(global::AppStoreConnect.GameCenterChallenge),
                GameCenterGroups,
                typeof(global::AppStoreConnect.GameCenterGroup),
                GameCenterLeaderboardReleases1,
                typeof(global::AppStoreConnect.GameCenterLeaderboardRelease),
                GameCenterLeaderboardSetReleases1,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetRelease),
                GameCenterLeaderboardSetReleases2,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSet),
                GameCenterLeaderboardReleases2,
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
        public bool Equals(IncludedItem101 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(GameCenterAppVersions1, other.GameCenterAppVersions1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementRelease?>.Default.Equals(GameCenterAchievementReleases1, other.GameCenterAchievementReleases1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievementReleases2, other.GameCenterAchievementReleases2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityVersionRelease?>.Default.Equals(GameCenterActivityVersionReleases, other.GameCenterActivityVersionReleases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAppVersion?>.Default.Equals(GameCenterAppVersions2, other.GameCenterAppVersions2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeVersionRelease?>.Default.Equals(GameCenterChallengeVersionReleases1, other.GameCenterChallengeVersionReleases1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallenge?>.Default.Equals(GameCenterChallengeVersionReleases2, other.GameCenterChallengeVersionReleases2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardRelease?>.Default.Equals(GameCenterLeaderboardReleases1, other.GameCenterLeaderboardReleases1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetRelease?>.Default.Equals(GameCenterLeaderboardSetReleases1, other.GameCenterLeaderboardSetReleases1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSetReleases2, other.GameCenterLeaderboardSetReleases2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboardReleases2, other.GameCenterLeaderboardReleases2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem101 obj1, IncludedItem101 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem101>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem101 obj1, IncludedItem101 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem101 o && Equals(o);
        }
    }
}
