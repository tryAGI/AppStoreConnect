
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeviceCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BundleIdPlatform Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("udid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Udid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="platform"></param>
        /// <param name="udid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeviceCreateRequestDataAttributes(
            string name,
            global::AppStoreConnect.BundleIdPlatform platform,
            string udid)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Platform = platform;
            this.Udid = udid ?? throw new global::System.ArgumentNullException(nameof(udid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCreateRequestDataAttributes" /> class.
        /// </summary>
        public DeviceCreateRequestDataAttributes()
        {
        }

    }
}