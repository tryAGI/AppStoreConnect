
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.AppClipDomainCacheStatus => "appClipDomainCacheStatus",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.AppClipDomainDebugStatus => "appClipDomainDebugStatus",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BaDownloadAllowance => "baDownloadAllowance",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BaMaxInstallSize => "baMaxInstallSize",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BetaAppClipInvocations => "betaAppClipInvocations",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BuildBundleFileSizes => "buildBundleFileSizes",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BundleId => "bundleId",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BundleType => "bundleType",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.DSYMUrl => "dSYMUrl",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.DeviceProtocols => "deviceProtocols",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.Entitlements => "entitlements",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.FileName => "fileName",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.HasOnDemandResources => "hasOnDemandResources",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.HasPrerenderedIcon => "hasPrerenderedIcon",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.HasSirikit => "hasSirikit",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.IncludesSymbols => "includesSymbols",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.IsIosBuildMacAppStoreCompatible => "isIosBuildMacAppStoreCompatible",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.Locales => "locales",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.MinimumOsVersion => "minimumOsVersion",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.PlatformBuild => "platformBuild",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.RequiredCapabilities => "requiredCapabilities",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.SdkBuild => "sdkBuild",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.SupportedArchitectures => "supportedArchitectures",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.UsesLocationServices => "usesLocationServices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainCacheStatus" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.AppClipDomainCacheStatus,
                "appClipDomainDebugStatus" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.AppClipDomainDebugStatus,
                "baDownloadAllowance" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BaDownloadAllowance,
                "baMaxInstallSize" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BaMaxInstallSize,
                "betaAppClipInvocations" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BetaAppClipInvocations,
                "buildBundleFileSizes" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BuildBundleFileSizes,
                "bundleId" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BundleId,
                "bundleType" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.BundleType,
                "dSYMUrl" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.DSYMUrl,
                "deviceProtocols" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.DeviceProtocols,
                "entitlements" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.Entitlements,
                "fileName" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.FileName,
                "hasOnDemandResources" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.HasOnDemandResources,
                "hasPrerenderedIcon" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.HasPrerenderedIcon,
                "hasSirikit" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.HasSirikit,
                "includesSymbols" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.IncludesSymbols,
                "isIosBuildMacAppStoreCompatible" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.IsIosBuildMacAppStoreCompatible,
                "locales" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.Locales,
                "minimumOsVersion" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.MinimumOsVersion,
                "platformBuild" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.PlatformBuild,
                "requiredCapabilities" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.RequiredCapabilities,
                "sdkBuild" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.SdkBuild,
                "supportedArchitectures" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.SupportedArchitectures,
                "usesLocationServices" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildBundle.UsesLocationServices,
                _ => null,
            };
        }
    }
}