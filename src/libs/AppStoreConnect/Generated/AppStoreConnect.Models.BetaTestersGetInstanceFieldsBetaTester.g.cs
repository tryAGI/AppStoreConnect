
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTestersGetInstanceFieldsBetaTester
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
    public static class BetaTestersGetInstanceFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetInstanceFieldsBetaTester value)
        {
            return value switch
            {
                BetaTestersGetInstanceFieldsBetaTester.AppDevices => "appDevices",
                BetaTestersGetInstanceFieldsBetaTester.Apps => "apps",
                BetaTestersGetInstanceFieldsBetaTester.BetaGroups => "betaGroups",
                BetaTestersGetInstanceFieldsBetaTester.Builds => "builds",
                BetaTestersGetInstanceFieldsBetaTester.Email => "email",
                BetaTestersGetInstanceFieldsBetaTester.FirstName => "firstName",
                BetaTestersGetInstanceFieldsBetaTester.InviteType => "inviteType",
                BetaTestersGetInstanceFieldsBetaTester.LastName => "lastName",
                BetaTestersGetInstanceFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetInstanceFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BetaTestersGetInstanceFieldsBetaTester.AppDevices,
                "apps" => BetaTestersGetInstanceFieldsBetaTester.Apps,
                "betaGroups" => BetaTestersGetInstanceFieldsBetaTester.BetaGroups,
                "builds" => BetaTestersGetInstanceFieldsBetaTester.Builds,
                "email" => BetaTestersGetInstanceFieldsBetaTester.Email,
                "firstName" => BetaTestersGetInstanceFieldsBetaTester.FirstName,
                "inviteType" => BetaTestersGetInstanceFieldsBetaTester.InviteType,
                "lastName" => BetaTestersGetInstanceFieldsBetaTester.LastName,
                "state" => BetaTestersGetInstanceFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}