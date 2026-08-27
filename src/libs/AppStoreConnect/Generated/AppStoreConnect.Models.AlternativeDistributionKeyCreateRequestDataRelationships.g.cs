
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlternativeDistributionKeyCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.AlternativeDistributionKeyCreateRequestDataRelationshipsApp? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionKeyCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionKeyCreateRequestDataRelationships(
            global::AppStoreConnect.AlternativeDistributionKeyCreateRequestDataRelationshipsApp? app)
        {
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionKeyCreateRequestDataRelationships" /> class.
        /// </summary>
        public AlternativeDistributionKeyCreateRequestDataRelationships()
        {
        }

    }
}