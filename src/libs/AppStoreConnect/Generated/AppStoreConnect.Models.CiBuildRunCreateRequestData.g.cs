
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildRunCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiBuildRunCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.CiBuildRunCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.CiBuildRunCreateRequestDataAttributes? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.CiBuildRunCreateRequestDataRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunCreateRequestData" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiBuildRunCreateRequestData(
            global::AppStoreConnect.CiBuildRunCreateRequestDataType type,
            global::AppStoreConnect.CiBuildRunCreateRequestDataAttributes? attributes,
            global::AppStoreConnect.CiBuildRunCreateRequestDataRelationships? relationships)
        {
            this.Type = type;
            this.Attributes = attributes;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiBuildRunCreateRequestData" /> class.
        /// </summary>
        public CiBuildRunCreateRequestData()
        {
        }

    }
}