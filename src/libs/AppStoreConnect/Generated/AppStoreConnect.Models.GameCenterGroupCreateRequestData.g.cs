
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterGroupCreateRequestData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterGroupCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterGroupCreateRequestDataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.GameCenterGroupCreateRequestDataAttributes? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterGroupCreateRequestData" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterGroupCreateRequestData(
            global::AppStoreConnect.GameCenterGroupCreateRequestDataType type,
            global::AppStoreConnect.GameCenterGroupCreateRequestDataAttributes? attributes)
        {
            this.Type = type;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterGroupCreateRequestData" /> class.
        /// </summary>
        public GameCenterGroupCreateRequestData()
        {
        }

    }
}