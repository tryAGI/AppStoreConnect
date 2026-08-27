
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playerId")]
        public string? PlayerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.Property>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes(
            string? playerId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.Property>? properties)
        {
            this.PlayerId = playerId;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes()
        {
        }

    }
}