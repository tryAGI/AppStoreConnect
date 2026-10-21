
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EBC4BBE2F890B3F7
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemTypeNullableJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType2.Create_GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableGameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType2.Create_NullableGameCenterLeaderboardSetCreateRequestDataRelationshipsGameCenterLeaderboardsDataItemType2(options);
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