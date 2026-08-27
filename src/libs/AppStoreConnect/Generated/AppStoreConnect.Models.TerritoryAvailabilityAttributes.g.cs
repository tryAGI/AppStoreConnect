
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TerritoryAvailabilityAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        public bool? Available { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releaseDate")]
        public global::System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preOrderEnabled")]
        public bool? PreOrderEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preOrderPublishDate")]
        public global::System.DateTime? PreOrderPublishDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentStatuses")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse>? ContentStatuses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TerritoryAvailabilityAttributes" /> class.
        /// </summary>
        /// <param name="available"></param>
        /// <param name="releaseDate"></param>
        /// <param name="preOrderEnabled"></param>
        /// <param name="preOrderPublishDate"></param>
        /// <param name="contentStatuses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TerritoryAvailabilityAttributes(
            bool? available,
            global::System.DateTime? releaseDate,
            bool? preOrderEnabled,
            global::System.DateTime? preOrderPublishDate,
            global::System.Collections.Generic.IList<global::AppStoreConnect.TerritoryAvailabilityAttributesContentStatuse>? contentStatuses)
        {
            this.Available = available;
            this.ReleaseDate = releaseDate;
            this.PreOrderEnabled = preOrderEnabled;
            this.PreOrderPublishDate = preOrderPublishDate;
            this.ContentStatuses = contentStatuses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerritoryAvailabilityAttributes" /> class.
        /// </summary>
        public TerritoryAvailabilityAttributes()
        {
        }

    }
}