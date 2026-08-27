#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataType Read(
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
                        return global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboardDataTypeExtensions.ToValueString(value));
        }
    }
}
