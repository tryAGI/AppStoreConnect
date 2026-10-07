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
        public global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminatorType? Type { get; }

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
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterChallengeVersion value) => new IncludedItem101((global::AppStoreConnect.GameCenterChallengeVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterChallengeVersion?(IncludedItem101 @this) => @this.GameCenterChallengeVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterChallengeVersion? value)
        {
            GameCenterChallengeVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem101 FromGameCenterChallengeVersions(global::AppStoreConnect.GameCenterChallengeVersion? value) => new IncludedItem101(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem101((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem101 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem101 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem101(value);

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
        public static implicit operator IncludedItem101(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem101((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem101 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem101(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem101 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem101(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem101(
            global::AppStoreConnect.GameCenterChallengesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterChallengeVersion? gameCenterChallengeVersions,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards
            )
        {
            Type = type;

            GameCenterChallengeVersions = gameCenterChallengeVersions;
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
            GameCenterChallengeVersions as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterChallengeVersions?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString() ??
            GameCenterLeaderboards?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterChallengeVersions && !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboards || !IsGameCenterChallengeVersions && IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboards || !IsGameCenterChallengeVersions && !IsGameCenterDetails && IsGameCenterGroups && !IsGameCenterLeaderboards || !IsGameCenterChallengeVersions && !IsGameCenterDetails && !IsGameCenterGroups && IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterChallengeVersion, TResult>? gameCenterChallengeVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterChallengeVersions is { } __value0 && gameCenterChallengeVersions != null)
            {
                return gameCenterChallengeVersions(__value0);
            }
            else if (GameCenterDetails is { } __value1 && gameCenterDetails != null)
            {
                return gameCenterDetails(__value1);
            }
            else if (GameCenterGroups is { } __value2 && gameCenterGroups != null)
            {
                return gameCenterGroups(__value2);
            }
            else if (GameCenterLeaderboards is { } __value3 && gameCenterLeaderboards != null)
            {
                return gameCenterLeaderboards(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersion>? gameCenterChallengeVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterChallengeVersions is { } __value0)
            {
                gameCenterChallengeVersions?.Invoke(__value0);
            }
            else if (GameCenterDetails is { } __value1)
            {
                gameCenterDetails?.Invoke(__value1);
            }
            else if (GameCenterGroups is { } __value2)
            {
                gameCenterGroups?.Invoke(__value2);
            }
            else if (GameCenterLeaderboards is { } __value3)
            {
                gameCenterLeaderboards?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterChallengeVersion>? gameCenterChallengeVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterChallengeVersions is { } __value0)
            {
                gameCenterChallengeVersions?.Invoke(__value0);
            }
            else if (GameCenterDetails is { } __value1)
            {
                gameCenterDetails?.Invoke(__value1);
            }
            else if (GameCenterGroups is { } __value2)
            {
                gameCenterGroups?.Invoke(__value2);
            }
            else if (GameCenterLeaderboards is { } __value3)
            {
                gameCenterLeaderboards?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterChallengeVersions,
                typeof(global::AppStoreConnect.GameCenterChallengeVersion),
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
        public bool Equals(IncludedItem101 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterChallengeVersion?>.Default.Equals(GameCenterChallengeVersions, other.GameCenterChallengeVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards)
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
