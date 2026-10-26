#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem108 : global::System.IEquatable<IncludedItem108>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardImage? GameCenterLeaderboardImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardImage? GameCenterLeaderboardImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardImages))]
#endif
        public bool IsGameCenterLeaderboardImages => GameCenterLeaderboardImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardImage? value)
        {
            value = GameCenterLeaderboardImages;
            return IsGameCenterLeaderboardImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardImage PickGameCenterLeaderboardImages() => GameCenterLeaderboardImages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardImages' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem108(global::AppStoreConnect.GameCenterLeaderboardImage value) => new IncludedItem108((global::AppStoreConnect.GameCenterLeaderboardImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardImage?(IncludedItem108 @this) => @this.GameCenterLeaderboardImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem108(global::AppStoreConnect.GameCenterLeaderboardImage? value)
        {
            GameCenterLeaderboardImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem108 FromGameCenterLeaderboardImages(global::AppStoreConnect.GameCenterLeaderboardImage? value) => new IncludedItem108(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem108(global::AppStoreConnect.GameCenterLeaderboard value) => new IncludedItem108((global::AppStoreConnect.GameCenterLeaderboard?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboard?(IncludedItem108 @this) => @this.GameCenterLeaderboards;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem108(global::AppStoreConnect.GameCenterLeaderboard? value)
        {
            GameCenterLeaderboards = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem108 FromGameCenterLeaderboards(global::AppStoreConnect.GameCenterLeaderboard? value) => new IncludedItem108(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem108(
            global::AppStoreConnect.GameCenterLeaderboardLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardImage? gameCenterLeaderboardImages,
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards
            )
        {
            Type = type;

            GameCenterLeaderboardImages = gameCenterLeaderboardImages;
            GameCenterLeaderboards = gameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboards as object ??
            GameCenterLeaderboardImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardImages?.ToString() ??
            GameCenterLeaderboards?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardImages && !IsGameCenterLeaderboards || !IsGameCenterLeaderboardImages && IsGameCenterLeaderboards;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardImage, TResult>? gameCenterLeaderboardImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboard, TResult>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterLeaderboardImages is { } __value0 && gameCenterLeaderboardImages != null)
            {
                return gameCenterLeaderboardImages(__value0);
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
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardImage>? gameCenterLeaderboardImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterLeaderboardImages is { } __value0)
            {
                gameCenterLeaderboardImages?.Invoke(__value0);
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
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardImage>? gameCenterLeaderboardImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboard>? gameCenterLeaderboards = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (GameCenterLeaderboardImages is { } __value0)
            {
                gameCenterLeaderboardImages?.Invoke(__value0);
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
                GameCenterLeaderboardImages,
                typeof(global::AppStoreConnect.GameCenterLeaderboardImage),
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
        public bool Equals(IncludedItem108 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardImage?>.Default.Equals(GameCenterLeaderboardImages, other.GameCenterLeaderboardImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboard?>.Default.Equals(GameCenterLeaderboards, other.GameCenterLeaderboards)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem108 obj1, IncludedItem108 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem108>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem108 obj1, IncludedItem108 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem108 o && Equals(o);
        }
    }
}
