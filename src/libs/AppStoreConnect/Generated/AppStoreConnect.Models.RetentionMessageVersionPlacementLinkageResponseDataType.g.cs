
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionPlacementLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionPlacementLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionPlacementLinkageResponseDataType value)
        {
            return value switch
            {
                RetentionMessageVersionPlacementLinkageResponseDataType.AppAssetLibraryPlacements => "appAssetLibraryPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionPlacementLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacements" => RetentionMessageVersionPlacementLinkageResponseDataType.AppAssetLibraryPlacements,
                _ => null,
            };
        }
    }
}