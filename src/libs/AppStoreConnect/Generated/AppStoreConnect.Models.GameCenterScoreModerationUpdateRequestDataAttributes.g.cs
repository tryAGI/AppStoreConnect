
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterScoreModerationUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterScoreModerationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="blocked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterScoreModerationUpdateRequestDataAttributes(
            bool? blocked)
        {
            this.Blocked = blocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterScoreModerationUpdateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterScoreModerationUpdateRequestDataAttributes()
        {
        }

    }
}