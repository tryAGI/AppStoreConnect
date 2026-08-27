
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppAvailabilityV2CreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppAvailabilityV2CreateRequestData Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.TerritoryAvailabilityInlineCreate>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="included"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAvailabilityV2CreateRequest(
            global::AppStoreConnect.AppAvailabilityV2CreateRequestData data,
            global::System.Collections.Generic.IList<global::AppStoreConnect.TerritoryAvailabilityInlineCreate>? included)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAvailabilityV2CreateRequest" /> class.
        /// </summary>
        public AppAvailabilityV2CreateRequest()
        {
        }

    }
}