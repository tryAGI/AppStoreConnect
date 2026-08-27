
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CapabilityOption
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CapabilityOptionKeyJsonConverter))]
        public global::AppStoreConnect.CapabilityOptionKey? Key { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsWildcard")]
        public bool? SupportsWildcard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityOption" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="enabledByDefault"></param>
        /// <param name="enabled"></param>
        /// <param name="supportsWildcard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CapabilityOption(
            global::AppStoreConnect.CapabilityOptionKey? key,
            string? name,
            string? description,
            bool? enabledByDefault,
            bool? enabled,
            bool? supportsWildcard)
        {
            this.Key = key;
            this.Name = name;
            this.Description = description;
            this.EnabledByDefault = enabledByDefault;
            this.Enabled = enabled;
            this.SupportsWildcard = supportsWildcard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilityOption" /> class.
        /// </summary>
        public CapabilityOption()
        {
        }

    }
}