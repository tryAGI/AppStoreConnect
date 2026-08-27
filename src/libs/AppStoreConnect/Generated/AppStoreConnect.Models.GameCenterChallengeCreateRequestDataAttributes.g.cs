
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterChallengeCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("challengeType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterChallengeCreateRequestDataAttributesChallengeTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterChallengeCreateRequestDataAttributesChallengeType ChallengeType { get; set; }

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
        /// Initializes a new instance of the <see cref="GameCenterChallengeCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="challengeType"></param>
        /// <param name="repeatable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeCreateRequestDataAttributes(
            string referenceName,
            string vendorIdentifier,
            global::AppStoreConnect.GameCenterChallengeCreateRequestDataAttributesChallengeType challengeType,
            bool? repeatable)
        {
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
            this.VendorIdentifier = vendorIdentifier ?? throw new global::System.ArgumentNullException(nameof(vendorIdentifier));
            this.ChallengeType = challengeType;
            this.Repeatable = repeatable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeCreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterChallengeCreateRequestDataAttributes()
        {
        }

    }
}