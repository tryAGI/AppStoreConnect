
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest
    {
        /// <summary>
        ///
        /// </summary>
        OrderedPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest.OrderedPlacements => "orderedPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest? ToEnum(string value)
        {
            return value switch
            {
                "orderedPlacements" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest.OrderedPlacements,
                _ => null,
            };
        }
    }
}