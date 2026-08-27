
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementLocalizationV2UpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeEarnedDescription")]
        public string? BeforeEarnedDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afterEarnedDescription")]
        public string? AfterEarnedDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationV2UpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="beforeEarnedDescription"></param>
        /// <param name="afterEarnedDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementLocalizationV2UpdateRequestDataAttributes(
            string? name,
            string? beforeEarnedDescription,
            string? afterEarnedDescription)
        {
            this.Name = name;
            this.BeforeEarnedDescription = beforeEarnedDescription;
            this.AfterEarnedDescription = afterEarnedDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationV2UpdateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterAchievementLocalizationV2UpdateRequestDataAttributes()
        {
        }

    }
}