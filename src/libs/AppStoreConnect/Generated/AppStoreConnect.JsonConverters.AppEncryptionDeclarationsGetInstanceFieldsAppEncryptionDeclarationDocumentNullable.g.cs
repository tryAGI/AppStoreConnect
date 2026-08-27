#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocumentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument? Read(
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
                        return global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocumentExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocumentExtensions.ToValueString(value.Value));
            }
        }
    }
}
