
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAppClipInvocationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaAppClipInvocationLocalizations")]
        public global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizations? BetaAppClipInvocationLocalizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationRelationships" /> class.
        /// </summary>
        /// <param name="betaAppClipInvocationLocalizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppClipInvocationRelationships(
            global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizations? betaAppClipInvocationLocalizations)
        {
            this.BetaAppClipInvocationLocalizations = betaAppClipInvocationLocalizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationRelationships" /> class.
        /// </summary>
        public BetaAppClipInvocationRelationships()
        {
        }

    }
}