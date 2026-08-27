
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlternativeDistributionPackageRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageRelationships" /> class.
        /// </summary>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionPackageRelationships(
            global::AppStoreConnect.AlternativeDistributionPackageRelationshipsVersions? versions)
        {
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageRelationships" /> class.
        /// </summary>
        public AlternativeDistributionPackageRelationships()
        {
        }

    }
}