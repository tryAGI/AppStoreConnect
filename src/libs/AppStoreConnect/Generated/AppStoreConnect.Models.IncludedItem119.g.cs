#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem119 : global::System.IEquatable<IncludedItem119>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationResponseIncludedItemDiscriminatorType? Type { get; }

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
        public static implicit operator IncludedItem119(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem119((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem119 @this) => @this.GameCenterLeaderboardSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem119(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem119 FromGameCenterLeaderboardSets(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem119(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem119(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem119((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem119 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem119(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem119 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem119(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem119(
            global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards
            )
        {
            Type = type;

            GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            GameCenterLeaderboards = gameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboards as object ??
            GameCenterLeaderboardSets as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardSets?.ToString() ??
            GameCenterLeaderboards?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardSets && !IsGameCenterLeaderboards || !IsGameCenterLeaderboardSets && IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSets = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterLeaderboardSets is { } __value0 && gameCenterLeaderboardSets != null)
            {
                return gameCenterLeaderboardSets(__value0);
            }
            else if (GameCenterLeaderboards is { } __value1 && gameCenterLeaderboards != null)
            {
                return gameCenterLeaderboards(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterLeaderboardSets is { } __value0)
            {
                gameCenterLeaderboardSets?.Invoke(__value0);
            }
            else if (GameCenterLeaderboards is { } __value1)
            {
                gameCenterLeaderboards?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterLeaderboardSets is { } __value0)
            {
                gameCenterLeaderboardSets?.Invoke(__value0);
            }
            else if (GameCenterLeaderboards is { } __value1)
            {
                gameCenterLeaderboards?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
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
        public bool Equals(IncludedItem119 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSets, other.GameCenterLeaderboardSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem119 obj1, IncludedItem119 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem119>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem119 obj1, IncludedItem119 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem119 o && Equals(o);
        }
    }
}
