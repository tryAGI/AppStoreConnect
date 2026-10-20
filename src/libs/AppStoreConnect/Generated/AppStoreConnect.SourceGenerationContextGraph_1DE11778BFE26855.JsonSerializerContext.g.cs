
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_1DE11778BFE26855 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_1DE11778BFE26855 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_1DE11778BFE26855(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem129JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsImageDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsImageDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationV2RelationshipsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationV2RelationshipsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsImageDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationV2RelationshipsImageDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsImageDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardLocalizationV2RelationshipsImageDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesSubmissionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesSubmissionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesScoreSortTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesScoreSortTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2AttributesVisibilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsActivityDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsActivityDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsChallengeDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsChallengeDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsVersionsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardV2RelationshipsVersionsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterLeaderboardFormatterNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterVersionStateNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.DocumentLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DocumentLinks(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardFormatter2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2RelationshipsImage(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsImageData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2RelationshipsImageData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsImageDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2RelationshipsImageDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2RelationshipsVersion(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2RelationshipsVersionData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardLocalizationV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2AttributesScoreSortType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2AttributesSubmissionType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2AttributesVisibility2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivity))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsActivity(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsActivityData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsActivityDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallenge))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsChallenge(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsChallengeData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsChallengeDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetail))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterDetail(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterDetailData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterGroup(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterGroupData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSets))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSets(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterScoreModerations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsGameCenterScoreModerations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersions))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsVersions(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsVersionsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2RelationshipsVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Attributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2Attributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Relationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2Relationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboard))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2RelationshipsLeaderboard(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2RelationshipsLeaderboardData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizations))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2RelationshipsLocalizations(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Response))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2Response(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminator(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterLeaderboardVersionV2Type2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterVersionState))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_GameCenterVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem129))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1292(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_F9B7F725042B2331(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_FD35EBB76C3818AD(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_025EFA1CCECE9BEA(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem129>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_A431D373E3E17009(options);
                }
                if (type == typeof(global::System.DateTime))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_DateTime(options);
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
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardFormatter?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardFormatter2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsImageDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardLocalizationV2RelationshipsImageDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardLocalizationV2RelationshipsVersionDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardLocalizationV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardLocalizationV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesScoreSortType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2AttributesScoreSortType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesSubmissionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2AttributesSubmissionType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2AttributesVisibility?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2AttributesVisibility2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivityDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2RelationshipsActivityDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallengeDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2RelationshipsChallengeDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetailDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2RelationshipsGameCenterDetailDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroupDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2RelationshipsGameCenterGroupDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2RelationshipsVersionsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardV2Type2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardVersionV2RelationshipsLeaderboardDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItemType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardVersionV2ResponseIncludedItemDiscriminatorType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.GameCenterLeaderboardVersionV2Type?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterLeaderboardVersionV2Type2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::AppStoreConnect.GameCenterVersionState?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterVersionState2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem129?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1292(options);
                }
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSetsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B637A18950B143A7(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersionsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_39C90618A4FF8826(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizationsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CA3545F29D98B4A2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem129>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C5DD0B808DFBF835(options);
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