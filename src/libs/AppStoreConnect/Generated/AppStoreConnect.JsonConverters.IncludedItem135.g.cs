#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public class IncludedItem135JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.IncludedItem135>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.IncludedItem135 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::AppStoreConnect.GameCenterMatchmakingQueue? gameCenterMatchmakingQueues = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingQueues)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingQueue> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterMatchmakingQueue)}");
                gameCenterMatchmakingQueues = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterMatchmakingRule? gameCenterMatchmakingRules = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingRules)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterMatchmakingRule)}");
                gameCenterMatchmakingRules = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::AppStoreConnect.GameCenterMatchmakingTeam? gameCenterMatchmakingTeams = default;
            if (discriminator?.Type == global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType.GameCenterMatchmakingTeams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingTeam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingTeam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::AppStoreConnect.GameCenterMatchmakingTeam)}");
                gameCenterMatchmakingTeams = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::AppStoreConnect.IncludedItem135(
                discriminator?.Type,
                gameCenterMatchmakingQueues,

                gameCenterMatchmakingRules,

                gameCenterMatchmakingTeams
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.IncludedItem135 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGameCenterMatchmakingQueues)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingQueue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingQueue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterMatchmakingQueue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterMatchmakingQueues!, typeInfo);
            }
            else if (value.IsGameCenterMatchmakingRules)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterMatchmakingRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterMatchmakingRules!, typeInfo);
            }
            else if (value.IsGameCenterMatchmakingTeams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::AppStoreConnect.GameCenterMatchmakingTeam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::AppStoreConnect.GameCenterMatchmakingTeam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::AppStoreConnect.GameCenterMatchmakingTeam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GameCenterMatchmakingTeams!, typeInfo);
            }
        }
    }
}