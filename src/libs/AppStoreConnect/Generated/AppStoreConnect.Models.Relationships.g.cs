#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Relationships : global::System.IEquatable<Relationships>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType? MediaType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships? Image { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships? Video { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships? Video { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships PickVideo() => Video is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Relationships(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships value) => new Relationships((global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships?(Relationships @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public Relationships(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Relationships FromImage(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships? value) => new Relationships(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Relationships(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships value) => new Relationships((global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships?(Relationships @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public Relationships(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Relationships FromVideo(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships? value) => new Relationships(value);

        /// <summary>
        ///
        /// </summary>
        public Relationships(
            global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType? mediaType,
            global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships? image,
            global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships? video
            )
        {
            MediaType = mediaType;

            Image = image;
            Video = video;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Video as object ??
            Image as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Image?.ToString() ??
            Video?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImage && !IsVideo || !IsImage && IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships?, TResult>? image = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships?, TResult>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0 && image != null)
            {
                return image(__value0);
            }
            else if (Video is { } __value1 && video != null)
            {
                return video(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships?>? image = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships?>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0)
            {
                image?.Invoke(__value0);
            }
            else if (Video is { } __value1)
            {
                video?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships?>? image = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships?>? video = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Image is { } __value0)
            {
                image?.Invoke(__value0);
            }
            else if (Video is { } __value1)
            {
                video?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Image,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships),
                Video,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships),
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
        public bool Equals(Relationships other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships?>.Default.Equals(Video, other.Video)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Relationships obj1, Relationships obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Relationships>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Relationships obj1, Relationships obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Relationships o && Equals(o);
        }
    }
}
