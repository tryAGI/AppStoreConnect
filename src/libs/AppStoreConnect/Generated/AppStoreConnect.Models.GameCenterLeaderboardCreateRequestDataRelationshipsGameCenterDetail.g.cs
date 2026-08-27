
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::AppStoreConnect.GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterDetailData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterDetail" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterDetail(
            global::AppStoreConnect.GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterDetailData? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterDetail" /> class.
        /// </summary>
        public GameCenterLeaderboardCreateRequestDataRelationshipsGameCenterDetail()
        {
        }

    }
}