
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAppClipInvocationLocalizationInlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaAppClipInvocation")]
        public global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation? BetaAppClipInvocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationLocalizationInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="betaAppClipInvocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppClipInvocationLocalizationInlineCreateRelationships(
            global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation? betaAppClipInvocation)
        {
            this.BetaAppClipInvocation = betaAppClipInvocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationLocalizationInlineCreateRelationships" /> class.
        /// </summary>
        public BetaAppClipInvocationLocalizationInlineCreateRelationships()
        {
        }

    }
}