#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryVideoUploadCompleteAttributes : global::System.IEquatable<AppAssetLibraryVideoUploadCompleteAttributes>
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
        public global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2? AppAssetLibraryVideoUploadCompleteAttributesVariant2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2? AppAssetLibraryVideoUploadCompleteAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideoUploadCompleteAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryVideoUploadCompleteAttributesVariant2 => AppAssetLibraryVideoUploadCompleteAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideoUploadCompleteAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2? value)
        {
            value = AppAssetLibraryVideoUploadCompleteAttributesVariant2;
            return IsAppAssetLibraryVideoUploadCompleteAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2 PickAppAssetLibraryVideoUploadCompleteAttributesVariant2() => AppAssetLibraryVideoUploadCompleteAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideoUploadCompleteAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoUploadCompleteAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes value) => new AppAssetLibraryVideoUploadCompleteAttributes((global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?(AppAssetLibraryVideoUploadCompleteAttributes @this) => @this.AppAssetLibraryVideoCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoUploadCompleteAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            AppAssetLibraryVideoCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoUploadCompleteAttributes FromAppAssetLibraryVideoCommonAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value) => new AppAssetLibraryVideoUploadCompleteAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoUploadCompleteAttributes(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2 value) => new AppAssetLibraryVideoUploadCompleteAttributes((global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2?(AppAssetLibraryVideoUploadCompleteAttributes @this) => @this.AppAssetLibraryVideoUploadCompleteAttributesVariant2;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoUploadCompleteAttributes(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2? value)
        {
            AppAssetLibraryVideoUploadCompleteAttributesVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoUploadCompleteAttributes FromAppAssetLibraryVideoUploadCompleteAttributesVariant2(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2? value) => new AppAssetLibraryVideoUploadCompleteAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoUploadCompleteAttributes(
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? appAssetLibraryVideoCommonAttributes,
            global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2? appAssetLibraryVideoUploadCompleteAttributesVariant2
            )
        {
            AppAssetLibraryVideoCommonAttributes = appAssetLibraryVideoCommonAttributes;
            AppAssetLibraryVideoUploadCompleteAttributesVariant2 = appAssetLibraryVideoUploadCompleteAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryVideoUploadCompleteAttributesVariant2 as object ??
            AppAssetLibraryVideoCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryVideoCommonAttributes?.ToString() ??
            AppAssetLibraryVideoUploadCompleteAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryVideoCommonAttributes && IsAppAssetLibraryVideoUploadCompleteAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes, TResult>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2, TResult>? appAssetLibraryVideoUploadCompleteAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoUploadCompleteAttributesVariant2 is { } __value1 && appAssetLibraryVideoUploadCompleteAttributesVariant2 != null)
            {
                return appAssetLibraryVideoUploadCompleteAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2>? appAssetLibraryVideoUploadCompleteAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoUploadCompleteAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoUploadCompleteAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2>? appAssetLibraryVideoUploadCompleteAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoUploadCompleteAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoUploadCompleteAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryVideoUploadCompleteAttributesVariant2,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2),
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
        public bool Equals(AppAssetLibraryVideoUploadCompleteAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?>.Default.Equals(AppAssetLibraryVideoCommonAttributes, other.AppAssetLibraryVideoCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoUploadCompleteAttributesVariant2?>.Default.Equals(AppAssetLibraryVideoUploadCompleteAttributesVariant2, other.AppAssetLibraryVideoUploadCompleteAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryVideoUploadCompleteAttributes obj1, AppAssetLibraryVideoUploadCompleteAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryVideoUploadCompleteAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryVideoUploadCompleteAttributes obj1, AppAssetLibraryVideoUploadCompleteAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryVideoUploadCompleteAttributes o && Equals(o);
        }
    }
}
