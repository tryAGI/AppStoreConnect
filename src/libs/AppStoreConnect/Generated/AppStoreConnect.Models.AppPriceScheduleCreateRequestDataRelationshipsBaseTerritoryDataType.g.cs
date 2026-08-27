
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType value)
        {
            return value switch
            {
                AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}