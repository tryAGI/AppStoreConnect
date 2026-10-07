
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        OrderedPlacements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem.OrderedPlacements => "orderedPlacements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "orderedPlacements" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem.OrderedPlacements,
                _ => null,
            };
        }
    }
}