
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueueUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classicMatchmakingBundleIds")]
        public global::System.Collections.Generic.IList<string>? ClassicMatchmakingBundleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="classicMatchmakingBundleIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingQueueUpdateRequestDataAttributes(
            global::System.Collections.Generic.IList<string>? classicMatchmakingBundleIds)
        {
            this.ClassicMatchmakingBundleIds = classicMatchmakingBundleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueUpdateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingQueueUpdateRequestDataAttributes()
        {
        }

    }
}