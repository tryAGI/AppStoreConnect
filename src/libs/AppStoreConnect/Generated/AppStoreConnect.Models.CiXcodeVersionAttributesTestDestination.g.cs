
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiXcodeVersionAttributesTestDestination
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
        [global::System.Text.Json.Serialization.JsonPropertyName("availableRuntimes")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>? AvailableRuntimes { get; set; }

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
        /// Initializes a new instance of the <see cref="CiXcodeVersionAttributesTestDestination" /> class.
        /// </summary>
        /// <param name="deviceTypeName"></param>
        /// <param name="deviceTypeIdentifier"></param>
        /// <param name="availableRuntimes"></param>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiXcodeVersionAttributesTestDestination(
            string? deviceTypeName,
            string? deviceTypeIdentifier,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestinationAvailableRuntime>? availableRuntimes,
            global::AppStoreConnect.CiTestDestinationKind? kind)
        {
            this.DeviceTypeName = deviceTypeName;
            this.DeviceTypeIdentifier = deviceTypeIdentifier;
            this.AvailableRuntimes = availableRuntimes;
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiXcodeVersionAttributesTestDestination" /> class.
        /// </summary>
        public CiXcodeVersionAttributesTestDestination()
        {
        }

    }
}