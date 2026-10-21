
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterActivitiesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_16416624CB42B785.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_13F6DBB6D6E49804.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_70C8770B68BB632C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B44013FFFB58612.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FE4FEA57E67BE454.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A84BDE91E305C4A3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DB9FAAF14D7395D0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2BAC393045894831.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_73861EB3BD398F2B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4ABC30BBB199C670.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0958141627DE53B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_70B143C7DFDCF18F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3DCC6FB4D8C399E2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_950690408AF54D23.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A001284628B69AE1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5CEC5F547D347F16.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E10F6D0556B241B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B64D643E075A14E6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_725BE89A2EC8B258.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B967181F7E08C710.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C70E31ACB3A83284.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85FAE99B57BAFE16.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BA3611FD09DFF5E8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_79C0B71E5B8F7107.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DDF8515A1568430F.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterActivitiesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterActivitiesSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterActivitiesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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