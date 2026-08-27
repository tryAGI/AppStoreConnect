
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterActivityCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterActivityCreateRequestDataRelationshipsVersions? versions)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterActivityCreateRequestDataRelationships()
        {
        }

    }
}