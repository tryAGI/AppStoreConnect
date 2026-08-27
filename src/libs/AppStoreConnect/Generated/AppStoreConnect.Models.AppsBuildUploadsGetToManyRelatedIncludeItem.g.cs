
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBuildUploadsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AssetDescriptionFile,
        /// <summary>
        ///
        /// </summary>
        AssetFile,
        /// <summary>
        ///
        /// </summary>
        AssetSpiFile,
        /// <summary>
        ///
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBuildUploadsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBuildUploadsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsBuildUploadsGetToManyRelatedIncludeItem.AssetDescriptionFile => "assetDescriptionFile",
                AppsBuildUploadsGetToManyRelatedIncludeItem.AssetFile => "assetFile",
                AppsBuildUploadsGetToManyRelatedIncludeItem.AssetSpiFile => "assetSpiFile",
                AppsBuildUploadsGetToManyRelatedIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBuildUploadsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "assetDescriptionFile" => AppsBuildUploadsGetToManyRelatedIncludeItem.AssetDescriptionFile,
                "assetFile" => AppsBuildUploadsGetToManyRelatedIncludeItem.AssetFile,
                "assetSpiFile" => AppsBuildUploadsGetToManyRelatedIncludeItem.AssetSpiFile,
                "build" => AppsBuildUploadsGetToManyRelatedIncludeItem.Build,
                _ => null,
            };
        }
    }
}