
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_FA22A6324F64A380 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_FA22A6324F64A380 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_FA22A6324F64A380(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ActorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType)

                    || typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ActorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorAttributesActorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ActorAttributesActorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.ActorAttributesActorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeCustomCodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeCustomCodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(bool))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Boolean(options);
                }
                if (type == typeof(global::AppStoreConnect.Actor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Actor(options);
                }
                if (type == typeof(global::AppStoreConnect.ActorAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ActorAttributes(options);
                }
                if (type == typeof(global::AppStoreConnect.ActorAttributesActorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ActorAttributesActorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ActorType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ActorType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCode(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActor(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActor(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodeType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesResponse))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_InAppPurchaseOfferCodeCustomCodesResponse(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
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
                if (type == typeof(global::AppStoreConnect.ResourceLinks))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_ResourceLinks(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Actor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_70EFA0EF2991C0AC(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata2.Create_SourceGenerationContextMetadataType_793E3F76C63D2B0A(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_0E5EACE527340D0F(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_9C6915BD0C414EE5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_2098AACECFF7C0C5(options);
                }
                #pragma warning restore CS0618
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
                if (type == typeof(global::AppStoreConnect.ActorAttributesActorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableActorAttributesActorType2(options);
                }
                if (type == typeof(global::AppStoreConnect.ActorType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableActorType2(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActorDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableInAppPurchaseOfferCodeCustomCodeType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem2(options);
                }
                #pragma warning restore CS0618
                if (type == typeof(global::System.DateTime?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableDateTime(options);
                }
                if (type == typeof(int?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableInt32(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Actor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_SourceGenerationContextMetadataType_1F91F1FBECFDC805(options);
                }
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_F5F3328B0F53B0BB(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_3976C5A4F26A77A7(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_26B2879C05068FBB(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_F8E9DF716635FC08(options);
                }
                #pragma warning restore CS0618
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