
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionPhasedReleaseCreateRequestData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppStoreVersionPhasedReleaseCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.AppStoreVersionPhasedReleaseCreateRequestDataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.AppStoreVersionPhasedReleaseCreateRequestDataAttributes? Attributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppStoreVersionPhasedReleaseCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPhasedReleaseCreateRequestData" /> class.
        /// </summary>
        /// <param name="relationships"></param>
        /// <param name="type"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionPhasedReleaseCreateRequestData(
            global::AppStoreConnect.AppStoreVersionPhasedReleaseCreateRequestDataRelationships relationships,
            global::AppStoreConnect.AppStoreVersionPhasedReleaseCreateRequestDataType type,
            global::AppStoreConnect.AppStoreVersionPhasedReleaseCreateRequestDataAttributes? attributes)
        {
            this.Type = type;
            this.Attributes = attributes;
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionPhasedReleaseCreateRequestData" /> class.
        /// </summary>
        public AppStoreVersionPhasedReleaseCreateRequestData()
        {
        }

    }
}