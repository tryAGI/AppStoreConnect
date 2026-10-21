
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppEventLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8A9AA96AE6F70034.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_817C582D64360811.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AB509B55F60F5D0D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B2BB85784ECB781D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6D409DDA00018DB7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_95D217705A094A4B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C70FEE6F9A9A705D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D955EFA7461530F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C51D1521A7962279.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C1DE073994C42092.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_15B3D116A4C749A8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_883C3F3D1B1E662A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_512F277E5669E195.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9810C0622F1395DD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7BF42EEBD6403791.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D05932A16FDEA1D3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_10FFD29B2419D63D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA5F6DBA4E53C1B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C179BDCBCD993033.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28E28395E883FFFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_12DD292C928E93F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AC04A0D95B1F22C3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5DD25C6F48C85EFB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02C6C2792B75EC4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91DC5CEE98911F8A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27C7FD3588489CFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_78772F068465FB22.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F0DE8BB7EEABBDED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0501272107B22CAB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4C7BDE92C185F97F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91CD50866C79CD66.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_189547D261DCE003.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D4AFA6E434157267.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8F3D777E7806F35A.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppEventLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppEventLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppEventLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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