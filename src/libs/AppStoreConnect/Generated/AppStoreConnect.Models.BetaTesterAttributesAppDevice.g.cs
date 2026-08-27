
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTesterAttributesAppDevice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BetaTesterAttributesAppDevicePlatformJsonConverter))]
        public global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("osVersion")]
        public string? OsVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appBuildVersion")]
        public string? AppBuildVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterAttributesAppDevice" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="platform"></param>
        /// <param name="osVersion"></param>
        /// <param name="appBuildVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterAttributesAppDevice(
            string? model,
            global::AppStoreConnect.BetaTesterAttributesAppDevicePlatform? platform,
            string? osVersion,
            string? appBuildVersion)
        {
            this.Model = model;
            this.Platform = platform;
            this.OsVersion = osVersion;
            this.AppBuildVersion = appBuildVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterAttributesAppDevice" /> class.
        /// </summary>
        public BetaTesterAttributesAppDevice()
        {
        }

    }
}