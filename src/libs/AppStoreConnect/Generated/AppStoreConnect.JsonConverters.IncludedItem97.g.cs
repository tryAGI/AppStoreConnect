#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem97JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem97>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem97 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.GameCenterChallengeImage? gameCenterChallengeImages = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallengeImage)}");
                gameCenterChallengeImages = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterChallengeLocalization? gameCenterChallengeLocalizations1 = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeLocalization> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallengeLocalization)}");
                gameCenterChallengeLocalizations1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterChallengeVersionRelease? gameCenterChallengeVersionReleases = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersionReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersionRelease> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallengeVersionRelease)}");
                gameCenterChallengeVersionReleases = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterChallenge? gameCenterChallengeLocalizations2 = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterChallengeVersionsResponseIncludedItemDiscriminatorType.GameCenterChallengeLocalizations)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallenge), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallenge> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterChallenge)}");
                gameCenterChallengeLocalizations2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem97(
                discriminator?.Type,
                gameCenterChallengeImages,

                gameCenterChallengeLocalizations1,

                gameCenterChallengeVersionReleases,

                gameCenterChallengeLocalizations2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem97 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGameCenterChallengeImages)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterChallengeImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterChallengeImages!, typeInfo);
            }
            else if (value.IsGameCenterChallengeLocalizations1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeLocalization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeLocalization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterChallengeLocalization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterChallengeLocalizations1!, typeInfo);
            }
            else if (value.IsGameCenterChallengeVersionReleases)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallengeVersionRelease?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterChallengeVersionRelease).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterChallengeVersionReleases!, typeInfo);
            }
            else if (value.IsGameCenterChallengeLocalizations2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterChallenge), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterChallenge?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterChallenge).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterChallengeLocalizations2!, typeInfo);
            }
        }
    }
}