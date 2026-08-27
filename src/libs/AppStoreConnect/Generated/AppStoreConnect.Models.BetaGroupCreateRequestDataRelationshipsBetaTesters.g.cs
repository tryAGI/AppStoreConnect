
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGroupCreateRequestDataRelationshipsBetaTesters
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupCreateRequestDataRelationshipsBetaTestersDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataRelationshipsBetaTesters" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGroupCreateRequestDataRelationshipsBetaTesters(
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupCreateRequestDataRelationshipsBetaTestersDataItem>? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataRelationshipsBetaTesters" /> class.
        /// </summary>
        public BetaGroupCreateRequestDataRelationshipsBetaTesters()
        {
        }

    }
}