
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionCreateRequestDataRelationshipsPlacementDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionCreateRequestDataRelationshipsPlacementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionCreateRequestDataRelationshipsPlacementDataType value)
        {
            return value switch
            {
                RetentionMessageVersionCreateRequestDataRelationshipsPlacementDataType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionCreateRequestDataRelationshipsPlacementDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => RetentionMessageVersionCreateRequestDataRelationshipsPlacementDataType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}