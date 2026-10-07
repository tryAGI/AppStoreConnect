#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryVideoReadyForReviewAttributes : global::System.IEquatable<AppAssetLibraryVideoReadyForReviewAttributes>
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
        public object? AppAssetLibraryVideoReadyForReviewAttributesVariant2 { get; init; }
#else
        public object? AppAssetLibraryVideoReadyForReviewAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideoReadyForReviewAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryVideoReadyForReviewAttributesVariant2 => AppAssetLibraryVideoReadyForReviewAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideoReadyForReviewAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = AppAssetLibraryVideoReadyForReviewAttributesVariant2;
            return IsAppAssetLibraryVideoReadyForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickAppAssetLibraryVideoReadyForReviewAttributesVariant2() => AppAssetLibraryVideoReadyForReviewAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideoReadyForReviewAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoReadyForReviewAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes value) => new AppAssetLibraryVideoReadyForReviewAttributes((global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?(AppAssetLibraryVideoReadyForReviewAttributes @this) => @this.AppAssetLibraryVideoCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoReadyForReviewAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            AppAssetLibraryVideoCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoReadyForReviewAttributes FromAppAssetLibraryVideoCommonAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value) => new AppAssetLibraryVideoReadyForReviewAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoReadyForReviewAttributes(
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? appAssetLibraryVideoCommonAttributes,
            object? appAssetLibraryVideoReadyForReviewAttributesVariant2
            )
        {
            AppAssetLibraryVideoCommonAttributes = appAssetLibraryVideoCommonAttributes;
            AppAssetLibraryVideoReadyForReviewAttributesVariant2 = appAssetLibraryVideoReadyForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryVideoReadyForReviewAttributesVariant2 as object ??
            AppAssetLibraryVideoCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryVideoCommonAttributes?.ToString() ??
            AppAssetLibraryVideoReadyForReviewAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryVideoCommonAttributes && IsAppAssetLibraryVideoReadyForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes, TResult>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Func<object, TResult>? appAssetLibraryVideoReadyForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoReadyForReviewAttributesVariant2 is { } __value1 && appAssetLibraryVideoReadyForReviewAttributesVariant2 != null)
            {
                return appAssetLibraryVideoReadyForReviewAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,

            global::System.Action<object>? appAssetLibraryVideoReadyForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoReadyForReviewAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoReadyForReviewAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Action<object>? appAssetLibraryVideoReadyForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoReadyForReviewAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoReadyForReviewAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryVideoReadyForReviewAttributesVariant2,
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
        public bool Equals(AppAssetLibraryVideoReadyForReviewAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?>.Default.Equals(AppAssetLibraryVideoCommonAttributes, other.AppAssetLibraryVideoCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(AppAssetLibraryVideoReadyForReviewAttributesVariant2, other.AppAssetLibraryVideoReadyForReviewAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryVideoReadyForReviewAttributes obj1, AppAssetLibraryVideoReadyForReviewAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryVideoReadyForReviewAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryVideoReadyForReviewAttributes obj1, AppAssetLibraryVideoReadyForReviewAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryVideoReadyForReviewAttributes o && Equals(o);
        }
    }
}
