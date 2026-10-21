
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BundleIdsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45DDF6A6D83E4FD3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F6FF9A07FA506217.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_170CA4EE2B8A7540.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_315273F11ACDC4D1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2A492E390208D684.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_24EB98CAA2492EED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1BC4E10A090FBDE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5CC073C50D6E290C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_728AE667712FFA5E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED02AA71C8B9F0B7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B8F9F34C90283236.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E06ACB492914D948.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A40F5F6C66D05739.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B75BEB52FB4D7ECB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_72C191A0C67BDF5E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4A32C6517283DF80.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BAE36A8128A1BA32.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_425414232EA30DBA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45ECF78134B625FD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EB4E9B6C68F28C92.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_36A954AECBF503E5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C2C70CA4DC7C2F51.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FCDBC1E2692BF158.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CAC60630096BD187.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7287A6FF3207C8CB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2D35B7098C33A878.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F2E5BB8747CC8717.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BundleIdsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BundleIdsSourceGenerationContext Default => DefaultHolder.Instance;
        private BundleIdsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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