
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B9D87EDE7F90377C
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
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalizationJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization?), static () => new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalizationNullableJsonConverter());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization2.Create_GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_NullableGameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization2.Create_NullableGameCenterLeaderboardSetImagesGetInstanceFieldsGameCenterLeaderboardSetLocalization2(options);
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