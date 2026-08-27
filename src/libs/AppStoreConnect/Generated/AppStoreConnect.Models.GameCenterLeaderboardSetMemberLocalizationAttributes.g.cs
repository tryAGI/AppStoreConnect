
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetMemberLocalizationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetMemberLocalizationAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="locale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetMemberLocalizationAttributes(
            string? name,
            string? locale)
        {
            this.Name = name;
            this.Locale = locale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetMemberLocalizationAttributes" /> class.
        /// </summary>
        public GameCenterLeaderboardSetMemberLocalizationAttributes()
        {
        }

    }
}