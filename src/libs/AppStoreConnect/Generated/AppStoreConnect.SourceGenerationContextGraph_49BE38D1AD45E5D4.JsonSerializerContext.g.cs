
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_49BE38D1AD45E5D4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_49BE38D1AD45E5D4 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_49BE38D1AD45E5D4(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeamJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueueJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_GameCenterMatchmakingRuleSetsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_B0436B4F91A887CE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_893A659D42D1164E(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_EA32496C8008308D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_144D310A08F18199(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_D73A16B6A83B8B6A(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam2(options);
                }
                if (type == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableGameCenterMatchmakingRuleSetsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C23BB6AB0E86F853(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_76D675F460EAD2EE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_00DC0F7572776575(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_70945DBE502E419E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_29925C52B007FD7D(options);
                }
                return null;
            }
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