
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfileAttributesProfileType
    {
        /// <summary>
        /// 
        /// </summary>
        IosAppAdhoc,
        /// <summary>
        /// 
        /// </summary>
        IosAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        IosAppInhouse,
        /// <summary>
        /// 
        /// </summary>
        IosAppStore,
        /// <summary>
        /// 
        /// </summary>
        MacAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        MacAppDirect,
        /// <summary>
        /// 
        /// </summary>
        MacAppStore,
        /// <summary>
        /// 
        /// </summary>
        MacCatalystAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        MacCatalystAppDirect,
        /// <summary>
        /// 
        /// </summary>
        MacCatalystAppStore,
        /// <summary>
        /// 
        /// </summary>
        TvosAppAdhoc,
        /// <summary>
        /// 
        /// </summary>
        TvosAppDevelopment,
        /// <summary>
        /// 
        /// </summary>
        TvosAppInhouse,
        /// <summary>
        /// 
        /// </summary>
        TvosAppStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileAttributesProfileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileAttributesProfileType value)
        {
            return value switch
            {
                ProfileAttributesProfileType.IosAppAdhoc => "IOS_APP_ADHOC",
                ProfileAttributesProfileType.IosAppDevelopment => "IOS_APP_DEVELOPMENT",
                ProfileAttributesProfileType.IosAppInhouse => "IOS_APP_INHOUSE",
                ProfileAttributesProfileType.IosAppStore => "IOS_APP_STORE",
                ProfileAttributesProfileType.MacAppDevelopment => "MAC_APP_DEVELOPMENT",
                ProfileAttributesProfileType.MacAppDirect => "MAC_APP_DIRECT",
                ProfileAttributesProfileType.MacAppStore => "MAC_APP_STORE",
                ProfileAttributesProfileType.MacCatalystAppDevelopment => "MAC_CATALYST_APP_DEVELOPMENT",
                ProfileAttributesProfileType.MacCatalystAppDirect => "MAC_CATALYST_APP_DIRECT",
                ProfileAttributesProfileType.MacCatalystAppStore => "MAC_CATALYST_APP_STORE",
                ProfileAttributesProfileType.TvosAppAdhoc => "TVOS_APP_ADHOC",
                ProfileAttributesProfileType.TvosAppDevelopment => "TVOS_APP_DEVELOPMENT",
                ProfileAttributesProfileType.TvosAppInhouse => "TVOS_APP_INHOUSE",
                ProfileAttributesProfileType.TvosAppStore => "TVOS_APP_STORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileAttributesProfileType? ToEnum(string value)
        {
            return value switch
            {
                "IOS_APP_ADHOC" => ProfileAttributesProfileType.IosAppAdhoc,
                "IOS_APP_DEVELOPMENT" => ProfileAttributesProfileType.IosAppDevelopment,
                "IOS_APP_INHOUSE" => ProfileAttributesProfileType.IosAppInhouse,
                "IOS_APP_STORE" => ProfileAttributesProfileType.IosAppStore,
                "MAC_APP_DEVELOPMENT" => ProfileAttributesProfileType.MacAppDevelopment,
                "MAC_APP_DIRECT" => ProfileAttributesProfileType.MacAppDirect,
                "MAC_APP_STORE" => ProfileAttributesProfileType.MacAppStore,
                "MAC_CATALYST_APP_DEVELOPMENT" => ProfileAttributesProfileType.MacCatalystAppDevelopment,
                "MAC_CATALYST_APP_DIRECT" => ProfileAttributesProfileType.MacCatalystAppDirect,
                "MAC_CATALYST_APP_STORE" => ProfileAttributesProfileType.MacCatalystAppStore,
                "TVOS_APP_ADHOC" => ProfileAttributesProfileType.TvosAppAdhoc,
                "TVOS_APP_DEVELOPMENT" => ProfileAttributesProfileType.TvosAppDevelopment,
                "TVOS_APP_INHOUSE" => ProfileAttributesProfileType.TvosAppInhouse,
                "TVOS_APP_STORE" => ProfileAttributesProfileType.TvosAppStore,
                _ => null,
            };
        }
    }
}