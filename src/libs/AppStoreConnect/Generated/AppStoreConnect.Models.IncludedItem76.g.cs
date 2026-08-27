#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem76 : global::System.IEquatable<IncludedItem76>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementImageV2? GameCenterAchievementImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementImageV2? GameCenterAchievementImages { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementImages))]
#endif
        public bool IsGameCenterAchievementImages => GameCenterAchievementImages != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievementImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementImageV2? value)
        {
            value = GameCenterAchievementImages;
            return IsGameCenterAchievementImages;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementImageV2 PickGameCenterAchievementImages() => IsGameCenterAchievementImages
            ? GameCenterAchievementImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementImages' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementVersionV2? GameCenterAchievementVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementVersionV2? GameCenterAchievementVersions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievementVersions))]
#endif
        public bool IsGameCenterAchievementVersions => GameCenterAchievementVersions != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievementVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievementVersionV2? value)
        {
            value = GameCenterAchievementVersions;
            return IsGameCenterAchievementVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementVersionV2 PickGameCenterAchievementVersions() => IsGameCenterAchievementVersions
            ? GameCenterAchievementVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementVersions' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem76(global::AppStoreConnect.GameCenterAchievementImageV2 value) => new IncludedItem76((global::AppStoreConnect.GameCenterAchievementImageV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementImageV2?(IncludedItem76 @this) => @this.GameCenterAchievementImages;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem76(global::AppStoreConnect.GameCenterAchievementImageV2? value)
        {
            GameCenterAchievementImages = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem76 FromGameCenterAchievementImages(global::AppStoreConnect.GameCenterAchievementImageV2? value) => new IncludedItem76(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem76(global::AppStoreConnect.GameCenterAchievementVersionV2 value) => new IncludedItem76((global::AppStoreConnect.GameCenterAchievementVersionV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementVersionV2?(IncludedItem76 @this) => @this.GameCenterAchievementVersions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem76(global::AppStoreConnect.GameCenterAchievementVersionV2? value)
        {
            GameCenterAchievementVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem76 FromGameCenterAchievementVersions(global::AppStoreConnect.GameCenterAchievementVersionV2? value) => new IncludedItem76(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem76(
            global::AppStoreConnect.GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievementImageV2? gameCenterAchievementImages,
            global::AppStoreConnect.GameCenterAchievementVersionV2? gameCenterAchievementVersions
            )
        {
            Type = type;

            GameCenterAchievementImages = gameCenterAchievementImages;
            GameCenterAchievementVersions = gameCenterAchievementVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterAchievementVersions as object ??
            GameCenterAchievementImages as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievementImages?.ToString() ??
            GameCenterAchievementVersions?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievementImages && !IsGameCenterAchievementVersions || !IsGameCenterAchievementImages && IsGameCenterAchievementVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievementImageV2, TResult>? gameCenterAchievementImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievementVersionV2, TResult>? gameCenterAchievementVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementImages && gameCenterAchievementImages != null)
            {
                return gameCenterAchievementImages(GameCenterAchievementImages!);
            }
            else if (IsGameCenterAchievementVersions && gameCenterAchievementVersions != null)
            {
                return gameCenterAchievementVersions(GameCenterAchievementVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementImageV2>? gameCenterAchievementImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievementVersionV2>? gameCenterAchievementVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementImages)
            {
                gameCenterAchievementImages?.Invoke(GameCenterAchievementImages!);
            }
            else if (IsGameCenterAchievementVersions)
            {
                gameCenterAchievementVersions?.Invoke(GameCenterAchievementVersions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementImageV2>? gameCenterAchievementImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievementVersionV2>? gameCenterAchievementVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterAchievementImages)
            {
                gameCenterAchievementImages?.Invoke(GameCenterAchievementImages!);
            }
            else if (IsGameCenterAchievementVersions)
            {
                gameCenterAchievementVersions?.Invoke(GameCenterAchievementVersions!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterAchievementImages,
                typeof(global::AppStoreConnect.GameCenterAchievementImageV2),
                GameCenterAchievementVersions,
                typeof(global::AppStoreConnect.GameCenterAchievementVersionV2),
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
        public bool Equals(IncludedItem76 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementImageV2?>.Default.Equals(GameCenterAchievementImages, other.GameCenterAchievementImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementVersionV2?>.Default.Equals(GameCenterAchievementVersions, other.GameCenterAchievementVersions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem76 obj1, IncludedItem76 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem76>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem76 obj1, IncludedItem76 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem76 o && Equals(o);
        }
    }
}
