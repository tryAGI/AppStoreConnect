#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem21 : global::System.IEquatable<IncludedItem21>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEncryptionDeclarationResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEncryptionDeclarationDocument? AppEncryptionDeclarationDocuments { get; init; }
#else
        public global::AppStoreConnect.AppEncryptionDeclarationDocument? AppEncryptionDeclarationDocuments { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEncryptionDeclarationDocuments))]
#endif
        public bool IsAppEncryptionDeclarationDocuments => AppEncryptionDeclarationDocuments != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEncryptionDeclarationDocuments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEncryptionDeclarationDocument? value)
        {
            value = AppEncryptionDeclarationDocuments;
            return IsAppEncryptionDeclarationDocuments;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEncryptionDeclarationDocument PickAppEncryptionDeclarationDocuments() => AppEncryptionDeclarationDocuments is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEncryptionDeclarationDocuments' but the value was {ToString()}.");

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
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Build? Builds { get; init; }
#else
        public global::AppStoreConnect.Build? Builds { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Builds))]
#endif
        public bool IsBuilds => Builds != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuilds(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Build? value)
        {
            value = Builds;
            return IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Build PickBuilds() => Builds is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builds' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem21(global::AppStoreConnect.AppEncryptionDeclarationDocument value) => new IncludedItem21((global::AppStoreConnect.AppEncryptionDeclarationDocument?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEncryptionDeclarationDocument?(IncludedItem21 @this) => @this.AppEncryptionDeclarationDocuments;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem21(global::AppStoreConnect.AppEncryptionDeclarationDocument? value)
        {
            AppEncryptionDeclarationDocuments = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem21 FromAppEncryptionDeclarationDocuments(global::AppStoreConnect.AppEncryptionDeclarationDocument? value) => new IncludedItem21(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem21(global::AppStoreConnect.App value) => new IncludedItem21((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem21 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem21(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem21 FromApps(global::AppStoreConnect.App? value) => new IncludedItem21(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem21(global::AppStoreConnect.Build value) => new IncludedItem21((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem21 @this) => @this.Builds;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem21(global::AppStoreConnect.Build? value)
        {
            Builds = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem21 FromBuilds(global::AppStoreConnect.Build? value) => new IncludedItem21(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem21(
            global::AppStoreConnect.AppEncryptionDeclarationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppEncryptionDeclarationDocument? appEncryptionDeclarationDocuments,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.Build? builds
            )
        {
            Type = type;

            AppEncryptionDeclarationDocuments = appEncryptionDeclarationDocuments;
            Apps = apps;
            Builds = builds;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Builds as object ??
            Apps as object ??
            AppEncryptionDeclarationDocuments as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppEncryptionDeclarationDocuments?.ToString() ??
            Apps?.ToString() ??
            Builds?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppEncryptionDeclarationDocuments && !IsApps && !IsBuilds || !IsAppEncryptionDeclarationDocuments && IsApps && !IsBuilds || !IsAppEncryptionDeclarationDocuments && !IsApps && IsBuilds;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppEncryptionDeclarationDocument, TResult>? appEncryptionDeclarationDocuments = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppEncryptionDeclarationDocuments is { } __value0 && appEncryptionDeclarationDocuments != null)
            {
                return appEncryptionDeclarationDocuments(__value0);
            }
            else if (Apps is { } __value1 && apps != null)
            {
                return apps(__value1);
            }
            else if (Builds is { } __value2 && builds != null)
            {
                return builds(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppEncryptionDeclarationDocument>? appEncryptionDeclarationDocuments = null,

            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppEncryptionDeclarationDocuments is { } __value0)
            {
                appEncryptionDeclarationDocuments?.Invoke(__value0);
            }
            else if (Apps is { } __value1)
            {
                apps?.Invoke(__value1);
            }
            else if (Builds is { } __value2)
            {
                builds?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppEncryptionDeclarationDocument>? appEncryptionDeclarationDocuments = null,
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppEncryptionDeclarationDocuments is { } __value0)
            {
                appEncryptionDeclarationDocuments?.Invoke(__value0);
            }
            else if (Apps is { } __value1)
            {
                apps?.Invoke(__value1);
            }
            else if (Builds is { } __value2)
            {
                builds?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppEncryptionDeclarationDocuments,
                typeof(global::AppStoreConnect.AppEncryptionDeclarationDocument),
                Apps,
                typeof(global::AppStoreConnect.App),
                Builds,
                typeof(global::AppStoreConnect.Build),
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
        public bool Equals(IncludedItem21 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEncryptionDeclarationDocument?>.Default.Equals(AppEncryptionDeclarationDocuments, other.AppEncryptionDeclarationDocuments) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(Builds, other.Builds)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem21 obj1, IncludedItem21 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem21>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem21 obj1, IncludedItem21 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem21 o && Equals(o);
        }
    }
}
