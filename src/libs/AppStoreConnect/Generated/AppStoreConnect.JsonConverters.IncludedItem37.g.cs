#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem37JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem37>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem37 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppAssetLibraryPlacements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryPlacement)}");
                appAssetLibraryPlacements = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppPreviewSet? appPreviewSets = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppPreviewSets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppPreviewSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppPreviewSet> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppPreviewSet)}");
                appPreviewSets = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppScreenshotSet? appScreenshotSets = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppScreenshotSets)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppScreenshotSet), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppScreenshotSet> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppScreenshotSet)}");
                appScreenshotSets = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersionExperimentTreatment? appStoreVersionExperimentTreatments = default;
            if (discriminator?.Type == global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentTreatment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperimentTreatment)}");
                appStoreVersionExperimentTreatments = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem37(
                discriminator?.Type,
                appAssetLibraryPlacements,

                appPreviewSets,

                appScreenshotSets,

                appStoreVersionExperimentTreatments
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem37 value,
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
            else if (value.IsAppStoreVersionExperimentTreatments)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentTreatment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersionExperimentTreatments(), typeInfo);
            }
        }
    }
}