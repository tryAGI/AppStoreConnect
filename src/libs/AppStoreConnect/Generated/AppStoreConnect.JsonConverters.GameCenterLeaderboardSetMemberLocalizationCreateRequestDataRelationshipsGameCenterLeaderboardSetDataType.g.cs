#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSetDataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType Read(
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
                        return global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSetDataTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSetDataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSetDataTypeExtensions.ToValueString(value));
        }
    }
}
