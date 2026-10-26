#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem106 : global::System.IEquatable<IncludedItem106>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterDetail? GameCenterDetails { get; init; }
#else
        public global::AppStoreConnect.GameCenterDetail? GameCenterDetails { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterDetails))]
#endif
        public bool IsGameCenterDetails => GameCenterDetails != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterDetails(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterDetail? value)
        {
            value = GameCenterDetails;
            return IsGameCenterDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterDetail PickGameCenterDetails() => GameCenterDetails is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterDetails' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem106(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem106((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem106 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem106(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem106 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem106(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem106(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem106((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem106 @this) => @this.GameCenterActivities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem106(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem106 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem106(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem106(global::AppStoreConnect.GameCenterChallenge value) => new IncludedItem106((global::AppStoreConnect.GameCenterChallenge?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallenge?(IncludedItem106 @this) => @this.GameCenterChallenges;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem106(global::AppStoreConnect.GameCenterChallenge? value)
        {
            GameCenterChallenges = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem106 FromGameCenterChallenges(global::AppStoreConnect.GameCenterChallenge? value) => new IncludedItem106(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem106(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem106((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem106 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem106(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem106 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem106(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem106(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem106((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem106 @this) => @this.GameCenterLeaderboardSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem106(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem106 FromGameCenterLeaderboardSets(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem106(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem106(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem106((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem106 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem106(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem106 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem106(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem106(
            global::AppStoreConnect.GameCenterGroupsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievements,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallenges,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards
            )
        {
            Type = type;

            GameCenterAchievements = gameCenterAchievements;
            GameCenterActivities = gameCenterActivities;
            GameCenterChallenges = gameCenterChallenges;
            GameCenterDetails = gameCenterDetails;
            GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            GameCenterLeaderboards = gameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboards as object ??
            GameCenterLeaderboardSets as object ??
            GameCenterDetails as object ??
            GameCenterChallenges as object ??
            GameCenterActivities as object ??
            GameCenterAchievements as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievements?.ToString() ??
            GameCenterActivities?.ToString() ??
            GameCenterChallenges?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterLeaderboardSets?.ToString() ??
            GameCenterLeaderboards?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsGameCenterAchievements && IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsGameCenterAchievements && !IsGameCenterActivities && IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterChallenges && IsGameCenterDetails && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterLeaderboardSets && IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievements = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallenge, TResult>? gameCenterChallenges = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSets = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterAchievements is { } __value0 && gameCenterAchievements != null)
            {
                return gameCenterAchievements(__value0);
            }
            else if (GameCenterActivities is { } __value1 && gameCenterActivities != null)
            {
                return gameCenterActivities(__value1);
            }
            else if (GameCenterChallenges is { } __value2 && gameCenterChallenges != null)
            {
                return gameCenterChallenges(__value2);
            }
            else if (GameCenterDetails is { } __value3 && gameCenterDetails != null)
            {
                return gameCenterDetails(__value3);
            }
            else if (GameCenterLeaderboardSets is { } __value4 && gameCenterLeaderboardSets != null)
            {
                return gameCenterLeaderboardSets(__value4);
            }
            else if (GameCenterLeaderboards is { } __value5 && gameCenterLeaderboards != null)
            {
                return gameCenterLeaderboards(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterAchievements is { } __value0)
            {
                gameCenterAchievements?.Invoke(__value0);
            }
            else if (GameCenterActivities is { } __value1)
            {
                gameCenterActivities?.Invoke(__value1);
            }
            else if (GameCenterChallenges is { } __value2)
            {
                gameCenterChallenges?.Invoke(__value2);
            }
            else if (GameCenterDetails is { } __value3)
            {
                gameCenterDetails?.Invoke(__value3);
            }
            else if (GameCenterLeaderboardSets is { } __value4)
            {
                gameCenterLeaderboardSets?.Invoke(__value4);
            }
            else if (GameCenterLeaderboards is { } __value5)
            {
                gameCenterLeaderboards?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterAchievements is { } __value0)
            {
                gameCenterAchievements?.Invoke(__value0);
            }
            else if (GameCenterActivities is { } __value1)
            {
                gameCenterActivities?.Invoke(__value1);
            }
            else if (GameCenterChallenges is { } __value2)
            {
                gameCenterChallenges?.Invoke(__value2);
            }
            else if (GameCenterDetails is { } __value3)
            {
                gameCenterDetails?.Invoke(__value3);
            }
            else if (GameCenterLeaderboardSets is { } __value4)
            {
                gameCenterLeaderboardSets?.Invoke(__value4);
            }
            else if (GameCenterLeaderboards is { } __value5)
            {
                gameCenterLeaderboards?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterAchievements,
                typeof(global::AppStoreConnect.GameCenterAchievement),
                GameCenterActivities,
                typeof(global::AppStoreConnect.GameCenterActivity),
                GameCenterChallenges,
                typeof(global::AppStoreConnect.GameCenterChallenge),
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
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
        public bool Equals(IncludedItem106 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallenge?>.Default.Equals(GameCenterChallenges, other.GameCenterChallenges) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSets, other.GameCenterLeaderboardSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem106 obj1, IncludedItem106 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem106>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem106 obj1, IncludedItem106 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem106 o && Equals(o);
        }
    }
}
