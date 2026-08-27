
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeviceAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BundleIdPlatformJsonConverter))]
        public global::AppStoreConnect.BundleIdPlatform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("udid")]
        public string? Udid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceClass")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DeviceAttributesDeviceClassJsonConverter))]
        public global::AppStoreConnect.DeviceAttributesDeviceClass? DeviceClass { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DeviceAttributesStatusJsonConverter))]
        public global::AppStoreConnect.DeviceAttributesStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedDate")]
        public global::System.DateTime? AddedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="platform"></param>
        /// <param name="udid"></param>
        /// <param name="deviceClass"></param>
        /// <param name="status"></param>
        /// <param name="model"></param>
        /// <param name="addedDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeviceAttributes(
            string? name,
            global::AppStoreConnect.BundleIdPlatform? platform,
            string? udid,
            global::AppStoreConnect.DeviceAttributesDeviceClass? deviceClass,
            global::AppStoreConnect.DeviceAttributesStatus? status,
            string? model,
            global::System.DateTime? addedDate)
        {
            this.Name = name;
            this.Platform = platform;
            this.Udid = udid;
            this.DeviceClass = deviceClass;
            this.Status = status;
            this.Model = model;
            this.AddedDate = addedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceAttributes" /> class.
        /// </summary>
        public DeviceAttributes()
        {
        }

    }
}