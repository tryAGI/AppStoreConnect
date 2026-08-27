#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class CiProductsWorkflowsGetToManyRelatedFieldsCiProductNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct? Read(
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
                        return global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProductExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProductExtensions.ToValueString(value.Value));
            }
        }
    }
}
