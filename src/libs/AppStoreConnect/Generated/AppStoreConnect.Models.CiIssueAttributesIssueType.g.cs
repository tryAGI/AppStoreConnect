
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiIssueAttributesIssueType
    {
        /// <summary>
        /// 
        /// </summary>
        AnalyzerWarning,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        TestFailure,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiIssueAttributesIssueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiIssueAttributesIssueType value)
        {
            return value switch
            {
                CiIssueAttributesIssueType.AnalyzerWarning => "ANALYZER_WARNING",
                CiIssueAttributesIssueType.Error => "ERROR",
                CiIssueAttributesIssueType.TestFailure => "TEST_FAILURE",
                CiIssueAttributesIssueType.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiIssueAttributesIssueType? ToEnum(string value)
        {
            return value switch
            {
                "ANALYZER_WARNING" => CiIssueAttributesIssueType.AnalyzerWarning,
                "ERROR" => CiIssueAttributesIssueType.Error,
                "TEST_FAILURE" => CiIssueAttributesIssueType.TestFailure,
                "WARNING" => CiIssueAttributesIssueType.Warning,
                _ => null,
            };
        }
    }
}