
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreReviewDetailCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreReviewDetailCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.AppStoreReviewDetailCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.AppStoreReviewDetailCreateRequestDataAttributes? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppStoreReviewDetailCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewDetailCreateRequestData" /> class.
        /// </summary>
        /// <param name="relationships"></param>
        /// <param name="type"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreReviewDetailCreateRequestData(
            global::AppStoreConnect.AppStoreReviewDetailCreateRequestDataRelationships relationships,
            global::AppStoreConnect.AppStoreReviewDetailCreateRequestDataType type,
            global::AppStoreConnect.AppStoreReviewDetailCreateRequestDataAttributes? attributes)
        {
            this.Type = type;
            this.Attributes = attributes;
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewDetailCreateRequestData" /> class.
        /// </summary>
        public AppStoreReviewDetailCreateRequestData()
        {
        }

    }
}