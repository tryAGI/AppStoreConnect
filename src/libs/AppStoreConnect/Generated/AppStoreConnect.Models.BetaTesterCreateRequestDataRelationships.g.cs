
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaTesterCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaGroups")]
        public global::AppStoreConnect.BetaTesterCreateRequestDataRelationshipsBetaGroups? BetaGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::AppStoreConnect.BetaTesterCreateRequestDataRelationshipsBuilds? Builds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="betaGroups"></param>
        /// <param name="builds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterCreateRequestDataRelationships(
            global::AppStoreConnect.BetaTesterCreateRequestDataRelationshipsBetaGroups? betaGroups,
            global::AppStoreConnect.BetaTesterCreateRequestDataRelationshipsBuilds? builds)
        {
            this.BetaGroups = betaGroups;
            this.Builds = builds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterCreateRequestDataRelationships" /> class.
        /// </summary>
        public BetaTesterCreateRequestDataRelationships()
        {
        }

    }
}