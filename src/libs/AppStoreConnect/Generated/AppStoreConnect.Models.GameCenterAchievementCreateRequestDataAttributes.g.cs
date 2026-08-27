
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterAchievementCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("vendorIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VendorIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Points { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("showBeforeEarned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ShowBeforeEarned { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeatable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Repeatable { get; set; }

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
        /// Initializes a new instance of the <see cref="GameCenterAchievementCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="points"></param>
        /// <param name="showBeforeEarned"></param>
        /// <param name="repeatable"></param>
        /// <param name="activityProperties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementCreateRequestDataAttributes(
            string referenceName,
            string vendorIdentifier,
            int points,
            bool showBeforeEarned,
            bool repeatable,
            global::System.Collections.Generic.Dictionary<string, string>? activityProperties)
        {
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
            this.VendorIdentifier = vendorIdentifier ?? throw new global::System.ArgumentNullException(nameof(vendorIdentifier));
            this.Points = points;
            this.ShowBeforeEarned = showBeforeEarned;
            this.Repeatable = repeatable;
            this.ActivityProperties = activityProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementCreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterAchievementCreateRequestDataAttributes()
        {
        }

    }
}