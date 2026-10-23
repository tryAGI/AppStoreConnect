
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_971EDC31887B1CC8
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27D82D5C13E63ACE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3852D5C99441DFB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3EEC1707BE9911A3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B1153695911883A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6AF1A6DB9F4F1A6C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7CCA5C1848913DC1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_814C730632B2EE7A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8985F1E779E1DA54.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97D140A7AE1AA859.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1ACDC219AEBB569.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DB9B2469AB6F6F04.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E96A445AA2F0F29C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FB991B724BADE2D7.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem64JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem64JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem64))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0475.Create_IncludedItem642(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem64?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch0716.Create_NullableIncludedItem642(options);
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