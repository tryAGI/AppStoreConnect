
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingTeamCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minPlayers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinPlayers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPlayers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxPlayers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTeamCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="minPlayers"></param>
        /// <param name="maxPlayers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingTeamCreateRequestDataAttributes(
            string referenceName,
            int minPlayers,
            int maxPlayers)
        {
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
            this.MinPlayers = minPlayers;
            this.MaxPlayers = maxPlayers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTeamCreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingTeamCreateRequestDataAttributes()
        {
        }

    }
}