
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementLocalizationV2CreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beforeEarnedDescription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BeforeEarnedDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("afterEarnedDescription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AfterEarnedDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationV2CreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="name"></param>
        /// <param name="beforeEarnedDescription"></param>
        /// <param name="afterEarnedDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementLocalizationV2CreateRequestDataAttributes(
            string locale,
            string name,
            string beforeEarnedDescription,
            string afterEarnedDescription)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.BeforeEarnedDescription = beforeEarnedDescription ?? throw new global::System.ArgumentNullException(nameof(beforeEarnedDescription));
            this.AfterEarnedDescription = afterEarnedDescription ?? throw new global::System.ArgumentNullException(nameof(afterEarnedDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationV2CreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterAchievementLocalizationV2CreateRequestDataAttributes()
        {
        }

    }
}