
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminator(
            global::AppStoreConnect.GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminator" /> class.
        /// </summary>
        public GameCenterAchievementLocalizationV2ResponseIncludedItemDiscriminator()
        {
        }

    }
}