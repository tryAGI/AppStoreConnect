#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem110JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem110>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem110 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.GameCenterLeaderboardImageV2? gameCenterLeaderboardImages = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardImageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardImageV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardImageV2)}");
                gameCenterLeaderboardImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboardVersionV2? gameCenterLeaderboardVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardVersionV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardVersionV2)}");
                gameCenterLeaderboardVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem110(
                discriminator?.Type,
                gameCenterLeaderboardImages,

                gameCenterLeaderboardVersions
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem110 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGameCenterLeaderboardImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardImageV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardImageV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardImageV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboardImages(), typeInfo);
            }
            else if (value.IsGameCenterLeaderboardVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardVersionV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboardVersions(), typeInfo);
            }
        }
    }
}