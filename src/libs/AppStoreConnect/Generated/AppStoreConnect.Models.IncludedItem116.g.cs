#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem116 : global::System.IEquatable<IncludedItem116>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.GameCenterLeaderboardSetImageV2 PickGameCenterLeaderboardSetImages() => GameCenterLeaderboardSetImages is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 PickGameCenterLeaderboardSetVersions() => GameCenterLeaderboardSetVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem116(global::AppStoreConnect.GameCenterLeaderboardSetImageV2 value) => new IncludedItem116((global::AppStoreConnect.GameCenterLeaderboardSetImageV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetImageV2?(IncludedItem116 @this) => @this.GameCenterLeaderboardSetImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem116(global::AppStoreConnect.GameCenterLeaderboardSetImageV2? value)
        {
            GameCenterLeaderboardSetImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem116 FromGameCenterLeaderboardSetImages(global::AppStoreConnect.GameCenterLeaderboardSetImageV2? value) => new IncludedItem116(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem116(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2 value) => new IncludedItem116((global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?(IncludedItem116 @this) => @this.GameCenterLeaderboardSetVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem116(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value)
        {
            GameCenterLeaderboardSetVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem116 FromGameCenterLeaderboardSetVersions(global::AppStoreConnect.GameCenterLeaderboardSetVersionV2? value) => new IncludedItem116(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem116(
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2ResponseIncludedItemDiscriminatorType? type,
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

            if (GameCenterLeaderboardSetImages is { } __value0 && gameCenterLeaderboardSetImages != null)
            {
                return gameCenterLeaderboardSetImages(__value0);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value1 && gameCenterLeaderboardSetVersions != null)
            {
                return gameCenterLeaderboardSetVersions(__value1);
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

            if (GameCenterLeaderboardSetImages is { } __value0)
            {
                gameCenterLeaderboardSetImages?.Invoke(__value0);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value1)
            {
                gameCenterLeaderboardSetVersions?.Invoke(__value1);
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

            if (GameCenterLeaderboardSetImages is { } __value0)
            {
                gameCenterLeaderboardSetImages?.Invoke(__value0);
            }
            else if (GameCenterLeaderboardSetVersions is { } __value1)
            {
                gameCenterLeaderboardSetVersions?.Invoke(__value1);
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
        public bool Equals(IncludedItem116 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetImageV2?>.Default.Equals(GameCenterLeaderboardSetImages, other.GameCenterLeaderboardSetImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2?>.Default.Equals(GameCenterLeaderboardSetVersions, other.GameCenterLeaderboardSetVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem116 obj1, IncludedItem116 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem116>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem116 obj1, IncludedItem116 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem116 o && Equals(o);
        }
    }
}
