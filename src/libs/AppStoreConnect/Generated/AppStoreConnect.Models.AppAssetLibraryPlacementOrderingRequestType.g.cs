
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestType
    {
        /// <summary>
        ///
        /// </summary>
        AppAssetLibraryPlacementOrderingRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestType.AppAssetLibraryPlacementOrderingRequests => "appAssetLibraryPlacementOrderingRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestType? ToEnum(string value)
        {
            return value switch
            {
                "appAssetLibraryPlacementOrderingRequests" => AppAssetLibraryPlacementOrderingRequestType.AppAssetLibraryPlacementOrderingRequests,
                _ => null,
            };
        }
    }
}