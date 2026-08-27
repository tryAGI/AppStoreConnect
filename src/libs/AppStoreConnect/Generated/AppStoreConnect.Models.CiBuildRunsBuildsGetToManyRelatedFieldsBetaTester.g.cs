
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.AppDevices => "appDevices",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.Apps => "apps",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.BetaGroups => "betaGroups",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.Builds => "builds",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.Email => "email",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.FirstName => "firstName",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.InviteType => "inviteType",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.LastName => "lastName",
                CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.AppDevices,
                "apps" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.Apps,
                "betaGroups" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.BetaGroups,
                "builds" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.Builds,
                "email" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.Email,
                "firstName" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.FirstName,
                "inviteType" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.InviteType,
                "lastName" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.LastName,
                "state" => CiBuildRunsBuildsGetToManyRelatedFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}