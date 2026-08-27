
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference
    {
        /// <summary>
        /// 
        /// </summary>
        CanonicalName,
        /// <summary>
        /// 
        /// </summary>
        IsDeleted,
        /// <summary>
        /// 
        /// </summary>
        Kind,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReferenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference value)
        {
            return value switch
            {
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.CanonicalName => "canonicalName",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.IsDeleted => "isDeleted",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.Kind => "kind",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.Name => "name",
                CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference? ToEnum(string value)
        {
            return value switch
            {
                "canonicalName" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.CanonicalName,
                "isDeleted" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.IsDeleted,
                "kind" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.Kind,
                "name" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.Name,
                "repository" => CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference.Repository,
                _ => null,
            };
        }
    }
}