
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester
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
    public static class BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.AppDevices => "appDevices",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.Apps => "apps",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.BetaGroups => "betaGroups",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.Builds => "builds",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.Email => "email",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.FirstName => "firstName",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.InviteType => "inviteType",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.LastName => "lastName",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.AppDevices,
                "apps" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.Apps,
                "betaGroups" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.BetaGroups,
                "builds" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.Builds,
                "email" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.Email,
                "firstName" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.FirstName,
                "inviteType" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.InviteType,
                "lastName" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.LastName,
                "state" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}