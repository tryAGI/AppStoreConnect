
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFilterStateItem
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFilterStateItem.AwaitingUpload => "AWAITING_UPLOAD",
                BackgroundAssetsVersionsGetToManyRelatedFilterStateItem.Complete => "COMPLETE",
                BackgroundAssetsVersionsGetToManyRelatedFilterStateItem.Failed => "FAILED",
                BackgroundAssetsVersionsGetToManyRelatedFilterStateItem.Processing => "PROCESSING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "AWAITING_UPLOAD" => BackgroundAssetsVersionsGetToManyRelatedFilterStateItem.AwaitingUpload,
                "COMPLETE" => BackgroundAssetsVersionsGetToManyRelatedFilterStateItem.Complete,
                "FAILED" => BackgroundAssetsVersionsGetToManyRelatedFilterStateItem.Failed,
                "PROCESSING" => BackgroundAssetsVersionsGetToManyRelatedFilterStateItem.Processing,
                _ => null,
            };
        }
    }
}