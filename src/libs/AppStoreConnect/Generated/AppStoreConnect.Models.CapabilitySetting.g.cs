
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CapabilitySetting
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CapabilitySettingKeyJsonConverter))]
        public global::AppStoreConnect.CapabilitySettingKey? Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabledByDefault")]
        public bool? EnabledByDefault { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedInstances")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CapabilitySettingAllowedInstancesJsonConverter))]
        public global::AppStoreConnect.CapabilitySettingAllowedInstances? AllowedInstances { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minInstances")]
        public int? MinInstances { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CapabilityOption>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilitySetting" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="enabledByDefault"></param>
        /// <param name="visible"></param>
        /// <param name="allowedInstances"></param>
        /// <param name="minInstances"></param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CapabilitySetting(
            global::AppStoreConnect.CapabilitySettingKey? key,
            string? name,
            string? description,
            bool? enabledByDefault,
            bool? visible,
            global::AppStoreConnect.CapabilitySettingAllowedInstances? allowedInstances,
            int? minInstances,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CapabilityOption>? options)
        {
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.EnabledByDefault = enabledByDefault;
            this.Visible = visible;
            this.AllowedInstances = allowedInstances;
            this.MinInstances = minInstances;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilitySetting" /> class.
        /// </summary>
        public CapabilitySetting()
        {
        }

    }
}