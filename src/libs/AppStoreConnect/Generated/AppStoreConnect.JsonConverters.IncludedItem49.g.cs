#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem49JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem49>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem49 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.BackgroundAssetUploadFile? backgroundAssetUploadFiles = default;
            if (discriminator?.Type == global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetUploadFiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetUploadFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetUploadFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BackgroundAssetUploadFile)}");
                backgroundAssetUploadFiles = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease? backgroundAssetVersionAppStoreReleases1 = default;
            if (discriminator?.Type == global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionAppStoreReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease)}");
                backgroundAssetVersionAppStoreReleases1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease? backgroundAssetVersionExternalBetaReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionExternalBetaReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease)}");
                backgroundAssetVersionExternalBetaReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease? backgroundAssetVersionInternalBetaReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionInternalBetaReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease)}");
                backgroundAssetVersionInternalBetaReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.BackgroundAsset? backgroundAssetVersionAppStoreReleases2 = default;
            if (discriminator?.Type == global::AppStoreConnect.BackgroundAssetVersionResponseIncludedItemDiscriminatorType.BackgroundAssetVersionAppStoreReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAsset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.BackgroundAsset)}");
                backgroundAssetVersionAppStoreReleases2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem49(
                discriminator?.Type,
                backgroundAssetUploadFiles,

                backgroundAssetVersionAppStoreReleases1,

                backgroundAssetVersionExternalBetaReleases,

                backgroundAssetVersionInternalBetaReleases,

                backgroundAssetVersionAppStoreReleases2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem49 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBackgroundAssetUploadFiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetUploadFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetUploadFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BackgroundAssetUploadFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BackgroundAssetUploadFiles!, typeInfo);
            }
            else if (value.IsBackgroundAssetVersionAppStoreReleases1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BackgroundAssetVersionAppStoreRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BackgroundAssetVersionAppStoreReleases1!, typeInfo);
            }
            else if (value.IsBackgroundAssetVersionExternalBetaReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BackgroundAssetVersionExternalBetaRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BackgroundAssetVersionExternalBetaReleases!, typeInfo);
            }
            else if (value.IsBackgroundAssetVersionInternalBetaReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BackgroundAssetVersionInternalBetaRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BackgroundAssetVersionInternalBetaReleases!, typeInfo);
            }
            else if (value.IsBackgroundAssetVersionAppStoreReleases2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.BackgroundAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.BackgroundAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.BackgroundAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BackgroundAssetVersionAppStoreReleases2!, typeInfo);
            }
        }
    }
}