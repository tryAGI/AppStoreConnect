
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_10B57236DC654FA1
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_00580CD5AC902D19.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_139876587687A3C4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_182123A51C2B2D4F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1D85BDDC2111F3E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_65AD8C7DE6FB98BB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6D94C35165AA72DB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9100415794E7D713.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9D50E52C247A6B11.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C2DB1DF0EEC8EC27.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D44D255B20B21655.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E9919BA097D35345.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FCD7E0FA4085A5C0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FE27C2806C92255E.MetadataScope,
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
                if (type == typeof(global::AppStoreConnect.AppStoreVersionRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_AppStoreVersionRelationships.Create_AppStoreVersionRelationships(options);
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