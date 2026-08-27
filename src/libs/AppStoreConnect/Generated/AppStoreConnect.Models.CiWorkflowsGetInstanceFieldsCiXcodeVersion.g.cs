
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsGetInstanceFieldsCiXcodeVersion
    {
        /// <summary>
        ///
        /// </summary>
        MacOsVersions,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        TestDestinations,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsGetInstanceFieldsCiXcodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsGetInstanceFieldsCiXcodeVersion value)
        {
            return value switch
            {
                CiWorkflowsGetInstanceFieldsCiXcodeVersion.MacOsVersions => "macOsVersions",
                CiWorkflowsGetInstanceFieldsCiXcodeVersion.Name => "name",
                CiWorkflowsGetInstanceFieldsCiXcodeVersion.TestDestinations => "testDestinations",
                CiWorkflowsGetInstanceFieldsCiXcodeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsGetInstanceFieldsCiXcodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiWorkflowsGetInstanceFieldsCiXcodeVersion.MacOsVersions,
                "name" => CiWorkflowsGetInstanceFieldsCiXcodeVersion.Name,
                "testDestinations" => CiWorkflowsGetInstanceFieldsCiXcodeVersion.TestDestinations,
                "version" => CiWorkflowsGetInstanceFieldsCiXcodeVersion.Version,
                _ => null,
            };
        }
    }
}