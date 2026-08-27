#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSetExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSetExtensions.ToValueString(value.Value));
            }
        }
    }
}
