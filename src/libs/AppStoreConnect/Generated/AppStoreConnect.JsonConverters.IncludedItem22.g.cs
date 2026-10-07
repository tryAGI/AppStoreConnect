#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem22JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem22>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem22 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEventLocalizationsResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEventLocalizationsResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEventLocalizationsResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements = default;
            if (discriminator?.Type == global::AppStoreConnect.AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppAssetLibraryPlacements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryPlacement)}");
                appAssetLibraryPlacements = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppEventScreenshot? appEventScreenshots = default;
            if (discriminator?.Type == global::AppStoreConnect.AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEventScreenshots)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEventScreenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEventScreenshot> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEventScreenshot)}");
                appEventScreenshots = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppEventVideoClip? appEventVideoClips = default;
            if (discriminator?.Type == global::AppStoreConnect.AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEventVideoClips)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEventVideoClip), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEventVideoClip> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEventVideoClip)}");
                appEventVideoClips = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppEvent? appEvents = default;
            if (discriminator?.Type == global::AppStoreConnect.AppEventLocalizationsResponseIncludedItemDiscriminatorType.AppEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEvent)}");
                appEvents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem22(
                discriminator?.Type,
                appAssetLibraryPlacements,

                appEventScreenshots,

                appEventVideoClips,

                appEvents
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem22 value,
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
            else if (value.IsAppEventScreenshots)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEventScreenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEventScreenshot?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppEventScreenshot).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppEventScreenshots(), typeInfo);
            }
            else if (value.IsAppEventVideoClips)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEventVideoClip), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEventVideoClip?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppEventVideoClip).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppEventVideoClips(), typeInfo);
            }
            else if (value.IsAppEvents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppEvents(), typeInfo);
            }
        }
    }
}