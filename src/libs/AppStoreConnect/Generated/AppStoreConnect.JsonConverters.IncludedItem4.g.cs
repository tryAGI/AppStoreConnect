#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem4>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryImage? appAssetLibraryImages = default;
            if (discriminator?.Type == global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppAssetLibraryImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryImage)}");
                appAssetLibraryImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppAssetLibraryVideo? appAssetLibraryVideos = default;
            if (discriminator?.Type == global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppAssetLibraryVideos)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryVideo)}");
                appAssetLibraryVideos = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppCustomProductPageLocalization? appCustomProductPageLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppCustomProductPageLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppCustomProductPageLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppCustomProductPageLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppCustomProductPageLocalization)}");
                appCustomProductPageLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppEventLocalization? appEventLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppEventLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEventLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEventLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppEventLocalization)}");
                appEventLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatmentLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization)}");
                appStoreVersionExperimentTreatmentLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.AppStoreVersionLocalization? appStoreVersionLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.AppAssetLibraryPlacementResponseIncludedItemDiscriminatorType.AppStoreVersionLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppStoreVersionLocalization)}");
                appStoreVersionLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem4(
                discriminator?.Type,
                appAssetLibraryImages,

                appAssetLibraryVideos,

                appCustomProductPageLocalizations,

                appEventLocalizations,

                appStoreVersionExperimentTreatmentLocalizations,

                appStoreVersionLocalizations
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAppAssetLibraryImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppAssetLibraryImages(), typeInfo);
            }
            else if (value.IsAppAssetLibraryVideos)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppAssetLibraryVideos(), typeInfo);
            }
            else if (value.IsAppCustomProductPageLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppCustomProductPageLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppCustomProductPageLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppCustomProductPageLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppCustomProductPageLocalizations(), typeInfo);
            }
            else if (value.IsAppEventLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppEventLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppEventLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppEventLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppEventLocalizations(), typeInfo);
            }
            else if (value.IsAppStoreVersionExperimentTreatmentLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersionExperimentTreatmentLocalizations(), typeInfo);
            }
            else if (value.IsAppStoreVersionLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppStoreVersionLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppStoreVersionLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppStoreVersionLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppStoreVersionLocalizations(), typeInfo);
            }
        }
    }
}