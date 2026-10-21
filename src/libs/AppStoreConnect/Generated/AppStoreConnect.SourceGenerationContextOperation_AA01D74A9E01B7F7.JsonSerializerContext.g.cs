
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_AA01D74A9E01B7F7 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECCF9A36D97176B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_864D946264306329.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BAC0EA1BD276524E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D689F7D1D9FF5CCC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_53899700D4B8DC95.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_15CE5E622689FF51.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9BF0E5ABAEA0C44.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_59C2CBA53CB45FB7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4B12AED2FB63F3A2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9E0461EAEB298386.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EB632C55284944AE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_92C25CE9331E8CFF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1B8BD71368535FAA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFC3F452314A04BA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7A05243C46B298E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDAB0573C493829E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DDC533238D0DEA3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_AA01D74A9E01B7F7 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_AA01D74A9E01B7F7 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_AA01D74A9E01B7F7(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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