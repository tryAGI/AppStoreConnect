
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_E6420E9E479E5940 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28E28395E883FFFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A759F293679A355E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3F955778FDFC9AAA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7514C894FBBD7485.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1205496106F718C1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EB4C508DFF3ED6CE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2543C294277D3587.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1CF91B1C24BF7A4E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_30B20A7061E1AB85.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_918A2C936ABA9017.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_785566AA54C96833.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E0125A336A76C145.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_E6420E9E479E5940 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_E6420E9E479E5940 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_E6420E9E479E5940(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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