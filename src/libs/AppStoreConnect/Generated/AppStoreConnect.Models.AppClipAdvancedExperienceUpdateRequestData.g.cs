
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceUpdateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributes? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceUpdateRequestData(
            string id,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataType type,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributes? attributes,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataRelationships? relationships)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Attributes = attributes;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestData" /> class.
        /// </summary>
        public AppClipAdvancedExperienceUpdateRequestData()
        {
        }

    }
}