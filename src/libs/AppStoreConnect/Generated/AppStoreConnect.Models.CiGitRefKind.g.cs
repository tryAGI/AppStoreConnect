
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiGitRefKind
    {
        /// <summary>
        /// 
        /// </summary>
        Branch,
        /// <summary>
        /// 
        /// </summary>
        Tag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiGitRefKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiGitRefKind value)
        {
            return value switch
            {
                CiGitRefKind.Branch => "BRANCH",
                CiGitRefKind.Tag => "TAG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiGitRefKind? ToEnum(string value)
        {
            return value switch
            {
                "BRANCH" => CiGitRefKind.Branch,
                "TAG" => CiGitRefKind.Tag,
                _ => null,
            };
        }
    }
}