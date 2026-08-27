
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetInstanceFieldsBuildBundle
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
    public static class BuildsGetInstanceFieldsBuildBundleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBuildBundle value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBuildBundle.AppClipDomainCacheStatus => "appClipDomainCacheStatus",
                BuildsGetInstanceFieldsBuildBundle.AppClipDomainDebugStatus => "appClipDomainDebugStatus",
                BuildsGetInstanceFieldsBuildBundle.BaDownloadAllowance => "baDownloadAllowance",
                BuildsGetInstanceFieldsBuildBundle.BaMaxInstallSize => "baMaxInstallSize",
                BuildsGetInstanceFieldsBuildBundle.BetaAppClipInvocations => "betaAppClipInvocations",
                BuildsGetInstanceFieldsBuildBundle.BuildBundleFileSizes => "buildBundleFileSizes",
                BuildsGetInstanceFieldsBuildBundle.BundleId => "bundleId",
                BuildsGetInstanceFieldsBuildBundle.BundleType => "bundleType",
                BuildsGetInstanceFieldsBuildBundle.DSYMUrl => "dSYMUrl",
                BuildsGetInstanceFieldsBuildBundle.DeviceProtocols => "deviceProtocols",
                BuildsGetInstanceFieldsBuildBundle.Entitlements => "entitlements",
                BuildsGetInstanceFieldsBuildBundle.FileName => "fileName",
                BuildsGetInstanceFieldsBuildBundle.HasOnDemandResources => "hasOnDemandResources",
                BuildsGetInstanceFieldsBuildBundle.HasPrerenderedIcon => "hasPrerenderedIcon",
                BuildsGetInstanceFieldsBuildBundle.HasSirikit => "hasSirikit",
                BuildsGetInstanceFieldsBuildBundle.IncludesSymbols => "includesSymbols",
                BuildsGetInstanceFieldsBuildBundle.IsIosBuildMacAppStoreCompatible => "isIosBuildMacAppStoreCompatible",
                BuildsGetInstanceFieldsBuildBundle.Locales => "locales",
                BuildsGetInstanceFieldsBuildBundle.MinimumOsVersion => "minimumOsVersion",
                BuildsGetInstanceFieldsBuildBundle.PlatformBuild => "platformBuild",
                BuildsGetInstanceFieldsBuildBundle.RequiredCapabilities => "requiredCapabilities",
                BuildsGetInstanceFieldsBuildBundle.SdkBuild => "sdkBuild",
                BuildsGetInstanceFieldsBuildBundle.SupportedArchitectures => "supportedArchitectures",
                BuildsGetInstanceFieldsBuildBundle.UsesLocationServices => "usesLocationServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBuildBundle? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainCacheStatus" => BuildsGetInstanceFieldsBuildBundle.AppClipDomainCacheStatus,
                "appClipDomainDebugStatus" => BuildsGetInstanceFieldsBuildBundle.AppClipDomainDebugStatus,
                "baDownloadAllowance" => BuildsGetInstanceFieldsBuildBundle.BaDownloadAllowance,
                "baMaxInstallSize" => BuildsGetInstanceFieldsBuildBundle.BaMaxInstallSize,
                "betaAppClipInvocations" => BuildsGetInstanceFieldsBuildBundle.BetaAppClipInvocations,
                "buildBundleFileSizes" => BuildsGetInstanceFieldsBuildBundle.BuildBundleFileSizes,
                "bundleId" => BuildsGetInstanceFieldsBuildBundle.BundleId,
                "bundleType" => BuildsGetInstanceFieldsBuildBundle.BundleType,
                "dSYMUrl" => BuildsGetInstanceFieldsBuildBundle.DSYMUrl,
                "deviceProtocols" => BuildsGetInstanceFieldsBuildBundle.DeviceProtocols,
                "entitlements" => BuildsGetInstanceFieldsBuildBundle.Entitlements,
                "fileName" => BuildsGetInstanceFieldsBuildBundle.FileName,
                "hasOnDemandResources" => BuildsGetInstanceFieldsBuildBundle.HasOnDemandResources,
                "hasPrerenderedIcon" => BuildsGetInstanceFieldsBuildBundle.HasPrerenderedIcon,
                "hasSirikit" => BuildsGetInstanceFieldsBuildBundle.HasSirikit,
                "includesSymbols" => BuildsGetInstanceFieldsBuildBundle.IncludesSymbols,
                "isIosBuildMacAppStoreCompatible" => BuildsGetInstanceFieldsBuildBundle.IsIosBuildMacAppStoreCompatible,
                "locales" => BuildsGetInstanceFieldsBuildBundle.Locales,
                "minimumOsVersion" => BuildsGetInstanceFieldsBuildBundle.MinimumOsVersion,
                "platformBuild" => BuildsGetInstanceFieldsBuildBundle.PlatformBuild,
                "requiredCapabilities" => BuildsGetInstanceFieldsBuildBundle.RequiredCapabilities,
                "sdkBuild" => BuildsGetInstanceFieldsBuildBundle.SdkBuild,
                "supportedArchitectures" => BuildsGetInstanceFieldsBuildBundle.SupportedArchitectures,
                "usesLocationServices" => BuildsGetInstanceFieldsBuildBundle.UsesLocationServices,
                _ => null,
            };
        }
    }
}