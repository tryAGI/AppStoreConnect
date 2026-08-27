#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem77 : global::System.IEquatable<IncludedItem77>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievementImage? GameCenterAchievementImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievementImage? GameCenterAchievementImages { get; }
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
            out global::AppStoreConnect.GameCenterAchievementImage? value)
        {
            value = GameCenterAchievementImages;
            return IsGameCenterAchievementImages;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievementImage PickGameCenterAchievementImages() => IsGameCenterAchievementImages
            ? GameCenterAchievementImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievementImages' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievements { get; init; }
#else
        public global::AppStoreConnect.GameCenterAchievement? GameCenterAchievements { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAchievements))]
#endif
        public bool IsGameCenterAchievements => GameCenterAchievements != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGameCenterAchievements(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAchievement? value)
        {
            value = GameCenterAchievements;
            return IsGameCenterAchievements;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievements() => IsGameCenterAchievements
            ? GameCenterAchievements!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievements' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem77(global::AppStoreConnect.GameCenterAchievementImage value) => new IncludedItem77((global::AppStoreConnect.GameCenterAchievementImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementImage?(IncludedItem77 @this) => @this.GameCenterAchievementImages;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem77(global::AppStoreConnect.GameCenterAchievementImage? value)
        {
            GameCenterAchievementImages = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem77 FromGameCenterAchievementImages(global::AppStoreConnect.GameCenterAchievementImage? value) => new IncludedItem77(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem77(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem77((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem77 @this) => @this.GameCenterAchievements;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem77(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem77 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem77(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem77(
            global::AppStoreConnect.GameCenterAchievementLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterAchievementImage? gameCenterAchievementImages,
            global::AppStoreConnect.GameCenterAchievement? gameCenterAchievements
            )
        {
            Type = type;

            GameCenterAchievementImages = gameCenterAchievementImages;
            GameCenterAchievements = gameCenterAchievements;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterAchievements as object ??
            GameCenterAchievementImages as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterAchievementImages?.ToString() ??
            GameCenterAchievements?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterAchievementImages && !IsGameCenterAchievements || !IsGameCenterAchievementImages && IsGameCenterAchievements;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterAchievementImage, TResult>? gameCenterAchievementImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterAchievement, TResult>? gameCenterAchievements = null,
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
            else if (IsGameCenterAchievements && gameCenterAchievements != null)
            {
                return gameCenterAchievements(GameCenterAchievements!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementImage>? gameCenterAchievementImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,
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
            else if (IsGameCenterAchievements)
            {
                gameCenterAchievements?.Invoke(GameCenterAchievements!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterAchievementImage>? gameCenterAchievementImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterAchievement>? gameCenterAchievements = null,
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
            else if (IsGameCenterAchievements)
            {
                gameCenterAchievements?.Invoke(GameCenterAchievements!);
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
                typeof(global::AppStoreConnect.GameCenterAchievementImage),
                GameCenterAchievements,
                typeof(global::AppStoreConnect.GameCenterAchievement),
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
        public bool Equals(IncludedItem77 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementImage?>.Default.Equals(GameCenterAchievementImages, other.GameCenterAchievementImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem77 obj1, IncludedItem77 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem77>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem77 obj1, IncludedItem77 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem77 o && Equals(o);
        }
    }
}
