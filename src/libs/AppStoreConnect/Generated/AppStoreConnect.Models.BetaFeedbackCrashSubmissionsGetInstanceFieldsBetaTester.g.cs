
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester
    {
        /// <summary>
        /// 
        /// </summary>
        AppDevices,
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
        /// <summary>
        /// 
        /// </summary>
        Builds,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        FirstName,
        /// <summary>
        /// 
        /// </summary>
        InviteType,
        /// <summary>
        /// 
        /// </summary>
        LastName,
        /// <summary>
        /// 
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.AppDevices => "appDevices",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.Apps => "apps",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.BetaGroups => "betaGroups",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.Builds => "builds",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.Email => "email",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.FirstName => "firstName",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.InviteType => "inviteType",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.LastName => "lastName",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.AppDevices,
                "apps" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.Apps,
                "betaGroups" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.BetaGroups,
                "builds" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.Builds,
                "email" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.Email,
                "firstName" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.FirstName,
                "inviteType" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.InviteType,
                "lastName" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.LastName,
                "state" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}