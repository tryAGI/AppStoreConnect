#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryImageRejectedAttributes : global::System.IEquatable<AppAssetLibraryImageRejectedAttributes>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? AppAssetLibraryImageCommonAttributes { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? AppAssetLibraryImageCommonAttributes { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryImageCommonAttributes))]
#endif
        public bool IsAppAssetLibraryImageCommonAttributes => AppAssetLibraryImageCommonAttributes != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryImageCommonAttributes(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            value = AppAssetLibraryImageCommonAttributes;
            return IsAppAssetLibraryImageCommonAttributes;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageCommonAttributes PickAppAssetLibraryImageCommonAttributes() => AppAssetLibraryImageCommonAttributes is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryImageCommonAttributes' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? AppAssetLibraryImageRejectedAttributesVariant2 { get; init; }
#else
        public object? AppAssetLibraryImageRejectedAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryImageRejectedAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryImageRejectedAttributesVariant2 => AppAssetLibraryImageRejectedAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryImageRejectedAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = AppAssetLibraryImageRejectedAttributesVariant2;
            return IsAppAssetLibraryImageRejectedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickAppAssetLibraryImageRejectedAttributesVariant2() => AppAssetLibraryImageRejectedAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryImageRejectedAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryImageRejectedAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes value) => new AppAssetLibraryImageRejectedAttributes((global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?(AppAssetLibraryImageRejectedAttributes @this) => @this.AppAssetLibraryImageCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageRejectedAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            AppAssetLibraryImageCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryImageRejectedAttributes FromAppAssetLibraryImageCommonAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value) => new AppAssetLibraryImageRejectedAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageRejectedAttributes(
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? appAssetLibraryImageCommonAttributes,
            object? appAssetLibraryImageRejectedAttributesVariant2
            )
        {
            AppAssetLibraryImageCommonAttributes = appAssetLibraryImageCommonAttributes;
            AppAssetLibraryImageRejectedAttributesVariant2 = appAssetLibraryImageRejectedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryImageRejectedAttributesVariant2 as object ??
            AppAssetLibraryImageCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryImageCommonAttributes?.ToString() ??
            AppAssetLibraryImageRejectedAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryImageCommonAttributes && IsAppAssetLibraryImageRejectedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes, TResult>? appAssetLibraryImageCommonAttributes = null,
            global::System.Func<object, TResult>? appAssetLibraryImageRejectedAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImageCommonAttributes is { } __value0 && appAssetLibraryImageCommonAttributes != null)
            {
                return appAssetLibraryImageCommonAttributes(__value0);
            }
            else if (AppAssetLibraryImageRejectedAttributesVariant2 is { } __value1 && appAssetLibraryImageRejectedAttributesVariant2 != null)
            {
                return appAssetLibraryImageRejectedAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,

            global::System.Action<object>? appAssetLibraryImageRejectedAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImageCommonAttributes is { } __value0)
            {
                appAssetLibraryImageCommonAttributes?.Invoke(__value0);
            }
            else if (AppAssetLibraryImageRejectedAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageRejectedAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,
            global::System.Action<object>? appAssetLibraryImageRejectedAttributesVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImageCommonAttributes is { } __value0)
            {
                appAssetLibraryImageCommonAttributes?.Invoke(__value0);
            }
            else if (AppAssetLibraryImageRejectedAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageRejectedAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryImageCommonAttributes,
                typeof(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes),
                AppAssetLibraryImageRejectedAttributesVariant2,
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
        public bool Equals(AppAssetLibraryImageRejectedAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?>.Default.Equals(AppAssetLibraryImageCommonAttributes, other.AppAssetLibraryImageCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(AppAssetLibraryImageRejectedAttributesVariant2, other.AppAssetLibraryImageRejectedAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryImageRejectedAttributes obj1, AppAssetLibraryImageRejectedAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryImageRejectedAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryImageRejectedAttributes obj1, AppAssetLibraryImageRejectedAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryImageRejectedAttributes o && Equals(o);
        }
    }
}
