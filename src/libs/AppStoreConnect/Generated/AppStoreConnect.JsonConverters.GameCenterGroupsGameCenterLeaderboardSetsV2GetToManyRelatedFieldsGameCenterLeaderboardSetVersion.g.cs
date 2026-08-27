#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion Read(
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
                        return global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardSetsV2GetToManyRelatedFieldsGameCenterLeaderboardSetVersionExtensions.ToValueString(value));
        }
    }
}
