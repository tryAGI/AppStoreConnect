
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_6B347D48677105F7 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_6B347D48677105F7 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_6B347D48677105F7(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsNominationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsNominationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetInstanceFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetInstanceFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetInstanceFieldsNomination2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_98BB6A153F61B458(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DB1D7669BDA8442F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_8A3FD545F57810E4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_424434D7A537E316(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4DDF801B4EEF1F0D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B84393E9C353D5CB(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetInstanceFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetInstanceFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetInstanceFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetInstanceFieldsNomination2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetInstanceFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AA7B7CAFD2CE167D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CBA45220FD25D60A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BE11723A4B1F02BB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DF17E4B594A65D2C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_97C9D32C4C105092(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F23A3F92989FE848(options);
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