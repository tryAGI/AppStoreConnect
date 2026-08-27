
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewSummarizationRelationshipsTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewSummarizationRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewSummarizationRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                CustomerReviewSummarizationRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewSummarizationRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => CustomerReviewSummarizationRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}