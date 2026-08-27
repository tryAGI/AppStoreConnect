
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsIndividualTestersGetToManyRelatedFieldsBetaTester
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
    public static class BuildsIndividualTestersGetToManyRelatedFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsIndividualTestersGetToManyRelatedFieldsBetaTester value)
        {
            return value switch
            {
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.AppDevices => "appDevices",
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.Apps => "apps",
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.BetaGroups => "betaGroups",
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.Builds => "builds",
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.Email => "email",
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.FirstName => "firstName",
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.InviteType => "inviteType",
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.LastName => "lastName",
                BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsIndividualTestersGetToManyRelatedFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.AppDevices,
                "apps" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.Apps,
                "betaGroups" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.BetaGroups,
                "builds" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.Builds,
                "email" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.Email,
                "firstName" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.FirstName,
                "inviteType" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.InviteType,
                "lastName" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.LastName,
                "state" => BuildsIndividualTestersGetToManyRelatedFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}