
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrereleaseVersionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        public global::AppStoreConnect.PrereleaseVersionRelationshipsBuilds? Builds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.PrereleaseVersionRelationshipsApp? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrereleaseVersionRelationships" /> class.
        /// </summary>
        /// <param name="builds"></param>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrereleaseVersionRelationships(
            global::AppStoreConnect.PrereleaseVersionRelationshipsBuilds? builds,
            global::AppStoreConnect.PrereleaseVersionRelationshipsApp? app)
        {
            this.Builds = builds;
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrereleaseVersionRelationships" /> class.
        /// </summary>
        public PrereleaseVersionRelationships()
        {
        }

    }
}