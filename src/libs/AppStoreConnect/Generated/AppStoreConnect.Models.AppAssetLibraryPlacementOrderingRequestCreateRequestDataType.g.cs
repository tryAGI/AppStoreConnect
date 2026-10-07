
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacementOrderingRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestCreateRequestDataType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestCreateRequestDataType.AppAssetLibraryPlacementOrderingRequests => "appAssetLibraryPlacementOrderingRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacementOrderingRequests" => AppAssetLibraryPlacementOrderingRequestCreateRequestDataType.AppAssetLibraryPlacementOrderingRequests,
                _ => null,
            };
        }
    }
}