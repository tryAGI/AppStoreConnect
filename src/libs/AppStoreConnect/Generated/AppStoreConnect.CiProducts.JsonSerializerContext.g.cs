
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiProductsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CiProductsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CiProductsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_0D86CE405F68CA4F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_48A35DFFECB0A606.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_84D3CF577C628E59.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C5390AA41DB0BF10.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2BA68103F83BE0CA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_14EE4E076E36B379.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_45D66797ADE7E6CB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F22B9CB03047C407.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DC71ECCD95D86AC6.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_78F293D95A2CEA92.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D8A5D4FF54A7CF4D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_504C0CC0E9248B8B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_14AB76D94851D2DA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_81082FC71A60F6E4.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C580B938909CAAFE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6F1A3F5BB6E36843.AddConverters(options);
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

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[19];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_0D86CE405F68CA4F.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_48A35DFFECB0A606.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_84D3CF577C628E59.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_C5390AA41DB0BF10.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_2BA68103F83BE0CA.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_14EE4E076E36B379.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_45D66797ADE7E6CB.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_F22B9CB03047C407.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_DC71ECCD95D86AC6.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_78F293D95A2CEA92.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_D8A5D4FF54A7CF4D.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_504C0CC0E9248B8B.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_14AB76D94851D2DA.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_81082FC71A60F6E4.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_C580B938909CAAFE.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_6F1A3F5BB6E36843.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}