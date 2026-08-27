
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester
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
    public static class AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester value)
        {
            return value switch
            {
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.AppDevices => "appDevices",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.Apps => "apps",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.BetaGroups => "betaGroups",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.Builds => "builds",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.Email => "email",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.FirstName => "firstName",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.InviteType => "inviteType",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.LastName => "lastName",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.AppDevices,
                "apps" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.Apps,
                "betaGroups" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.BetaGroups,
                "builds" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.Builds,
                "email" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.Email,
                "firstName" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.FirstName,
                "inviteType" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.InviteType,
                "lastName" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.LastName,
                "state" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}