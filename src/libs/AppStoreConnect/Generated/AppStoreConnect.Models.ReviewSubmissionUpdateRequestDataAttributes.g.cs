
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewSubmissionUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted")]
        public bool? Submitted { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled")]
        public bool? Canceled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="submitted"></param>
        /// <param name="canceled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewSubmissionUpdateRequestDataAttributes(
            global::AppStoreConnect.Platform? platform,
            bool? submitted,
            bool? canceled)
        {
            this.Platform = platform;
            this.Submitted = submitted;
            this.Canceled = canceled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionUpdateRequestDataAttributes" /> class.
        /// </summary>
        public ReviewSubmissionUpdateRequestDataAttributes()
        {
        }

    }
}