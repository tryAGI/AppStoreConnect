#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class CiWorkflowsBuildRunsGetToManyRelatedFieldsBuildJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild Read(
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
                        return global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuildExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuildExtensions.ToValueString(value));
        }
    }
}
