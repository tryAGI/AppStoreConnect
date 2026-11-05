#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem157JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem157>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem157 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionMessageVersionResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionMessageVersionResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.RetentionMessageVersionResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements = default;
            if (discriminator?.Type == global::AppStoreConnect.RetentionMessageVersionResponseIncludedItemDiscriminatorType.AppAssetLibraryPlacements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacement> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.AppAssetLibraryPlacement)}");
                appAssetLibraryPlacements = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.RetentionMessageLocalization? retentionMessageLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.RetentionMessageVersionResponseIncludedItemDiscriminatorType.RetentionMessageLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionMessageLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionMessageLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.RetentionMessageLocalization)}");
                retentionMessageLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.RetentionMessage? retentionMessages = default;
            if (discriminator?.Type == global::AppStoreConnect.RetentionMessageVersionResponseIncludedItemDiscriminatorType.RetentionMessages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.RetentionMessage)}");
                retentionMessages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem157(
                discriminator?.Type,
                appAssetLibraryPlacements,

                retentionMessageLocalizations,

                retentionMessages
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem157 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsAppAssetLibraryPlacements)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.AppAssetLibraryPlacement), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.AppAssetLibraryPlacement?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.AppAssetLibraryPlacement).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAppAssetLibraryPlacements(), typeInfo);
            }
            else if (value.IsRetentionMessageLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionMessageLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionMessageLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.RetentionMessageLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRetentionMessageLocalizations(), typeInfo);
            }
            else if (value.IsRetentionMessages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.RetentionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.RetentionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.RetentionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRetentionMessages(), typeInfo);
            }
        }
    }
}