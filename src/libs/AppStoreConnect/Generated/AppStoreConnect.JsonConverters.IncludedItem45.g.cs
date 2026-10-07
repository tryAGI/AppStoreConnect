#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem45JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem45>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem45 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionLocalizationResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionLocalizationResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionLocalizationResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppAssetLibraryPlacements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryPlacement)}");
                appAssetLibraryPlacements = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppKeyword? appKeywords = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppKeywords)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppKeyword), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppKeyword> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppKeyword)}");
                appKeywords = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppPreviewSet? appPreviewSets = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppPreviewSets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppPreviewSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppPreviewSet> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppPreviewSet)}");
                appPreviewSets = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppScreenshotSet? appScreenshotSets = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppScreenshotSets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppScreenshotSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppScreenshotSet> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppScreenshotSet)}");
                appScreenshotSets = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersion? appStoreVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionLocalizationResponseIncludedItemDiscriminatorType.AppStoreVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersion)}");
                appStoreVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem45(
                discriminator?.Type,
                appAssetLibraryPlacements,

                appKeywords,

                appPreviewSets,

                appScreenshotSets,

                appStoreVersions
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem45 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAppAssetLibraryPlacements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacement?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryPlacement).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppAssetLibraryPlacements(), typeInfo);
            }
            else if (value.IsAppKeywords)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppKeyword), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppKeyword?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppKeyword).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppKeywords(), typeInfo);
            }
            else if (value.IsAppPreviewSets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppPreviewSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppPreviewSet?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppPreviewSet).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppPreviewSets(), typeInfo);
            }
            else if (value.IsAppScreenshotSets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppScreenshotSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppScreenshotSet?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppScreenshotSet).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppScreenshotSets(), typeInfo);
            }
            else if (value.IsAppStoreVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersions(), typeInfo);
            }
        }
    }
}