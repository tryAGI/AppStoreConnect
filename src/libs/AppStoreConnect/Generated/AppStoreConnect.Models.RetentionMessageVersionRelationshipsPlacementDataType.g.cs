
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionRelationshipsPlacementDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionRelationshipsPlacementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionRelationshipsPlacementDataType value)
        {
            return value switch
            {
                RetentionMessageVersionRelationshipsPlacementDataType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionRelationshipsPlacementDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => RetentionMessageVersionRelationshipsPlacementDataType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}