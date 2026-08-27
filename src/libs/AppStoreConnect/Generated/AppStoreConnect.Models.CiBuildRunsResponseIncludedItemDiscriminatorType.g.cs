
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsResponseIncludedItemDiscriminatorType
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
    public static class CiBuildRunsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                CiBuildRunsResponseIncludedItemDiscriminatorType.Builds => "builds",
                CiBuildRunsResponseIncludedItemDiscriminatorType.CiProducts => "ciProducts",
                CiBuildRunsResponseIncludedItemDiscriminatorType.CiWorkflows => "ciWorkflows",
                CiBuildRunsResponseIncludedItemDiscriminatorType.ScmGitReferences => "scmGitReferences",
                CiBuildRunsResponseIncludedItemDiscriminatorType.ScmPullRequests => "scmPullRequests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => CiBuildRunsResponseIncludedItemDiscriminatorType.Builds,
                "ciProducts" => CiBuildRunsResponseIncludedItemDiscriminatorType.CiProducts,
                "ciWorkflows" => CiBuildRunsResponseIncludedItemDiscriminatorType.CiWorkflows,
                "scmGitReferences" => CiBuildRunsResponseIncludedItemDiscriminatorType.ScmGitReferences,
                "scmPullRequests" => CiBuildRunsResponseIncludedItemDiscriminatorType.ScmPullRequests,
                _ => null,
            };
        }
    }
}