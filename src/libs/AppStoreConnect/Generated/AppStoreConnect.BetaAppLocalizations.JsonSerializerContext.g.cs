
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BetaAppLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45DDF6A6D83E4FD3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6D6E7DDD7C279D26.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_207D7A8CB84FB99B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_78F2733BF89F18C8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_071D9C3B0645AE15.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7E7BAB335D5B7222.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F0CAC341F88EFE6B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B1F4C9D06D4727F0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A0689F39828E8317.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AB4D51F0C1AB6C14.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B5C9E3E09896BA7B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_03921259A8050F8F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5E3BB0341D742563.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C0CFC20D53B6800A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1D3DCE0430E6CF45.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BetaAppLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BetaAppLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private BetaAppLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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