#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitieJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie Read(
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
                        return global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitieExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitie value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppAvailabilitiesV2GetInstanceFieldsAppAvailabilitieExtensions.ToValueString(value));
        }
    }
}
