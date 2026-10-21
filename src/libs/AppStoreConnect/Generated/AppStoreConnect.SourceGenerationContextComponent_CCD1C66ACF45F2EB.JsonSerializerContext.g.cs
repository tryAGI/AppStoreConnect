
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextComponent_CCD1C66ACF45F2EB : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05A3B9FEA71FE3BC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_25072A55C7A7C455.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4026D24682E65C13.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_43AFBBA8C1044645.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_452971CF2BDFA121.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_59431305183A369A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97D140A7AE1AA859.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A33EEFBFB9D9F2BB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D89C92F5F6C7551D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E4022F50F4E70682.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EF7AC224013F48A7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F9DA568520D6BE19.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextComponent_CCD1C66ACF45F2EB Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextComponent_CCD1C66ACF45F2EB Default => DefaultHolder.Instance;
        private SourceGenerationContextComponent_CCD1C66ACF45F2EB(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.IncludedItem46JsonConverter>(static () => new global::AppStoreConnect.JsonConverters.IncludedItem46JsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.IncludedItem46))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_IncludedItem462.Create_IncludedItem462(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem46?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableIncludedItem462.Create_NullableIncludedItem462(options);
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