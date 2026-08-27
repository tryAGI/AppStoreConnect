
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetCollectionFieldsBuildBundle
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDomainCacheStatus,
        /// <summary>
        ///
        /// </summary>
        AppClipDomainDebugStatus,
        /// <summary>
        ///
        /// </summary>
        BaDownloadAllowance,
        /// <summary>
        ///
        /// </summary>
        BaMaxInstallSize,
        /// <summary>
        ///
        /// </summary>
        BetaAppClipInvocations,
        /// <summary>
        ///
        /// </summary>
        BuildBundleFileSizes,
        /// <summary>
        ///
        /// </summary>
        BundleId,
        /// <summary>
        ///
        /// </summary>
        BundleType,
        /// <summary>
        ///
        /// </summary>
        DSYMUrl,
        /// <summary>
        ///
        /// </summary>
        DeviceProtocols,
        /// <summary>
        ///
        /// </summary>
        Entitlements,
        /// <summary>
        ///
        /// </summary>
        FileName,
        /// <summary>
        ///
        /// </summary>
        HasOnDemandResources,
        /// <summary>
        ///
        /// </summary>
        HasPrerenderedIcon,
        /// <summary>
        ///
        /// </summary>
        HasSirikit,
        /// <summary>
        ///
        /// </summary>
        IncludesSymbols,
        /// <summary>
        ///
        /// </summary>
        IsIosBuildMacAppStoreCompatible,
        /// <summary>
        ///
        /// </summary>
        Locales,
        /// <summary>
        ///
        /// </summary>
        MinimumOsVersion,
        /// <summary>
        ///
        /// </summary>
        PlatformBuild,
        /// <summary>
        ///
        /// </summary>
        RequiredCapabilities,
        /// <summary>
        ///
        /// </summary>
        SdkBuild,
        /// <summary>
        ///
        /// </summary>
        SupportedArchitectures,
        /// <summary>
        ///
        /// </summary>
        UsesLocationServices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsGetCollectionFieldsBuildBundleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsBuildBundle value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsBuildBundle.AppClipDomainCacheStatus => "appClipDomainCacheStatus",
                BuildsGetCollectionFieldsBuildBundle.AppClipDomainDebugStatus => "appClipDomainDebugStatus",
                BuildsGetCollectionFieldsBuildBundle.BaDownloadAllowance => "baDownloadAllowance",
                BuildsGetCollectionFieldsBuildBundle.BaMaxInstallSize => "baMaxInstallSize",
                BuildsGetCollectionFieldsBuildBundle.BetaAppClipInvocations => "betaAppClipInvocations",
                BuildsGetCollectionFieldsBuildBundle.BuildBundleFileSizes => "buildBundleFileSizes",
                BuildsGetCollectionFieldsBuildBundle.BundleId => "bundleId",
                BuildsGetCollectionFieldsBuildBundle.BundleType => "bundleType",
                BuildsGetCollectionFieldsBuildBundle.DSYMUrl => "dSYMUrl",
                BuildsGetCollectionFieldsBuildBundle.DeviceProtocols => "deviceProtocols",
                BuildsGetCollectionFieldsBuildBundle.Entitlements => "entitlements",
                BuildsGetCollectionFieldsBuildBundle.FileName => "fileName",
                BuildsGetCollectionFieldsBuildBundle.HasOnDemandResources => "hasOnDemandResources",
                BuildsGetCollectionFieldsBuildBundle.HasPrerenderedIcon => "hasPrerenderedIcon",
                BuildsGetCollectionFieldsBuildBundle.HasSirikit => "hasSirikit",
                BuildsGetCollectionFieldsBuildBundle.IncludesSymbols => "includesSymbols",
                BuildsGetCollectionFieldsBuildBundle.IsIosBuildMacAppStoreCompatible => "isIosBuildMacAppStoreCompatible",
                BuildsGetCollectionFieldsBuildBundle.Locales => "locales",
                BuildsGetCollectionFieldsBuildBundle.MinimumOsVersion => "minimumOsVersion",
                BuildsGetCollectionFieldsBuildBundle.PlatformBuild => "platformBuild",
                BuildsGetCollectionFieldsBuildBundle.RequiredCapabilities => "requiredCapabilities",
                BuildsGetCollectionFieldsBuildBundle.SdkBuild => "sdkBuild",
                BuildsGetCollectionFieldsBuildBundle.SupportedArchitectures => "supportedArchitectures",
                BuildsGetCollectionFieldsBuildBundle.UsesLocationServices => "usesLocationServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsBuildBundle? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainCacheStatus" => BuildsGetCollectionFieldsBuildBundle.AppClipDomainCacheStatus,
                "appClipDomainDebugStatus" => BuildsGetCollectionFieldsBuildBundle.AppClipDomainDebugStatus,
                "baDownloadAllowance" => BuildsGetCollectionFieldsBuildBundle.BaDownloadAllowance,
                "baMaxInstallSize" => BuildsGetCollectionFieldsBuildBundle.BaMaxInstallSize,
                "betaAppClipInvocations" => BuildsGetCollectionFieldsBuildBundle.BetaAppClipInvocations,
                "buildBundleFileSizes" => BuildsGetCollectionFieldsBuildBundle.BuildBundleFileSizes,
                "bundleId" => BuildsGetCollectionFieldsBuildBundle.BundleId,
                "bundleType" => BuildsGetCollectionFieldsBuildBundle.BundleType,
                "dSYMUrl" => BuildsGetCollectionFieldsBuildBundle.DSYMUrl,
                "deviceProtocols" => BuildsGetCollectionFieldsBuildBundle.DeviceProtocols,
                "entitlements" => BuildsGetCollectionFieldsBuildBundle.Entitlements,
                "fileName" => BuildsGetCollectionFieldsBuildBundle.FileName,
                "hasOnDemandResources" => BuildsGetCollectionFieldsBuildBundle.HasOnDemandResources,
                "hasPrerenderedIcon" => BuildsGetCollectionFieldsBuildBundle.HasPrerenderedIcon,
                "hasSirikit" => BuildsGetCollectionFieldsBuildBundle.HasSirikit,
                "includesSymbols" => BuildsGetCollectionFieldsBuildBundle.IncludesSymbols,
                "isIosBuildMacAppStoreCompatible" => BuildsGetCollectionFieldsBuildBundle.IsIosBuildMacAppStoreCompatible,
                "locales" => BuildsGetCollectionFieldsBuildBundle.Locales,
                "minimumOsVersion" => BuildsGetCollectionFieldsBuildBundle.MinimumOsVersion,
                "platformBuild" => BuildsGetCollectionFieldsBuildBundle.PlatformBuild,
                "requiredCapabilities" => BuildsGetCollectionFieldsBuildBundle.RequiredCapabilities,
                "sdkBuild" => BuildsGetCollectionFieldsBuildBundle.SdkBuild,
                "supportedArchitectures" => BuildsGetCollectionFieldsBuildBundle.SupportedArchitectures,
                "usesLocationServices" => BuildsGetCollectionFieldsBuildBundle.UsesLocationServices,
                _ => null,
            };
        }
    }
}