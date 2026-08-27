
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardImageV2CreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardImageV2CreateRequestDataRelationshipsLocalization Localization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardImageV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="localization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardImageV2CreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardImageV2CreateRequestDataRelationshipsLocalization localization)
        {
            this.Localization = localization ?? throw new global::System.ArgumentNullException(nameof(localization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardImageV2CreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardImageV2CreateRequestDataRelationships()
        {
        }

    }
}