
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class XcodeOverviewSignatures
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topHangPoint")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.PerformanceSignature>? TopHangPoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topLaunchPoint")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.PerformanceSignature>? TopLaunchPoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topDiskWritePoint")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.PerformanceSignature>? TopDiskWritePoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewSignatures" /> class.
        /// </summary>
        /// <param name="topHangPoint"></param>
        /// <param name="topLaunchPoint"></param>
        /// <param name="topDiskWritePoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeOverviewSignatures(
            global::System.Collections.Generic.IList<global::AppStoreConnect.PerformanceSignature>? topHangPoint,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PerformanceSignature>? topLaunchPoint,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PerformanceSignature>? topDiskWritePoint)
        {
            this.TopHangPoint = topHangPoint;
            this.TopLaunchPoint = topLaunchPoint;
            this.TopDiskWritePoint = topDiskWritePoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeOverviewSignatures" /> class.
        /// </summary>
        public XcodeOverviewSignatures()
        {
        }

    }
}