
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterActivityVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D9AFFC1E49E93576.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A3490C4F380A1BCD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_44285A82F713E08B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA3CB9B9516DFBC6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E6DBAA668D10934C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5EF92882619DBA13.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4C2794A8ECEF12F7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C4E029C0CADCC28F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F8E73CB0FCEF35AB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0C74B0ADCD83A769.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_61FEEB6AC5F576F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_98C66DD35AA582AF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5A0D4BBB7A99DD61.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F689785709B0805A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8D6DBFB0BBE78EA2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7122D0B67FB0FA22.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C5C466ECA5115985.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4B98E587977CA75D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0CC64B93788CF646.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3C2CC4E40834DAD8.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterActivityVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterActivityVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterActivityVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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