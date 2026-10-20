
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_AB677DFCE60D95BB : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_AB677DFCE60D95BB Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_AB677DFCE60D95BB(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFilterTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFilterTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsNominationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsNominationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionFieldsNomination2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionFilterTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_NominationsGetCollectionSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3D00C74F1CEA1A88(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_63D35A720707ABE8(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_85D671A194BA4913(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsNomination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E1D2038EBCEB56BF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_5FA49EAFE80F5491(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_614E39FE0FA755BD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFilterTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_0B78C25D58626AFE(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_64C6C0DFA6E94056(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C692A643FA374C3A(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionFieldsActor2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionFieldsAppEvent2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionFieldsNomination2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionFieldsTerritorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionFilterStateItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionFilterTypeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionIncludeItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableNominationsGetCollectionSortItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_99D9CC7751087B21(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F4A12FF2AE8F7557(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_35B789E43DCEE626(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsNomination>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B0D41F5934488247(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_595A15712DCF6489(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFilterStateItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_929C0A5EAEFC487E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFilterTypeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_84A97634EB21D45E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_2B121C9E89604748(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionSortItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_81508050309FBEA6(options);
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