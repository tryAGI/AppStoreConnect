
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserType), TypeInfoPropertyName = "UserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserRelationshipsVisibleApps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UserRelationshipsVisibleAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserRelationshipsVisibleAppsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserRelationshipsVisibleAppsDataItemType), TypeInfoPropertyName = "UserRelationshipsVisibleAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestDataType), TypeInfoPropertyName = "UserUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleApps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItemType), TypeInfoPropertyName = "UserUpdateRequestDataRelationshipsVisibleAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserVisibleAppsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItemType), TypeInfoPropertyName = "UserVisibleAppsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserVisibleAppsLinkagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItemType), TypeInfoPropertyName = "UserVisibleAppsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFilterRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionFilterRole), TypeInfoPropertyName = "UsersGetCollectionFilterRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionSortItem), TypeInfoPropertyName = "UsersGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFieldsUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionFieldsUser), TypeInfoPropertyName = "UsersGetCollectionFieldsUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionFieldsApp), TypeInfoPropertyName = "UsersGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionIncludeItem), TypeInfoPropertyName = "UsersGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceFieldsUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetInstanceFieldsUser), TypeInfoPropertyName = "UsersGetInstanceFieldsUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetInstanceFieldsApp), TypeInfoPropertyName = "UsersGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetInstanceIncludeItem), TypeInfoPropertyName = "UsersGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.UsersVisibleAppsGetToManyRelatedFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersVisibleAppsGetToManyRelatedFieldsApp), TypeInfoPropertyName = "UsersVisibleAppsGetToManyRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserType?), TypeInfoPropertyName = "NullableUserType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserRelationshipsVisibleAppsDataItemType?), TypeInfoPropertyName = "NullableUserRelationshipsVisibleAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestDataType?), TypeInfoPropertyName = "NullableUserUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItemType?), TypeInfoPropertyName = "NullableUserUpdateRequestDataRelationshipsVisibleAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableUserVisibleAppsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItemType?), TypeInfoPropertyName = "NullableUserVisibleAppsLinkagesRequestDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionFilterRole?), TypeInfoPropertyName = "NullableUsersGetCollectionFilterRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionSortItem?), TypeInfoPropertyName = "NullableUsersGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionFieldsUser?), TypeInfoPropertyName = "NullableUsersGetCollectionFieldsUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionFieldsApp?), TypeInfoPropertyName = "NullableUsersGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableUsersGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetInstanceFieldsUser?), TypeInfoPropertyName = "NullableUsersGetInstanceFieldsUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableUsersGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableUsersGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.UsersVisibleAppsGetToManyRelatedFieldsApp?), TypeInfoPropertyName = "NullableUsersVisibleAppsGetToManyRelatedFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UserRelationshipsVisibleAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersGetCollectionFilterRole>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersGetCollectionFieldsUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersGetInstanceFieldsUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.UsersVisibleAppsGetToManyRelatedFieldsApp>))]
    internal sealed partial class UsersSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static UsersSourceGenerationContext Default { get; } = new(DefaultOptions);

        private UsersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
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
                    typeToConvert == typeof(global::AppStoreConnect.UserType)

                    || typeToConvert == typeof(global::AppStoreConnect.UserType?)

                    || typeToConvert == typeof(global::AppStoreConnect.UserRelationshipsVisibleAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.UserRelationshipsVisibleAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.UserUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.UserUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFilterRole)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFilterRole?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFieldsUser)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFieldsUser?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceFieldsUser)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceFieldsUser?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersVisibleAppsGetToManyRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.UsersVisibleAppsGetToManyRelatedFieldsApp?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.UserType))
                {
                    return new global::AppStoreConnect.JsonConverters.UserTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserType?))
                {
                    return new global::AppStoreConnect.JsonConverters.UserTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserRelationshipsVisibleAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.UserRelationshipsVisibleAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserRelationshipsVisibleAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.UserRelationshipsVisibleAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.UserUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.UserUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.UserUpdateRequestDataRelationshipsVisibleAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserUpdateRequestDataRelationshipsVisibleAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.UserUpdateRequestDataRelationshipsVisibleAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.UserVisibleAppsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserVisibleAppsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.UserVisibleAppsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.UserVisibleAppsLinkagesRequestDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UserVisibleAppsLinkagesRequestDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.UserVisibleAppsLinkagesRequestDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFilterRole))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionFilterRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFilterRole?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionFilterRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFieldsUser))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionFieldsUserJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFieldsUser?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionFieldsUserNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceFieldsUser))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetInstanceFieldsUserJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceFieldsUser?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetInstanceFieldsUserNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersVisibleAppsGetToManyRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersVisibleAppsGetToManyRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.UsersVisibleAppsGetToManyRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.UsersVisibleAppsGetToManyRelatedFieldsAppNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new UsersSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}