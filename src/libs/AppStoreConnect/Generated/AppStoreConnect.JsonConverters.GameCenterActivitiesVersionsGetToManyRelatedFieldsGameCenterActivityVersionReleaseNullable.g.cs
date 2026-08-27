#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionReleaseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease? Read(
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
                        return global::AppStoreConnect.GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionReleaseExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionReleaseExtensions.ToValueString(value.Value));
            }
        }
    }
}
