
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetLocalizationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetLocalizationAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetLocalizationAttributes(
            string? locale,
            string? name)
        {
            this.Locale = locale;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetLocalizationAttributes" /> class.
        /// </summary>
        public GameCenterLeaderboardSetLocalizationAttributes()
        {
        }

    }
}