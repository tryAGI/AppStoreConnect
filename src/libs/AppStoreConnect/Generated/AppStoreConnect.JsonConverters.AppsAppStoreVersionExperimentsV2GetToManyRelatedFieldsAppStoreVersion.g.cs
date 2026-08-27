#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion Read(
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
                        return global::AppStoreConnect.AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExtensions.ToValueString(value));
        }
    }
}
