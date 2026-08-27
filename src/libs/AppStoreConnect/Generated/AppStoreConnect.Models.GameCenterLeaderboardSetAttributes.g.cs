
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetAttributes
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="vendorIdentifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetAttributes(
            string? referenceName,
            string? vendorIdentifier)
        {
            this.ReferenceName = referenceName;
            this.VendorIdentifier = vendorIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetAttributes" /> class.
        /// </summary>
        public GameCenterLeaderboardSetAttributes()
        {
        }

    }
}