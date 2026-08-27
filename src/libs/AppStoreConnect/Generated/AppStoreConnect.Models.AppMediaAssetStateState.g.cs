
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppMediaAssetStateState
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
        UploadComplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppMediaAssetStateStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppMediaAssetStateState value)
        {
            return value switch
            {
                AppMediaAssetStateState.AwaitingUpload => "AWAITING_UPLOAD",
                AppMediaAssetStateState.Complete => "COMPLETE",
                AppMediaAssetStateState.Failed => "FAILED",
                AppMediaAssetStateState.UploadComplete => "UPLOAD_COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppMediaAssetStateState? ToEnum(string value)
        {
            return value switch
            {
                "AWAITING_UPLOAD" => AppMediaAssetStateState.AwaitingUpload,
                "COMPLETE" => AppMediaAssetStateState.Complete,
                "FAILED" => AppMediaAssetStateState.Failed,
                "UPLOAD_COMPLETE" => AppMediaAssetStateState.UploadComplete,
                _ => null,
            };
        }
    }
}