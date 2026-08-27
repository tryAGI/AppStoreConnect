
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionState
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
    public static class BackgroundAssetVersionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionState value)
        {
            return value switch
            {
                BackgroundAssetVersionState.AwaitingUpload => "AWAITING_UPLOAD",
                BackgroundAssetVersionState.Complete => "COMPLETE",
                BackgroundAssetVersionState.Failed => "FAILED",
                BackgroundAssetVersionState.Processing => "PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionState? ToEnum(string value)
        {
            return value switch
            {
                "AWAITING_UPLOAD" => BackgroundAssetVersionState.AwaitingUpload,
                "COMPLETE" => BackgroundAssetVersionState.Complete,
                "FAILED" => BackgroundAssetVersionState.Failed,
                "PROCESSING" => BackgroundAssetVersionState.Processing,
                _ => null,
            };
        }
    }
}