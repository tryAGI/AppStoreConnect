#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem87 : global::System.IEquatable<IncludedItem87>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboards() => IsGameCenterLeaderboards
            ? GameCenterLeaderboards!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboards' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem87((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem87 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterActivityVersion value) => new IncludedItem87((global::AppStoreConnect.GameCenterActivityVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersion?(IncludedItem87 @this) => @this.GameCenterActivityVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterActivityVersion? value)
        {
            GameCenterActivityVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterActivityVersions(global::AppStoreConnect.GameCenterActivityVersion? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem87((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem87 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem87((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem87 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem87(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem87((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem87 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem87 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem87(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem87(
            global::AppStoreConnect.GameCenterActivitiesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievements,
            global::AppStoreConnect.GameCenterActivityVersion? gameCenterActivityVersions,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards
            )
        {
            Type = type;

            GameCenterAchievements = gameCenterAchievements;
            GameCenterActivityVersions = gameCenterActivityVersions;
            GameCenterDetails = gameCenterDetails;
            GameCenterGroups = gameCenterGroups;
            GameCenterLeaderboards = gameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboards as object ??
            GameCenterGroups as object ??
            GameCenterDetails as object ??
            GameCenterActivityVersions as object ??
            GameCenterAchievements as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievements?.ToString() ??
            GameCenterActivityVersions?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString() ??
            GameCenterLeaderboards?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievements && !IsGameCenterActivityVersions && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboards || !IsGameCenterAchievements && IsGameCenterActivityVersions && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboards || !IsGameCenterAchievements && !IsGameCenterActivityVersions && IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboards || !IsGameCenterAchievements && !IsGameCenterActivityVersions && !IsGameCenterDetails && IsGameCenterGroups && !IsGameCenterLeaderboards || !IsGameCenterAchievements && !IsGameCenterActivityVersions && !IsGameCenterDetails && !IsGameCenterGroups && IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievements = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityVersion, TResult>? gameCenterActivityVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboards = null,
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
            else if (IsGameCenterActivityVersions && gameCenterActivityVersions != null)
            {
                return gameCenterActivityVersions(GameCenterActivityVersions!);
            }
            else if (IsGameCenterDetails && gameCenterDetails != null)
            {
                return gameCenterDetails(GameCenterDetails!);
            }
            else if (IsGameCenterGroups && gameCenterGroups != null)
            {
                return gameCenterGroups(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboards && gameCenterLeaderboards != null)
            {
                return gameCenterLeaderboards(GameCenterLeaderboards!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityVersion>? gameCenterActivityVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
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
            else if (IsGameCenterActivityVersions)
            {
                gameCenterActivityVersions?.Invoke(GameCenterActivityVersions!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboards)
            {
                gameCenterLeaderboards?.Invoke(GameCenterLeaderboards!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityVersion>? gameCenterActivityVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
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
            else if (IsGameCenterActivityVersions)
            {
                gameCenterActivityVersions?.Invoke(GameCenterActivityVersions!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboards)
            {
                gameCenterLeaderboards?.Invoke(GameCenterLeaderboards!);
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
                GameCenterActivityVersions,
                typeof(global::AppStoreConnect.GameCenterActivityVersion),
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
                GameCenterGroups,
                typeof(global::AppStoreConnect.GameCenterGroup),
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
        public bool Equals(IncludedItem87 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityVersion?>.Default.Equals(GameCenterActivityVersions, other.GameCenterActivityVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem87 obj1, IncludedItem87 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem87>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem87 obj1, IncludedItem87 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem87 o && Equals(o);
        }
    }
}
