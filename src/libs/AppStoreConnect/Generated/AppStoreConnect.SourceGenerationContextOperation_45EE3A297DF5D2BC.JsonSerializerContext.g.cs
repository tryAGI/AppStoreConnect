
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_45EE3A297DF5D2BC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28E28395E883FFFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A771E2726EF9232A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2F5AF7ECFB71D67F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7AA3691AB11042CA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0C1BA7CD7E5CBA01.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_37E9A0C16F00F68D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3CBDD2AC0B2BBFE9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C1FD68916A1FBC1B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E03288A80085F00.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B94F9A9E49A3EE31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3764E6F90B0C6381.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CF5C5015BB26193C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_45EE3A297DF5D2BC Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_45EE3A297DF5D2BC Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_45EE3A297DF5D2BC(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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