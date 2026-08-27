#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem109 : global::System.IEquatable<IncludedItem109>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardImageV2? GameCenterLeaderboardImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardImageV2? GameCenterLeaderboardImages { get; }
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
            out global::AppStoreConnect.GameCenterLeaderboardImageV2? value)
        {
            value = GameCenterLeaderboardImages;
            return IsGameCenterLeaderboardImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardImageV2 PickGameCenterLeaderboardImages() => IsGameCenterLeaderboardImages
            ? GameCenterLeaderboardImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardImages' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem109(global::AppStoreConnect.GameCenterLeaderboardImageV2 value) => new IncludedItem109((global::AppStoreConnect.GameCenterLeaderboardImageV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardImageV2?(IncludedItem109 @this) => @this.GameCenterLeaderboardImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem109(global::AppStoreConnect.GameCenterLeaderboardImageV2? value)
        {
            GameCenterLeaderboardImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem109 FromGameCenterLeaderboardImages(global::AppStoreConnect.GameCenterLeaderboardImageV2? value) => new IncludedItem109(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem109(global::AppStoreConnect.GameCenterLeaderboardVersionV2 value) => new IncludedItem109((global::AppStoreConnect.GameCenterLeaderboardVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardVersionV2?(IncludedItem109 @this) => @this.GameCenterLeaderboardVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem109(global::AppStoreConnect.GameCenterLeaderboardVersionV2? value)
        {
            GameCenterLeaderboardVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem109 FromGameCenterLeaderboardVersions(global::AppStoreConnect.GameCenterLeaderboardVersionV2? value) => new IncludedItem109(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem109(
            global::AppStoreConnect.GameCenterLeaderboardLocalizationV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardImageV2? gameCenterLeaderboardImages,
            global::AppStoreConnect.GameCenterLeaderboardVersionV2? gameCenterLeaderboardVersions
            )
        {
            Type = type;

            GameCenterLeaderboardImages = gameCenterLeaderboardImages;
            GameCenterLeaderboardVersions = gameCenterLeaderboardVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardVersions as object ??
            GameCenterLeaderboardImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardImages?.ToString() ??
            GameCenterLeaderboardVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardImages && !IsGameCenterLeaderboardVersions || !IsGameCenterLeaderboardImages && IsGameCenterLeaderboardVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardImageV2, TResult>? gameCenterLeaderboardImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardVersionV2, TResult>? gameCenterLeaderboardVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardImages && gameCenterLeaderboardImages != null)
            {
                return gameCenterLeaderboardImages(GameCenterLeaderboardImages!);
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
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardImageV2>? gameCenterLeaderboardImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardVersionV2>? gameCenterLeaderboardVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardImages)
            {
                gameCenterLeaderboardImages?.Invoke(GameCenterLeaderboardImages!);
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
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardImageV2>? gameCenterLeaderboardImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardVersionV2>? gameCenterLeaderboardVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardImages)
            {
                gameCenterLeaderboardImages?.Invoke(GameCenterLeaderboardImages!);
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
                GameCenterLeaderboardImages,
                typeof(global::AppStoreConnect.GameCenterLeaderboardImageV2),
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
        public bool Equals(IncludedItem109 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardImageV2?>.Default.Equals(GameCenterLeaderboardImages, other.GameCenterLeaderboardImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardVersionV2?>.Default.Equals(GameCenterLeaderboardVersions, other.GameCenterLeaderboardVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem109 obj1, IncludedItem109 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem109>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem109 obj1, IncludedItem109 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem109 o && Equals(o);
        }
    }
}
