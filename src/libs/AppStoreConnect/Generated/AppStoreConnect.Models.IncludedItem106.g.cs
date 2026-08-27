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
        public global::AppStoreConnect.GameCenterLeaderboardLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardImage? GameCenterLeaderboardImages1 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardImage? GameCenterLeaderboardImages1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardImages1))]
#endif
        public bool IsGameCenterLeaderboardImages1 => GameCenterLeaderboardImages1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardImages1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardImage? value)
        {
            value = GameCenterLeaderboardImages1;
            return IsGameCenterLeaderboardImages1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardImage PickGameCenterLeaderboardImages1() => IsGameCenterLeaderboardImages1
            ? GameCenterLeaderboardImages1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardImages1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardImages2 { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboard? GameCenterLeaderboardImages2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardImages2))]
#endif
        public bool IsGameCenterLeaderboardImages2 => GameCenterLeaderboardImages2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterLeaderboardImages2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            value = GameCenterLeaderboardImages2;
            return IsGameCenterLeaderboardImages2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboard PickGameCenterLeaderboardImages2() => IsGameCenterLeaderboardImages2
            ? GameCenterLeaderboardImages2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardImages2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem106(global::AppStoreConnect.GameCenterLeaderboardImage value) => new IncludedItem106((global::AppStoreConnect.GameCenterLeaderboardImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardImage?(IncludedItem106 @this) => @this.GameCenterLeaderboardImages1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem106(global::AppStoreConnect.GameCenterLeaderboardImage? value)
        {
            GameCenterLeaderboardImages1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem106 FromGameCenterLeaderboardImages1(global::AppStoreConnect.GameCenterLeaderboardImage? value) => new IncludedItem106(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem106(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem106((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem106 @this) => @this.GameCenterLeaderboardImages2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem106(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboardImages2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem106 FromGameCenterLeaderboardImages2(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem106(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem106(
            global::AppStoreConnect.GameCenterLeaderboardLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardImage? gameCenterLeaderboardImages1,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboardImages2
            )
        {
            Type = type;

            GameCenterLeaderboardImages1 = gameCenterLeaderboardImages1;
            GameCenterLeaderboardImages2 = gameCenterLeaderboardImages2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardImages2 as object ??
            GameCenterLeaderboardImages1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardImages1?.ToString() ??
            GameCenterLeaderboardImages2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardImages1 && !IsGameCenterLeaderboardImages2 || !IsGameCenterLeaderboardImages1 && IsGameCenterLeaderboardImages2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardImage, TResult>? gameCenterLeaderboardImages1 = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboardImages2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardImages1 && gameCenterLeaderboardImages1 != null)
            {
                return gameCenterLeaderboardImages1(GameCenterLeaderboardImages1!);
            }
            else if (IsGameCenterLeaderboardImages2 && gameCenterLeaderboardImages2 != null)
            {
                return gameCenterLeaderboardImages2(GameCenterLeaderboardImages2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardImage>? gameCenterLeaderboardImages1 = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardImages2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardImages1)
            {
                gameCenterLeaderboardImages1?.Invoke(GameCenterLeaderboardImages1!);
            }
            else if (IsGameCenterLeaderboardImages2)
            {
                gameCenterLeaderboardImages2?.Invoke(GameCenterLeaderboardImages2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardImage>? gameCenterLeaderboardImages1 = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboardImages2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardImages1)
            {
                gameCenterLeaderboardImages1?.Invoke(GameCenterLeaderboardImages1!);
            }
            else if (IsGameCenterLeaderboardImages2)
            {
                gameCenterLeaderboardImages2?.Invoke(GameCenterLeaderboardImages2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterLeaderboardImages1,
                typeof(global::AppStoreConnect.GameCenterLeaderboardImage),
                GameCenterLeaderboardImages2,
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
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardImage?>.Default.Equals(GameCenterLeaderboardImages1, other.GameCenterLeaderboardImages1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboardImages2, other.GameCenterLeaderboardImages2) 
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
