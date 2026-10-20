
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_5AFF42D1072BC1F8 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_5AFF42D1072BC1F8 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_5AFF42D1072BC1F8(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionDestination)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionDestination?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiActionType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode)

                    || typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay)

                    || typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind)

                    || typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildAudienceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionDestination))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionDestinationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionDestination?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionDestinationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTestConfigurationKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionTestConfigurationKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTestConfigurationKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionPlatformJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionPlatform?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionPlatformNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiActionType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode))
                {
                    return new global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiFilesAndFoldersRuleModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleFrequencyJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleFrequencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleDayJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiScheduledStartConditionScheduleDayNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind))
                {
                    return new global::AppStoreConnect.JsonConverters.CiTestDestinationKindJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiTestDestinationKind?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiTestDestinationKindNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BuildAudienceType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_BuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiAction))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiAction(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionDestination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiActionDestination2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionPlatform))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiActionPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionTestConfiguration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiActionTestConfiguration(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionTestConfigurationKind))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiActionTestConfigurationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiActionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBranchPatterns))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBranchPatterns(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBranchPatternsPattern))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiBranchPatternsPattern(options);
                }
                if (type == typeof(global::AppStoreConnect.CiBranchStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiBranchStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiFilesAndFoldersRule(options);
                }
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiFilesAndFoldersRuleMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiManualBranchStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiManualBranchStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiManualPullRequestStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiManualPullRequestStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiManualTagStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiManualTagStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiPullRequestStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiPullRequestStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiScheduledStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiScheduledStartConditionSchedule(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiScheduledStartConditionScheduleDay2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiScheduledStartConditionScheduleFrequency2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiStartConditionFileMatcher))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiStartConditionFileMatcher(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTagPatterns))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiTagPatterns(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTagPatternsPattern))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiTagPatternsPattern(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTagStartCondition))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiTagStartCondition(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTestDestination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_CiTestDestination(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTestDestinationKind))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiTestDestinationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequest(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataRelationshipsMacOsVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataRelationshipsMacOsVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataRelationshipsXcodeVersion(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataRelationshipsXcodeVersionData(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_CiWorkflowUpdateRequestDataType2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiAction>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata1.Create_SourceGenerationContextMetadataType_88079F1A701C7D9C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBranchPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B9B02AB79DCC8C48(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_AB2B53F828EB506B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiStartConditionFileMatcher>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D6C436E4DE22642B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiTagPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6D7072D3DD1CBCEF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiTestDestination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E5BB7C99D2A840CA(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(bool?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBoolean(options);
                }
                if (type == typeof(global::AppStoreConnect.BuildAudienceType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableBuildAudienceType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionDestination?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiActionDestination2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionPlatform?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiActionPlatform2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionTestConfigurationKind?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiActionTestConfigurationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiActionType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableCiActionType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiFilesAndFoldersRuleMode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiFilesAndFoldersRuleMode2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleDay?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiScheduledStartConditionScheduleDay2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiScheduledStartConditionScheduleFrequency?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiScheduledStartConditionScheduleFrequency2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiTestDestinationKind?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiTestDestinationKind2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.CiWorkflowUpdateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableCiWorkflowUpdateRequestDataType2(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiAction>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_30C300F3BF01C9E8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBranchPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1A29DB9DE0A0E523(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiScheduledStartConditionScheduleDay>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_679D29544747533F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiStartConditionFileMatcher>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2B4C9E09BA67CF83(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTagPatternsPattern>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_67C7E36A129B3B07(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiTestDestination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_76698A36C75EC160(options);
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