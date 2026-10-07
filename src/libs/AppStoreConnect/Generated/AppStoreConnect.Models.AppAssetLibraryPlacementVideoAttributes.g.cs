#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryPlacementVideoAttributes : global::System.IEquatable<AppAssetLibraryPlacementVideoAttributes>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes? AppAssetLibraryPlacementCommonAttributes { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes? AppAssetLibraryPlacementCommonAttributes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacementCommonAttributes))]
#endif
        public bool IsAppAssetLibraryPlacementCommonAttributes => AppAssetLibraryPlacementCommonAttributes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacementCommonAttributes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes? value)
        {
            value = AppAssetLibraryPlacementCommonAttributes;
            return IsAppAssetLibraryPlacementCommonAttributes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes PickAppAssetLibraryPlacementCommonAttributes() => AppAssetLibraryPlacementCommonAttributes is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacementCommonAttributes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? AppAssetLibraryPlacementVideoAttributesVariant2 { get; init; }
#else
        public object? AppAssetLibraryPlacementVideoAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacementVideoAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryPlacementVideoAttributesVariant2 => AppAssetLibraryPlacementVideoAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacementVideoAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = AppAssetLibraryPlacementVideoAttributesVariant2;
            return IsAppAssetLibraryPlacementVideoAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickAppAssetLibraryPlacementVideoAttributesVariant2() => AppAssetLibraryPlacementVideoAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacementVideoAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryPlacementVideoAttributes(global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes value) => new AppAssetLibraryPlacementVideoAttributes((global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes?(AppAssetLibraryPlacementVideoAttributes @this) => @this.AppAssetLibraryPlacementCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryPlacementVideoAttributes(global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes? value)
        {
            AppAssetLibraryPlacementCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryPlacementVideoAttributes FromAppAssetLibraryPlacementCommonAttributes(global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes? value) => new AppAssetLibraryPlacementVideoAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryPlacementVideoAttributes(
            global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes? appAssetLibraryPlacementCommonAttributes,
            object? appAssetLibraryPlacementVideoAttributesVariant2
            )
        {
            AppAssetLibraryPlacementCommonAttributes = appAssetLibraryPlacementCommonAttributes;
            AppAssetLibraryPlacementVideoAttributesVariant2 = appAssetLibraryPlacementVideoAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryPlacementVideoAttributesVariant2 as object ??
            AppAssetLibraryPlacementCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryPlacementCommonAttributes?.ToString() ??
            AppAssetLibraryPlacementVideoAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryPlacementCommonAttributes && IsAppAssetLibraryPlacementVideoAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes, TResult>? appAssetLibraryPlacementCommonAttributes = null,
            global::System.Func<object, TResult>? appAssetLibraryPlacementVideoAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonAttributes is { } __value0 && appAssetLibraryPlacementCommonAttributes != null)
            {
                return appAssetLibraryPlacementCommonAttributes(__value0);
            }
            else if (AppAssetLibraryPlacementVideoAttributesVariant2 is { } __value1 && appAssetLibraryPlacementVideoAttributesVariant2 != null)
            {
                return appAssetLibraryPlacementVideoAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes>? appAssetLibraryPlacementCommonAttributes = null,

            global::System.Action<object>? appAssetLibraryPlacementVideoAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonAttributes is { } __value0)
            {
                appAssetLibraryPlacementCommonAttributes?.Invoke(__value0);
            }
            else if (AppAssetLibraryPlacementVideoAttributesVariant2 is { } __value1)
            {
                appAssetLibraryPlacementVideoAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes>? appAssetLibraryPlacementCommonAttributes = null,
            global::System.Action<object>? appAssetLibraryPlacementVideoAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacementCommonAttributes is { } __value0)
            {
                appAssetLibraryPlacementCommonAttributes?.Invoke(__value0);
            }
            else if (AppAssetLibraryPlacementVideoAttributesVariant2 is { } __value1)
            {
                appAssetLibraryPlacementVideoAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryPlacementCommonAttributes,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes),
                AppAssetLibraryPlacementVideoAttributesVariant2,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AppAssetLibraryPlacementVideoAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacementCommonAttributes?>.Default.Equals(AppAssetLibraryPlacementCommonAttributes, other.AppAssetLibraryPlacementCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(AppAssetLibraryPlacementVideoAttributesVariant2, other.AppAssetLibraryPlacementVideoAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryPlacementVideoAttributes obj1, AppAssetLibraryPlacementVideoAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryPlacementVideoAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryPlacementVideoAttributes obj1, AppAssetLibraryPlacementVideoAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryPlacementVideoAttributes o && Equals(o);
        }
    }
}
