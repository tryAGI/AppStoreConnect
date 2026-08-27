
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterActivityAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("playStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterActivityAttributesPlayStyleJsonConverter))]
        public global::AppStoreConnect.GameCenterActivityAttributesPlayStyle? PlayStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumPlayersCount")]
        public int? MinimumPlayersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximumPlayersCount")]
        public int? MaximumPlayersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsPartyCode")]
        public bool? SupportsPartyCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, string>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="playStyle"></param>
        /// <param name="minimumPlayersCount"></param>
        /// <param name="maximumPlayersCount"></param>
        /// <param name="supportsPartyCode"></param>
        /// <param name="archived"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityAttributes(
            string? referenceName,
            string? vendorIdentifier,
            global::AppStoreConnect.GameCenterActivityAttributesPlayStyle? playStyle,
            int? minimumPlayersCount,
            int? maximumPlayersCount,
            bool? supportsPartyCode,
            bool? archived,
            global::System.Collections.Generic.Dictionary<string, string>? properties)
        {
            this.ReferenceName = referenceName;
            this.VendorIdentifier = vendorIdentifier;
            this.PlayStyle = playStyle;
            this.MinimumPlayersCount = minimumPlayersCount;
            this.MaximumPlayersCount = maximumPlayersCount;
            this.SupportsPartyCode = supportsPartyCode;
            this.Archived = archived;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityAttributes" /> class.
        /// </summary>
        public GameCenterActivityAttributes()
        {
        }

    }
}