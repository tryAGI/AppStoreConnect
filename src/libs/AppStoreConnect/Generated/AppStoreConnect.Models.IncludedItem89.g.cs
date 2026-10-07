#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem89 : global::System.IEquatable<IncludedItem89>
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
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievements() => GameCenterAchievements is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterActivityVersion PickGameCenterActivityVersions() => GameCenterActivityVersions is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterDetail PickGameCenterDetails() => GameCenterDetails is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterGroup PickGameCenterGroups() => GameCenterGroups is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboards() => GameCenterLeaderboards is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboards' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem89(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem89((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem89 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem89(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem89 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem89(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem89(global::AppStoreConnect.GameCenterActivityVersion value) => new IncludedItem89((global::AppStoreConnect.GameCenterActivityVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersion?(IncludedItem89 @this) => @this.GameCenterActivityVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem89(global::AppStoreConnect.GameCenterActivityVersion? value)
        {
            GameCenterActivityVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem89 FromGameCenterActivityVersions(global::AppStoreConnect.GameCenterActivityVersion? value) => new IncludedItem89(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem89(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem89((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem89 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem89(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem89 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem89(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem89(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem89((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem89 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem89(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem89 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem89(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem89(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem89((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem89 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem89(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem89 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem89(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem89(
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

            if (GameCenterAchievements is { } __value0 && gameCenterAchievements != null)
            {
                return gameCenterAchievements(__value0);
            }
            else if (GameCenterActivityVersions is { } __value1 && gameCenterActivityVersions != null)
            {
                return gameCenterActivityVersions(__value1);
            }
            else if (GameCenterDetails is { } __value2 && gameCenterDetails != null)
            {
                return gameCenterDetails(__value2);
            }
            else if (GameCenterGroups is { } __value3 && gameCenterGroups != null)
            {
                return gameCenterGroups(__value3);
            }
            else if (GameCenterLeaderboards is { } __value4 && gameCenterLeaderboards != null)
            {
                return gameCenterLeaderboards(__value4);
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

            if (GameCenterAchievements is { } __value0)
            {
                gameCenterAchievements?.Invoke(__value0);
            }
            else if (GameCenterActivityVersions is { } __value1)
            {
                gameCenterActivityVersions?.Invoke(__value1);
            }
            else if (GameCenterDetails is { } __value2)
            {
                gameCenterDetails?.Invoke(__value2);
            }
            else if (GameCenterGroups is { } __value3)
            {
                gameCenterGroups?.Invoke(__value3);
            }
            else if (GameCenterLeaderboards is { } __value4)
            {
                gameCenterLeaderboards?.Invoke(__value4);
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

            if (GameCenterAchievements is { } __value0)
            {
                gameCenterAchievements?.Invoke(__value0);
            }
            else if (GameCenterActivityVersions is { } __value1)
            {
                gameCenterActivityVersions?.Invoke(__value1);
            }
            else if (GameCenterDetails is { } __value2)
            {
                gameCenterDetails?.Invoke(__value2);
            }
            else if (GameCenterGroups is { } __value3)
            {
                gameCenterGroups?.Invoke(__value3);
            }
            else if (GameCenterLeaderboards is { } __value4)
            {
                gameCenterLeaderboards?.Invoke(__value4);
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
        public bool Equals(IncludedItem89 other)
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
        public static bool operator ==(IncludedItem89 obj1, IncludedItem89 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem89>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem89 obj1, IncludedItem89 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem89 o && Equals(o);
        }
    }
}
