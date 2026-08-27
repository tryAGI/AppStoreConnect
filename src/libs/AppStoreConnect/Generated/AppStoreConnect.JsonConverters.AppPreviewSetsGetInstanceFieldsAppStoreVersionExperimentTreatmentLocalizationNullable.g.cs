#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization? Read(
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
                        return global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppPreviewSetsGetInstanceFieldsAppStoreVersionExperimentTreatmentLocalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
