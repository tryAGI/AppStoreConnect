
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGroupCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BetaGroupCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::AppStoreConnect.BetaGroupCreateRequestDataRelationshipsBuilds? Builds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaTesters")]
        public global::AppStoreConnect.BetaGroupCreateRequestDataRelationshipsBetaTesters? BetaTesters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="builds"></param>
        /// <param name="betaTesters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGroupCreateRequestDataRelationships(
            global::AppStoreConnect.BetaGroupCreateRequestDataRelationshipsApp app,
            global::AppStoreConnect.BetaGroupCreateRequestDataRelationshipsBuilds? builds,
            global::AppStoreConnect.BetaGroupCreateRequestDataRelationshipsBetaTesters? betaTesters)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Builds = builds;
            this.BetaTesters = betaTesters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGroupCreateRequestDataRelationships" /> class.
        /// </summary>
        public BetaGroupCreateRequestDataRelationships()
        {
        }

    }
}