
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiProductAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiProductAttributesProductTypeJsonConverter))]
        public global::AppStoreConnect.CiProductAttributesProductType? ProductType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiProductAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="createdDate"></param>
        /// <param name="productType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiProductAttributes(
            string? name,
            global::System.DateTime? createdDate,
            global::AppStoreConnect.CiProductAttributesProductType? productType)
        {
            this.Name = name;
            this.CreatedDate = createdDate;
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiProductAttributes" /> class.
        /// </summary>
        public CiProductAttributes()
        {
        }

    }
}