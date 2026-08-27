
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBundleType
    {
        /// <summary>
        ///
        /// </summary>
        BuildBundles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleType value)
        {
            return value switch
            {
                BuildBundleType.BuildBundles => "buildBundles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleType? ToEnum(string value)
        {
            return value switch
            {
                "buildBundles" => BuildBundleType.BuildBundles,
                _ => null,
            };
        }
    }
}