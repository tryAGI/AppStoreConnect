
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ScmRepositoryGitReferencesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        ScmGitReferences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmRepositoryGitReferencesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmRepositoryGitReferencesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                ScmRepositoryGitReferencesLinkagesResponseDataItemType.ScmGitReferences => "scmGitReferences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmRepositoryGitReferencesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "scmGitReferences" => ScmRepositoryGitReferencesLinkagesResponseDataItemType.ScmGitReferences,
                _ => null,
            };
        }
    }
}