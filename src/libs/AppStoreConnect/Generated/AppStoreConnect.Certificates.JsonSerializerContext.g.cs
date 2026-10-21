
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class CertificatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_74A6120439388315.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7E0C3DAFF67854BB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_98535E583FDA48F2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6633812AA3ACD297.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6B0729BAC404F0BB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2BEA050AD4A312C1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E33ECBEFB4BF1BE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FF0584B5507FE9CB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CF174B9D4FB7F974.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6FAF1904710EC7A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9C236FBB10069B2E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_00E5458DEAD18C68.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_451CF806A8C6936B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C62CF2B93DF93F85.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8D892D9B75723CD5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_33463457106D16D0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_516A8ACB23C9C777.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93806030565799F5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3E7B0EC5F359015B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly CertificatesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static CertificatesSourceGenerationContext Default => DefaultHolder.Instance;
        private CertificatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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