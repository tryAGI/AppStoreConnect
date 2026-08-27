
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BundleIdCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seedId")]
        public string? SeedId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="platform"></param>
        /// <param name="identifier"></param>
        /// <param name="seedId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BundleIdCreateRequestDataAttributes(
            string name,
            global::AppStoreConnect.BundleIdPlatform platform,
            string identifier,
            string? seedId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Platform = platform;
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.SeedId = seedId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCreateRequestDataAttributes" /> class.
        /// </summary>
        public BundleIdCreateRequestDataAttributes()
        {
        }

    }
}