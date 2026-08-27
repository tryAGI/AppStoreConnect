
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAppClipInvocationLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaAppClipInvocation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BetaAppClipInvocationLocalizationCreateRequestDataRelationshipsBetaAppClipInvocation BetaAppClipInvocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="betaAppClipInvocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppClipInvocationLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.BetaAppClipInvocationLocalizationCreateRequestDataRelationshipsBetaAppClipInvocation betaAppClipInvocation)
        {
            this.BetaAppClipInvocation = betaAppClipInvocation ?? throw new global::System.ArgumentNullException(nameof(betaAppClipInvocation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public BetaAppClipInvocationLocalizationCreateRequestDataRelationships()
        {
        }

    }
}