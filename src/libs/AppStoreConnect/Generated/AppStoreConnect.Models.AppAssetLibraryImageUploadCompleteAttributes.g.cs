#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryImageUploadCompleteAttributes : global::System.IEquatable<AppAssetLibraryImageUploadCompleteAttributes>
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
        public global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2? AppAssetLibraryImageUploadCompleteAttributesVariant2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2? AppAssetLibraryImageUploadCompleteAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryImageUploadCompleteAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryImageUploadCompleteAttributesVariant2 => AppAssetLibraryImageUploadCompleteAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryImageUploadCompleteAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2? value)
        {
            value = AppAssetLibraryImageUploadCompleteAttributesVariant2;
            return IsAppAssetLibraryImageUploadCompleteAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2 PickAppAssetLibraryImageUploadCompleteAttributesVariant2() => AppAssetLibraryImageUploadCompleteAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryImageUploadCompleteAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryImageUploadCompleteAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes value) => new AppAssetLibraryImageUploadCompleteAttributes((global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?(AppAssetLibraryImageUploadCompleteAttributes @this) => @this.AppAssetLibraryImageCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageUploadCompleteAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            AppAssetLibraryImageCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryImageUploadCompleteAttributes FromAppAssetLibraryImageCommonAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value) => new AppAssetLibraryImageUploadCompleteAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryImageUploadCompleteAttributes(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2 value) => new AppAssetLibraryImageUploadCompleteAttributes((global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2?(AppAssetLibraryImageUploadCompleteAttributes @this) => @this.AppAssetLibraryImageUploadCompleteAttributesVariant2;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageUploadCompleteAttributes(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2? value)
        {
            AppAssetLibraryImageUploadCompleteAttributesVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryImageUploadCompleteAttributes FromAppAssetLibraryImageUploadCompleteAttributesVariant2(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2? value) => new AppAssetLibraryImageUploadCompleteAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageUploadCompleteAttributes(
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? appAssetLibraryImageCommonAttributes,
            global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2? appAssetLibraryImageUploadCompleteAttributesVariant2
            )
        {
            AppAssetLibraryImageCommonAttributes = appAssetLibraryImageCommonAttributes;
            AppAssetLibraryImageUploadCompleteAttributesVariant2 = appAssetLibraryImageUploadCompleteAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryImageUploadCompleteAttributesVariant2 as object ??
            AppAssetLibraryImageCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryImageCommonAttributes?.ToString() ??
            AppAssetLibraryImageUploadCompleteAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryImageCommonAttributes && IsAppAssetLibraryImageUploadCompleteAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes, TResult>? appAssetLibraryImageCommonAttributes = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2, TResult>? appAssetLibraryImageUploadCompleteAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageUploadCompleteAttributesVariant2 is { } __value1 && appAssetLibraryImageUploadCompleteAttributesVariant2 != null)
            {
                return appAssetLibraryImageUploadCompleteAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2>? appAssetLibraryImageUploadCompleteAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageUploadCompleteAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageUploadCompleteAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2>? appAssetLibraryImageUploadCompleteAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageUploadCompleteAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageUploadCompleteAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryImageUploadCompleteAttributesVariant2,
                typeof(global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2),
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
        public bool Equals(AppAssetLibraryImageUploadCompleteAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?>.Default.Equals(AppAssetLibraryImageCommonAttributes, other.AppAssetLibraryImageCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageUploadCompleteAttributesVariant2?>.Default.Equals(AppAssetLibraryImageUploadCompleteAttributesVariant2, other.AppAssetLibraryImageUploadCompleteAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryImageUploadCompleteAttributes obj1, AppAssetLibraryImageUploadCompleteAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryImageUploadCompleteAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryImageUploadCompleteAttributes obj1, AppAssetLibraryImageUploadCompleteAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryImageUploadCompleteAttributes o && Equals(o);
        }
    }
}
