
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppMediaVideoStateState
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
        /// <summary>
        ///
        /// </summary>
        UploadComplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppMediaVideoStateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppMediaVideoStateState value)
        {
            return value switch
            {
                AppMediaVideoStateState.AwaitingUpload => "AWAITING_UPLOAD",
                AppMediaVideoStateState.Complete => "COMPLETE",
                AppMediaVideoStateState.Failed => "FAILED",
                AppMediaVideoStateState.Processing => "PROCESSING",
                AppMediaVideoStateState.UploadComplete => "UPLOAD_COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppMediaVideoStateState? ToEnum(string value)
        {
            return value switch
            {
                "AWAITING_UPLOAD" => AppMediaVideoStateState.AwaitingUpload,
                "COMPLETE" => AppMediaVideoStateState.Complete,
                "FAILED" => AppMediaVideoStateState.Failed,
                "PROCESSING" => AppMediaVideoStateState.Processing,
                "UPLOAD_COMPLETE" => AppMediaVideoStateState.UploadComplete,
                _ => null,
            };
        }
    }
}