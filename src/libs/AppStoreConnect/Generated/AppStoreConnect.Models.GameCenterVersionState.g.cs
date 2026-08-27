
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterVersionState
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        DeveloperRejected,
        /// <summary>
        ///
        /// </summary>
        InReview,
        /// <summary>
        ///
        /// </summary>
        Live,
        /// <summary>
        ///
        /// </summary>
        PendingRelease,
        /// <summary>
        ///
        /// </summary>
        PrepareForSubmission,
        /// <summary>
        ///
        /// </summary>
        ReadyForReview,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        ReplacedWithNewVersion,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterVersionStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterVersionState value)
        {
            return value switch
            {
                GameCenterVersionState.Accepted => "ACCEPTED",
                GameCenterVersionState.DeveloperRejected => "DEVELOPER_REJECTED",
                GameCenterVersionState.InReview => "IN_REVIEW",
                GameCenterVersionState.Live => "LIVE",
                GameCenterVersionState.PendingRelease => "PENDING_RELEASE",
                GameCenterVersionState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                GameCenterVersionState.ReadyForReview => "READY_FOR_REVIEW",
                GameCenterVersionState.Rejected => "REJECTED",
                GameCenterVersionState.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                GameCenterVersionState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterVersionState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => GameCenterVersionState.Accepted,
                "DEVELOPER_REJECTED" => GameCenterVersionState.DeveloperRejected,
                "IN_REVIEW" => GameCenterVersionState.InReview,
                "LIVE" => GameCenterVersionState.Live,
                "PENDING_RELEASE" => GameCenterVersionState.PendingRelease,
                "PREPARE_FOR_SUBMISSION" => GameCenterVersionState.PrepareForSubmission,
                "READY_FOR_REVIEW" => GameCenterVersionState.ReadyForReview,
                "REJECTED" => GameCenterVersionState.Rejected,
                "REPLACED_WITH_NEW_VERSION" => GameCenterVersionState.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => GameCenterVersionState.WaitingForReview,
                _ => null,
            };
        }
    }
}