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
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageLocalizations))]
#endif
        public bool IsAppCustomProductPageLocalizations => AppCustomProductPageLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPageLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            value = AppCustomProductPageLocalizations;
            return IsAppCustomProductPageLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageLocalization PickAppCustomProductPageLocalizations() => AppCustomProductPageLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageLocalizations' but the value was {ToString()}.");

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
        public global::AppStoreConnect.App? Apps { get; init; }
#else
        public global::AppStoreConnect.App? Apps { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Apps))]
#endif
        public bool IsApps => Apps != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = Apps;
            return IsApps;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickApps() => Apps is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Apps' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem17(global::AppStoreConnect.AppCustomProductPageLocalization value) => new IncludedItem17((global::AppStoreConnect.AppCustomProductPageLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageLocalization?(IncludedItem17 @this) => @this.AppCustomProductPageLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem17(global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            AppCustomProductPageLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem17 FromAppCustomProductPageLocalizations(global::AppStoreConnect.AppCustomProductPageLocalization? value) => new IncludedItem17(value);

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
        public static implicit operator global::AppStoreConnect.App?(IncludedItem17 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem17(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem17 FromApps(global::AppStoreConnect.App? value) => new IncludedItem17(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem17(
            global::AppStoreConnect.AppCustomProductPagesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppCustomProductPageLocalization? appCustomProductPageLocalizations,
            global::AppStoreConnect.AppCustomProductPageVersion? appCustomProductPageVersions,
            global::AppStoreConnect.App? apps
            )
        {
            Type = type;

            AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
            AppCustomProductPageVersions = appCustomProductPageVersions;
            Apps = apps;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Apps as object ??
            AppCustomProductPageVersions as object ??
            AppCustomProductPageLocalizations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppCustomProductPageLocalizations?.ToString() ??
            AppCustomProductPageVersions?.ToString() ??
            Apps?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppCustomProductPageLocalizations && !IsAppCustomProductPageVersions && !IsApps || !IsAppCustomProductPageLocalizations && IsAppCustomProductPageVersions && !IsApps || !IsAppCustomProductPageLocalizations && !IsAppCustomProductPageVersions && IsApps;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppCustomProductPageLocalization, TResult>? appCustomProductPageLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppCustomProductPageVersion, TResult>? appCustomProductPageVersions = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations is { } __value0 && appCustomProductPageLocalizations != null)
            {
                return appCustomProductPageLocalizations(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1 && appCustomProductPageVersions != null)
            {
                return appCustomProductPageVersions(__value1);
            }
            else if (Apps is { } __value2 && apps != null)
            {
                return apps(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,

            global::System.Action<global::AppStoreConnect.App>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations is { } __value0)
            {
                appCustomProductPageLocalizations?.Invoke(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1)
            {
                appCustomProductPageVersions?.Invoke(__value1);
            }
            else if (Apps is { } __value2)
            {
                apps?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppCustomProductPageLocalizations is { } __value0)
            {
                appCustomProductPageLocalizations?.Invoke(__value0);
            }
            else if (AppCustomProductPageVersions is { } __value1)
            {
                appCustomProductPageVersions?.Invoke(__value1);
            }
            else if (Apps is { } __value2)
            {
                apps?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppCustomProductPageLocalizations,
                typeof(global::AppStoreConnect.AppCustomProductPageLocalization),
                AppCustomProductPageVersions,
                typeof(global::AppStoreConnect.AppCustomProductPageVersion),
                Apps,
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
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageLocalization?>.Default.Equals(AppCustomProductPageLocalizations, other.AppCustomProductPageLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageVersion?>.Default.Equals(AppCustomProductPageVersions, other.AppCustomProductPageVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps)
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
