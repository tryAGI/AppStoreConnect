
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFilterProcessingStateItem
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Invalid,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Valid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsGetCollectionFilterProcessingStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFilterProcessingStateItem value)
        {
            return value switch
            {
                BuildsGetCollectionFilterProcessingStateItem.Failed => "FAILED",
                BuildsGetCollectionFilterProcessingStateItem.Invalid => "INVALID",
                BuildsGetCollectionFilterProcessingStateItem.Processing => "PROCESSING",
                BuildsGetCollectionFilterProcessingStateItem.Valid => "VALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFilterProcessingStateItem? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => BuildsGetCollectionFilterProcessingStateItem.Failed,
                "INVALID" => BuildsGetCollectionFilterProcessingStateItem.Invalid,
                "PROCESSING" => BuildsGetCollectionFilterProcessingStateItem.Processing,
                "VALID" => BuildsGetCollectionFilterProcessingStateItem.Valid,
                _ => null,
            };
        }
    }
}