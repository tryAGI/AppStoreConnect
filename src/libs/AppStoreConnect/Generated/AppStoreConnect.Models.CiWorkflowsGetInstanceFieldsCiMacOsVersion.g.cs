
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowsGetInstanceFieldsCiMacOsVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Version,
        /// <summary>
        /// 
        /// </summary>
        XcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsGetInstanceFieldsCiMacOsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsGetInstanceFieldsCiMacOsVersion value)
        {
            return value switch
            {
                CiWorkflowsGetInstanceFieldsCiMacOsVersion.Name => "name",
                CiWorkflowsGetInstanceFieldsCiMacOsVersion.Version => "version",
                CiWorkflowsGetInstanceFieldsCiMacOsVersion.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsGetInstanceFieldsCiMacOsVersion? ToEnum(string value)
        {
            return value switch
            {
                "name" => CiWorkflowsGetInstanceFieldsCiMacOsVersion.Name,
                "version" => CiWorkflowsGetInstanceFieldsCiMacOsVersion.Version,
                "xcodeVersions" => CiWorkflowsGetInstanceFieldsCiMacOsVersion.XcodeVersions,
                _ => null,
            };
        }
    }
}