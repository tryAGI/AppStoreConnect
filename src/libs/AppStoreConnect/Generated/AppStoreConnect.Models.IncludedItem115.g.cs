#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem115 : global::System.IEquatable<IncludedItem115>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetImageV2? GameCenterLeaderboardSetImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetImageV2? GameCenterLeaderboardSetImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterLeaderboardSetImages))]
#endif
        public bool IsGameCenterLeaderboardSetImages => GameCenterLeaderboardSetImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterLeaderboardSetImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterLeaderboardSetImageV2? value)
        {
            value = GameCenterLeaderboardSetImages;
            return IsGameCenterLeaderboardSetImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetImageV2 PickGameCenterLeaderboardSetImages() => IsGameCenterLeaderboardSetImages
            ? GameCenterLeaderboardSetImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetImages' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem115(global::AppStoreConnect.GameCenterLeaderboardSetImageV2 value) => new IncludedItem115((global::AppStoreConnect.GameCenterLeaderboardSetImageV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetImageV2?(IncludedItem115 @this) => @this.GameCenterLeaderboardSetImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem115(global::AppStoreConnect.GameCenterLeaderboardSetImageV2? value)
        {
            GameCenterLeaderboardSetImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem115 FromGameCenterLeaderboardSetImages(global::AppStoreConnect.GameCenterLeaderboardSetImageV2? value) => new IncludedItem115(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem115(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 value) => new IncludedItem115((global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?(IncludedItem115 @this) => @this.GameCenterLeaderboardSetVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem115(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value)
        {
            GameCenterLeaderboardSetVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem115 FromGameCenterLeaderboardSetVersions(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value) => new IncludedItem115(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem115(
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardSetImageV2? gameCenterLeaderboardSetImages,
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? gameCenterLeaderboardSetVersions
            )
        {
            Type = type;

            GameCenterLeaderboardSetImages = gameCenterLeaderboardSetImages;
            GameCenterLeaderboardSetVersions = gameCenterLeaderboardSetVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardSetVersions as object ??
            GameCenterLeaderboardSetImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardSetImages?.ToString() ??
            GameCenterLeaderboardSetVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardSetImages && !IsGameCenterLeaderboardSetVersions || !IsGameCenterLeaderboardSetImages && IsGameCenterLeaderboardSetVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetImageV2, TResult>? gameCenterLeaderboardSetImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2, TResult>? gameCenterLeaderboardSetVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSetImages && gameCenterLeaderboardSetImages != null)
            {
                return gameCenterLeaderboardSetImages(GameCenterLeaderboardSetImages!);
            }
            else if (IsGameCenterLeaderboardSetVersions && gameCenterLeaderboardSetVersions != null)
            {
                return gameCenterLeaderboardSetVersions(GameCenterLeaderboardSetVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetImageV2>? gameCenterLeaderboardSetImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2>? gameCenterLeaderboardSetVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSetImages)
            {
                gameCenterLeaderboardSetImages?.Invoke(GameCenterLeaderboardSetImages!);
            }
            else if (IsGameCenterLeaderboardSetVersions)
            {
                gameCenterLeaderboardSetVersions?.Invoke(GameCenterLeaderboardSetVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetImageV2>? gameCenterLeaderboardSetImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2>? gameCenterLeaderboardSetVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterLeaderboardSetImages)
            {
                gameCenterLeaderboardSetImages?.Invoke(GameCenterLeaderboardSetImages!);
            }
            else if (IsGameCenterLeaderboardSetVersions)
            {
                gameCenterLeaderboardSetVersions?.Invoke(GameCenterLeaderboardSetVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterLeaderboardSetImages,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetImageV2),
                GameCenterLeaderboardSetVersions,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2),
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
        public bool Equals(IncludedItem115 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetImageV2?>.Default.Equals(GameCenterLeaderboardSetImages, other.GameCenterLeaderboardSetImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?>.Default.Equals(GameCenterLeaderboardSetVersions, other.GameCenterLeaderboardSetVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem115 obj1, IncludedItem115 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem115>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem115 obj1, IncludedItem115 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem115 o && Equals(o);
        }
    }
}
