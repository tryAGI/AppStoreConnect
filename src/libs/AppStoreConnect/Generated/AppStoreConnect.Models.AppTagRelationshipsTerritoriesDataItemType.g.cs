
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppTagRelationshipsTerritoriesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppTagRelationshipsTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppTagRelationshipsTerritoriesDataItemType value)
        {
            return value switch
            {
                AppTagRelationshipsTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppTagRelationshipsTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => AppTagRelationshipsTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}