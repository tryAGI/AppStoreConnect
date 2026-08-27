
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetCreateRequestData" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleSetCreateRequestData(
            global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataAttributes attributes,
            global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataType type)
        {
            this.Type = type;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetCreateRequestData" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleSetCreateRequestData()
        {
        }

    }
}