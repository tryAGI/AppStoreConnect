#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryImageWaitingForReviewAttributes : global::System.IEquatable<AppAssetLibraryImageWaitingForReviewAttributes>
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
        public object? AppAssetLibraryImageWaitingForReviewAttributesVariant2 { get; init; }
#else
        public object? AppAssetLibraryImageWaitingForReviewAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryImageWaitingForReviewAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryImageWaitingForReviewAttributesVariant2 => AppAssetLibraryImageWaitingForReviewAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryImageWaitingForReviewAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = AppAssetLibraryImageWaitingForReviewAttributesVariant2;
            return IsAppAssetLibraryImageWaitingForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickAppAssetLibraryImageWaitingForReviewAttributesVariant2() => AppAssetLibraryImageWaitingForReviewAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryImageWaitingForReviewAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryImageWaitingForReviewAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes value) => new AppAssetLibraryImageWaitingForReviewAttributes((global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?(AppAssetLibraryImageWaitingForReviewAttributes @this) => @this.AppAssetLibraryImageCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageWaitingForReviewAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            AppAssetLibraryImageCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryImageWaitingForReviewAttributes FromAppAssetLibraryImageCommonAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value) => new AppAssetLibraryImageWaitingForReviewAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageWaitingForReviewAttributes(
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? appAssetLibraryImageCommonAttributes,
            object? appAssetLibraryImageWaitingForReviewAttributesVariant2
            )
        {
            AppAssetLibraryImageCommonAttributes = appAssetLibraryImageCommonAttributes;
            AppAssetLibraryImageWaitingForReviewAttributesVariant2 = appAssetLibraryImageWaitingForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryImageWaitingForReviewAttributesVariant2 as object ??
            AppAssetLibraryImageCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryImageCommonAttributes?.ToString() ??
            AppAssetLibraryImageWaitingForReviewAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryImageCommonAttributes && IsAppAssetLibraryImageWaitingForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes, TResult>? appAssetLibraryImageCommonAttributes = null,
            global::System.Func<object, TResult>? appAssetLibraryImageWaitingForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageWaitingForReviewAttributesVariant2 is { } __value1 && appAssetLibraryImageWaitingForReviewAttributesVariant2 != null)
            {
                return appAssetLibraryImageWaitingForReviewAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,

            global::System.Action<object>? appAssetLibraryImageWaitingForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageWaitingForReviewAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageWaitingForReviewAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,
            global::System.Action<object>? appAssetLibraryImageWaitingForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageWaitingForReviewAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageWaitingForReviewAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryImageWaitingForReviewAttributesVariant2,
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
        public bool Equals(AppAssetLibraryImageWaitingForReviewAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?>.Default.Equals(AppAssetLibraryImageCommonAttributes, other.AppAssetLibraryImageCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(AppAssetLibraryImageWaitingForReviewAttributesVariant2, other.AppAssetLibraryImageWaitingForReviewAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryImageWaitingForReviewAttributes obj1, AppAssetLibraryImageWaitingForReviewAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryImageWaitingForReviewAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryImageWaitingForReviewAttributes obj1, AppAssetLibraryImageWaitingForReviewAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryImageWaitingForReviewAttributes o && Equals(o);
        }
    }
}
