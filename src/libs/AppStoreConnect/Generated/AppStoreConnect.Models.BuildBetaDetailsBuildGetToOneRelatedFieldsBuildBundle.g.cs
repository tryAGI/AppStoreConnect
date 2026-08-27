
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.AppClipDomainCacheStatus => "appClipDomainCacheStatus",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.AppClipDomainDebugStatus => "appClipDomainDebugStatus",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BaDownloadAllowance => "baDownloadAllowance",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BaMaxInstallSize => "baMaxInstallSize",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BetaAppClipInvocations => "betaAppClipInvocations",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BuildBundleFileSizes => "buildBundleFileSizes",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BundleId => "bundleId",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BundleType => "bundleType",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.DSYMUrl => "dSYMUrl",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.DeviceProtocols => "deviceProtocols",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.Entitlements => "entitlements",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.FileName => "fileName",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.HasOnDemandResources => "hasOnDemandResources",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.HasPrerenderedIcon => "hasPrerenderedIcon",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.HasSirikit => "hasSirikit",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.IncludesSymbols => "includesSymbols",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.IsIosBuildMacAppStoreCompatible => "isIosBuildMacAppStoreCompatible",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.Locales => "locales",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.MinimumOsVersion => "minimumOsVersion",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.PlatformBuild => "platformBuild",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.RequiredCapabilities => "requiredCapabilities",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.SdkBuild => "sdkBuild",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.SupportedArchitectures => "supportedArchitectures",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.UsesLocationServices => "usesLocationServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainCacheStatus" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.AppClipDomainCacheStatus,
                "appClipDomainDebugStatus" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.AppClipDomainDebugStatus,
                "baDownloadAllowance" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BaDownloadAllowance,
                "baMaxInstallSize" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BaMaxInstallSize,
                "betaAppClipInvocations" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BetaAppClipInvocations,
                "buildBundleFileSizes" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BuildBundleFileSizes,
                "bundleId" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BundleId,
                "bundleType" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.BundleType,
                "dSYMUrl" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.DSYMUrl,
                "deviceProtocols" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.DeviceProtocols,
                "entitlements" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.Entitlements,
                "fileName" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.FileName,
                "hasOnDemandResources" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.HasOnDemandResources,
                "hasPrerenderedIcon" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.HasPrerenderedIcon,
                "hasSirikit" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.HasSirikit,
                "includesSymbols" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.IncludesSymbols,
                "isIosBuildMacAppStoreCompatible" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.IsIosBuildMacAppStoreCompatible,
                "locales" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.Locales,
                "minimumOsVersion" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.MinimumOsVersion,
                "platformBuild" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.PlatformBuild,
                "requiredCapabilities" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.RequiredCapabilities,
                "sdkBuild" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.SdkBuild,
                "supportedArchitectures" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.SupportedArchitectures,
                "usesLocationServices" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildBundle.UsesLocationServices,
                _ => null,
            };
        }
    }
}