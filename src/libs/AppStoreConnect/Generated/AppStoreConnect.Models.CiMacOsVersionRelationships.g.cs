
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiMacOsVersionRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xcodeVersions")]
        public global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersions? XcodeVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiMacOsVersionRelationships" /> class.
        /// </summary>
        /// <param name="xcodeVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiMacOsVersionRelationships(
            global::AppStoreConnect.CiMacOsVersionRelationshipsXcodeVersions? xcodeVersions)
        {
            this.XcodeVersions = xcodeVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiMacOsVersionRelationships" /> class.
        /// </summary>
        public CiMacOsVersionRelationships()
        {
        }

    }
}