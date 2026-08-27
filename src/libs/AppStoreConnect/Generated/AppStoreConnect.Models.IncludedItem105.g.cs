#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem105 : global::System.IEquatable<IncludedItem105>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievements() => IsGameCenterAchievements
            ? GameCenterAchievements!
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
        public global::AppStoreConnect.GameCenterActivity PickGameCenterActivities() => IsGameCenterActivities
            ? GameCenterActivities!
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
        public global::AppStoreConnect.GameCenterChallenge PickGameCenterChallenges() => IsGameCenterChallenges
            ? GameCenterChallenges!
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
        public global::AppStoreConnect.GameCenterDetail PickGameCenterDetails() => IsGameCenterDetails
            ? GameCenterDetails!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterDetails' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSets1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSet? GameCenterLeaderboardSets1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSets1))]
#endif
        public bool IsGameCenterLeaderboardSets1 => GameCenterLeaderboardSets1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSets1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            value = GameCenterLeaderboardSets1;
            return IsGameCenterLeaderboardSets1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSet PickGameCenterLeaderboardSets1() => IsGameCenterLeaderboardSets1
            ? GameCenterLeaderboardSets1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardSets2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardSets2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSets2))]
#endif
        public bool IsGameCenterLeaderboardSets2 => GameCenterLeaderboardSets2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSets2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            value = GameCenterLeaderboardSets2;
            return IsGameCenterLeaderboardSets2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboardSets2() => IsGameCenterLeaderboardSets2
            ? GameCenterLeaderboardSets2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem105(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem105((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem105 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem105(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem105 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem105(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem105(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem105((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem105 @this) => @this.GameCenterActivities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem105(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem105 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem105(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem105(global::AppStoreConnect.GameCenterChallenge value) => new IncludedItem105((global::AppStoreConnect.GameCenterChallenge?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallenge?(IncludedItem105 @this) => @this.GameCenterChallenges;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem105(global::AppStoreConnect.GameCenterChallenge? value)
        {
            GameCenterChallenges = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem105 FromGameCenterChallenges(global::AppStoreConnect.GameCenterChallenge? value) => new IncludedItem105(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem105(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem105((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem105 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem105(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem105 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem105(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem105(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem105((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem105 @this) => @this.GameCenterLeaderboardSets1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem105(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSets1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem105 FromGameCenterLeaderboardSets1(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem105(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem105(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem105((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem105 @this) => @this.GameCenterLeaderboardSets2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem105(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboardSets2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem105 FromGameCenterLeaderboardSets2(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem105(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem105(
            global::AppStoreConnect.GameCenterGroupResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievements,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallenges,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets1,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboardSets2
            )
        {
            Type = type;

            GameCenterAchievements = gameCenterAchievements;
            GameCenterActivities = gameCenterActivities;
            GameCenterChallenges = gameCenterChallenges;
            GameCenterDetails = gameCenterDetails;
            GameCenterLeaderboardSets1 = gameCenterLeaderboardSets1;
            GameCenterLeaderboardSets2 = gameCenterLeaderboardSets2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardSets2 as object ??
            GameCenterLeaderboardSets1 as object ??
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
            GameCenterLeaderboardSets1?.ToString() ??
            GameCenterLeaderboardSets2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterAchievements && IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterAchievements && !IsGameCenterActivities && IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterChallenges && IsGameCenterDetails && !IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterAchievements && !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterLeaderboardSets1 && IsGameCenterLeaderboardSets2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievements = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallenge, TResult>? gameCenterChallenges = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSets1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboardSets2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievements && gameCenterAchievements != null)
            {
                return gameCenterAchievements(GameCenterAchievements!);
            }
            else if (IsGameCenterActivities && gameCenterActivities != null)
            {
                return gameCenterActivities(GameCenterActivities!);
            }
            else if (IsGameCenterChallenges && gameCenterChallenges != null)
            {
                return gameCenterChallenges(GameCenterChallenges!);
            }
            else if (IsGameCenterDetails && gameCenterDetails != null)
            {
                return gameCenterDetails(GameCenterDetails!);
            }
            else if (IsGameCenterLeaderboardSets1 && gameCenterLeaderboardSets1 != null)
            {
                return gameCenterLeaderboardSets1(GameCenterLeaderboardSets1!);
            }
            else if (IsGameCenterLeaderboardSets2 && gameCenterLeaderboardSets2 != null)
            {
                return gameCenterLeaderboardSets2(GameCenterLeaderboardSets2!);
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

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardSets2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievements)
            {
                gameCenterAchievements?.Invoke(GameCenterAchievements!);
            }
            else if (IsGameCenterActivities)
            {
                gameCenterActivities?.Invoke(GameCenterActivities!);
            }
            else if (IsGameCenterChallenges)
            {
                gameCenterChallenges?.Invoke(GameCenterChallenges!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterLeaderboardSets1)
            {
                gameCenterLeaderboardSets1?.Invoke(GameCenterLeaderboardSets1!);
            }
            else if (IsGameCenterLeaderboardSets2)
            {
                gameCenterLeaderboardSets2?.Invoke(GameCenterLeaderboardSets2!);
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
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardSets2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievements)
            {
                gameCenterAchievements?.Invoke(GameCenterAchievements!);
            }
            else if (IsGameCenterActivities)
            {
                gameCenterActivities?.Invoke(GameCenterActivities!);
            }
            else if (IsGameCenterChallenges)
            {
                gameCenterChallenges?.Invoke(GameCenterChallenges!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterLeaderboardSets1)
            {
                gameCenterLeaderboardSets1?.Invoke(GameCenterLeaderboardSets1!);
            }
            else if (IsGameCenterLeaderboardSets2)
            {
                gameCenterLeaderboardSets2?.Invoke(GameCenterLeaderboardSets2!);
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
                GameCenterLeaderboardSets1,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSet),
                GameCenterLeaderboardSets2,
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
        public bool Equals(IncludedItem105 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallenge?>.Default.Equals(GameCenterChallenges, other.GameCenterChallenges) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSets1, other.GameCenterLeaderboardSets1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboardSets2, other.GameCenterLeaderboardSets2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem105 obj1, IncludedItem105 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem105>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem105 obj1, IncludedItem105 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem105 o && Equals(o);
        }
    }
}
