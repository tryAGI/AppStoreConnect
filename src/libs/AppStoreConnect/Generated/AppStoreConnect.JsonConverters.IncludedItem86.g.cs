#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem86JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem86>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem86 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.GameCenterAchievementVersionV2? gameCenterAchievementVersions = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementVersionV2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterAchievementVersionV2)}");
                gameCenterAchievementVersions = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterActivity? gameCenterActivities = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterActivities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterActivity)}");
                gameCenterActivities = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterDetails)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterDetail), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterDetail> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterDetail)}");
                gameCenterDetails = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterGroup? gameCenterGroups = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterAchievementV2ResponseIncludedItemDiscriminatorType.GameCenterGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterGroup)}");
                gameCenterGroups = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem86(
                discriminator?.Type,
                gameCenterAchievementVersions,

                gameCenterActivities,

                gameCenterDetails,

                gameCenterGroups
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem86 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGameCenterAchievementVersions)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterAchievementVersionV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterAchievementVersionV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterAchievementVersionV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterAchievementVersions(), typeInfo);
            }
            else if (value.IsGameCenterActivities)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterActivity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterActivity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterActivity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterActivities(), typeInfo);
            }
            else if (value.IsGameCenterDetails)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterDetail), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterDetail?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterDetail).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterDetails(), typeInfo);
            }
            else if (value.IsGameCenterGroups)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGameCenterGroups(), typeInfo);
            }
        }
    }
}