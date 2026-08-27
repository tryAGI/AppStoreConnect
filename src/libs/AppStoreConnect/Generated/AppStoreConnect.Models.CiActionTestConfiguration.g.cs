
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiActionTestConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiActionTestConfigurationKindJsonConverter))]
        public global::AppStoreConnect.CiActionTestConfigurationKind? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testPlanName")]
        public string? TestPlanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testDestinations")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CiTestDestination>? TestDestinations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiActionTestConfiguration" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="testPlanName"></param>
        /// <param name="testDestinations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiActionTestConfiguration(
            global::AppStoreConnect.CiActionTestConfigurationKind? kind,
            string? testPlanName,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiTestDestination>? testDestinations)
        {
            this.Kind = kind;
            this.TestPlanName = testPlanName;
            this.TestDestinations = testDestinations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiActionTestConfiguration" /> class.
        /// </summary>
        public CiActionTestConfiguration()
        {
        }

    }
}