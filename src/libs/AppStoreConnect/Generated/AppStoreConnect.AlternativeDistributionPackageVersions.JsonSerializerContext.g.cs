
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AlternativeDistributionPackageVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AA336FFC71C19A9F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6BB41C7661243FD0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4E3DF2A71F8D1FDA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05E9D38627FD414B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D78AC5860452F905.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5BFC7611F3596C7C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_471F02AE28AE3457.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C4E8C0A28EF25643.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_19ED6ACCADC15BE3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F36AC4F1F34376C0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1DBC923F05B1AF2C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3357E615B36BC3D4.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AlternativeDistributionPackageVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AlternativeDistributionPackageVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private AlternativeDistributionPackageVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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