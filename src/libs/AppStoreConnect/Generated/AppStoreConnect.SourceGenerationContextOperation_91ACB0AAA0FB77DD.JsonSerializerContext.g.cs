
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_91ACB0AAA0FB77DD : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECFEF16776C89FB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FBE243F2BDD0CC29.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_33C51F45C7A6C8B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_852CD8130CB3BF8F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CCE2043442A40D6C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D5379C5981355230.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76482F5932E4AB5D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA042AA21E394A21.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A49DBEEA91C3E6F6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9C2DBDCE2FFAAAC5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9637CDBA3EE5C8E8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2AE0FA399D6E083D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B2B50DCA82123685.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4F7C9B5471100E26.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_91ACB0AAA0FB77DD Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_91ACB0AAA0FB77DD Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_91ACB0AAA0FB77DD(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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