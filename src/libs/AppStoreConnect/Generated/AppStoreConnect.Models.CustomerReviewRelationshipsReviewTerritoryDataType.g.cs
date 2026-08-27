
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomerReviewRelationshipsReviewTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerReviewRelationshipsReviewTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerReviewRelationshipsReviewTerritoryDataType value)
        {
            return value switch
            {
                CustomerReviewRelationshipsReviewTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerReviewRelationshipsReviewTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => CustomerReviewRelationshipsReviewTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}