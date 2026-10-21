
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_1B77F63646083FFD : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA016E45FD565416.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28234D3C77C44BAC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_74F7CD2B15B4314D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E4B082F8D69841E6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5600FE2D86CE031B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5D3B098E411FF020.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_10772B02F53975A8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_99A600B4BB3DC9C0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_36DB8712FC5E30EC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_1B77F63646083FFD Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_1B77F63646083FFD Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_1B77F63646083FFD(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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