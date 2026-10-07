#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem17 : global::System.IEquatable<IncludedItem17>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPagesResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations1 { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageLocalizations1))]
#endif
        public bool IsAppCustomProductPageLocalizations1 => AppCustomProductPageLocalizations1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPageLocalizations1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            value = AppCustomProductPageLocalizations1;
            return IsAppCustomProductPageLocalizations1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageLocalization PickAppCustomProductPageLocalizations1() => AppCustomProductPageLocalizations1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageLocalizations1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPageVersion? AppCustomProductPageVersions { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPageVersion? AppCustomProductPageVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageVersions))]
#endif
        public bool IsAppCustomProductPageVersions => AppCustomProductPageVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPageVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPageVersion? value)
        {
            value = AppCustomProductPageVersions;
            return IsAppCustomProductPageVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageVersion PickAppCustomProductPageVersions() => AppCustomProductPageVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppCustomProductPageLocalizations2 { get; init; }
#else
        public global::AppStoreConnect.App? AppCustomProductPageLocalizations2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageLocalizations2))]
#endif
        public bool IsAppCustomProductPageLocalizations2 => AppCustomProductPageLocalizations2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPageLocalizations2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppCustomProductPageLocalizations2;
            return IsAppCustomProductPageLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickAppCustomProductPageLocalizations2() => AppCustomProductPageLocalizations2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageLocalizations2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem17(global::AppStoreConnect.AppCustomProductPageLocalization value) => new IncludedItem17((global::AppStoreConnect.AppCustomProductPageLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageLocalization?(IncludedItem17 @this) => @this.AppCustomProductPageLocalizations1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem17(global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            AppCustomProductPageLocalizations1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem17 FromAppCustomProductPageLocalizations1(global::AppStoreConnect.AppCustomProductPageLocalization? value) => new IncludedItem17(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem17(global::AppStoreConnect.AppCustomProductPageVersion value) => new IncludedItem17((global::AppStoreConnect.AppCustomProductPageVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageVersion?(IncludedItem17 @this) => @this.AppCustomProductPageVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem17(global::AppStoreConnect.AppCustomProductPageVersion? value)
        {
            AppCustomProductPageVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem17 FromAppCustomProductPageVersions(global::AppStoreConnect.AppCustomProductPageVersion? value) => new IncludedItem17(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem17(global::AppStoreConnect.App value) => new IncludedItem17((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem17 @this) => @this.AppCustomProductPageLocalizations2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem17(global::AppStoreConnect.App? value)
        {
            AppCustomProductPageLocalizations2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem17 FromAppCustomProductPageLocalizations2(global::AppStoreConnect.App? value) => new IncludedItem17(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem17(
            global::AppStoreConnect.AppCustomProductPagesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppCustomProductPageLocalization? appCustomProductPageLocalizations1,
            global::AppStoreConnect.AppCustomProductPageVersion? appCustomProductPageVersions,
            global::AppStoreConnect.App? appCustomProductPageLocalizations2
            )
        {
            Type = type;

            AppCustomProductPageLocalizations1 = appCustomProductPageLocalizations1;
            AppCustomProductPageVersions = appCustomProductPageVersions;
            AppCustomProductPageLocalizations2 = appCustomProductPageLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppCustomProductPageLocalizations2 as object ??
            AppCustomProductPageVersions as object ??
            AppCustomProductPageLocalizations1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppCustomProductPageLocalizations1?.ToString() ??
            AppCustomProductPageVersions?.ToString() ??
            AppCustomProductPageLocalizations2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppCustomProductPageLocalizations1 && !IsAppCustomProductPageVersions && !IsAppCustomProductPageLocalizations2 || !IsAppCustomProductPageLocalizations1 && IsAppCustomProductPageVersions && !IsAppCustomProductPageLocalizations2 || !IsAppCustomProductPageLocalizations1 && !IsAppCustomProductPageVersions && IsAppCustomProductPageLocalizations2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppCustomProductPageLocalization, TResult>? appCustomProductPageLocalizations1 = null,
            global::System.Func<global::AppStoreConnect.AppCustomProductPageVersion, TResult>? appCustomProductPageVersions = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appCustomProductPageLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations1 is { } __value0 && appCustomProductPageLocalizations1 != null)
            {
                return appCustomProductPageLocalizations1(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1 && appCustomProductPageVersions != null)
            {
                return appCustomProductPageVersions(__value1);
            }
            else if (AppCustomProductPageLocalizations2 is { } __value2 && appCustomProductPageLocalizations2 != null)
            {
                return appCustomProductPageLocalizations2(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations1 = null,

            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,

            global::System.Action<global::AppStoreConnect.App>? appCustomProductPageLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations1 is { } __value0)
            {
                appCustomProductPageLocalizations1?.Invoke(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1)
            {
                appCustomProductPageVersions?.Invoke(__value1);
            }
            else if (AppCustomProductPageLocalizations2 is { } __value2)
            {
                appCustomProductPageLocalizations2?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations1 = null,
            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,
            global::System.Action<global::AppStoreConnect.App>? appCustomProductPageLocalizations2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations1 is { } __value0)
            {
                appCustomProductPageLocalizations1?.Invoke(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1)
            {
                appCustomProductPageVersions?.Invoke(__value1);
            }
            else if (AppCustomProductPageLocalizations2 is { } __value2)
            {
                appCustomProductPageLocalizations2?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppCustomProductPageLocalizations1,
                typeof(global::AppStoreConnect.AppCustomProductPageLocalization),
                AppCustomProductPageVersions,
                typeof(global::AppStoreConnect.AppCustomProductPageVersion),
                AppCustomProductPageLocalizations2,
                typeof(global::AppStoreConnect.App),
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
        public bool Equals(IncludedItem17 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageLocalization?>.Default.Equals(AppCustomProductPageLocalizations1, other.AppCustomProductPageLocalizations1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageVersion?>.Default.Equals(AppCustomProductPageVersions, other.AppCustomProductPageVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppCustomProductPageLocalizations2, other.AppCustomProductPageLocalizations2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem17 obj1, IncludedItem17 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem17>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem17 obj1, IncludedItem17 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem17 o && Equals(o);
        }
    }
}
