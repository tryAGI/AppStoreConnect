
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxTesters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationshipsSandboxTesters SandboxTesters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="sandboxTesters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships(
            global::AppStoreConnect.SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationshipsSandboxTesters sandboxTesters)
        {
            this.SandboxTesters = sandboxTesters ?? throw new global::System.ArgumentNullException(nameof(sandboxTesters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships" /> class.
        /// </summary>
        public SandboxTestersClearPurchaseHistoryRequestV2CreateRequestDataRelationships()
        {
        }

    }
}