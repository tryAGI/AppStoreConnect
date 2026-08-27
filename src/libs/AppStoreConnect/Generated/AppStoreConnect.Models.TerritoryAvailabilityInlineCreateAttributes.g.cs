
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TerritoryAvailabilityInlineCreateAttributes
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TerritoryAvailabilityInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="available"></param>
        /// <param name="releaseDate"></param>
        /// <param name="preOrderEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TerritoryAvailabilityInlineCreateAttributes(
            bool? available,
            global::System.DateTime? releaseDate,
            bool? preOrderEnabled)
        {
            this.Available = available;
            this.ReleaseDate = releaseDate;
            this.PreOrderEnabled = preOrderEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerritoryAvailabilityInlineCreateAttributes" /> class.
        /// </summary>
        public TerritoryAvailabilityInlineCreateAttributes()
        {
        }

    }
}