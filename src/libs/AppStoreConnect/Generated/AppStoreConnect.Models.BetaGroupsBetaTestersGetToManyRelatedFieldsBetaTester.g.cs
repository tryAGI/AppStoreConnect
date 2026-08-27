
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester
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
    public static class BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester value)
        {
            return value switch
            {
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.AppDevices => "appDevices",
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.Apps => "apps",
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.BetaGroups => "betaGroups",
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.Builds => "builds",
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.Email => "email",
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.FirstName => "firstName",
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.InviteType => "inviteType",
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.LastName => "lastName",
                BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.AppDevices,
                "apps" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.Apps,
                "betaGroups" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.BetaGroups,
                "builds" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.Builds,
                "email" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.Email,
                "firstName" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.FirstName,
                "inviteType" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.InviteType,
                "lastName" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.LastName,
                "state" => BetaGroupsBetaTestersGetToManyRelatedFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}