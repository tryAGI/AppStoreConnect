#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflowNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow? Read(
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
                        return global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflowExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflowExtensions.ToValueString(value.Value));
            }
        }
    }
}
