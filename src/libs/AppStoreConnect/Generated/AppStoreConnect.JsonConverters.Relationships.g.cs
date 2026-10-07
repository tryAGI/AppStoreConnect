#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class RelationshipsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.Relationships>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.Relationships Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships? image = default;
            if (discriminator?.MediaType == global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships? video = default;
            if (discriminator?.MediaType == global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.Relationships(
                discriminator?.MediaType,
                image,

                video
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.Relationships value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryPlacementImageRelationships).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImage(), typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationships).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVideo(), typeInfo);
            }
        }
    }
}