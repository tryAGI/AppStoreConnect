
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_8DAAD02A2413BAA0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FEBF1DCC9488395B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3FE2F82F9FCFB408.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B3EBC5C2645D4D41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_060277662E875FE4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D94D1FC21FD8D26A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDAA0572D59C2E9F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E07150600870F366.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27FCD34DA43A7EFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7F7611F57B555F51.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_8DAAD02A2413BAA0 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_8DAAD02A2413BAA0 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_8DAAD02A2413BAA0(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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