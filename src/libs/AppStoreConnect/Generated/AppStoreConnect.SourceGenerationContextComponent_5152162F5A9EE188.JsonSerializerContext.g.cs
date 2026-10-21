
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5152162F5A9EE188
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_01665E4AA334A8CD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_12F6B218EC5C3F5F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2A5EC866BE298699.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B1153695911883A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_62FC50089768F020.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6AF1A6DB9F4F1A6C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6BD49E5BF06734D4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6BFB6D21F589AD0D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_703F9F9F41A224E2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8985F1E779E1DA54.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DFC304D172DF5A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8FD188339DCBE7A1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1ACDC219AEBB569.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A7F89F2939F7FF21.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AAF425DCDEAEDD52.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C1C5D13F9912BE87.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC8C56126697921D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D051AADB2C0E4D8D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D6B1F6F57126ADC7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D8159C17E0F56FB3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E25F411FF31E911E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E63345E0CFC7F8BB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EBF9D85E752E6B29.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EF7AC224013F48A7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FB991B724BADE2D7.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem49JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem49JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem49))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_IncludedItem492.Create_IncludedItem492(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem49?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableIncludedItem492.Create_NullableIncludedItem492(options);
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