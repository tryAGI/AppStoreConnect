#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem79 : global::System.IEquatable<IncludedItem79>
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
        public global::AppStoreConnect.GameCenterAchievementImage PickGameCenterAchievementImages() => GameCenterAchievementImages is { } value
            ? value
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
        public global::AppStoreConnect.GameCenterAchievement PickGameCenterAchievements() => GameCenterAchievements is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAchievements' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem79(global::AppStoreConnect.GameCenterAchievementImage value) => new IncludedItem79((global::AppStoreConnect.GameCenterAchievementImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievementImage?(IncludedItem79 @this) => @this.GameCenterAchievementImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem79(global::AppStoreConnect.GameCenterAchievementImage? value)
        {
            GameCenterAchievementImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem79 FromGameCenterAchievementImages(global::AppStoreConnect.GameCenterAchievementImage? value) => new IncludedItem79(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem79(global::AppStoreConnect.GameCenterAchievement value) => new IncludedItem79((global::AppStoreConnect.GameCenterAchievement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAchievement?(IncludedItem79 @this) => @this.GameCenterAchievements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem79(global::AppStoreConnect.GameCenterAchievement? value)
        {
            GameCenterAchievements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem79 FromGameCenterAchievements(global::AppStoreConnect.GameCenterAchievement? value) => new IncludedItem79(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem79(
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

            if (GameCenterAchievementImages is { } __value0 && gameCenterAchievementImages != null)
            {
                return gameCenterAchievementImages(__value0);
            }
            else if (GameCenterAchievements is { } __value1 && gameCenterAchievements != null)
            {
                return gameCenterAchievements(__value1);
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

            if (GameCenterAchievementImages is { } __value0)
            {
                gameCenterAchievementImages?.Invoke(__value0);
            }
            else if (GameCenterAchievements is { } __value1)
            {
                gameCenterAchievements?.Invoke(__value1);
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

            if (GameCenterAchievementImages is { } __value0)
            {
                gameCenterAchievementImages?.Invoke(__value0);
            }
            else if (GameCenterAchievements is { } __value1)
            {
                gameCenterAchievements?.Invoke(__value1);
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
        public bool Equals(IncludedItem79 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievementImage?>.Default.Equals(GameCenterAchievementImages, other.GameCenterAchievementImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAchievement?>.Default.Equals(GameCenterAchievements, other.GameCenterAchievements)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem79 obj1, IncludedItem79 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem79>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem79 obj1, IncludedItem79 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem79 o && Equals(o);
        }
    }
}
