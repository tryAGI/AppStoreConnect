
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_F95629C384F3780F : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_F95629C384F3780F Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_F95629C384F3780F(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem83JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2RelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementLocalizationV2RelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsAchievementDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsAchievementDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2RelationshipsImage(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2RelationshipsImageData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2RelationshipsImageDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2RelationshipsVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2RelationshipsVersionData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2RelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementLocalizationV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsActivity(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsActivityData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsActivityDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsGameCenterDetail(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsGameCenterDetailData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsGameCenterDetailDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsGameCenterGroup(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsGameCenterGroupData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsGameCenterGroupDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsVersions(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsVersionsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2RelationshipsVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2RelationshipsAchievement(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2RelationshipsAchievementData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2RelationshipsAchievementDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2RelationshipsLocalizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2Response))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionsV2Response(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminator(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem83))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_IncludedItem832(options);
                }
                if (type == typeof(global::AppStoreConnect.PagedDocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagedDocumentLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformation))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_PagingInformation(options);
                }
                if (type == typeof(global::AppStoreConnect.PagingInformationPaging))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_PagingInformationPaging(options);
                }
                if (type == typeof(global::AppStoreConnect.RelationshipLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_RelationshipLinks(options);
                }
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_593B24410976DFD9(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B11A5801C840858C(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_5F9E0B292C1A50CD(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E3A9DE9EB337F694(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BAD2CA903CE226A4(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3FB5416C9AC16DA8(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_2D1E669F444E5666(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem83>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_B42A055C7530CD3B(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementLocalizationV2RelationshipsImageDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2RelationshipsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementLocalizationV2RelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementLocalizationV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementLocalizationV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivityDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementV2RelationshipsActivityDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementV2RelationshipsGameCenterDetailDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroupDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementV2RelationshipsGameCenterGroupDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementV2RelationshipsVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievementDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementVersionV2RelationshipsAchievementDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementVersionV2RelationshipsLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementVersionV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterAchievementVersionsV2ResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem83?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem832(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9F370005E7982AE7(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementVersionV2>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DF6EE2043809A92D(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0041D4BE747A06E1(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_9DBEAD72BB45AEAA(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_BC37517273CC3157(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F8F022255EFFFD26(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_6F0B5537CF2CAC48(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem83>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2A4B62D89CE0147E(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}