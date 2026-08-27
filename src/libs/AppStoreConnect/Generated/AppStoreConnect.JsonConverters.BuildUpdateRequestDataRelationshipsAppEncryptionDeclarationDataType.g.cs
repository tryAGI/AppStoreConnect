#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType Read(
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
                        return global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.BuildUpdateRequestDataRelationshipsAppEncryptionDeclarationDataTypeExtensions.ToValueString(value));
        }
    }
}
