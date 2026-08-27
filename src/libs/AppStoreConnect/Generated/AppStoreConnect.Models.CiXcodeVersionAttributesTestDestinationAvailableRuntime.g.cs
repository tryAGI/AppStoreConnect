
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiXcodeVersionAttributesTestDestinationAvailableRuntime
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiXcodeVersionAttributesTestDestinationAvailableRuntime" /> class.
        /// </summary>
        /// <param name="runtimeName"></param>
        /// <param name="runtimeIdentifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiXcodeVersionAttributesTestDestinationAvailableRuntime(
            string? runtimeName,
            string? runtimeIdentifier)
        {
            this.RuntimeName = runtimeName;
            this.RuntimeIdentifier = runtimeIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiXcodeVersionAttributesTestDestinationAvailableRuntime" /> class.
        /// </summary>
        public CiXcodeVersionAttributesTestDestinationAvailableRuntime()
        {
        }

    }
}