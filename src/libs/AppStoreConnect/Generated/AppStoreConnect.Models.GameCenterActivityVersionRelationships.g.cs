
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterActivityVersionRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivity? Activity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultImage")]
        public global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImage? DefaultImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleases? Releases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionRelationships" /> class.
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="localizations"></param>
        /// <param name="defaultImage"></param>
        /// <param name="releases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityVersionRelationships(
            global::AppStoreConnect.GameCenterActivityVersionRelationshipsActivity? activity,
            global::AppStoreConnect.GameCenterActivityVersionRelationshipsLocalizations? localizations,
            global::AppStoreConnect.GameCenterActivityVersionRelationshipsDefaultImage? defaultImage,
            global::AppStoreConnect.GameCenterActivityVersionRelationshipsReleases? releases)
        {
            this.Activity = activity;
            this.Localizations = localizations;
            this.DefaultImage = defaultImage;
            this.Releases = releases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityVersionRelationships" /> class.
        /// </summary>
        public GameCenterActivityVersionRelationships()
        {
        }

    }
}