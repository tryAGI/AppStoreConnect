
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificatesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CertificatesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CertificatesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_D836BE7B5F4BD3EF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B7DF97547F0B3216.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6EA5B436E36000E9.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6A654E9695F0CBDF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0D68B7C19C5D694E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_663CBD176BE3B562.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_26942CE27A087595.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_70294BCC36EB493F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_714E8B4D8C007D5F.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[12];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_D836BE7B5F4BD3EF.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B7DF97547F0B3216.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_6EA5B436E36000E9.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_6A654E9695F0CBDF.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_0D68B7C19C5D694E.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_663CBD176BE3B562.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_26942CE27A087595.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_70294BCC36EB493F.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_714E8B4D8C007D5F.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}