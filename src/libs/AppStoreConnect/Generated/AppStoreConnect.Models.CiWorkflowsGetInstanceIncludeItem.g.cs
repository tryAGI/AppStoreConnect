
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        MacOsVersion,
        /// <summary>
        ///
        /// </summary>
        Product,
        /// <summary>
        ///
        /// </summary>
        Repository,
        /// <summary>
        ///
        /// </summary>
        XcodeVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsGetInstanceIncludeItem value)
        {
            return value switch
            {
                CiWorkflowsGetInstanceIncludeItem.MacOsVersion => "macOsVersion",
                CiWorkflowsGetInstanceIncludeItem.Product => "product",
                CiWorkflowsGetInstanceIncludeItem.Repository => "repository",
                CiWorkflowsGetInstanceIncludeItem.XcodeVersion => "xcodeVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersion" => CiWorkflowsGetInstanceIncludeItem.MacOsVersion,
                "product" => CiWorkflowsGetInstanceIncludeItem.Product,
                "repository" => CiWorkflowsGetInstanceIncludeItem.Repository,
                "xcodeVersion" => CiWorkflowsGetInstanceIncludeItem.XcodeVersion,
                _ => null,
            };
        }
    }
}