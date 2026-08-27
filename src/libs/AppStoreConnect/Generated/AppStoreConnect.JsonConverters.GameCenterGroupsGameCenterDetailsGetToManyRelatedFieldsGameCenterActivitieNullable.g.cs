#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitieNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie? Read(
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
                        return global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitieExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitieExtensions.ToValueString(value.Value));
            }
        }
    }
}
