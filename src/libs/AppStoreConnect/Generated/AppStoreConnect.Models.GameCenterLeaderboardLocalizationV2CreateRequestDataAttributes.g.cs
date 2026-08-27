
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardLocalizationV2CreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("formatterOverride")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterJsonConverter))]
        public global::AppStoreConnect.GameCenterLeaderboardFormatter? FormatterOverride { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatterSuffix")]
        public string? FormatterSuffix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatterSuffixSingular")]
        public string? FormatterSuffixSingular { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardLocalizationV2CreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="name"></param>
        /// <param name="formatterOverride"></param>
        /// <param name="formatterSuffix"></param>
        /// <param name="formatterSuffixSingular"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardLocalizationV2CreateRequestDataAttributes(
            string locale,
            string name,
            global::AppStoreConnect.GameCenterLeaderboardFormatter? formatterOverride,
            string? formatterSuffix,
            string? formatterSuffixSingular,
            string? description)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FormatterOverride = formatterOverride;
            this.FormatterSuffix = formatterSuffix;
            this.FormatterSuffixSingular = formatterSuffixSingular;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardLocalizationV2CreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterLeaderboardLocalizationV2CreateRequestDataAttributes()
        {
        }

    }
}