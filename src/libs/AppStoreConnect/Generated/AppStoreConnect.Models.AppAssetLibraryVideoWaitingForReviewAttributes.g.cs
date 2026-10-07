#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryVideoWaitingForReviewAttributes : global::System.IEquatable<AppAssetLibraryVideoWaitingForReviewAttributes>
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
        public object? AppAssetLibraryVideoWaitingForReviewAttributesVariant2 { get; init; }
#else
        public object? AppAssetLibraryVideoWaitingForReviewAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideoWaitingForReviewAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryVideoWaitingForReviewAttributesVariant2 => AppAssetLibraryVideoWaitingForReviewAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideoWaitingForReviewAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = AppAssetLibraryVideoWaitingForReviewAttributesVariant2;
            return IsAppAssetLibraryVideoWaitingForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickAppAssetLibraryVideoWaitingForReviewAttributesVariant2() => AppAssetLibraryVideoWaitingForReviewAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideoWaitingForReviewAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoWaitingForReviewAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes value) => new AppAssetLibraryVideoWaitingForReviewAttributes((global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?(AppAssetLibraryVideoWaitingForReviewAttributes @this) => @this.AppAssetLibraryVideoCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoWaitingForReviewAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            AppAssetLibraryVideoCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoWaitingForReviewAttributes FromAppAssetLibraryVideoCommonAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value) => new AppAssetLibraryVideoWaitingForReviewAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoWaitingForReviewAttributes(
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? appAssetLibraryVideoCommonAttributes,
            object? appAssetLibraryVideoWaitingForReviewAttributesVariant2
            )
        {
            AppAssetLibraryVideoCommonAttributes = appAssetLibraryVideoCommonAttributes;
            AppAssetLibraryVideoWaitingForReviewAttributesVariant2 = appAssetLibraryVideoWaitingForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryVideoWaitingForReviewAttributesVariant2 as object ??
            AppAssetLibraryVideoCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryVideoCommonAttributes?.ToString() ??
            AppAssetLibraryVideoWaitingForReviewAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryVideoCommonAttributes && IsAppAssetLibraryVideoWaitingForReviewAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes, TResult>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Func<object, TResult>? appAssetLibraryVideoWaitingForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoWaitingForReviewAttributesVariant2 is { } __value1 && appAssetLibraryVideoWaitingForReviewAttributesVariant2 != null)
            {
                return appAssetLibraryVideoWaitingForReviewAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,

            global::System.Action<object>? appAssetLibraryVideoWaitingForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoWaitingForReviewAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoWaitingForReviewAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Action<object>? appAssetLibraryVideoWaitingForReviewAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoWaitingForReviewAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoWaitingForReviewAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryVideoWaitingForReviewAttributesVariant2,
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
        public bool Equals(AppAssetLibraryVideoWaitingForReviewAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?>.Default.Equals(AppAssetLibraryVideoCommonAttributes, other.AppAssetLibraryVideoCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(AppAssetLibraryVideoWaitingForReviewAttributesVariant2, other.AppAssetLibraryVideoWaitingForReviewAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryVideoWaitingForReviewAttributes obj1, AppAssetLibraryVideoWaitingForReviewAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryVideoWaitingForReviewAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryVideoWaitingForReviewAttributes obj1, AppAssetLibraryVideoWaitingForReviewAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryVideoWaitingForReviewAttributes o && Equals(o);
        }
    }
}
