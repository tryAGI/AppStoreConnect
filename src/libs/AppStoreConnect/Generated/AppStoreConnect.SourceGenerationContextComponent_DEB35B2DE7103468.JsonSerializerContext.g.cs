
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_DEB35B2DE7103468
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0DFFD43A6C1250E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0FF9AE9377E3BBD9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1FDA8638BCB27BD0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2F0377941C16D79C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4B8FB8DFE8362CA9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5A2815D9E123B742.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B162F6F39CFBB23.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_672C7568460F72ED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_694792B4312494C5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8B0F0C255BA6D622.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8D5A1A515B7FC832.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9B55BC20A6AA398F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AA13C57E9A072599.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D675E8E0B84B05A1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EC83386FCE7D645A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F7C13ACA926F2922.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.ReviewSubmissionItemRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_ReviewSubmissionItemRelationships.Create_ReviewSubmissionItemRelationships(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}