
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppMediaPreviewFrameImageStateState
    {
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
    public static class AppMediaPreviewFrameImageStateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppMediaPreviewFrameImageStateState value)
        {
            return value switch
            {
                AppMediaPreviewFrameImageStateState.Complete => "COMPLETE",
                AppMediaPreviewFrameImageStateState.Failed => "FAILED",
                AppMediaPreviewFrameImageStateState.Processing => "PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppMediaPreviewFrameImageStateState? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => AppMediaPreviewFrameImageStateState.Complete,
                "FAILED" => AppMediaPreviewFrameImageStateState.Failed,
                "PROCESSING" => AppMediaPreviewFrameImageStateState.Processing,
                _ => null,
            };
        }
    }
}