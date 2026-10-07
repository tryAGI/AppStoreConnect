#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem92JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem92>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem92 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.GameCenterActivityImage? gameCenterActivityImages = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType.GameCenterActivityImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityImage)}");
                gameCenterActivityImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivityVersion? gameCenterActivityVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterActivityLocalizationResponseIncludedItemDiscriminatorType.GameCenterActivityVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityVersion)}");
                gameCenterActivityVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem92(
                discriminator?.Type,
                gameCenterActivityImages,

                gameCenterActivityVersions
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem92 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGameCenterActivityImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivityImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivityImages(), typeInfo);
            }
            else if (value.IsGameCenterActivityVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivityVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivityVersions(), typeInfo);
            }
        }
    }
}