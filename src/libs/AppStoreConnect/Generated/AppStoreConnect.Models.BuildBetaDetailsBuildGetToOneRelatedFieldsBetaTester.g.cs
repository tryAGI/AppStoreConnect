
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTesterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.AppDevices => "appDevices",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.Apps => "apps",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.BetaGroups => "betaGroups",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.Builds => "builds",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.Email => "email",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.FirstName => "firstName",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.InviteType => "inviteType",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.LastName => "lastName",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester? ToEnum(string value)
        {
            return value switch
            {
                "appDevices" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.AppDevices,
                "apps" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.Apps,
                "betaGroups" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.BetaGroups,
                "builds" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.Builds,
                "email" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.Email,
                "firstName" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.FirstName,
                "inviteType" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.InviteType,
                "lastName" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.LastName,
                "state" => BuildBetaDetailsBuildGetToOneRelatedFieldsBetaTester.State,
                _ => null,
            };
        }
    }
}