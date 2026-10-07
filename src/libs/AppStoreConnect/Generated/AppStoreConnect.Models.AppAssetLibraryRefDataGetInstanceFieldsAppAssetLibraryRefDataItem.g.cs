
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem
    {
        /// <summary>
        ///
        /// </summary>
        DisplayClasses,
        /// <summary>
        ///
        /// </summary>
        Features,
        /// <summary>
        ///
        /// </summary>
        ImageSpecs,
        /// <summary>
        ///
        /// </summary>
        PlacementProfileGroups,
        /// <summary>
        ///
        /// </summary>
        PlacementTypes,
        /// <summary>
        ///
        /// </summary>
        VideoSpecs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem value)
        {
            return value switch
            {
                AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.DisplayClasses => "displayClasses",
                AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.Features => "features",
                AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.ImageSpecs => "imageSpecs",
                AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.PlacementProfileGroups => "placementProfileGroups",
                AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.PlacementTypes => "placementTypes",
                AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.VideoSpecs => "videoSpecs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem? ToEnum(string value)
        {
            return value switch
            {
                "displayClasses" => AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.DisplayClasses,
                "features" => AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.Features,
                "imageSpecs" => AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.ImageSpecs,
                "placementProfileGroups" => AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.PlacementProfileGroups,
                "placementTypes" => AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.PlacementTypes,
                "videoSpecs" => AppAssetLibraryRefDataGetInstanceFieldsAppAssetLibraryRefDataItem.VideoSpecs,
                _ => null,
            };
        }
    }
}