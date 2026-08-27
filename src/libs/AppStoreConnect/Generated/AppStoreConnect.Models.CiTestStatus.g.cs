
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiTestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ExpectedFailure,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Mixed,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiTestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiTestStatus value)
        {
            return value switch
            {
                CiTestStatus.ExpectedFailure => "EXPECTED_FAILURE",
                CiTestStatus.Failure => "FAILURE",
                CiTestStatus.Mixed => "MIXED",
                CiTestStatus.Skipped => "SKIPPED",
                CiTestStatus.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiTestStatus? ToEnum(string value)
        {
            return value switch
            {
                "EXPECTED_FAILURE" => CiTestStatus.ExpectedFailure,
                "FAILURE" => CiTestStatus.Failure,
                "MIXED" => CiTestStatus.Mixed,
                "SKIPPED" => CiTestStatus.Skipped,
                "SUCCESS" => CiTestStatus.Success,
                _ => null,
            };
        }
    }
}