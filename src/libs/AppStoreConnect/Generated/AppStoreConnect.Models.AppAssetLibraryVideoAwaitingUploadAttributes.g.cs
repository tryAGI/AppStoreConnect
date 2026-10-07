#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryVideoAwaitingUploadAttributes : global::System.IEquatable<AppAssetLibraryVideoAwaitingUploadAttributes>
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
        public global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2? AppAssetLibraryVideoAwaitingUploadAttributesVariant2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2? AppAssetLibraryVideoAwaitingUploadAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideoAwaitingUploadAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryVideoAwaitingUploadAttributesVariant2 => AppAssetLibraryVideoAwaitingUploadAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideoAwaitingUploadAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2? value)
        {
            value = AppAssetLibraryVideoAwaitingUploadAttributesVariant2;
            return IsAppAssetLibraryVideoAwaitingUploadAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2 PickAppAssetLibraryVideoAwaitingUploadAttributesVariant2() => AppAssetLibraryVideoAwaitingUploadAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideoAwaitingUploadAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoAwaitingUploadAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes value) => new AppAssetLibraryVideoAwaitingUploadAttributes((global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?(AppAssetLibraryVideoAwaitingUploadAttributes @this) => @this.AppAssetLibraryVideoCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoAwaitingUploadAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value)
        {
            AppAssetLibraryVideoCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoAwaitingUploadAttributes FromAppAssetLibraryVideoCommonAttributes(global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? value) => new AppAssetLibraryVideoAwaitingUploadAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryVideoAwaitingUploadAttributes(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2 value) => new AppAssetLibraryVideoAwaitingUploadAttributes((global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2?(AppAssetLibraryVideoAwaitingUploadAttributes @this) => @this.AppAssetLibraryVideoAwaitingUploadAttributesVariant2;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoAwaitingUploadAttributes(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2? value)
        {
            AppAssetLibraryVideoAwaitingUploadAttributesVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryVideoAwaitingUploadAttributes FromAppAssetLibraryVideoAwaitingUploadAttributesVariant2(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2? value) => new AppAssetLibraryVideoAwaitingUploadAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryVideoAwaitingUploadAttributes(
            global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes? appAssetLibraryVideoCommonAttributes,
            global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2? appAssetLibraryVideoAwaitingUploadAttributesVariant2
            )
        {
            AppAssetLibraryVideoCommonAttributes = appAssetLibraryVideoCommonAttributes;
            AppAssetLibraryVideoAwaitingUploadAttributesVariant2 = appAssetLibraryVideoAwaitingUploadAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryVideoAwaitingUploadAttributesVariant2 as object ??
            AppAssetLibraryVideoCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryVideoCommonAttributes?.ToString() ??
            AppAssetLibraryVideoAwaitingUploadAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryVideoCommonAttributes && IsAppAssetLibraryVideoAwaitingUploadAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes, TResult>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2, TResult>? appAssetLibraryVideoAwaitingUploadAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoAwaitingUploadAttributesVariant2 is { } __value1 && appAssetLibraryVideoAwaitingUploadAttributesVariant2 != null)
            {
                return appAssetLibraryVideoAwaitingUploadAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2>? appAssetLibraryVideoAwaitingUploadAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoAwaitingUploadAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoAwaitingUploadAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes>? appAssetLibraryVideoCommonAttributes = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2>? appAssetLibraryVideoAwaitingUploadAttributesVariant2 = null,
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
            else if (AppAssetLibraryVideoAwaitingUploadAttributesVariant2 is { } __value1)
            {
                appAssetLibraryVideoAwaitingUploadAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryVideoAwaitingUploadAttributesVariant2,
                typeof(global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2),
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
        public bool Equals(AppAssetLibraryVideoAwaitingUploadAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoCommonAttributes?>.Default.Equals(AppAssetLibraryVideoCommonAttributes, other.AppAssetLibraryVideoCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideoAwaitingUploadAttributesVariant2?>.Default.Equals(AppAssetLibraryVideoAwaitingUploadAttributesVariant2, other.AppAssetLibraryVideoAwaitingUploadAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryVideoAwaitingUploadAttributes obj1, AppAssetLibraryVideoAwaitingUploadAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryVideoAwaitingUploadAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryVideoAwaitingUploadAttributes obj1, AppAssetLibraryVideoAwaitingUploadAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryVideoAwaitingUploadAttributes o && Equals(o);
        }
    }
}
