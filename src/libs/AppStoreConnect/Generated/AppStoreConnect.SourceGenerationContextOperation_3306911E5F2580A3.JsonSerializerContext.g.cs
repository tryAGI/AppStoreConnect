
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_3306911E5F2580A3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECFEF16776C89FB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B554BDE9DB38738B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AB1262BC673C1A4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D2DBAC60F1C2DC4E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_703255E6E689ECD1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0501176EFDAB9B49.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1AB6BB734B4E9231.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93E5D4606116D6EF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_99133EBD2256FD09.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_62EDAB5E02C06C6E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_254A477D46386E67.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CB89E7BD613CACB0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C5A3C052679CFBFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7A9C6C299926E917.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_3306911E5F2580A3 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_3306911E5F2580A3 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_3306911E5F2580A3(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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