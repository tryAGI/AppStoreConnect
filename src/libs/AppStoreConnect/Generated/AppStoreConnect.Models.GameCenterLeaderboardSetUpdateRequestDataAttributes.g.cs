
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetUpdateRequestDataAttributes(
            string? referenceName)
        {
            this.ReferenceName = referenceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetUpdateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterLeaderboardSetUpdateRequestDataAttributes()
        {
        }

    }
}