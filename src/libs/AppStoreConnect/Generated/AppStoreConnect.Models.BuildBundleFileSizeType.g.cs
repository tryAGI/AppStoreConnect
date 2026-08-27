
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundleFileSizeType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildBundleFileSizes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleFileSizeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleFileSizeType value)
        {
            return value switch
            {
                BuildBundleFileSizeType.BuildBundleFileSizes => "buildBundleFileSizes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleFileSizeType? ToEnum(string value)
        {
            return value switch
            {
                "buildBundleFileSizes" => BuildBundleFileSizeType.BuildBundleFileSizes,
                _ => null,
            };
        }
    }
}