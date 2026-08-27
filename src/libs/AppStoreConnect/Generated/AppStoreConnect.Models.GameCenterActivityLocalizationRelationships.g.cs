
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterActivityLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public global::AppStoreConnect.GameCenterActivityLocalizationRelationshipsVersion? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::AppStoreConnect.GameCenterActivityLocalizationRelationshipsImage? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityLocalizationRelationships(
            global::AppStoreConnect.GameCenterActivityLocalizationRelationshipsVersion? version,
            global::AppStoreConnect.GameCenterActivityLocalizationRelationshipsImage? image)
        {
            this.Version = version;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityLocalizationRelationships" /> class.
        /// </summary>
        public GameCenterActivityLocalizationRelationships()
        {
        }

    }
}