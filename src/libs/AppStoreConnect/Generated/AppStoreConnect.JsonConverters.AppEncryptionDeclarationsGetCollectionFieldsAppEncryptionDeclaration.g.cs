#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration Read(
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
                        return global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclaration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppEncryptionDeclarationsGetCollectionFieldsAppEncryptionDeclarationExtensions.ToValueString(value));
        }
    }
}
