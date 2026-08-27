
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppEventCreateRequestDataAttributesTerritorySchedule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territories")]
        public global::System.Collections.Generic.IList<string>? Territories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishStart")]
        public global::System.DateTime? PublishStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventStart")]
        public global::System.DateTime? EventStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventEnd")]
        public global::System.DateTime? EventEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventCreateRequestDataAttributesTerritorySchedule" /> class.
        /// </summary>
        /// <param name="territories"></param>
        /// <param name="publishStart"></param>
        /// <param name="eventStart"></param>
        /// <param name="eventEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventCreateRequestDataAttributesTerritorySchedule(
            global::System.Collections.Generic.IList<string>? territories,
            global::System.DateTime? publishStart,
            global::System.DateTime? eventStart,
            global::System.DateTime? eventEnd)
        {
            this.Territories = territories;
            this.PublishStart = publishStart;
            this.EventStart = eventStart;
            this.EventEnd = eventEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventCreateRequestDataAttributesTerritorySchedule" /> class.
        /// </summary>
        public AppEventCreateRequestDataAttributesTerritorySchedule()
        {
        }

    }
}