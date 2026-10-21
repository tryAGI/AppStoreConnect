
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppAvailabilitiesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5705478DCD70EB24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_270499E581F1E57B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_51DE6D8388C3042E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_11BA981091D08DE9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C0D2498FE1D7A0C6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2CD1304AEE6803C7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8F55154FDEC263E2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7BCB0162726A069B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D858052BFF631F16.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_455F9B950946C862.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E71E0B8C98A8AA73.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_09149EA34A4763B2.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppAvailabilitiesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppAvailabilitiesSourceGenerationContext Default => DefaultHolder.Instance;
        private AppAvailabilitiesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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