#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem113 : global::System.IEquatable<IncludedItem113>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterLeaderboardSetImage? GameCenterLeaderboardSetImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterLeaderboardSetImage? GameCenterLeaderboardSetImages { get; }
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
            out global::AppStoreConnect.GameCenterLeaderboardSetImage? value)
        {
            value = GameCenterLeaderboardSetImages;
            return IsGameCenterLeaderboardSetImages;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.GameCenterLeaderboardSetImage PickGameCenterLeaderboardSetImages() => IsGameCenterLeaderboardSetImages
            ? GameCenterLeaderboardSetImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSetImages' but the value was {ToString()}.");

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
        public global::AppStoreConnect.GameCenterLeaderboardSet PickGameCenterLeaderboardSets() => IsGameCenterLeaderboardSets
            ? GameCenterLeaderboardSets!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterLeaderboardSets' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem113(global::AppStoreConnect.GameCenterLeaderboardSetImage value) => new IncludedItem113((global::AppStoreConnect.GameCenterLeaderboardSetImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSetImage?(IncludedItem113 @this) => @this.GameCenterLeaderboardSetImages;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem113(global::AppStoreConnect.GameCenterLeaderboardSetImage? value)
        {
            GameCenterLeaderboardSetImages = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem113 FromGameCenterLeaderboardSetImages(global::AppStoreConnect.GameCenterLeaderboardSetImage? value) => new IncludedItem113(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem113(global::AppStoreConnect.GameCenterLeaderboardSet value) => new IncludedItem113((global::AppStoreConnect.GameCenterLeaderboardSet?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterLeaderboardSet?(IncludedItem113 @this) => @this.GameCenterLeaderboardSets;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem113(global::AppStoreConnect.GameCenterLeaderboardSet? value)
        {
            GameCenterLeaderboardSets = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem113 FromGameCenterLeaderboardSets(global::AppStoreConnect.GameCenterLeaderboardSet? value) => new IncludedItem113(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem113(
            global::AppStoreConnect.GameCenterLeaderboardSetLocalizationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterLeaderboardSetImage? gameCenterLeaderboardSetImages,
            global::AppStoreConnect.GameCenterLeaderboardSet? gameCenterLeaderboardSets
            )
        {
            Type = type;

            GameCenterLeaderboardSetImages = gameCenterLeaderboardSetImages;
            GameCenterLeaderboardSets = gameCenterLeaderboardSets;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GameCenterLeaderboardSets as object ??
            GameCenterLeaderboardSetImages as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GameCenterLeaderboardSetImages?.ToString() ??
            GameCenterLeaderboardSets?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterLeaderboardSetImages && !IsGameCenterLeaderboardSets || !IsGameCenterLeaderboardSetImages && IsGameCenterLeaderboardSets;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSetImage, TResult>? gameCenterLeaderboardSetImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterLeaderboardSet, TResult>? gameCenterLeaderboardSets = null,
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
            else if (IsGameCenterLeaderboardSets && gameCenterLeaderboardSets != null)
            {
                return gameCenterLeaderboardSets(GameCenterLeaderboardSets!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetImage>? gameCenterLeaderboardSetImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,
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
            else if (IsGameCenterLeaderboardSets)
            {
                gameCenterLeaderboardSets?.Invoke(GameCenterLeaderboardSets!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSetImage>? gameCenterLeaderboardSetImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterLeaderboardSet>? gameCenterLeaderboardSets = null,
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
            else if (IsGameCenterLeaderboardSets)
            {
                gameCenterLeaderboardSets?.Invoke(GameCenterLeaderboardSets!);
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
                typeof(global::AppStoreConnect.GameCenterLeaderboardSetImage),
                GameCenterLeaderboardSets,
                typeof(global::AppStoreConnect.GameCenterLeaderboardSet),
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
        public bool Equals(IncludedItem113 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSetImage?>.Default.Equals(GameCenterLeaderboardSetImages, other.GameCenterLeaderboardSetImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterLeaderboardSet?>.Default.Equals(GameCenterLeaderboardSets, other.GameCenterLeaderboardSets) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem113 obj1, IncludedItem113 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem113>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem113 obj1, IncludedItem113 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem113 o && Equals(o);
        }
    }
}
