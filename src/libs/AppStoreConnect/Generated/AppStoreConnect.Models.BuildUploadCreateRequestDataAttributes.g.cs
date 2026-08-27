
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildUploadCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfBundleShortVersionString")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CfBundleShortVersionString { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfBundleVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CfBundleVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.Platform Platform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="cfBundleShortVersionString"></param>
        /// <param name="cfBundleVersion"></param>
        /// <param name="platform"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildUploadCreateRequestDataAttributes(
            string cfBundleShortVersionString,
            string cfBundleVersion,
            global::AppStoreConnect.Platform platform)
        {
            this.CfBundleShortVersionString = cfBundleShortVersionString ?? throw new global::System.ArgumentNullException(nameof(cfBundleShortVersionString));
            this.CfBundleVersion = cfBundleVersion ?? throw new global::System.ArgumentNullException(nameof(cfBundleVersion));
            this.Platform = platform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadCreateRequestDataAttributes" /> class.
        /// </summary>
        public BuildUploadCreateRequestDataAttributes()
        {
        }

    }
}