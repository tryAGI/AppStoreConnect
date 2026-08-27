#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem11 : global::System.IEquatable<IncludedItem11>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AppCustomProductPageVersion PickAppCustomProductPageVersions() => IsAppCustomProductPageVersions
            ? AppCustomProductPageVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppKeyword? AppKeywords { get; init; }
#else
        public global::AppStoreConnect.AppKeyword? AppKeywords { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppKeywords))]
#endif
        public bool IsAppKeywords => AppKeywords != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppKeywords(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppKeyword? value)
        {
            value = AppKeywords;
            return IsAppKeywords;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppKeyword PickAppKeywords() => IsAppKeywords
            ? AppKeywords!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppKeywords' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppPreviewSet? AppPreviewSets { get; init; }
#else
        public global::AppStoreConnect.AppPreviewSet? AppPreviewSets { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppPreviewSets))]
#endif
        public bool IsAppPreviewSets => AppPreviewSets != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppPreviewSets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppPreviewSet? value)
        {
            value = AppPreviewSets;
            return IsAppPreviewSets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPreviewSet PickAppPreviewSets() => IsAppPreviewSets
            ? AppPreviewSets!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppPreviewSets' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppScreenshotSet? AppScreenshotSets { get; init; }
#else
        public global::AppStoreConnect.AppScreenshotSet? AppScreenshotSets { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppScreenshotSets))]
