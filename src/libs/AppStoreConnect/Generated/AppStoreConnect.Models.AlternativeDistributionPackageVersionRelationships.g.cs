
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlternativeDistributionPackageVersionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariants? Variants { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deltas")]
        public global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltas? Deltas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternativeDistributionPackage")]
        public global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackage? AlternativeDistributionPackage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageVersionRelationships" /> class.
        /// </summary>
        /// <param name="variants"></param>
        /// <param name="deltas"></param>
        /// <param name="alternativeDistributionPackage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionPackageVersionRelationships(
            global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsVariants? variants,
            global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsDeltas? deltas,
            global::AppStoreConnect.AlternativeDistributionPackageVersionRelationshipsAlternativeDistributionPackage? alternativeDistributionPackage)
        {
            this.Variants = variants;
            this.Deltas = deltas;
            this.AlternativeDistributionPackage = alternativeDistributionPackage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageVersionRelationships" /> class.
        /// </summary>
        public AlternativeDistributionPackageVersionRelationships()
        {
        }

    }
}