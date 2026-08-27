
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion
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
    public static class CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion value)
        {
            return value switch
            {
                CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion.MacOsVersions => "macOsVersions",
                CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion.Name => "name",
                CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion.TestDestinations => "testDestinations",
                CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion? ToEnum(string value)
        {
            return value switch
            {
                "macOsVersions" => CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion.MacOsVersions,
                "name" => CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion.Name,
                "testDestinations" => CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion.TestDestinations,
                "version" => CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion.Version,
                _ => null,
            };
        }
    }
}