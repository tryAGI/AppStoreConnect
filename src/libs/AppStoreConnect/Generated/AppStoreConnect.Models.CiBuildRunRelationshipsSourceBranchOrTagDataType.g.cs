
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunRelationshipsSourceBranchOrTagDataType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmGitReferences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunRelationshipsSourceBranchOrTagDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunRelationshipsSourceBranchOrTagDataType value)
        {
            return value switch
            {
                CiBuildRunRelationshipsSourceBranchOrTagDataType.ScmGitReferences => "scmGitReferences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunRelationshipsSourceBranchOrTagDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmGitReferences" => CiBuildRunRelationshipsSourceBranchOrTagDataType.ScmGitReferences,
                _ => null,
            };
        }
    }
}