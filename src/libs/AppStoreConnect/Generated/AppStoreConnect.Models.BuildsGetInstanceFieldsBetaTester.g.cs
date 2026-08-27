
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceFieldsBetaTester
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
    public static class BuildsGetInstanceFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBetaTester value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBetaTester.AppDevices => "appDevices",
                BuildsGetInstanceFieldsBetaTester.Apps => "apps",
                BuildsGetInstanceFieldsBetaTester.BetaGroups => "betaGroups",
                BuildsGetInstanceFieldsBetaTester.Builds => "builds",
                BuildsGetInstanceFieldsBetaTester.Email => "email",
                BuildsGetInstanceFieldsBetaTester.FirstName => "firstName",
                BuildsGetInstanceFieldsBetaTester.InviteType => "inviteType",
                BuildsGetInstanceFieldsBetaTester.LastName => "lastName",
                BuildsGetInstanceFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BuildsGetInstanceFieldsBetaTester.AppDevices,
                "apps" => BuildsGetInstanceFieldsBetaTester.Apps,
                "betaGroups" => BuildsGetInstanceFieldsBetaTester.BetaGroups,
                "builds" => BuildsGetInstanceFieldsBetaTester.Builds,
                "email" => BuildsGetInstanceFieldsBetaTester.Email,
                "firstName" => BuildsGetInstanceFieldsBetaTester.FirstName,
                "inviteType" => BuildsGetInstanceFieldsBetaTester.InviteType,
                "lastName" => BuildsGetInstanceFieldsBetaTester.LastName,
                "state" => BuildsGetInstanceFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}