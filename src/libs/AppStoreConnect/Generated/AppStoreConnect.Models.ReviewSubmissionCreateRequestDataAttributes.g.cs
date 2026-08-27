
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewSubmissionCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="platform"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewSubmissionCreateRequestDataAttributes(
            global::AppStoreConnect.Platform? platform)
        {
            this.Platform = platform;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionCreateRequestDataAttributes" /> class.
        /// </summary>
        public ReviewSubmissionCreateRequestDataAttributes()
        {
        }

    }
}