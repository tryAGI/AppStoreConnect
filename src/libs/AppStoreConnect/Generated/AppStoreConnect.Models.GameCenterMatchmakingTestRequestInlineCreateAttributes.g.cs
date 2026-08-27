
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingTestRequestInlineCreateAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestName")]
        public string? RequestName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondsInQueue")]
        public int? SecondsInQueue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTestRequestInlineCreateAttributesLocaleJsonConverter))]
        public global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale? Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::AppStoreConnect.Location? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playerCount")]
        public int? PlayerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appVersion")]
        public string? AppVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestRequestInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="requestName"></param>
        /// <param name="secondsInQueue"></param>
        /// <param name="locale"></param>
        /// <param name="location"></param>
        /// <param name="minPlayers"></param>
        /// <param name="maxPlayers"></param>
        /// <param name="playerCount"></param>
        /// <param name="bundleId"></param>
        /// <param name="platform"></param>
        /// <param name="appVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingTestRequestInlineCreateAttributes(
            string? requestName,
            int? secondsInQueue,
            global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateAttributesLocale? locale,
            global::AppStoreConnect.Location? location,
            int? minPlayers,
            int? maxPlayers,
            int? playerCount,
            string? bundleId,
            global::AppStoreConnect.Platform? platform,
            string? appVersion)
        {
            this.RequestName = requestName;
            this.SecondsInQueue = secondsInQueue;
            this.Locale = locale;
            this.Location = location;
            this.MinPlayers = minPlayers;
            this.MaxPlayers = maxPlayers;
            this.PlayerCount = playerCount;
            this.BundleId = bundleId;
            this.Platform = platform;
            this.AppVersion = appVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestRequestInlineCreateAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingTestRequestInlineCreateAttributes()
        {
        }

    }
}