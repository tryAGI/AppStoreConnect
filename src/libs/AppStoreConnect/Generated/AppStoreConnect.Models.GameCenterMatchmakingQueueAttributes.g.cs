
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueueAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

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
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="classicMatchmakingBundleIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingQueueAttributes(
            string? referenceName,
            global::System.Collections.Generic.IList<string>? classicMatchmakingBundleIds)
        {
            this.ReferenceName = referenceName;
            this.ClassicMatchmakingBundleIds = classicMatchmakingBundleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingQueueAttributes()
        {
        }

    }
}