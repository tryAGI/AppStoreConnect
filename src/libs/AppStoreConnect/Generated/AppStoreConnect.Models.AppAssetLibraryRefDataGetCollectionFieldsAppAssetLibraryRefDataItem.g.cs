
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem
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
    public static class AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem value)
        {
            return value switch
            {
                AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.DisplayClasses => "displayClasses",
                AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.Features => "features",
                AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.ImageSpecs => "imageSpecs",
                AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.PlacementProfileGroups => "placementProfileGroups",
                AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.PlacementTypes => "placementTypes",
                AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.VideoSpecs => "videoSpecs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem? ToEnum(string value)
        {
            return value switch
            {
                "displayClasses" => AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.DisplayClasses,
                "features" => AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.Features,
                "imageSpecs" => AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.ImageSpecs,
                "placementProfileGroups" => AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.PlacementProfileGroups,
                "placementTypes" => AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.PlacementTypes,
                "videoSpecs" => AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem.VideoSpecs,
                _ => null,
            };
        }
    }
}