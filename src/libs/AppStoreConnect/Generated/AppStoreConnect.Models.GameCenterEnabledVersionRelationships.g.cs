
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterEnabledVersionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatibleVersions")]
        public global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersions? CompatibleVersions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.GameCenterEnabledVersionRelationshipsApp? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterEnabledVersionRelationships" /> class.
        /// </summary>
        /// <param name="compatibleVersions"></param>
        /// <param name="app"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterEnabledVersionRelationships(
            global::AppStoreConnect.GameCenterEnabledVersionRelationshipsCompatibleVersions? compatibleVersions,
            global::AppStoreConnect.GameCenterEnabledVersionRelationshipsApp? app)
        {
            this.CompatibleVersions = compatibleVersions;
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterEnabledVersionRelationships" /> class.
        /// </summary>
        public GameCenterEnabledVersionRelationships()
        {
        }

    }
}