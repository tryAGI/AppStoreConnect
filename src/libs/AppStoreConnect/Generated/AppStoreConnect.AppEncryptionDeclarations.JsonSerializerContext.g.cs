
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppEncryptionDeclarationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8BAB17973B3327DD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A85898EAE0A23288.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_460F7A018434038F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2A58222C39870E23.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3C6A4F8681493E44.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F17AC3545C150151.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0869AD21D0357EC7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_314835728F9C3CFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2181FFBC24624EFA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F12FBA52C1262EF6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ACAE6C25E4EFCDF7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2D9B9D0D0D0D8749.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DF0531A24B14DD2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3326812AA1A5D908.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_97C4A11CB4F9EED8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED356F5DE5C1ED9F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F5C8C85D3D8FADD2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_66486404CF5BA374.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppEncryptionDeclarationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppEncryptionDeclarationsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppEncryptionDeclarationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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