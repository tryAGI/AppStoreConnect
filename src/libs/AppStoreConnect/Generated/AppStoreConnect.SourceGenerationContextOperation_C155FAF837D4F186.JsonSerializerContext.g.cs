
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_C155FAF837D4F186 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28E28395E883FFFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EE7220B7BAE6E932.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1762573A79B1C057.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4414604419043029.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_988A6443A6E50E91.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ADD5CDB6A7468D22.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F9FC6E1E4AF0404A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_51EEDAA6611BA4C9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C95C32097A2128DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B2274D4219575018.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B8F2547A8F0F37D7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2A4444A539792F97.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_C155FAF837D4F186 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_C155FAF837D4F186 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_C155FAF837D4F186(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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