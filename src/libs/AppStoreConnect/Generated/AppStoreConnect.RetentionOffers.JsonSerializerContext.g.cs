
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class RetentionOffersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_90F730A69AD65367.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E476FE461B1A9D2F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_659C27949D1EA995.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_06D34B3FC7D86B36.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4AF1C0CA5BF04F40.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_36269309BB1197BD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F6B952DE5F0999F6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0B6D79EEC854E668.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_92060CA19E7BCAEA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9FB79C772F01A123.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BE32291A1012CFD0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F5BA35907F7835C2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D721F61F99E94627.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A39CE653939D78A7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_254C2DE7DE5B295E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D1CA5DCE5412F34.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly RetentionOffersSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static RetentionOffersSourceGenerationContext Default => DefaultHolder.Instance;
        private RetentionOffersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}