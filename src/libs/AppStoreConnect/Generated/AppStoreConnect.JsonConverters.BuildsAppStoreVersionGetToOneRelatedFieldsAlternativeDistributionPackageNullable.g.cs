#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage?>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage? Read(
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
                        return global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackageExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::AppStoreConnect.BuildsAppStoreVersionGetToOneRelatedFieldsAlternativeDistributionPackageExtensions.ToValueString(value.Value));
            }
        }
    }
}
