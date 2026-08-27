
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem
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
    public static class PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem value)
        {
            return value switch
            {
                PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem.Failed => "FAILED",
                PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem.Invalid => "INVALID",
                PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem.Processing => "PROCESSING",
                PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem.Valid => "VALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem.Failed,
                "INVALID" => PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem.Invalid,
                "PROCESSING" => PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem.Processing,
                "VALID" => PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem.Valid,
                _ => null,
            };
        }
    }
}