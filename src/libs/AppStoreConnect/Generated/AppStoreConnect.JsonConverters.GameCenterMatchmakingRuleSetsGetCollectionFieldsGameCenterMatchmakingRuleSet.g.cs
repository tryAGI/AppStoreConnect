#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet Read(
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
                        return global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSetExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSetExtensions.ToValueString(value));
        }
    }
}
