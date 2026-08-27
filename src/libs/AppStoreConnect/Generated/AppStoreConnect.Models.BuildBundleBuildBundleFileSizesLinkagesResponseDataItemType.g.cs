
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildBundleFileSizes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleBuildBundleFileSizesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType.BuildBundleFileSizes => "buildBundleFileSizes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "buildBundleFileSizes" => BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType.BuildBundleFileSizes,
                _ => null,
            };
        }
    }
}