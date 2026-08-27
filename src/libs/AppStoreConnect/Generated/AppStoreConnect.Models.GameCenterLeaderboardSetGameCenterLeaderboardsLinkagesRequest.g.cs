
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest(
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequestDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest" /> class.
        /// </summary>
        public GameCenterLeaderboardSetGameCenterLeaderboardsLinkagesRequest()
        {
        }

    }
}