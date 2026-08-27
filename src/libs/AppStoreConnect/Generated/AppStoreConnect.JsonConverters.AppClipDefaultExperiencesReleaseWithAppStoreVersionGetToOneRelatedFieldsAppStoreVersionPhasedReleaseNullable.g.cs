#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease? Read(
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
                        return global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppClipDefaultExperiencesReleaseWithAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseExtensions.ToValueString(value.Value));
            }
        }
    }
}
