
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingTeamAssignment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playerId")]
        public string? PlayerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        public string? Team { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTeamAssignment" /> class.
        /// </summary>
        /// <param name="playerId"></param>
        /// <param name="team"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingTeamAssignment(
            string? playerId,
            string? team)
        {
            this.PlayerId = playerId;
            this.Team = team;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTeamAssignment" /> class.
        /// </summary>
        public GameCenterMatchmakingTeamAssignment()
        {
        }

    }
}