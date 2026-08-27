
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadsGetInstanceIncludeItem
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
    public static class BuildUploadsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BuildUploadsGetInstanceIncludeItem.AssetDescriptionFile => "assetDescriptionFile",
                BuildUploadsGetInstanceIncludeItem.AssetFile => "assetFile",
                BuildUploadsGetInstanceIncludeItem.AssetSpiFile => "assetSpiFile",
                BuildUploadsGetInstanceIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "assetDescriptionFile" => BuildUploadsGetInstanceIncludeItem.AssetDescriptionFile,
                "assetFile" => BuildUploadsGetInstanceIncludeItem.AssetFile,
                "assetSpiFile" => BuildUploadsGetInstanceIncludeItem.AssetSpiFile,
                "build" => BuildUploadsGetInstanceIncludeItem.Build,
                _ => null,
            };
        }
    }
}