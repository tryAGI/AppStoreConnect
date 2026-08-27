#nullable enable

namespace AppStoreConnect.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRatingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating>
    {
        /// <inheritdoc />
        public override global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating Read(
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
                        return global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRatingExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRating value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::AppStoreConnect.AppInfosTerritoryAgeRatingsGetToManyRelatedFieldsTerritoryAgeRatingExtensions.ToValueString(value));
        }
    }
}
