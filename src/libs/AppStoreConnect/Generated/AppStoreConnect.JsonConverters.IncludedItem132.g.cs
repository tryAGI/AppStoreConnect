#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem132JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem132>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem132 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty? gameCenterMatchmakingTestPlayerProperties = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTestPlayerProperties)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty)}");
                gameCenterMatchmakingTestPlayerProperties = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterMatchmakingTestRequest? gameCenterMatchmakingTestRequests = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterMatchmakingRuleSetTestResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTestRequests)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingTestRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterMatchmakingTestRequest)}");
                gameCenterMatchmakingTestRequests = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem132(
                discriminator?.Type,
                gameCenterMatchmakingTestPlayerProperties,

                gameCenterMatchmakingTestRequests
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem132 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGameCenterMatchmakingTestPlayerProperties)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterMatchmakingTestPlayerProperty).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterMatchmakingTestPlayerProperties!, typeInfo);
            }
            else if (value.IsGameCenterMatchmakingTestRequests)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingTestRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterMatchmakingTestRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterMatchmakingTestRequests!, typeInfo);
            }
        }
    }
}