#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem24 : global::System.IEquatable<IncludedItem24>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AppCustomProductPageLocalization PickAppCustomProductPageLocalizations() => IsAppCustomProductPageLocalizations
            ? AppCustomProductPageLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppPreview? AppPreviews { get; init; }
#else
        public global::AppStoreConnect.AppPreview? AppPreviews { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppPreviews))]
#endif
        public bool IsAppPreviews => AppPreviews != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppPreviews(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppPreview? value)
        {
            value = AppPreviews;
            return IsAppPreviews;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPreview PickAppPreviews() => IsAppPreviews
            ? AppPreviews!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppPreviews' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatmentLocalizations))]
#endif
        public bool IsAppStoreVersionExperimentTreatmentLocalizations => AppStoreVersionExperimentTreatmentLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatmentLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            value = AppStoreVersionExperimentTreatmentLocalizations;
            return IsAppStoreVersionExperimentTreatmentLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization PickAppStoreVersionExperimentTreatmentLocalizations() => IsAppStoreVersionExperimentTreatmentLocalizations
            ? AppStoreVersionExperimentTreatmentLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatmentLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionLocalization? AppStoreVersionLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionLocalization? AppStoreVersionLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionLocalizations))]
#endif
        public bool IsAppStoreVersionLocalizations => AppStoreVersionLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionLocalization? value)
        {
            value = AppStoreVersionLocalizations;
            return IsAppStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionLocalization PickAppStoreVersionLocalizations() => IsAppStoreVersionLocalizations
            ? AppStoreVersionLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionLocalizations' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem24(global::AppStoreConnect.AppCustomProductPageLocalization value) => new IncludedItem24((global::AppStoreConnect.AppCustomProductPageLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageLocalization?(IncludedItem24 @this) => @this.AppCustomProductPageLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem24(global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            AppCustomProductPageLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem24 FromAppCustomProductPageLocalizations(global::AppStoreConnect.AppCustomProductPageLocalization? value) => new IncludedItem24(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem24(global::AppStoreConnect.AppPreview value) => new IncludedItem24((global::AppStoreConnect.AppPreview?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPreview?(IncludedItem24 @this) => @this.AppPreviews;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem24(global::AppStoreConnect.AppPreview? value)
        {
            AppPreviews = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem24 FromAppPreviews(global::AppStoreConnect.AppPreview? value) => new IncludedItem24(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem24(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization value) => new IncludedItem24((global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?(IncludedItem24 @this) => @this.AppStoreVersionExperimentTreatmentLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem24(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            AppStoreVersionExperimentTreatmentLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem24 FromAppStoreVersionExperimentTreatmentLocalizations(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value) => new IncludedItem24(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem24(global::AppStoreConnect.AppStoreVersionLocalization value) => new IncludedItem24((global::AppStoreConnect.AppStoreVersionLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionLocalization?(IncludedItem24 @this) => @this.AppStoreVersionLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem24(global::AppStoreConnect.AppStoreVersionLocalization? value)
        {
            AppStoreVersionLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem24 FromAppStoreVersionLocalizations(global::AppStoreConnect.AppStoreVersionLocalization? value) => new IncludedItem24(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem24(
            global::AppStoreConnect.AppPreviewSetsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppCustomProductPageLocalization? appCustomProductPageLocalizations,
            global::AppStoreConnect.AppPreview? appPreviews,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalizations,
            global::AppStoreConnect.AppStoreVersionLocalization? appStoreVersionLocalizations
            )
        {
            Type = type;

            AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
            AppPreviews = appPreviews;
            AppStoreVersionExperimentTreatmentLocalizations = appStoreVersionExperimentTreatmentLocalizations;
            AppStoreVersionLocalizations = appStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersionLocalizations as object ??
            AppStoreVersionExperimentTreatmentLocalizations as object ??
            AppPreviews as object ??
            AppCustomProductPageLocalizations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppCustomProductPageLocalizations?.ToString() ??
            AppPreviews?.ToString() ??
            AppStoreVersionExperimentTreatmentLocalizations?.ToString() ??
            AppStoreVersionLocalizations?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppCustomProductPageLocalizations && !IsAppPreviews && !IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppCustomProductPageLocalizations && IsAppPreviews && !IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppCustomProductPageLocalizations && !IsAppPreviews && IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppCustomProductPageLocalizations && !IsAppPreviews && !IsAppStoreVersionExperimentTreatmentLocalizations && IsAppStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppCustomProductPageLocalization, TResult>? appCustomProductPageLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppPreview, TResult>? appPreviews = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization, TResult>? appStoreVersionExperimentTreatmentLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionLocalization, TResult>? appStoreVersionLocalizations = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageLocalizations && appCustomProductPageLocalizations != null)
            {
                return appCustomProductPageLocalizations(AppCustomProductPageLocalizations!);
            }
            else if (IsAppPreviews && appPreviews != null)
            {
                return appPreviews(AppPreviews!);
            }
            else if (IsAppStoreVersionExperimentTreatmentLocalizations && appStoreVersionExperimentTreatmentLocalizations != null)
            {
                return appStoreVersionExperimentTreatmentLocalizations(AppStoreVersionExperimentTreatmentLocalizations!);
            }
            else if (IsAppStoreVersionLocalizations && appStoreVersionLocalizations != null)
            {
                return appStoreVersionLocalizations(AppStoreVersionLocalizations!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppPreview>? appPreviews = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization>? appStoreVersionExperimentTreatmentLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionLocalization>? appStoreVersionLocalizations = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageLocalizations)
            {
                appCustomProductPageLocalizations?.Invoke(AppCustomProductPageLocalizations!);
            }
            else if (IsAppPreviews)
            {
                appPreviews?.Invoke(AppPreviews!);
            }
            else if (IsAppStoreVersionExperimentTreatmentLocalizations)
            {
                appStoreVersionExperimentTreatmentLocalizations?.Invoke(AppStoreVersionExperimentTreatmentLocalizations!);
            }
            else if (IsAppStoreVersionLocalizations)
            {
                appStoreVersionLocalizations?.Invoke(AppStoreVersionLocalizations!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppPreview>? appPreviews = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization>? appStoreVersionExperimentTreatmentLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionLocalization>? appStoreVersionLocalizations = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppCustomProductPageLocalizations)
            {
                appCustomProductPageLocalizations?.Invoke(AppCustomProductPageLocalizations!);
            }
            else if (IsAppPreviews)
            {
                appPreviews?.Invoke(AppPreviews!);
            }
            else if (IsAppStoreVersionExperimentTreatmentLocalizations)
            {
                appStoreVersionExperimentTreatmentLocalizations?.Invoke(AppStoreVersionExperimentTreatmentLocalizations!);
            }
            else if (IsAppStoreVersionLocalizations)
            {
                appStoreVersionLocalizations?.Invoke(AppStoreVersionLocalizations!);
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
                AppPreviews,
                typeof(global::AppStoreConnect.AppPreview),
                AppStoreVersionExperimentTreatmentLocalizations,
                typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization),
                AppStoreVersionLocalizations,
                typeof(global::AppStoreConnect.AppStoreVersionLocalization),
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
        public bool Equals(IncludedItem24 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageLocalization?>.Default.Equals(AppCustomProductPageLocalizations, other.AppCustomProductPageLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPreview?>.Default.Equals(AppPreviews, other.AppPreviews) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?>.Default.Equals(AppStoreVersionExperimentTreatmentLocalizations, other.AppStoreVersionExperimentTreatmentLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionLocalization?>.Default.Equals(AppStoreVersionLocalizations, other.AppStoreVersionLocalizations)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem24 obj1, IncludedItem24 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem24>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem24 obj1, IncludedItem24 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem24 o && Equals(o);
        }
    }
}
