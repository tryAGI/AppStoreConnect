#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboard>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboard Read(
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
                        return global::AppStoreConnect.GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboard)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboard);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboard value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterLeaderboardsReleasesGetToManyRelatedFieldsGameCenterLeaderboardExtensions.ToValueString(value));
        }
    }
}