#endif
        public bool IsAppScreenshotSets => AppScreenshotSets != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppScreenshotSets(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppScreenshotSet? value)
        {
            value = AppScreenshotSets;
            return IsAppScreenshotSets;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppScreenshotSet PickAppScreenshotSets() => IsAppScreenshotSets
            ? AppScreenshotSets!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppScreenshotSets' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem11(global::AppStoreConnect.AppCustomProductPageVersion value) => new IncludedItem11((global::AppStoreConnect.AppCustomProductPageVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageVersion?(IncludedItem11 @this) => @this.AppCustomProductPageVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem11(global::AppStoreConnect.AppCustomProductPageVersion? value)
        {
            AppCustomProductPageVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem11 FromAppCustomProductPageVersions(global::AppStoreConnect.AppCustomProductPageVersion? value) => new IncludedItem11(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem11(global::AppStoreConnect.AppKeyword value) => new IncludedItem11((global::AppStoreConnect.AppKeyword?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppKeyword?(IncludedItem11 @this) => @this.AppKeywords;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem11(global::AppStoreConnect.AppKeyword? value)
        {
            AppKeywords = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem11 FromAppKeywords(global::AppStoreConnect.AppKeyword? value) => new IncludedItem11(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem11(global::AppStoreConnect.AppPreviewSet value) => new IncludedItem11((global::AppStoreConnect.AppPreviewSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPreviewSet?(IncludedItem11 @this) => @this.AppPreviewSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem11(global::AppStoreConnect.AppPreviewSet? value)
        {
            AppPreviewSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem11 FromAppPreviewSets(global::AppStoreConnect.AppPreviewSet? value) => new IncludedItem11(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem11(global::AppStoreConnect.AppScreenshotSet value) => new IncludedItem11((global::AppStoreConnect.AppScreenshotSet?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppScreenshotSet?(IncludedItem11 @this) => @this.AppScreenshotSets;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem11(global::AppStoreConnect.AppScreenshotSet? value)
        {
            AppScreenshotSets = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem11 FromAppScreenshotSets(global::AppStoreConnect.AppScreenshotSet? value) => new IncludedItem11(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem11(
            global::AppStoreConnect.AppCustomProductPageLocalizationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppCustomProductPageVersion? appCustomProductPageVersions,
            global::AppStoreConnect.AppKeyword? appKeywords,
            global::AppStoreConnect.AppPreviewSet? appPreviewSets,
            global::AppStoreConnect.AppScreenshotSet? appScreenshotSets
            )
        {
            Type = type;

            AppCustomProductPageVersions = appCustomProductPageVersions;
            AppKeywords = appKeywords;
            AppPreviewSets = appPreviewSets;
            AppScreenshotSets = appScreenshotSets;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppScreenshotSets as object ??
            AppPreviewSets as object ??
            AppKeywords as object ??
            AppCustomProductPageVersions as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppCustomProductPageVersions?.ToString() ??
            AppKeywords?.ToString() ??
            AppPreviewSets?.ToString() ??
            AppScreenshotSets?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppCustomProductPageVersions && !IsAppKeywords && !IsAppPreviewSets && !IsAppScreenshotSets || !IsAppCustomProductPageVersions && IsAppKeywords && !IsAppPreviewSets && !IsAppScreenshotSets || !IsAppCustomProductPageVersions && !IsAppKeywords && IsAppPreviewSets && !IsAppScreenshotSets || !IsAppCustomProductPageVersions && !IsAppKeywords && !IsAppPreviewSets && IsAppScreenshotSets;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppCustomProductPageVersion, TResult>? appCustomProductPageVersions = null,
            global::System.Func<global::AppStoreConnect.AppKeyword, TResult>? appKeywords = null,
            global::System.Func<global::AppStoreConnect.AppPreviewSet, TResult>? appPreviewSets = null,
            global::System.Func<global::AppStoreConnect.AppScreenshotSet, TResult>? appScreenshotSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageVersions && appCustomProductPageVersions != null)
            {
                return appCustomProductPageVersions(AppCustomProductPageVersions!);
            }
            else if (IsAppKeywords && appKeywords != null)
            {
                return appKeywords(AppKeywords!);
            }
            else if (IsAppPreviewSets && appPreviewSets != null)
            {
                return appPreviewSets(AppPreviewSets!);
            }
            else if (IsAppScreenshotSets && appScreenshotSets != null)
            {
                return appScreenshotSets(AppScreenshotSets!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,

            global::System.Action<global::AppStoreConnect.AppKeyword>? appKeywords = null,

            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,

            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageVersions)
            {
                appCustomProductPageVersions?.Invoke(AppCustomProductPageVersions!);
            }
            else if (IsAppKeywords)
            {
                appKeywords?.Invoke(AppKeywords!);
            }
            else if (IsAppPreviewSets)
            {
                appPreviewSets?.Invoke(AppPreviewSets!);
            }
            else if (IsAppScreenshotSets)
            {
                appScreenshotSets?.Invoke(AppScreenshotSets!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageVersion>? appCustomProductPageVersions = null,
            global::System.Action<global::AppStoreConnect.AppKeyword>? appKeywords = null,
            global::System.Action<global::AppStoreConnect.AppPreviewSet>? appPreviewSets = null,
            global::System.Action<global::AppStoreConnect.AppScreenshotSet>? appScreenshotSets = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageVersions)
            {
                appCustomProductPageVersions?.Invoke(AppCustomProductPageVersions!);
            }
            else if (IsAppKeywords)
            {
                appKeywords?.Invoke(AppKeywords!);
            }
            else if (IsAppPreviewSets)
            {
                appPreviewSets?.Invoke(AppPreviewSets!);
            }
            else if (IsAppScreenshotSets)
            {
                appScreenshotSets?.Invoke(AppScreenshotSets!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppCustomProductPageVersions,
                typeof(global::AppStoreConnect.AppCustomProductPageVersion),
                AppKeywords,
                typeof(global::AppStoreConnect.AppKeyword),
                AppPreviewSets,
                typeof(global::AppStoreConnect.AppPreviewSet),
                AppScreenshotSets,
                typeof(global::AppStoreConnect.AppScreenshotSet),
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
        public bool Equals(IncludedItem11 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageVersion?>.Default.Equals(AppCustomProductPageVersions, other.AppCustomProductPageVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppKeyword?>.Default.Equals(AppKeywords, other.AppKeywords) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPreviewSet?>.Default.Equals(AppPreviewSets, other.AppPreviewSets) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppScreenshotSet?>.Default.Equals(AppScreenshotSets, other.AppScreenshotSets)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem11 obj1, IncludedItem11 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem11>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem11 obj1, IncludedItem11 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem11 o && Equals(o);
        }
    }
}
