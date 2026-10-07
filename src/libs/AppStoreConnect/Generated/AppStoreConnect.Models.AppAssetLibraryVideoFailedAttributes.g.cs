#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryVideoFailedAttributes : global::System.IEquatable<AppAssetLibraryVideoFailedAttributes>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? AppAssetLibraryVideoCommonAttributes { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? AppAssetLibraryVideoCommonAttributes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideoCommonAttributes))]
#endif
        public bool IsAppAssetLibraryVideoCommonAttributes => AppAssetLibraryVideoCommonAttributes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideoCommonAttributes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            value = AppAssetLibraryVideoCommonAttributes;
            return IsAppAssetLibraryVideoCommonAttributes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes PickAppAssetLibraryVideoCommonAttributes() => AppAssetLibraryVideoCommonAttributes is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideoCommonAttributes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2? AppAssetLibraryVideoFailedAttributesVariant2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2? AppAssetLibraryVideoFailedAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideoFailedAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryVideoFailedAttributesVariant2 => AppAssetLibraryVideoFailedAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideoFailedAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2? value)
        {
            value = AppAssetLibraryVideoFailedAttributesVariant2;
            return IsAppAssetLibraryVideoFailedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2 PickAppAssetLibraryVideoFailedAttributesVariant2() => AppAssetLibraryVideoFailedAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideoFailedAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoFailedAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes value) => new AppAssetLibraryVideoFailedAttributes((global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?(AppAssetLibraryVideoFailedAttributes @this) => @this.AppAssetLibraryVideoCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoFailedAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            AppAssetLibraryVideoCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoFailedAttributes FromAppAssetLibraryVideoCommonAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value) => new AppAssetLibraryVideoFailedAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoFailedAttributes(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2 value) => new AppAssetLibraryVideoFailedAttributes((global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2?(AppAssetLibraryVideoFailedAttributes @this) => @this.AppAssetLibraryVideoFailedAttributesVariant2;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoFailedAttributes(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2? value)
        {
            AppAssetLibraryVideoFailedAttributesVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoFailedAttributes FromAppAssetLibraryVideoFailedAttributesVariant2(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2? value) => new AppAssetLibraryVideoFailedAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoFailedAttributes(
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? appAssetLibraryVideoCommonAttributes,
            global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2? appAssetLibraryVideoFailedAttributesVariant2
            )
        {
            AppAssetLibraryVideoCommonAttributes = appAssetLibraryVideoCommonAttributes;
            AppAssetLibraryVideoFailedAttributesVariant2 = appAssetLibraryVideoFailedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryVideoFailedAttributesVariant2 as object ??
            AppAssetLibraryVideoCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryVideoCommonAttributes?.ToString() ??
            AppAssetLibraryVideoFailedAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryVideoCommonAttributes && IsAppAssetLibraryVideoFailedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes, TResult>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2, TResult>? appAssetLibraryVideoFailedAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryVideoCommonAttributes is { } __value0 && appAssetLibraryVideoCommonAttributes != null)
            {
                return appAssetLibraryVideoCommonAttributes(__value0);
            }
            else if (AppAssetLibraryVideoFailedAttributesVariant2 is { } __value1 && appAssetLibraryVideoFailedAttributesVariant2 != null)
            {
                return appAssetLibraryVideoFailedAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2>? appAssetLibraryVideoFailedAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryVideoCommonAttributes is { } __value0)
            {
                appAssetLibraryVideoCommonAttributes?.Invoke(__value0);
            }
            else if (AppAssetLibraryVideoFailedAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoFailedAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2>? appAssetLibraryVideoFailedAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryVideoCommonAttributes is { } __value0)
            {
                appAssetLibraryVideoCommonAttributes?.Invoke(__value0);
            }
            else if (AppAssetLibraryVideoFailedAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoFailedAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryVideoCommonAttributes,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes),
                AppAssetLibraryVideoFailedAttributesVariant2,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2),
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
        public bool Equals(AppAssetLibraryVideoFailedAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?>.Default.Equals(AppAssetLibraryVideoCommonAttributes, other.AppAssetLibraryVideoCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoFailedAttributesVariant2?>.Default.Equals(AppAssetLibraryVideoFailedAttributesVariant2, other.AppAssetLibraryVideoFailedAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryVideoFailedAttributes obj1, AppAssetLibraryVideoFailedAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryVideoFailedAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryVideoFailedAttributes obj1, AppAssetLibraryVideoFailedAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryVideoFailedAttributes o && Equals(o);
        }
    }
}
