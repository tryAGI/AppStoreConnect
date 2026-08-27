#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem123 : global::System.IEquatable<IncludedItem123>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterLeaderboardV2? GameCenterLeaderboards { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardV2? GameCenterLeaderboards { get; }
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
            out global::AppStoreConnect.GameCenterLeaderboardV2? value)
        {
            value = GameCenterLeaderboards;
            return IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardV2 PickGameCenterLeaderboards() => IsGameCenterLeaderboards
            ? GameCenterLeaderboards!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboards' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem123(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem123((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem123 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem123(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem123 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem123(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem123(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem123((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem123 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem123(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem123 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem123(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem123(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 value) => new IncludedItem123((global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?(IncludedItem123 @this) => @this.GameCenterLeaderboardSetVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem123(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value)
        {
            GameCenterLeaderboardSetVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem123 FromGameCenterLeaderboardSetVersions(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value) => new IncludedItem123(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem123(global::AppStoreConnect.GameCenterLeaderboardV2 value) => new IncludedItem123((global::AppStoreConnect.GameCenterLeaderboardV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardV2?(IncludedItem123 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem123(global::AppStoreConnect.GameCenterLeaderboardV2? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem123 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboardV2? value) => new IncludedItem123(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem123(
            global::AppStoreConnect.GameCenterLeaderboardSetV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups,
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? gameCenterLeaderboardSetVersions,
            global::AppStoreConnect.GameCenterLeaderboardV2? gameCenterLeaderboards
            )
        {
            Type = type;

            GameCenterDetails = gameCenterDetails;
            GameCenterGroups = gameCenterGroups;
            GameCenterLeaderboardSetVersions = gameCenterLeaderboardSetVersions;
            GameCenterLeaderboards = gameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboards as object ??
            GameCenterLeaderboardSetVersions as object ??
            GameCenterGroups as object ??
            GameCenterDetails as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterDetails?.ToString() ??
            GameCenterGroups?.ToString() ??
            GameCenterLeaderboardSetVersions?.ToString() ??
            GameCenterLeaderboards?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboards || !IsGameCenterDetails && IsGameCenterGroups && !IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboards || !IsGameCenterDetails && !IsGameCenterGroups && IsGameCenterLeaderboardSetVersions && !IsGameCenterLeaderboards || !IsGameCenterDetails && !IsGameCenterGroups && !IsGameCenterLeaderboardSetVersions && IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterGroup, TResult>? gameCenterGroups = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2, TResult>? gameCenterLeaderboardSetVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardV2, TResult>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterDetails && gameCenterDetails != null)
            {
                return gameCenterDetails(GameCenterDetails!);
            }
            else if (IsGameCenterGroups && gameCenterGroups != null)
            {
                return gameCenterGroups(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardSetVersions && gameCenterLeaderboardSetVersions != null)
            {
                return gameCenterLeaderboardSetVersions(GameCenterLeaderboardSetVersions!);
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
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2>? gameCenterLeaderboardSetVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardV2>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardSetVersions)
            {
                gameCenterLeaderboardSetVersions?.Invoke(GameCenterLeaderboardSetVersions!);
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
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterGroup>? gameCenterGroups = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2>? gameCenterLeaderboardSetVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardV2>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterGroups)
            {
                gameCenterGroups?.Invoke(GameCenterGroups!);
            }
            else if (IsGameCenterLeaderboardSetVersions)
            {
                gameCenterLeaderboardSetVersions?.Invoke(GameCenterLeaderboardSetVersions!);
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
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
                GameCenterGroups,
                typeof(global::AppStoreConnect.GameCenterGroup),
                GameCenterLeaderboardSetVersions,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2),
                GameCenterLeaderboards,
                typeof(global::AppStoreConnect.GameCenterLeaderboardV2),
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
        public bool Equals(IncludedItem123 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterGroup?>.Default.Equals(GameCenterGroups, other.GameCenterGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?>.Default.Equals(GameCenterLeaderboardSetVersions, other.GameCenterLeaderboardSetVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardV2?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem123 obj1, IncludedItem123 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem123>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem123 obj1, IncludedItem123 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem123 o && Equals(o);
        }
    }
}
