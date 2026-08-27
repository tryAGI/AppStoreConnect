#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType? Read(
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
                        return global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSetDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
