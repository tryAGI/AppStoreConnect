#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatmentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment? Read(
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
                        return global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatmentExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatmentExtensions.ToValueString(value.Value));
            }
        }
    }
}
