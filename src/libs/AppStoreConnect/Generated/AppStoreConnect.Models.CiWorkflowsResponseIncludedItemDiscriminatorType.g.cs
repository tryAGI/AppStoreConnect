
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CiMacOsVersions,
        /// <summary>
        ///
        /// </summary>
        CiProducts,
        /// <summary>
        ///
        /// </summary>
        CiXcodeVersions,
        /// <summary>
        ///
        /// </summary>
        ScmRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                CiWorkflowsResponseIncludedItemDiscriminatorType.CiMacOsVersions => "ciMacOsVersions",
                CiWorkflowsResponseIncludedItemDiscriminatorType.CiProducts => "ciProducts",
                CiWorkflowsResponseIncludedItemDiscriminatorType.CiXcodeVersions => "ciXcodeVersions",
                CiWorkflowsResponseIncludedItemDiscriminatorType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ciMacOsVersions" => CiWorkflowsResponseIncludedItemDiscriminatorType.CiMacOsVersions,
                "ciProducts" => CiWorkflowsResponseIncludedItemDiscriminatorType.CiProducts,
                "ciXcodeVersions" => CiWorkflowsResponseIncludedItemDiscriminatorType.CiXcodeVersions,
                "scmRepositories" => CiWorkflowsResponseIncludedItemDiscriminatorType.ScmRepositories,
                _ => null,
            };
        }
    }
}