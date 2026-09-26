
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterDetailPlayerAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterDetailPlayerAttributes" /> class.
        /// </summary>
        /// <param name="nickname"></param>
        /// <param name="blocked"></param>
        /// <param name="bundleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterDetailPlayerAttributes(
            string? nickname,
            bool? blocked,
            string? bundleId)
        {
            this.Nickname = nickname;
            this.Blocked = blocked;
            this.BundleId = bundleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterDetailPlayerAttributes" /> class.
        /// </summary>
        public GameCenterDetailPlayerAttributes()
        {
        }

    }
}