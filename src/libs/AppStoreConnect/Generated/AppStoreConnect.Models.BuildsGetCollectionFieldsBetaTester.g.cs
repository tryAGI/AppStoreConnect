
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFieldsBetaTester
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
    public static class BuildsGetCollectionFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsBetaTester value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsBetaTester.AppDevices => "appDevices",
                BuildsGetCollectionFieldsBetaTester.Apps => "apps",
                BuildsGetCollectionFieldsBetaTester.BetaGroups => "betaGroups",
                BuildsGetCollectionFieldsBetaTester.Builds => "builds",
                BuildsGetCollectionFieldsBetaTester.Email => "email",
                BuildsGetCollectionFieldsBetaTester.FirstName => "firstName",
                BuildsGetCollectionFieldsBetaTester.InviteType => "inviteType",
                BuildsGetCollectionFieldsBetaTester.LastName => "lastName",
                BuildsGetCollectionFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BuildsGetCollectionFieldsBetaTester.AppDevices,
                "apps" => BuildsGetCollectionFieldsBetaTester.Apps,
                "betaGroups" => BuildsGetCollectionFieldsBetaTester.BetaGroups,
                "builds" => BuildsGetCollectionFieldsBetaTester.Builds,
                "email" => BuildsGetCollectionFieldsBetaTester.Email,
                "firstName" => BuildsGetCollectionFieldsBetaTester.FirstName,
                "inviteType" => BuildsGetCollectionFieldsBetaTester.InviteType,
                "lastName" => BuildsGetCollectionFieldsBetaTester.LastName,
                "state" => BuildsGetCollectionFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}