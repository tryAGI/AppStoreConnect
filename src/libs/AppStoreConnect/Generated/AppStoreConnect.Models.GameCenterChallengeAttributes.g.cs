
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterChallengeAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendorIdentifier")]
        public string? VendorIdentifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterChallengeAttributesChallengeTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterChallengeAttributesChallengeType? ChallengeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeatable")]
        public bool? Repeatable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="archived"></param>
        /// <param name="challengeType"></param>
        /// <param name="repeatable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeAttributes(
            string? referenceName,
            string? vendorIdentifier,
            bool? archived,
            global::AppStoreConnect.GameCenterChallengeAttributesChallengeType? challengeType,
            bool? repeatable)
        {
            this.ReferenceName = referenceName;
            this.VendorIdentifier = vendorIdentifier;
            this.Archived = archived;
            this.ChallengeType = challengeType;
            this.Repeatable = repeatable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeAttributes" /> class.
        /// </summary>
        public GameCenterChallengeAttributes()
        {
        }

    }
}