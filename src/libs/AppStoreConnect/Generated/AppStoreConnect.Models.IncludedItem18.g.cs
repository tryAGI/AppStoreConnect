#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem18 : global::System.IEquatable<IncludedItem18>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEncryptionDeclarationDocument? AppEncryptionDeclarationDocuments1 { get; init; }
#else
        public global::AppStoreConnect.AppEncryptionDeclarationDocument? AppEncryptionDeclarationDocuments1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEncryptionDeclarationDocuments1))]
#endif
        public bool IsAppEncryptionDeclarationDocuments1 => AppEncryptionDeclarationDocuments1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppEncryptionDeclarationDocuments1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEncryptionDeclarationDocument? value)
        {
            value = AppEncryptionDeclarationDocuments1;
            return IsAppEncryptionDeclarationDocuments1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppEncryptionDeclarationDocument PickAppEncryptionDeclarationDocuments1() => IsAppEncryptionDeclarationDocuments1
            ? AppEncryptionDeclarationDocuments1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEncryptionDeclarationDocuments1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppEncryptionDeclarationDocuments2 { get; init; }
#else
        public global::AppStoreConnect.App? AppEncryptionDeclarationDocuments2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEncryptionDeclarationDocuments2))]
#endif
        public bool IsAppEncryptionDeclarationDocuments2 => AppEncryptionDeclarationDocuments2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAppEncryptionDeclarationDocuments2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppEncryptionDeclarationDocuments2;
            return IsAppEncryptionDeclarationDocuments2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.App PickAppEncryptionDeclarationDocuments2() => IsAppEncryptionDeclarationDocuments2
            ? AppEncryptionDeclarationDocuments2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEncryptionDeclarationDocuments2' but the value was {ToString()}.");

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
        public global::AppStoreConnect.Build PickBuilds() => IsBuilds
            ? Builds!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builds' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem18(global::AppStoreConnect.AppEncryptionDeclarationDocument value) => new IncludedItem18((global::AppStoreConnect.AppEncryptionDeclarationDocument?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEncryptionDeclarationDocument?(IncludedItem18 @this) => @this.AppEncryptionDeclarationDocuments1;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem18(global::AppStoreConnect.AppEncryptionDeclarationDocument? value)
        {
            AppEncryptionDeclarationDocuments1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem18 FromAppEncryptionDeclarationDocuments1(global::AppStoreConnect.AppEncryptionDeclarationDocument? value) => new IncludedItem18(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem18(global::AppStoreConnect.App value) => new IncludedItem18((global::AppStoreConnect.App?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem18 @this) => @this.AppEncryptionDeclarationDocuments2;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem18(global::AppStoreConnect.App? value)
        {
            AppEncryptionDeclarationDocuments2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem18 FromAppEncryptionDeclarationDocuments2(global::AppStoreConnect.App? value) => new IncludedItem18(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem18(global::AppStoreConnect.Build value) => new IncludedItem18((global::AppStoreConnect.Build?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem18 @this) => @this.Builds;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem18(global::AppStoreConnect.Build? value)
        {
            Builds = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem18 FromBuilds(global::AppStoreConnect.Build? value) => new IncludedItem18(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem18(
            global::AppStoreConnect.AppEncryptionDeclarationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppEncryptionDeclarationDocument? appEncryptionDeclarationDocuments1,
            global::AppStoreConnect.App? appEncryptionDeclarationDocuments2,
            global::AppStoreConnect.Build? builds
            )
        {
            Type = type;

            AppEncryptionDeclarationDocuments1 = appEncryptionDeclarationDocuments1;
            AppEncryptionDeclarationDocuments2 = appEncryptionDeclarationDocuments2;
            Builds = builds;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Builds as object ??
            AppEncryptionDeclarationDocuments2 as object ??
            AppEncryptionDeclarationDocuments1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AppEncryptionDeclarationDocuments1?.ToString() ??
            AppEncryptionDeclarationDocuments2?.ToString() ??
            Builds?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppEncryptionDeclarationDocuments1 && !IsAppEncryptionDeclarationDocuments2 && !IsBuilds || !IsAppEncryptionDeclarationDocuments1 && IsAppEncryptionDeclarationDocuments2 && !IsBuilds || !IsAppEncryptionDeclarationDocuments1 && !IsAppEncryptionDeclarationDocuments2 && IsBuilds;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppEncryptionDeclarationDocument, TResult>? appEncryptionDeclarationDocuments1 = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appEncryptionDeclarationDocuments2 = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEncryptionDeclarationDocuments1 && appEncryptionDeclarationDocuments1 != null)
            {
                return appEncryptionDeclarationDocuments1(AppEncryptionDeclarationDocuments1!);
            }
            else if (IsAppEncryptionDeclarationDocuments2 && appEncryptionDeclarationDocuments2 != null)
            {
                return appEncryptionDeclarationDocuments2(AppEncryptionDeclarationDocuments2!);
            }
            else if (IsBuilds && builds != null)
            {
                return builds(Builds!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppEncryptionDeclarationDocument>? appEncryptionDeclarationDocuments1 = null,

            global::System.Action<global::AppStoreConnect.App>? appEncryptionDeclarationDocuments2 = null,

            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEncryptionDeclarationDocuments1)
            {
                appEncryptionDeclarationDocuments1?.Invoke(AppEncryptionDeclarationDocuments1!);
            }
            else if (IsAppEncryptionDeclarationDocuments2)
            {
                appEncryptionDeclarationDocuments2?.Invoke(AppEncryptionDeclarationDocuments2!);
            }
            else if (IsBuilds)
            {
                builds?.Invoke(Builds!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppEncryptionDeclarationDocument>? appEncryptionDeclarationDocuments1 = null,
            global::System.Action<global::AppStoreConnect.App>? appEncryptionDeclarationDocuments2 = null,
            global::System.Action<global::AppStoreConnect.Build>? builds = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEncryptionDeclarationDocuments1)
            {
                appEncryptionDeclarationDocuments1?.Invoke(AppEncryptionDeclarationDocuments1!);
            }
            else if (IsAppEncryptionDeclarationDocuments2)
            {
                appEncryptionDeclarationDocuments2?.Invoke(AppEncryptionDeclarationDocuments2!);
            }
            else if (IsBuilds)
            {
                builds?.Invoke(Builds!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppEncryptionDeclarationDocuments1,
                typeof(global::AppStoreConnect.AppEncryptionDeclarationDocument),
                AppEncryptionDeclarationDocuments2,
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
        public bool Equals(IncludedItem18 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEncryptionDeclarationDocument?>.Default.Equals(AppEncryptionDeclarationDocuments1, other.AppEncryptionDeclarationDocuments1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppEncryptionDeclarationDocuments2, other.AppEncryptionDeclarationDocuments2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(Builds, other.Builds) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem18 obj1, IncludedItem18 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem18>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem18 obj1, IncludedItem18 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem18 o && Equals(o);
        }
    }
}
