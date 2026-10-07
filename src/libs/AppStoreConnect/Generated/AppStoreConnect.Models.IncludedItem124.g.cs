#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem124 : global::System.IEquatable<IncludedItem124>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 PickGameCenterLeaderboardSetVersions() => GameCenterLeaderboardSetVersions is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterLeaderboardV2 PickGameCenterLeaderboards() => GameCenterLeaderboards is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboards' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem124(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem124((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem124 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem124(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem124 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem124(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem124(global::AppStoreConnect.GameCenterGroup value) => new IncludedItem124((global::AppStoreConnect.GameCenterGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterGroup?(IncludedItem124 @this) => @this.GameCenterGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem124(global::AppStoreConnect.GameCenterGroup? value)
        {
            GameCenterGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem124 FromGameCenterGroups(global::AppStoreConnect.GameCenterGroup? value) => new IncludedItem124(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem124(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 value) => new IncludedItem124((global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?(IncludedItem124 @this) => @this.GameCenterLeaderboardSetVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem124(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value)
        {
            GameCenterLeaderboardSetVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem124 FromGameCenterLeaderboardSetVersions(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value) => new IncludedItem124(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem124(global::AppStoreConnect.GameCenterLeaderboardV2 value) => new IncludedItem124((global::AppStoreConnect.GameCenterLeaderboardV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardV2?(IncludedItem124 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem124(global::AppStoreConnect.GameCenterLeaderboardV2? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem124 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboardV2? value) => new IncludedItem124(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem124(
            global::AppStoreConnect.GameCenterLeaderboardSetsV2ResponseIncludedItemDiscriminatorType? type,
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

            if (GameCenterDetails is { } __value0 && gameCenterDetails != null)
            {
                return gameCenterDetails(__value0);
            }
            else if (GameCenterGroups is { } __value1 && gameCenterGroups != null)
            {
                return gameCenterGroups(__value1);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value2 && gameCenterLeaderboardSetVersions != null)
            {
                return gameCenterLeaderboardSetVersions(__value2);
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

            if (GameCenterDetails is { } __value0)
            {
                gameCenterDetails?.Invoke(__value0);
            }
            else if (GameCenterGroups is { } __value1)
            {
                gameCenterGroups?.Invoke(__value1);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value2)
            {
                gameCenterLeaderboardSetVersions?.Invoke(__value2);
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

            if (GameCenterDetails is { } __value0)
            {
                gameCenterDetails?.Invoke(__value0);
            }
            else if (GameCenterGroups is { } __value1)
            {
                gameCenterGroups?.Invoke(__value1);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value2)
            {
                gameCenterLeaderboardSetVersions?.Invoke(__value2);
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
        public bool Equals(IncludedItem124 other)
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
        public static bool operator ==(IncludedItem124 obj1, IncludedItem124 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem124>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem124 obj1, IncludedItem124 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem124 o && Equals(o);
        }
    }
}
