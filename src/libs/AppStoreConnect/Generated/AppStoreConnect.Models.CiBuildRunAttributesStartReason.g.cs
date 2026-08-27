
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunAttributesStartReason
    {
        /// <summary>
        ///
        /// </summary>
        GitRefChange,
        /// <summary>
        ///
        /// </summary>
        Manual,
        /// <summary>
        ///
        /// </summary>
        ManualRebuild,
        /// <summary>
        ///
        /// </summary>
        PullRequestOpen,
        /// <summary>
        ///
        /// </summary>
        PullRequestUpdate,
        /// <summary>
        ///
        /// </summary>
        Schedule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunAttributesStartReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunAttributesStartReason value)
        {
            return value switch
            {
                CiBuildRunAttributesStartReason.GitRefChange => "GIT_REF_CHANGE",
                CiBuildRunAttributesStartReason.Manual => "MANUAL",
                CiBuildRunAttributesStartReason.ManualRebuild => "MANUAL_REBUILD",
                CiBuildRunAttributesStartReason.PullRequestOpen => "PULL_REQUEST_OPEN",
                CiBuildRunAttributesStartReason.PullRequestUpdate => "PULL_REQUEST_UPDATE",
                CiBuildRunAttributesStartReason.Schedule => "SCHEDULE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunAttributesStartReason? ToEnum(string value)
        {
            return value switch
            {
                "GIT_REF_CHANGE" => CiBuildRunAttributesStartReason.GitRefChange,
                "MANUAL" => CiBuildRunAttributesStartReason.Manual,
                "MANUAL_REBUILD" => CiBuildRunAttributesStartReason.ManualRebuild,
                "PULL_REQUEST_OPEN" => CiBuildRunAttributesStartReason.PullRequestOpen,
                "PULL_REQUEST_UPDATE" => CiBuildRunAttributesStartReason.PullRequestUpdate,
                "SCHEDULE" => CiBuildRunAttributesStartReason.Schedule,
                _ => null,
            };
        }
    }
}