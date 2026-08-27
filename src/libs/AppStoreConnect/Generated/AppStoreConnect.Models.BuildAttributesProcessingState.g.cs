
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildAttributesProcessingState
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
    public static class BuildAttributesProcessingStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildAttributesProcessingState value)
        {
            return value switch
            {
                BuildAttributesProcessingState.Failed => "FAILED",
                BuildAttributesProcessingState.Invalid => "INVALID",
                BuildAttributesProcessingState.Processing => "PROCESSING",
                BuildAttributesProcessingState.Valid => "VALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildAttributesProcessingState? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => BuildAttributesProcessingState.Failed,
                "INVALID" => BuildAttributesProcessingState.Invalid,
                "PROCESSING" => BuildAttributesProcessingState.Processing,
                "VALID" => BuildAttributesProcessingState.Valid,
                _ => null,
            };
        }
    }
}