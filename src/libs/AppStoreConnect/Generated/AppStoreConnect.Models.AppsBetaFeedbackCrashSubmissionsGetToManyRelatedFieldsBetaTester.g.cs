
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester
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
    public static class AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester value)
        {
            return value switch
            {
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.AppDevices => "appDevices",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.Apps => "apps",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.BetaGroups => "betaGroups",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.Builds => "builds",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.Email => "email",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.FirstName => "firstName",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.InviteType => "inviteType",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.LastName => "lastName",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.AppDevices,
                "apps" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.Apps,
                "betaGroups" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.BetaGroups,
                "builds" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.Builds,
                "email" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.Email,
                "firstName" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.FirstName,
                "inviteType" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.InviteType,
                "lastName" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.LastName,
                "state" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}