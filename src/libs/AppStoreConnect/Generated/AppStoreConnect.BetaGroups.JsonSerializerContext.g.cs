
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGroupsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaGroupsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaGroupsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_9D3FCE071F43FA88.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4BA537C95E0893AC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2C690E891F9E1662.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FE1A0051D60AC9F1.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3E513C384057AA53.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5D3A0AF0B4F70120.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4EBBE6FE99C7A456.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D3AAF904507E6F00.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_845522CBF0AA0337.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AFDC555EBFD41FE8.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_595A3A156C6A8099.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B79530C605D25640.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_33FA5086219B54F5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7A82E97E24BF7B68.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DE45B14E8D2206E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_726561F71F2CA118.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7ABEDD8A17970F97.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6A5C24234B905B7D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_82E4AB52E1962463.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_94855AAFAB8AD532.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8AD205A067A745F5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FDCA4006F53462BC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_13F15A03054D5D30.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E3131F9DAEC88A1C.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[27];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_9D3FCE071F43FA88.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_4BA537C95E0893AC.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_2C690E891F9E1662.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_FE1A0051D60AC9F1.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_3E513C384057AA53.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_5D3A0AF0B4F70120.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_4EBBE6FE99C7A456.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_D3AAF904507E6F00.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_845522CBF0AA0337.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_AFDC555EBFD41FE8.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_595A3A156C6A8099.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_B79530C605D25640.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_33FA5086219B54F5.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_7A82E97E24BF7B68.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_6DE45B14E8D2206E.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_726561F71F2CA118.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_7ABEDD8A17970F97.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_6A5C24234B905B7D.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_82E4AB52E1962463.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_94855AAFAB8AD532.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_8AD205A067A745F5.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_FDCA4006F53462BC.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_13F15A03054D5D30.TypeInfoResolver,

                    26 => global::AppStoreConnect.SourceGenerationContextGraph_E3131F9DAEC88A1C.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}