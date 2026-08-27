
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiWorkflowUpdateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xcodeVersion")]
        public global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersion? XcodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macOsVersion")]
        public global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersion? MacOsVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="xcodeVersion"></param>
        /// <param name="macOsVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiWorkflowUpdateRequestDataRelationships(
            global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersion? xcodeVersion,
            global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersion? macOsVersion)
        {
            this.XcodeVersion = xcodeVersion;
            this.MacOsVersion = macOsVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiWorkflowUpdateRequestDataRelationships" /> class.
        /// </summary>
        public CiWorkflowUpdateRequestDataRelationships()
        {
        }

    }
}