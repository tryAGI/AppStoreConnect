
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie value)
        {
            return value switch
            {
                AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => AppStoreVersionsCustomerReviewsGetToManyRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}