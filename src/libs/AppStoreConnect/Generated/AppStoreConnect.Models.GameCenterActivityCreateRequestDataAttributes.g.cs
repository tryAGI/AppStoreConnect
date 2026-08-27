
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterActivityCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("playStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterActivityCreateRequestDataAttributesPlayStyleJsonConverter))]
        public global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributesPlayStyle? PlayStyle { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.Dictionary<string, string>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="vendorIdentifier"></param>
        /// <param name="playStyle"></param>
        /// <param name="minimumPlayersCount"></param>
        /// <param name="maximumPlayersCount"></param>
        /// <param name="supportsPartyCode"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityCreateRequestDataAttributes(
            string referenceName,
            string vendorIdentifier,
            global::AppStoreConnect.GameCenterActivityCreateRequestDataAttributesPlayStyle? playStyle,
            int? minimumPlayersCount,
            int? maximumPlayersCount,
            bool? supportsPartyCode,
            global::System.Collections.Generic.Dictionary<string, string>? properties)
        {
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
            this.VendorIdentifier = vendorIdentifier ?? throw new global::System.ArgumentNullException(nameof(vendorIdentifier));
            this.PlayStyle = playStyle;
            this.MinimumPlayersCount = minimumPlayersCount;
            this.MaximumPlayersCount = maximumPlayersCount;
            this.SupportsPartyCode = supportsPartyCode;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityCreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterActivityCreateRequestDataAttributes()
        {
        }

    }
}