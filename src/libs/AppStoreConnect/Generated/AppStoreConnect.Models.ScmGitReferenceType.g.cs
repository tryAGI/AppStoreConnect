
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScmGitReferenceType
    {
        /// <summary>
        /// 
        /// </summary>
        ScmGitReferences,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScmGitReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScmGitReferenceType value)
        {
            return value switch
            {
                ScmGitReferenceType.ScmGitReferences => "scmGitReferences",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScmGitReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "scmGitReferences" => ScmGitReferenceType.ScmGitReferences,
                _ => null,
            };
        }
    }
}