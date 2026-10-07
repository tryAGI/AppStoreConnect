#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryVideoRejectedAttributes : global::System.IEquatable<AppAssetLibraryVideoRejectedAttributes>
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
        public object? AppAssetLibraryVideoRejectedAttributesVariant2 { get; init; }
#else
        public object? AppAssetLibraryVideoRejectedAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideoRejectedAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryVideoRejectedAttributesVariant2 => AppAssetLibraryVideoRejectedAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideoRejectedAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = AppAssetLibraryVideoRejectedAttributesVariant2;
            return IsAppAssetLibraryVideoRejectedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickAppAssetLibraryVideoRejectedAttributesVariant2() => AppAssetLibraryVideoRejectedAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideoRejectedAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoRejectedAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes value) => new AppAssetLibraryVideoRejectedAttributes((global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?(AppAssetLibraryVideoRejectedAttributes @this) => @this.AppAssetLibraryVideoCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoRejectedAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            AppAssetLibraryVideoCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoRejectedAttributes FromAppAssetLibraryVideoCommonAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value) => new AppAssetLibraryVideoRejectedAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoRejectedAttributes(
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? appAssetLibraryVideoCommonAttributes,
            object? appAssetLibraryVideoRejectedAttributesVariant2
            )
        {
            AppAssetLibraryVideoCommonAttributes = appAssetLibraryVideoCommonAttributes;
            AppAssetLibraryVideoRejectedAttributesVariant2 = appAssetLibraryVideoRejectedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryVideoRejectedAttributesVariant2 as object ??
            AppAssetLibraryVideoCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryVideoCommonAttributes?.ToString() ??
            AppAssetLibraryVideoRejectedAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryVideoCommonAttributes && IsAppAssetLibraryVideoRejectedAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes, TResult>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Func<object, TResult>? appAssetLibraryVideoRejectedAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoRejectedAttributesVariant2 is { } __value1 && appAssetLibraryVideoRejectedAttributesVariant2 != null)
            {
                return appAssetLibraryVideoRejectedAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,

            global::System.Action<object>? appAssetLibraryVideoRejectedAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoRejectedAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoRejectedAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Action<object>? appAssetLibraryVideoRejectedAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoRejectedAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoRejectedAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryVideoRejectedAttributesVariant2,
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
        public bool Equals(AppAssetLibraryVideoRejectedAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?>.Default.Equals(AppAssetLibraryVideoCommonAttributes, other.AppAssetLibraryVideoCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(AppAssetLibraryVideoRejectedAttributesVariant2, other.AppAssetLibraryVideoRejectedAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryVideoRejectedAttributes obj1, AppAssetLibraryVideoRejectedAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryVideoRejectedAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryVideoRejectedAttributes obj1, AppAssetLibraryVideoRejectedAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryVideoRejectedAttributes o && Equals(o);
        }
    }
}
