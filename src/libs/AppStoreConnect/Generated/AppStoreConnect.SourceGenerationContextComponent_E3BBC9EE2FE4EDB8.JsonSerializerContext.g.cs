
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E3BBC9EE2FE4EDB8
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26E86BC21D263C29.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3C6A7C5788562B42.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1D75377E7BE7D31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BCE8FC7B6AC6D97E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CB39F89D889A41DC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EBACA0DF211A5A41.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem51JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem51JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem51))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_IncludedItem512.Create_IncludedItem512(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem51?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableIncludedItem512.Create_NullableIncludedItem512(options);
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