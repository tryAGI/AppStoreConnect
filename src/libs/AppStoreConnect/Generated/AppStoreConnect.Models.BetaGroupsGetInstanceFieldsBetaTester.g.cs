
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetInstanceFieldsBetaTester
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
    public static class BetaGroupsGetInstanceFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetInstanceFieldsBetaTester value)
        {
            return value switch
            {
                BetaGroupsGetInstanceFieldsBetaTester.AppDevices => "appDevices",
                BetaGroupsGetInstanceFieldsBetaTester.Apps => "apps",
                BetaGroupsGetInstanceFieldsBetaTester.BetaGroups => "betaGroups",
                BetaGroupsGetInstanceFieldsBetaTester.Builds => "builds",
                BetaGroupsGetInstanceFieldsBetaTester.Email => "email",
                BetaGroupsGetInstanceFieldsBetaTester.FirstName => "firstName",
                BetaGroupsGetInstanceFieldsBetaTester.InviteType => "inviteType",
                BetaGroupsGetInstanceFieldsBetaTester.LastName => "lastName",
                BetaGroupsGetInstanceFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetInstanceFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BetaGroupsGetInstanceFieldsBetaTester.AppDevices,
                "apps" => BetaGroupsGetInstanceFieldsBetaTester.Apps,
                "betaGroups" => BetaGroupsGetInstanceFieldsBetaTester.BetaGroups,
                "builds" => BetaGroupsGetInstanceFieldsBetaTester.Builds,
                "email" => BetaGroupsGetInstanceFieldsBetaTester.Email,
                "firstName" => BetaGroupsGetInstanceFieldsBetaTester.FirstName,
                "inviteType" => BetaGroupsGetInstanceFieldsBetaTester.InviteType,
                "lastName" => BetaGroupsGetInstanceFieldsBetaTester.LastName,
                "state" => BetaGroupsGetInstanceFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}