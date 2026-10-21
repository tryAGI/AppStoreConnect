
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_F8EE43C97E061B30 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9F2883A028F87B90.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_626E5479AC5FB4BC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_953B408CE0569A4C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA39D34F7772D66F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FD50DF4E718DB3E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_34B6F14A321492D0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E2B73F1CB9AB721C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_15F3D6CFDABEC448.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9B26C592E661AC28.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_03B320F93A91D454.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6C2D2DA5183643D4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4E7524C51E8702AF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0AB54311F5DEA0ED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02B5470B99D54CD4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28E1832D227CF19D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E983614E885980A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_F8EE43C97E061B30 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_F8EE43C97E061B30 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_F8EE43C97E061B30(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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