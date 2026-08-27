
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiActionTypeJsonConverter))]
        public global::AppStoreConnect.CiActionType? ActionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiActionDestinationJsonConverter))]
        public global::AppStoreConnect.CiActionDestination? Destination { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildDistributionAudience")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter))]
        public global::AppStoreConnect.BuildAudienceType? BuildDistributionAudience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testConfiguration")]
        public global::AppStoreConnect.CiActionTestConfiguration? TestConfiguration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        public string? Scheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiActionPlatformJsonConverter))]
        public global::AppStoreConnect.CiActionPlatform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRequiredToPass")]
        public bool? IsRequiredToPass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiAction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="actionType"></param>
        /// <param name="destination"></param>
        /// <param name="buildDistributionAudience"></param>
        /// <param name="testConfiguration"></param>
        /// <param name="scheme"></param>
        /// <param name="platform"></param>
        /// <param name="isRequiredToPass"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiAction(
            string? name,
            global::AppStoreConnect.CiActionType? actionType,
            global::AppStoreConnect.CiActionDestination? destination,
            global::AppStoreConnect.BuildAudienceType? buildDistributionAudience,
            global::AppStoreConnect.CiActionTestConfiguration? testConfiguration,
            string? scheme,
            global::AppStoreConnect.CiActionPlatform? platform,
            bool? isRequiredToPass)
        {
            this.Name = name;
            this.ActionType = actionType;
            this.Destination = destination;
            this.BuildDistributionAudience = buildDistributionAudience;
            this.TestConfiguration = testConfiguration;
            this.Scheme = scheme;
            this.Platform = platform;
            this.IsRequiredToPass = isRequiredToPass;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiAction" /> class.
        /// </summary>
        public CiAction()
        {
        }

    }
}