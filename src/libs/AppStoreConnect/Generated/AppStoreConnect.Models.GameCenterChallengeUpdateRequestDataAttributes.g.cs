
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterChallengeUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

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
        /// Initializes a new instance of the <see cref="GameCenterChallengeUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="archived"></param>
        /// <param name="repeatable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeUpdateRequestDataAttributes(
            string? referenceName,
            bool? archived,
            bool? repeatable)
        {
            this.ReferenceName = referenceName;
            this.Archived = archived;
            this.Repeatable = repeatable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeUpdateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterChallengeUpdateRequestDataAttributes()
        {
        }

    }
}