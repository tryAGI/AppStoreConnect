
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5B3E2E6698B073C0
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_07E2A157A474E809.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1743FF67D689886C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_322595E2D7BB2F43.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_372AC0FE4B4FDA89.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3CD9DD37C9B3E1B5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_44055F1724BB8715.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4F14B87F4283C815.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_80BF96BA1D85F985.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A0EA5BF0D68B4379.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ABD3A3357F9903C4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AFC908AA7A9D078C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D120D217E6304B7D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D396771DDF5FEFE9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DCA5021592CDA4B1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5282E242B4EC883.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F0DDE23FCBFE147B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F9CD4BB9E2C5A8F5.MetadataScope,
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
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationUpdateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_AgeRatingDeclarationUpdateRequestDataAttributes.Create_AgeRatingDeclarationUpdateRequestDataAttributes(options);
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