
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesGetCollectionFilterProfileTypeItem
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
    public static class ProfilesGetCollectionFilterProfileTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetCollectionFilterProfileTypeItem value)
        {
            return value switch
            {
                ProfilesGetCollectionFilterProfileTypeItem.IosAppAdhoc => "IOS_APP_ADHOC",
                ProfilesGetCollectionFilterProfileTypeItem.IosAppDevelopment => "IOS_APP_DEVELOPMENT",
                ProfilesGetCollectionFilterProfileTypeItem.IosAppInhouse => "IOS_APP_INHOUSE",
                ProfilesGetCollectionFilterProfileTypeItem.IosAppStore => "IOS_APP_STORE",
                ProfilesGetCollectionFilterProfileTypeItem.MacAppDevelopment => "MAC_APP_DEVELOPMENT",
                ProfilesGetCollectionFilterProfileTypeItem.MacAppDirect => "MAC_APP_DIRECT",
                ProfilesGetCollectionFilterProfileTypeItem.MacAppStore => "MAC_APP_STORE",
                ProfilesGetCollectionFilterProfileTypeItem.MacCatalystAppDevelopment => "MAC_CATALYST_APP_DEVELOPMENT",
                ProfilesGetCollectionFilterProfileTypeItem.MacCatalystAppDirect => "MAC_CATALYST_APP_DIRECT",
                ProfilesGetCollectionFilterProfileTypeItem.MacCatalystAppStore => "MAC_CATALYST_APP_STORE",
                ProfilesGetCollectionFilterProfileTypeItem.TvosAppAdhoc => "TVOS_APP_ADHOC",
                ProfilesGetCollectionFilterProfileTypeItem.TvosAppDevelopment => "TVOS_APP_DEVELOPMENT",
                ProfilesGetCollectionFilterProfileTypeItem.TvosAppInhouse => "TVOS_APP_INHOUSE",
                ProfilesGetCollectionFilterProfileTypeItem.TvosAppStore => "TVOS_APP_STORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetCollectionFilterProfileTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS_APP_ADHOC" => ProfilesGetCollectionFilterProfileTypeItem.IosAppAdhoc,
                "IOS_APP_DEVELOPMENT" => ProfilesGetCollectionFilterProfileTypeItem.IosAppDevelopment,
                "IOS_APP_INHOUSE" => ProfilesGetCollectionFilterProfileTypeItem.IosAppInhouse,
                "IOS_APP_STORE" => ProfilesGetCollectionFilterProfileTypeItem.IosAppStore,
                "MAC_APP_DEVELOPMENT" => ProfilesGetCollectionFilterProfileTypeItem.MacAppDevelopment,
                "MAC_APP_DIRECT" => ProfilesGetCollectionFilterProfileTypeItem.MacAppDirect,
                "MAC_APP_STORE" => ProfilesGetCollectionFilterProfileTypeItem.MacAppStore,
                "MAC_CATALYST_APP_DEVELOPMENT" => ProfilesGetCollectionFilterProfileTypeItem.MacCatalystAppDevelopment,
                "MAC_CATALYST_APP_DIRECT" => ProfilesGetCollectionFilterProfileTypeItem.MacCatalystAppDirect,
                "MAC_CATALYST_APP_STORE" => ProfilesGetCollectionFilterProfileTypeItem.MacCatalystAppStore,
                "TVOS_APP_ADHOC" => ProfilesGetCollectionFilterProfileTypeItem.TvosAppAdhoc,
                "TVOS_APP_DEVELOPMENT" => ProfilesGetCollectionFilterProfileTypeItem.TvosAppDevelopment,
                "TVOS_APP_INHOUSE" => ProfilesGetCollectionFilterProfileTypeItem.TvosAppInhouse,
                "TVOS_APP_STORE" => ProfilesGetCollectionFilterProfileTypeItem.TvosAppStore,
                _ => null,
            };
        }
    }
}