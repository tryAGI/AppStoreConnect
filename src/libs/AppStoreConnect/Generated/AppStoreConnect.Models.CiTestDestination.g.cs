
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiTestDestination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceTypeName")]
        public string? DeviceTypeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceTypeIdentifier")]
        public string? DeviceTypeIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtimeName")]
        public string? RuntimeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtimeIdentifier")]
        public string? RuntimeIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiTestDestinationKindJsonConverter))]
        public global::AppStoreConnect.CiTestDestinationKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiTestDestination" /> class.
        /// </summary>
        /// <param name="deviceTypeName"></param>
        /// <param name="deviceTypeIdentifier"></param>
        /// <param name="runtimeName"></param>
        /// <param name="runtimeIdentifier"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiTestDestination(
            string? deviceTypeName,
            string? deviceTypeIdentifier,
            string? runtimeName,
            string? runtimeIdentifier,
            global::AppStoreConnect.CiTestDestinationKind? kind)
        {
            this.DeviceTypeName = deviceTypeName;
            this.DeviceTypeIdentifier = deviceTypeIdentifier;
            this.RuntimeName = runtimeName;
            this.RuntimeIdentifier = runtimeIdentifier;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiTestDestination" /> class.
        /// </summary>
        public CiTestDestination()
        {
        }

    }
}