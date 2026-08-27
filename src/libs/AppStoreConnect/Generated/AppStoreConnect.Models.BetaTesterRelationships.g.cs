
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaTesterRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::AppStoreConnect.BetaTesterRelationshipsApps? Apps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaGroups")]
        public global::AppStoreConnect.BetaTesterRelationshipsBetaGroups? BetaGroups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::AppStoreConnect.BetaTesterRelationshipsBuilds? Builds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterRelationships" /> class.
        /// </summary>
        /// <param name="apps"></param>
        /// <param name="betaGroups"></param>
        /// <param name="builds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterRelationships(
            global::AppStoreConnect.BetaTesterRelationshipsApps? apps,
            global::AppStoreConnect.BetaTesterRelationshipsBetaGroups? betaGroups,
            global::AppStoreConnect.BetaTesterRelationshipsBuilds? builds)
        {
            this.Apps = apps;
            this.BetaGroups = betaGroups;
            this.Builds = builds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterRelationships" /> class.
        /// </summary>
        public BetaTesterRelationships()
        {
        }

    }
}