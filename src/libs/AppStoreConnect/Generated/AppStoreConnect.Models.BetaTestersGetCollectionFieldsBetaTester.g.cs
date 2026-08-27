
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTestersGetCollectionFieldsBetaTester
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
    public static class BetaTestersGetCollectionFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetCollectionFieldsBetaTester value)
        {
            return value switch
            {
                BetaTestersGetCollectionFieldsBetaTester.AppDevices => "appDevices",
                BetaTestersGetCollectionFieldsBetaTester.Apps => "apps",
                BetaTestersGetCollectionFieldsBetaTester.BetaGroups => "betaGroups",
                BetaTestersGetCollectionFieldsBetaTester.Builds => "builds",
                BetaTestersGetCollectionFieldsBetaTester.Email => "email",
                BetaTestersGetCollectionFieldsBetaTester.FirstName => "firstName",
                BetaTestersGetCollectionFieldsBetaTester.InviteType => "inviteType",
                BetaTestersGetCollectionFieldsBetaTester.LastName => "lastName",
                BetaTestersGetCollectionFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetCollectionFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BetaTestersGetCollectionFieldsBetaTester.AppDevices,
                "apps" => BetaTestersGetCollectionFieldsBetaTester.Apps,
                "betaGroups" => BetaTestersGetCollectionFieldsBetaTester.BetaGroups,
                "builds" => BetaTestersGetCollectionFieldsBetaTester.Builds,
                "email" => BetaTestersGetCollectionFieldsBetaTester.Email,
                "firstName" => BetaTestersGetCollectionFieldsBetaTester.FirstName,
                "inviteType" => BetaTestersGetCollectionFieldsBetaTester.InviteType,
                "lastName" => BetaTestersGetCollectionFieldsBetaTester.LastName,
                "state" => BetaTestersGetCollectionFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}