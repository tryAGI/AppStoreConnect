
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8EE1EE0BD42EA99C
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_79A5F54982E107E6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D10DC2AF6F45F6FD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D694AB5FB367ECE7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5DEECA9076C6D82.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FAA5F4BD8D071CC9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardUpdateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_GameCenterLeaderboardUpdateRequestDataAttributes.Create_GameCenterLeaderboardUpdateRequestDataAttributes(options);
                }
                #pragma warning restore CS0618
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}