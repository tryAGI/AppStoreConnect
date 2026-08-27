
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiIssueType
    {
        /// <summary>
        ///
        /// </summary>
        CiIssues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiIssueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiIssueType value)
        {
            return value switch
            {
                CiIssueType.CiIssues => "ciIssues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiIssueType? ToEnum(string value)
        {
            return value switch
            {
                "ciIssues" => CiIssueType.CiIssues,
                _ => null,
            };
        }
    }
}