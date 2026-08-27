
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetsV2Response
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem122>? Included { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.PagedDocumentLinks Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::AppStoreConnect.PagingInformation? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetsV2Response" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="links"></param>
        /// <param name="included"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetsV2Response(
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetV2> data,
            global::AppStoreConnect.PagedDocumentLinks links,
            global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem122>? included,
            global::AppStoreConnect.PagingInformation? meta)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Included = included;
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetsV2Response" /> class.
        /// </summary>
        public GameCenterLeaderboardSetsV2Response()
        {
        }

    }
}