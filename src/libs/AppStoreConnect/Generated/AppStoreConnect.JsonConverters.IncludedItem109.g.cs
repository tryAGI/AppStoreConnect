#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem109JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem109>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem109 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.GameCenterLeaderboardImage? gameCenterLeaderboardImages = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboardImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboardImage)}");
                gameCenterLeaderboardImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterLeaderboard? gameCenterLeaderboards = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterLeaderboardLocalizationResponseIncludedItemDiscriminatorType.GameCenterLeaderboards)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterLeaderboard)}");
                gameCenterLeaderboards = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem109(
                discriminator?.Type,
                gameCenterLeaderboardImages,

                gameCenterLeaderboards
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem109 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::AppStoreConnect.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsGameCenterLeaderboardImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboardImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboardImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboardImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboardImages(), typeInfo);
            }
            else if (value.IsGameCenterLeaderboards)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterLeaderboard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterLeaderboard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterLeaderboard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterLeaderboards(), typeInfo);
            }
        }
    }
}