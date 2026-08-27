
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType
    {
        /// <summary>
        ///
        /// </summary>
        ScmGitReferences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType value)
        {
            return value switch
            {
                CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType.ScmGitReferences => "scmGitReferences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType? ToEnum(string value)
        {
            return value switch
            {
                "scmGitReferences" => CiBuildRunCreateRequestDataRelationshipsSourceBranchOrTagDataType.ScmGitReferences,
                _ => null,
            };
        }
    }
}