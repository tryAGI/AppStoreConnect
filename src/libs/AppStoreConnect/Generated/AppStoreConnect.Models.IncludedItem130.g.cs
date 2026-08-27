#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem130 : global::System.IEquatable<IncludedItem130>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterLeaderboardSetV2? GameCenterLeaderboardSets { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetV2? GameCenterLeaderboardSets { get; }
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
            out global::AppStoreConnect.GameCenterLeaderboardSetV2? value)
        {
            value = GameCenterLeaderboardSets;
            return IsGameCenterLeaderboardSets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetV2 PickGameCenterLeaderboardSets() => IsGameCenterLeaderboardSets
            ? GameCenterLeaderboardSets!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem130(global::AppStoreConnect.GameCenterActivity value) => new IncludedItem130((global::AppStoreConnect.GameCenterActivity?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivity?(IncludedItem130 @this) => @this.GameCenterActivities;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem130(global::AppStoreConnect.GameCenterActivity? value)
        {
            GameCenterActivities = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem130 FromGameCenterActivities(global::AppStoreConnect.GameCenterActivity? value) => new IncludedItem130(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem130(global::AppStoreConnect.GameCenterChallenge value) => new IncludedItem130((global::AppStoreConnect.GameCenterChallenge?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallenge?(IncludedItem130 @this) => @this.GameCenterChallenges;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem130(global::AppStoreConnect.GameCenterChallenge? value)
        {
            GameCenterChallenges = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem130 FromGameCenterChallenges(global::AppStoreConnect.GameCenterChallenge? value) => new IncludedItem130(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem130(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem130((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem130 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem130(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem130 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem130(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem130(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem130((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem130 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem130(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem130 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem130(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem130(global::AppStoreConnect.GameCenterLeaderboardSetV2 value) => new IncludedItem130((global::AppStoreConnect.GameCenterLeaderboardSetV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetV2?(IncludedItem130 @this) => @this.GameCenterLeaderboardSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem130(global::AppStoreConnect.GameCenterLeaderboardSetV2? value)
        {
            GameCenterLeaderboardSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem130 FromGameCenterLeaderboardSets(global::AppStoreConnect.GameCenterLeaderboardSetV2? value) => new IncludedItem130(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem130(global::AppStoreConnect.GameCenterLeaderboardVersionV2 value) => new IncludedItem130((global::AppStoreConnect.GameCenterLeaderboardVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardVersionV2?(IncludedItem130 @this) => @this.GameCenterLeaderboardVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem130(global::AppStoreConnect.GameCenterLeaderboardVersionV2? value)
        {
            GameCenterLeaderboardVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem130 FromGameCenterLeaderboardVersions(global::AppStoreConnect.GameCenterLeaderboardVersionV2? value) => new IncludedItem130(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem130(
            global::AppStoreConnect.GameCenterLeaderboardsV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities,
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallenges,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups,
            global::AppStoreConnect.GameCenterLeaderboardSetV2? gameCenterLeaderboardSets,
            global::AppStoreConnect.GameCenterLeaderboardVersionV2? gameCenterLeaderboardVersions
            )
        {
            Type = type;

            GameCenterActivities = gameCenterActivities;
            GameCenterChallenges = gameCenterChallenges;
            GameCenterDetails = gameCenterDetails;
            GameCenterGroups = gameCenterGroups;
            GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            GameCenterLeaderboardVersions = gameCenterLeaderboardVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardVersions as object ??
            GameCenterLeaderboardSets as object ??
            GameCenterGroups as object ??
            GameCenterDetails as object ??
            GameCenterChallenges as object ??
            GameCenterActivities as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterActivities?.ToString() ??
            GameCenterChallenges?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString() ??
            GameCenterLeaderboardSets?.ToString() ??
            GameCenterLeaderboardVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardVersions || !IsGameCenterActivities && IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardVersions || !IsGameCenterActivities && !IsGameCenterChallenges && IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardVersions || !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && IsGameCenterGroups && !IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardVersions || !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && IsGameCenterLeaderboardSets && !IsGameCenterLeaderboardVersions || !IsGameCenterActivities && !IsGameCenterChallenges && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSets && IsGameCenterLeaderboardVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterActivity, TResult>? gameCenterActivities = null,
            global::System.Func<global::AppStoreConnect.GameCenterChallenge, TResult>? gameCenterChallenges = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetV2, TResult>? gameCenterLeaderboardSets = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardVersionV2, TResult>? gameCenterLeaderboardVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivities && gameCenterActivities != null)
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
            else if (IsGameCenterGroups && gameCenterGroups != null)
            {
                return gameCenterGroups(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardSets && gameCenterLeaderboardSets != null)
            {
                return gameCenterLeaderboardSets(GameCenterLeaderboardSets!);
            }
            else if (IsGameCenterLeaderboardVersions && gameCenterLeaderboardVersions != null)
            {
                return gameCenterLeaderboardVersions(GameCenterLeaderboardVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,

            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetV2>? gameCenterLeaderboardSets = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardVersionV2>? gameCenterLeaderboardVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivities)
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
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardSets)
            {
                gameCenterLeaderboardSets?.Invoke(GameCenterLeaderboardSets!);
            }
            else if (IsGameCenterLeaderboardVersions)
            {
                gameCenterLeaderboardVersions?.Invoke(GameCenterLeaderboardVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterActivity>? gameCenterActivities = null,
            global::System.Action<global::AppStoreConnect.GameCenterChallenge>? gameCenterChallenges = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetV2>? gameCenterLeaderboardSets = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardVersionV2>? gameCenterLeaderboardVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivities)
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
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardSets)
            {
                gameCenterLeaderboardSets?.Invoke(GameCenterLeaderboardSets!);
            }
            else if (IsGameCenterLeaderboardVersions)
            {
                gameCenterLeaderboardVersions?.Invoke(GameCenterLeaderboardVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterActivities,
                typeof(global::AppStoreConnect.GameCenterActivity),
                GameCenterChallenges,
                typeof(global::AppStoreConnect.GameCenterChallenge),
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
                GameCenterGroups,
                typeof(global::AppStoreConnect.GameCenterGroup),
                GameCenterLeaderboardSets,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetV2),
                GameCenterLeaderboardVersions,
                typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2),
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
        public bool Equals(IncludedItem130 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivity?>.Default.Equals(GameCenterActivities, other.GameCenterActivities) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallenge?>.Default.Equals(GameCenterChallenges, other.GameCenterChallenges) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetV2?>.Default.Equals(GameCenterLeaderboardSets, other.GameCenterLeaderboardSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardVersionV2?>.Default.Equals(GameCenterLeaderboardVersions, other.GameCenterLeaderboardVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem130 obj1, IncludedItem130 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem130>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem130 obj1, IncludedItem130 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem130 o && Equals(o);
        }
    }
}
