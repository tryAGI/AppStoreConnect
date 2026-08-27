
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
        /// <summary>
        ///
        /// </summary>
        CiProducts,
        /// <summary>
        ///
        /// </summary>
        CiWorkflows,
        /// <summary>
        ///
        /// </summary>
        ScmGitReferences,
        /// <summary>
        ///
        /// </summary>
        ScmPullRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                CiBuildRunResponseIncludedItemDiscriminatorType.Builds => "builds",
                CiBuildRunResponseIncludedItemDiscriminatorType.CiProducts => "ciProducts",
                CiBuildRunResponseIncludedItemDiscriminatorType.CiWorkflows => "ciWorkflows",
                CiBuildRunResponseIncludedItemDiscriminatorType.ScmGitReferences => "scmGitReferences",
                CiBuildRunResponseIncludedItemDiscriminatorType.ScmPullRequests => "scmPullRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => CiBuildRunResponseIncludedItemDiscriminatorType.Builds,
                "ciProducts" => CiBuildRunResponseIncludedItemDiscriminatorType.CiProducts,
                "ciWorkflows" => CiBuildRunResponseIncludedItemDiscriminatorType.CiWorkflows,
                "scmGitReferences" => CiBuildRunResponseIncludedItemDiscriminatorType.ScmGitReferences,
                "scmPullRequests" => CiBuildRunResponseIncludedItemDiscriminatorType.ScmPullRequests,
                _ => null,
            };
        }
    }
}