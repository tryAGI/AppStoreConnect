
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        public int? Points { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("showBeforeEarned")]
        public bool? ShowBeforeEarned { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeatable")]
        public bool? Repeatable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activityProperties")]
        public global::System.Collections.Generic.Dictionary<string, string>? ActivityProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="points"></param>
        /// <param name="showBeforeEarned"></param>
        /// <param name="repeatable"></param>
        /// <param name="archived"></param>
        /// <param name="activityProperties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementUpdateRequestDataAttributes(
            string? referenceName,
            int? points,
            bool? showBeforeEarned,
            bool? repeatable,
            bool? archived,
            global::System.Collections.Generic.Dictionary<string, string>? activityProperties)
        {
            this.ReferenceName = referenceName;
            this.Points = points;
            this.ShowBeforeEarned = showBeforeEarned;
            this.Repeatable = repeatable;
            this.Archived = archived;
            this.ActivityProperties = activityProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementUpdateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterAchievementUpdateRequestDataAttributes()
        {
        }

    }
}