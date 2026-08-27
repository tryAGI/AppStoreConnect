
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiCompletionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Canceled,
        /// <summary>
        ///
        /// </summary>
        Errored,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiCompletionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiCompletionStatus value)
        {
            return value switch
            {
                CiCompletionStatus.Canceled => "CANCELED",
                CiCompletionStatus.Errored => "ERRORED",
                CiCompletionStatus.Failed => "FAILED",
                CiCompletionStatus.Skipped => "SKIPPED",
                CiCompletionStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiCompletionStatus? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => CiCompletionStatus.Canceled,
                "ERRORED" => CiCompletionStatus.Errored,
                "FAILED" => CiCompletionStatus.Failed,
                "SKIPPED" => CiCompletionStatus.Skipped,
                "SUCCEEDED" => CiCompletionStatus.Succeeded,
                _ => null,
            };
        }
    }
}