
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAppClipInvocationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildBundle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundle BuildBundle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaAppClipInvocationLocalizations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizations BetaAppClipInvocationLocalizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="buildBundle"></param>
        /// <param name="betaAppClipInvocationLocalizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppClipInvocationCreateRequestDataRelationships(
            global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundle buildBundle,
            global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizations betaAppClipInvocationLocalizations)
        {
            this.BuildBundle = buildBundle ?? throw new global::System.ArgumentNullException(nameof(buildBundle));
            this.BetaAppClipInvocationLocalizations = betaAppClipInvocationLocalizations ?? throw new global::System.ArgumentNullException(nameof(betaAppClipInvocationLocalizations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationCreateRequestDataRelationships" /> class.
        /// </summary>
        public BetaAppClipInvocationCreateRequestDataRelationships()
        {
        }

    }
}