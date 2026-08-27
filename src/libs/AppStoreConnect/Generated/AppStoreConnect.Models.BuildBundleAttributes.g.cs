
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildBundleAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BuildBundleType2JsonConverter))]
        public global::AppStoreConnect.BuildBundleType2? BundleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdkBuild")]
        public string? SdkBuild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platformBuild")]
        public string? PlatformBuild { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasSirikit")]
        public bool? HasSirikit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasOnDemandResources")]
        public bool? HasOnDemandResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasPrerenderedIcon")]
        public bool? HasPrerenderedIcon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usesLocationServices")]
        public bool? UsesLocationServices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isIosBuildMacAppStoreCompatible")]
        public bool? IsIosBuildMacAppStoreCompatible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includesSymbols")]
        public bool? IncludesSymbols { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dSYMUrl")]
        public string? DSYMUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedArchitectures")]
        public global::System.Collections.Generic.IList<string>? SupportedArchitectures { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requiredCapabilities")]
        public global::System.Collections.Generic.IList<string>? RequiredCapabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceProtocols")]
        public global::System.Collections.Generic.IList<string>? DeviceProtocols { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locales")]
        public global::System.Collections.Generic.IList<string>? Locales { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? Entitlements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baDownloadAllowance")]
        public int? BaDownloadAllowance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baMaxInstallSize")]
        public int? BaMaxInstallSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumOsVersion")]
        public string? MinimumOsVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleAttributes" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="bundleType"></param>
        /// <param name="sdkBuild"></param>
        /// <param name="platformBuild"></param>
        /// <param name="fileName"></param>
        /// <param name="hasSirikit"></param>
        /// <param name="hasOnDemandResources"></param>
        /// <param name="hasPrerenderedIcon"></param>
        /// <param name="usesLocationServices"></param>
        /// <param name="isIosBuildMacAppStoreCompatible"></param>
        /// <param name="includesSymbols"></param>
        /// <param name="dSYMUrl"></param>
        /// <param name="supportedArchitectures"></param>
        /// <param name="requiredCapabilities"></param>
        /// <param name="deviceProtocols"></param>
        /// <param name="locales"></param>
        /// <param name="entitlements"></param>
        /// <param name="baDownloadAllowance"></param>
        /// <param name="baMaxInstallSize"></param>
        /// <param name="minimumOsVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildBundleAttributes(
            string? bundleId,
            global::AppStoreConnect.BuildBundleType2? bundleType,
            string? sdkBuild,
            string? platformBuild,
            string? fileName,
            bool? hasSirikit,
            bool? hasOnDemandResources,
            bool? hasPrerenderedIcon,
            bool? usesLocationServices,
            bool? isIosBuildMacAppStoreCompatible,
            bool? includesSymbols,
            string? dSYMUrl,
            global::System.Collections.Generic.IList<string>? supportedArchitectures,
            global::System.Collections.Generic.IList<string>? requiredCapabilities,
            global::System.Collections.Generic.IList<string>? deviceProtocols,
            global::System.Collections.Generic.IList<string>? locales,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<string, string>>? entitlements,
            int? baDownloadAllowance,
            int? baMaxInstallSize,
            string? minimumOsVersion)
        {
            this.BundleId = bundleId;
            this.BundleType = bundleType;
            this.SdkBuild = sdkBuild;
            this.PlatformBuild = platformBuild;
            this.FileName = fileName;
            this.HasSirikit = hasSirikit;
            this.HasOnDemandResources = hasOnDemandResources;
            this.HasPrerenderedIcon = hasPrerenderedIcon;
            this.UsesLocationServices = usesLocationServices;
            this.IsIosBuildMacAppStoreCompatible = isIosBuildMacAppStoreCompatible;
            this.IncludesSymbols = includesSymbols;
            this.DSYMUrl = dSYMUrl;
            this.SupportedArchitectures = supportedArchitectures;
            this.RequiredCapabilities = requiredCapabilities;
            this.DeviceProtocols = deviceProtocols;
            this.Locales = locales;
            this.Entitlements = entitlements;
            this.BaDownloadAllowance = baDownloadAllowance;
            this.BaMaxInstallSize = baMaxInstallSize;
            this.MinimumOsVersion = minimumOsVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleAttributes" /> class.
        /// </summary>
        public BuildBundleAttributes()
        {
        }

    }
}