
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D098B77F00014EBC : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D098B77F00014EBC Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D098B77F00014EBC(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem136JsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRelationshipsRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRelationshipsRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTeamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTeamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeamJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueueJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionIncludeItemNullableJsonConverter();
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
                if (type == typeof(double))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Double(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueue))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueue(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueRelationshipsExperimentRuleSet(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueRelationshipsExperimentRuleSetData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueRelationshipsRuleSet(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueRelationshipsRuleSetData(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueRelationshipsRuleSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingQueueType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRule(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleAttributesType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSet(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationships(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueues))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueues(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRules))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsRules(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsRulesDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeams))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsTeams(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsTeamsDataItem(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetsResponse(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminator))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminator(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingRuleType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTeam))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTeam(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTeamAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_GameCenterMatchmakingTeamType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem136))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_IncludedItem1362(options);
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
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_167B134FEF4C37D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_E51931B6C5C29D0F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_0E0E837A5E905CD8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_ED59D27BA0C8036C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_8D43E766D4218C9A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_42E42C129AABEF0A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_6C4DA856547D5CB4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C58227B4DE013C0A(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E48B59134121978B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem136>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_31DC3FC94CE76031(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_05BF36C073875770(options);
                }
                if (type == typeof(int))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Int32(options);
                }
                if (type == typeof(double?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDouble(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingQueueRelationshipsRuleSetDataType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingQueueType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleAttributesType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetRelationshipsRulesDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingRuleType2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableGameCenterMatchmakingTeamType2(options);
                }
                if (type == typeof(global::AppStoreConnect.IncludedItem136?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableIncludedItem1362(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4411A15F89AE18FA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A3BD481CB2CA7B62(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_887A3DEFEFC8FA9D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_85DA7A6D603CDBE8(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2638BEA55C7103AF(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_730033EA2BE32383(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7D498E203280B8FD(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_0AF9426B11A4D958(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CB3227560F5E1616(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem136>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2FFF515B6D9F94FA(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_3F34DBFD50DE05D2(options);
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