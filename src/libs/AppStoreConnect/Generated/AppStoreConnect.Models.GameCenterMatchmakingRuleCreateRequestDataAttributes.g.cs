
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleCreateRequestDataAttributesTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributesType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="expression"></param>
        /// <param name="weight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleCreateRequestDataAttributes(
            string referenceName,
            string description,
            global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributesType type,
            string expression,
            double? weight)
        {
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Type = type;
            this.Expression = expression ?? throw new global::System.ArgumentNullException(nameof(expression));
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleCreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleCreateRequestDataAttributes()
        {
        }

    }
}