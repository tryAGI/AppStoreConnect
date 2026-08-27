
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppTagTerritoriesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppTagTerritoriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppTagTerritoriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppTagTerritoriesLinkagesResponseDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppTagTerritoriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => AppTagTerritoriesLinkagesResponseDataItemType.Territories,
                _ => null,
            };
        }
    }
}