
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterActivityImageCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localization")]
        public global::AppStoreConnect.GameCenterActivityImageCreateRequestDataRelationshipsLocalization? Localization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::AppStoreConnect.GameCenterActivityImageCreateRequestDataRelationshipsVersion? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityImageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="localization"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityImageCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterActivityImageCreateRequestDataRelationshipsLocalization? localization,
            global::AppStoreConnect.GameCenterActivityImageCreateRequestDataRelationshipsVersion? version)
        {
            this.Localization = localization;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityImageCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterActivityImageCreateRequestDataRelationships()
        {
        }

    }
}