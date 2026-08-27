
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppPricePointV3Attributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerPrice")]
        public string? CustomerPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proceeds")]
        public string? Proceeds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPricePointV3Attributes" /> class.
        /// </summary>
        /// <param name="customerPrice"></param>
        /// <param name="proceeds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPricePointV3Attributes(
            string? customerPrice,
            string? proceeds)
        {
            this.CustomerPrice = customerPrice;
            this.Proceeds = proceeds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPricePointV3Attributes" /> class.
        /// </summary>
        public AppPricePointV3Attributes()
        {
        }

    }
}