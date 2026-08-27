
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadState
    {
        /// <summary>
        ///
        /// </summary>
        AwaitingUpload,
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadState value)
        {
            return value switch
            {
                BuildUploadState.AwaitingUpload => "AWAITING_UPLOAD",
                BuildUploadState.Complete => "COMPLETE",
                BuildUploadState.Failed => "FAILED",
                BuildUploadState.Processing => "PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadState? ToEnum(string value)
        {
            return value switch
            {
                "AWAITING_UPLOAD" => BuildUploadState.AwaitingUpload,
                "COMPLETE" => BuildUploadState.Complete,
                "FAILED" => BuildUploadState.Failed,
                "PROCESSING" => BuildUploadState.Processing,
                _ => null,
            };
        }
    }
}