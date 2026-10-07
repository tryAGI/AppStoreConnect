#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryImageReadyForReviewAttributes : global::System.IEquatable<AppAssetLibraryImageReadyForReviewAttributes>
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
        public object? AppAssetLibraryImageReadyForReviewAttributesVariant2 { get; init; }
#else
        public object? AppAssetLibraryImageReadyForReviewAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryImageReadyForReviewAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryImageReadyForReviewAttributesVariant2 => AppAssetLibraryImageReadyForReviewAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryImageReadyForReviewAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = AppAssetLibraryImageReadyForReviewAttributesVariant2;
            return IsAppAssetLibraryImageReadyForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickAppAssetLibraryImageReadyForReviewAttributesVariant2() => AppAssetLibraryImageReadyForReviewAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryImageReadyForReviewAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryImageReadyForReviewAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes value) => new AppAssetLibraryImageReadyForReviewAttributes((global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?(AppAssetLibraryImageReadyForReviewAttributes @this) => @this.AppAssetLibraryImageCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageReadyForReviewAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            AppAssetLibraryImageCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryImageReadyForReviewAttributes FromAppAssetLibraryImageCommonAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value) => new AppAssetLibraryImageReadyForReviewAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageReadyForReviewAttributes(
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? appAssetLibraryImageCommonAttributes,
            object? appAssetLibraryImageReadyForReviewAttributesVariant2
            )
        {
            AppAssetLibraryImageCommonAttributes = appAssetLibraryImageCommonAttributes;
            AppAssetLibraryImageReadyForReviewAttributesVariant2 = appAssetLibraryImageReadyForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryImageReadyForReviewAttributesVariant2 as object ??
            AppAssetLibraryImageCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryImageCommonAttributes?.ToString() ??
            AppAssetLibraryImageReadyForReviewAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryImageCommonAttributes && IsAppAssetLibraryImageReadyForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes, TResult>? appAssetLibraryImageCommonAttributes = null,
            global::System.Func<object, TResult>? appAssetLibraryImageReadyForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageReadyForReviewAttributesVariant2 is { } __value1 && appAssetLibraryImageReadyForReviewAttributesVariant2 != null)
            {
                return appAssetLibraryImageReadyForReviewAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,

            global::System.Action<object>? appAssetLibraryImageReadyForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageReadyForReviewAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageReadyForReviewAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,
            global::System.Action<object>? appAssetLibraryImageReadyForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageReadyForReviewAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageReadyForReviewAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryImageReadyForReviewAttributesVariant2,
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
        public bool Equals(AppAssetLibraryImageReadyForReviewAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?>.Default.Equals(AppAssetLibraryImageCommonAttributes, other.AppAssetLibraryImageCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(AppAssetLibraryImageReadyForReviewAttributesVariant2, other.AppAssetLibraryImageReadyForReviewAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryImageReadyForReviewAttributes obj1, AppAssetLibraryImageReadyForReviewAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryImageReadyForReviewAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryImageReadyForReviewAttributes obj1, AppAssetLibraryImageReadyForReviewAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryImageReadyForReviewAttributes o && Equals(o);
        }
    }
}
