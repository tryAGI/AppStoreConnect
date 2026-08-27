#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem90 : global::System.IEquatable<IncludedItem90>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivityImage? GameCenterActivityImages { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivityImage? GameCenterActivityImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityImages))]
#endif
        public bool IsGameCenterActivityImages => GameCenterActivityImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterActivityImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivityImage? value)
        {
            value = GameCenterActivityImages;
            return IsGameCenterActivityImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityImage PickGameCenterActivityImages() => IsGameCenterActivityImages
            ? GameCenterActivityImages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterActivityVersion? GameCenterActivityVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterActivityVersion? GameCenterActivityVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterActivityVersions))]
#endif
        public bool IsGameCenterActivityVersions => GameCenterActivityVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterActivityVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterActivityVersion? value)
        {
            value = GameCenterActivityVersions;
            return IsGameCenterActivityVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterActivityVersion PickGameCenterActivityVersions() => IsGameCenterActivityVersions
            ? GameCenterActivityVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterActivityVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem90(global::AppStoreConnect.GameCenterActivityImage value) => new IncludedItem90((global::AppStoreConnect.GameCenterActivityImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityImage?(IncludedItem90 @this) => @this.GameCenterActivityImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem90(global::AppStoreConnect.GameCenterActivityImage? value)
        {
            GameCenterActivityImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem90 FromGameCenterActivityImages(global::AppStoreConnect.GameCenterActivityImage? value) => new IncludedItem90(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem90(global::AppStoreConnect.GameCenterActivityVersion value) => new IncludedItem90((global::AppStoreConnect.GameCenterActivityVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterActivityVersion?(IncludedItem90 @this) => @this.GameCenterActivityVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem90(global::AppStoreConnect.GameCenterActivityVersion? value)
        {
            GameCenterActivityVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem90 FromGameCenterActivityVersions(global::AppStoreConnect.GameCenterActivityVersion? value) => new IncludedItem90(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem90(
            global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.GameCenterActivityImage? gameCenterActivityImages,
            global::AppStoreConnect.GameCenterActivityVersion? gameCenterActivityVersions
            )
        {
            Type = type;

            GameCenterActivityImages = gameCenterActivityImages;
            GameCenterActivityVersions = gameCenterActivityVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterActivityVersions as object ??
            GameCenterActivityImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            GameCenterActivityImages?.ToString() ??
            GameCenterActivityVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGameCenterActivityImages && !IsGameCenterActivityVersions || !IsGameCenterActivityImages && IsGameCenterActivityVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.GameCenterActivityImage, TResult>? gameCenterActivityImages = null,
            global::System.Func<global::AppStoreConnect.GameCenterActivityVersion, TResult>? gameCenterActivityVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivityImages && gameCenterActivityImages != null)
            {
                return gameCenterActivityImages(GameCenterActivityImages!);
            }
            else if (IsGameCenterActivityVersions && gameCenterActivityVersions != null)
            {
                return gameCenterActivityVersions(GameCenterActivityVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.GameCenterActivityImage>? gameCenterActivityImages = null,

            global::System.Action<global::AppStoreConnect.GameCenterActivityVersion>? gameCenterActivityVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivityImages)
            {
                gameCenterActivityImages?.Invoke(GameCenterActivityImages!);
            }
            else if (IsGameCenterActivityVersions)
            {
                gameCenterActivityVersions?.Invoke(GameCenterActivityVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.GameCenterActivityImage>? gameCenterActivityImages = null,
            global::System.Action<global::AppStoreConnect.GameCenterActivityVersion>? gameCenterActivityVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGameCenterActivityImages)
            {
                gameCenterActivityImages?.Invoke(GameCenterActivityImages!);
            }
            else if (IsGameCenterActivityVersions)
            {
                gameCenterActivityVersions?.Invoke(GameCenterActivityVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GameCenterActivityImages,
                typeof(global::AppStoreConnect.GameCenterActivityImage),
                GameCenterActivityVersions,
                typeof(global::AppStoreConnect.GameCenterActivityVersion),
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
        public bool Equals(IncludedItem90 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityImage?>.Default.Equals(GameCenterActivityImages, other.GameCenterActivityImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterActivityVersion?>.Default.Equals(GameCenterActivityVersions, other.GameCenterActivityVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem90 obj1, IncludedItem90 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem90>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem90 obj1, IncludedItem90 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem90 o && Equals(o);
        }
    }
}
