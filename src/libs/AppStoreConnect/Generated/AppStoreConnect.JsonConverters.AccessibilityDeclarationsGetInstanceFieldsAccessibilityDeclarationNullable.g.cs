#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclarationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration? Read(
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
                        return global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclarationExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclarationExtensions.ToValueString(value.Value));
            }
        }
    }
}
