
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppStoreVersionLocalizationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppStoreVersionLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_65B06398B7E5752E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_56976E725DD68882.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_1C45D79320B8F56D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_149B8B9DD7106003.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6555EEA8FCC88A47.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2BDFD2F0F75408FE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5230EC4CB836F147.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_00B936CE9D07576C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CEA395C35E802C56.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0F6CFA5FEBC36902.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A321A1A2843C84BA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_218EDE7C19E3B09C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01D26459F4B06E4D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6426A0703B85F664.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9B0CA27F94F54D30.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E4FD32A6ABD1FB5F.AddConverters(options);
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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_65B06398B7E5752E.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_56976E725DD68882.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_1C45D79320B8F56D.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_149B8B9DD7106003.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_6555EEA8FCC88A47.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_2BDFD2F0F75408FE.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_5230EC4CB836F147.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_00B936CE9D07576C.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_CEA395C35E802C56.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_0F6CFA5FEBC36902.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_A321A1A2843C84BA.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_218EDE7C19E3B09C.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_01D26459F4B06E4D.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_6426A0703B85F664.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_9B0CA27F94F54D30.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_E4FD32A6ABD1FB5F.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}