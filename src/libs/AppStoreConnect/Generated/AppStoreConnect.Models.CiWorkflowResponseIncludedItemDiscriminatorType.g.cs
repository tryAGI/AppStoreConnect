
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowResponseIncludedItemDiscriminatorType
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
    public static class CiWorkflowResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                CiWorkflowResponseIncludedItemDiscriminatorType.CiMacOsVersions => "ciMacOsVersions",
                CiWorkflowResponseIncludedItemDiscriminatorType.CiProducts => "ciProducts",
                CiWorkflowResponseIncludedItemDiscriminatorType.CiXcodeVersions => "ciXcodeVersions",
                CiWorkflowResponseIncludedItemDiscriminatorType.ScmRepositories => "scmRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "ciMacOsVersions" => CiWorkflowResponseIncludedItemDiscriminatorType.CiMacOsVersions,
                "ciProducts" => CiWorkflowResponseIncludedItemDiscriminatorType.CiProducts,
                "ciXcodeVersions" => CiWorkflowResponseIncludedItemDiscriminatorType.CiXcodeVersions,
                "scmRepositories" => CiWorkflowResponseIncludedItemDiscriminatorType.ScmRepositories,
                _ => null,
            };
        }
    }
}