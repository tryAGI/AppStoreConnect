
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem
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
    public static class CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem.Failed => "FAILED",
                CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem.Invalid => "INVALID",
                CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem.Processing => "PROCESSING",
                CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem.Valid => "VALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem.Failed,
                "INVALID" => CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem.Invalid,
                "PROCESSING" => CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem.Processing,
                "VALID" => CiBuildRunsBuildsGetToManyRelatedFilterProcessingStateItem.Valid,
                _ => null,
            };
        }
    }
}