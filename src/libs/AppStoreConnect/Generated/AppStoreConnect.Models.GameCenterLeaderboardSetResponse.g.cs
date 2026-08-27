
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GameCenterLeaderboardSetResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::AppStoreConnect.GameCenterLeaderboardSet Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem125>? Included { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required global::AppStoreConnect.DocumentLinks Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="links"></param>
        /// <param name="included"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetResponse(
            global::AppStoreConnect.GameCenterLeaderboardSet data,
            global::AppStoreConnect.DocumentLinks links,
            global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem125>? included)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Included = included;
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetResponse" /> class.
        /// </summary>
        public GameCenterLeaderboardSetResponse()
        {
        }

    }
}