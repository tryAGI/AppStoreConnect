#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AppAssetLibraryImageAwaitingUploadAttributes : global::System.IEquatable<AppAssetLibraryImageAwaitingUploadAttributes>
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
        public global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2? AppAssetLibraryImageAwaitingUploadAttributesVariant2 { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2? AppAssetLibraryImageAwaitingUploadAttributesVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryImageAwaitingUploadAttributesVariant2))]
#endif
        public bool IsAppAssetLibraryImageAwaitingUploadAttributesVariant2 => AppAssetLibraryImageAwaitingUploadAttributesVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryImageAwaitingUploadAttributesVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2? value)
        {
            value = AppAssetLibraryImageAwaitingUploadAttributesVariant2;
            return IsAppAssetLibraryImageAwaitingUploadAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2 PickAppAssetLibraryImageAwaitingUploadAttributesVariant2() => AppAssetLibraryImageAwaitingUploadAttributesVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryImageAwaitingUploadAttributesVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryImageAwaitingUploadAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes value) => new AppAssetLibraryImageAwaitingUploadAttributes((global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?(AppAssetLibraryImageAwaitingUploadAttributes @this) => @this.AppAssetLibraryImageCommonAttributes;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageAwaitingUploadAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value)
        {
            AppAssetLibraryImageCommonAttributes = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryImageAwaitingUploadAttributes FromAppAssetLibraryImageCommonAttributes(global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? value) => new AppAssetLibraryImageAwaitingUploadAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AppAssetLibraryImageAwaitingUploadAttributes(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2 value) => new AppAssetLibraryImageAwaitingUploadAttributes((global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2?(AppAssetLibraryImageAwaitingUploadAttributes @this) => @this.AppAssetLibraryImageAwaitingUploadAttributesVariant2;

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageAwaitingUploadAttributes(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2? value)
        {
            AppAssetLibraryImageAwaitingUploadAttributesVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AppAssetLibraryImageAwaitingUploadAttributes FromAppAssetLibraryImageAwaitingUploadAttributesVariant2(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2? value) => new AppAssetLibraryImageAwaitingUploadAttributes(value);

        /// <summary>
        ///
        /// </summary>
        public AppAssetLibraryImageAwaitingUploadAttributes(
            global::AppStoreConnect.AppAssetLibraryImageCommonAttributes? appAssetLibraryImageCommonAttributes,
            global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2? appAssetLibraryImageAwaitingUploadAttributesVariant2
            )
        {
            AppAssetLibraryImageCommonAttributes = appAssetLibraryImageCommonAttributes;
            AppAssetLibraryImageAwaitingUploadAttributesVariant2 = appAssetLibraryImageAwaitingUploadAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppAssetLibraryImageAwaitingUploadAttributesVariant2 as object ??
            AppAssetLibraryImageCommonAttributes as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryImageCommonAttributes?.ToString() ??
            AppAssetLibraryImageAwaitingUploadAttributesVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryImageCommonAttributes && IsAppAssetLibraryImageAwaitingUploadAttributesVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes, TResult>? appAssetLibraryImageCommonAttributes = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2, TResult>? appAssetLibraryImageAwaitingUploadAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageAwaitingUploadAttributesVariant2 is { } __value1 && appAssetLibraryImageAwaitingUploadAttributesVariant2 != null)
            {
                return appAssetLibraryImageAwaitingUploadAttributesVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2>? appAssetLibraryImageAwaitingUploadAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageAwaitingUploadAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageAwaitingUploadAttributesVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes>? appAssetLibraryImageCommonAttributes = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2>? appAssetLibraryImageAwaitingUploadAttributesVariant2 = null,
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
            else if (AppAssetLibraryImageAwaitingUploadAttributesVariant2 is { } __value1)
            {
                appAssetLibraryImageAwaitingUploadAttributesVariant2?.Invoke(__value1);
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
                AppAssetLibraryImageAwaitingUploadAttributesVariant2,
                typeof(global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2),
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
        public bool Equals(AppAssetLibraryImageAwaitingUploadAttributes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageCommonAttributes?>.Default.Equals(AppAssetLibraryImageCommonAttributes, other.AppAssetLibraryImageCommonAttributes) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImageAwaitingUploadAttributesVariant2?>.Default.Equals(AppAssetLibraryImageAwaitingUploadAttributesVariant2, other.AppAssetLibraryImageAwaitingUploadAttributesVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AppAssetLibraryImageAwaitingUploadAttributes obj1, AppAssetLibraryImageAwaitingUploadAttributes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppAssetLibraryImageAwaitingUploadAttributes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AppAssetLibraryImageAwaitingUploadAttributes obj1, AppAssetLibraryImageAwaitingUploadAttributes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppAssetLibraryImageAwaitingUploadAttributes o && Equals(o);
        }
    }
}
