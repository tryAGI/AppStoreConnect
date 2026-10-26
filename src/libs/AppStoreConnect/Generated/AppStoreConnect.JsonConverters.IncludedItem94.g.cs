#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem94JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem94>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem94 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersionResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersionResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityVersionResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.GameCenterActivity? gameCenterActivities = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivity)}");
                gameCenterActivities = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivityImage? gameCenterActivityImages = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityImage)}");
                gameCenterActivityImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivityLocalization? gameCenterActivityLocalizations = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityLocalization)}");
                gameCenterActivityLocalizations = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivityVersionRelease? gameCenterActivityVersionReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterActivityVersionResponseIncludedItemDiscriminatorType.GameCenterActivityVersionReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersionRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersionRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivityVersionRelease)}");
                gameCenterActivityVersionReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem94(
                discriminator?.Type,
                gameCenterActivities,

                gameCenterActivityImages,

                gameCenterActivityLocalizations,

                gameCenterActivityVersionReleases
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem94 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsGameCenterActivities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivities(), typeInfo);
            }
            else if (value.IsGameCenterActivityImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivityImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivityImages(), typeInfo);
            }
            else if (value.IsGameCenterActivityLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivityLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivityLocalizations(), typeInfo);
            }
            else if (value.IsGameCenterActivityVersionReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivityVersionRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivityVersionRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivityVersionRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivityVersionReleases(), typeInfo);
            }
        }
    }
}