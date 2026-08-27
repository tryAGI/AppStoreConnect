#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalizationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization Read(
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
                        return global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalizationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalizationExtensions.ToValueString(value));
        }
    }
}
