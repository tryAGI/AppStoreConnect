
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingTestPlayerPropertyInlineCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestPlayerPropertyInlineCreateTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestPlayerPropertyInlineCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingTestPlayerPropertyInlineCreate(
            global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateType type,
            string? id,
            global::AppStoreConnect.GameCenterMatchmakingTestPlayerPropertyInlineCreateAttributes? attributes)
        {
            this.Type = type;
            this.Id = id;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestPlayerPropertyInlineCreate" /> class.
        /// </summary>
        public GameCenterMatchmakingTestPlayerPropertyInlineCreate()
        {
        }

    }
}