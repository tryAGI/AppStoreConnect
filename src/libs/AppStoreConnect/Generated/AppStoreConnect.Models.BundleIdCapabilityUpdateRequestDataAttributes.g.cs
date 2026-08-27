
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BundleIdCapabilityUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilityType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CapabilityTypeJsonConverter))]
        public global::AppStoreConnect.CapabilityType? CapabilityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CapabilitySetting>? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCapabilityUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="capabilityType"></param>
        /// <param name="settings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BundleIdCapabilityUpdateRequestDataAttributes(
            global::AppStoreConnect.CapabilityType? capabilityType,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CapabilitySetting>? settings)
        {
            this.CapabilityType = capabilityType;
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCapabilityUpdateRequestDataAttributes" /> class.
        /// </summary>
        public BundleIdCapabilityUpdateRequestDataAttributes()
        {
        }

    }
}