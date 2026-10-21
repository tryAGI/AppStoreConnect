
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppPriceSchedulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_43F782E1435207D2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93A0CE525D0315DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1B2816AA970E6989.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F66606F53742A273.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6996A90F2DCC01EF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_17654FF91D904B89.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C58ECB5578FA203D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A43E3EC90892027E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EC259773B8F00297.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BC4B15436AFD3172.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_967E28AE942B7699.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC60AB733F36B256.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F536ED556A8C8AB3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B7F7BB4D3BDAA7CE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6C4D92CB5DEA54E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F864F379339AA4D8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8EE20D45E0E970C8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5FD1EB9FA87D2EC0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EECFAA282CEB4606.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B9DFA489D0AD83E5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7427113D1DD74524.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_37F425CDBABBC69E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC52DC877FFE8DFD.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppPriceSchedulesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppPriceSchedulesSourceGenerationContext Default => DefaultHolder.Instance;
        private AppPriceSchedulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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