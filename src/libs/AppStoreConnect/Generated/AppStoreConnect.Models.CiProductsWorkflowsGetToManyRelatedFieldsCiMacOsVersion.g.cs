
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion
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
    public static class CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion value)
        {
            return value switch
            {
                CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion.Name => "name",
                CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion.Version => "version",
                CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion.XcodeVersions => "xcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion? ToEnum(string value)
        {
            return value switch
            {
                "name" => CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion.Name,
                "version" => CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion.Version,
                "xcodeVersions" => CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion.XcodeVersions,
                _ => null,
            };
        }
    }
}