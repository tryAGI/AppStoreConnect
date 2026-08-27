#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem117 : global::System.IEquatable<IncludedItem117>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationResponseIncludedItemDiscriminatorType? Type { get; }

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
        public static implicit operator IncludedItem117(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem117((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem117 @this) => @this.GameCenterLeaderboardSets1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem117(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSets1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem117 FromGameCenterLeaderboardSets1(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem117(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem117(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem117((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem117 @this) => @this.GameCenterLeaderboardSets2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem117(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboardSets2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem117 FromGameCenterLeaderboardSets2(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem117(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem117(
            global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets1,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboardSets2
            )
        {
            Type = type;

            GameCenterLeaderboardSets1 = gameCenterLeaderboardSets1;
            GameCenterLeaderboardSets2 = gameCenterLeaderboardSets2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardSets2 as object ??
            GameCenterLeaderboardSets1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardSets1?.ToString() ??
            GameCenterLeaderboardSets2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardSets1 && !IsGameCenterLeaderboardSets2 || !IsGameCenterLeaderboardSets1 && IsGameCenterLeaderboardSets2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSets1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboardSets2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSets1 && gameCenterLeaderboardSets1 != null)
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
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardSets2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSets1)
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
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardSets2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSets1)
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
        public bool Equals(IncludedItem117 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSets1, other.GameCenterLeaderboardSets1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboardSets2, other.GameCenterLeaderboardSets2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem117 obj1, IncludedItem117 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem117>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem117 obj1, IncludedItem117 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem117 o && Equals(o);
        }
    }
}
