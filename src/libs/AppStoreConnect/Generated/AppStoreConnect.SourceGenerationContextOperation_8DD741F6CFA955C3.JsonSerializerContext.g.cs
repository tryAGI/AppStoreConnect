
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_8DD741F6CFA955C3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E523330472A111D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_99DFFC88754029F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D5CA914EF43A0A38.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1A3E5C4858B14FDA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93989986708D7F12.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2B593298DD96E659.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F1DAB8189B88958E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFEE240D880D820C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0A104C5B851C3E56.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_8DD741F6CFA955C3 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_8DD741F6CFA955C3 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_8DD741F6CFA955C3(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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