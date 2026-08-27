#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem32 : global::System.IEquatable<IncludedItem32>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppScreenshotSetResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AppScreenshot? AppScreenshots { get; init; }
#else
        public global::AppStoreConnect.AppScreenshot? AppScreenshots { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppScreenshots))]
#endif
        public bool IsAppScreenshots => AppScreenshots != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppScreenshots(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppScreenshot? value)
        {
            value = AppScreenshots;
            return IsAppScreenshots;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppScreenshot PickAppScreenshots() => IsAppScreenshots
            ? AppScreenshots!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppScreenshots' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem32(global::AppStoreConnect.AppCustomProductPageLocalization value) => new IncludedItem32((global::AppStoreConnect.AppCustomProductPageLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageLocalization?(IncludedItem32 @this) => @this.AppCustomProductPageLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem32(global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            AppCustomProductPageLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem32 FromAppCustomProductPageLocalizations(global::AppStoreConnect.AppCustomProductPageLocalization? value) => new IncludedItem32(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem32(global::AppStoreConnect.AppScreenshot value) => new IncludedItem32((global::AppStoreConnect.AppScreenshot?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppScreenshot?(IncludedItem32 @this) => @this.AppScreenshots;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem32(global::AppStoreConnect.AppScreenshot? value)
        {
            AppScreenshots = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem32 FromAppScreenshots(global::AppStoreConnect.AppScreenshot? value) => new IncludedItem32(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem32(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization value) => new IncludedItem32((global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?(IncludedItem32 @this) => @this.AppStoreVersionExperimentTreatmentLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem32(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            AppStoreVersionExperimentTreatmentLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem32 FromAppStoreVersionExperimentTreatmentLocalizations(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value) => new IncludedItem32(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem32(global::AppStoreConnect.AppStoreVersionLocalization value) => new IncludedItem32((global::AppStoreConnect.AppStoreVersionLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionLocalization?(IncludedItem32 @this) => @this.AppStoreVersionLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem32(global::AppStoreConnect.AppStoreVersionLocalization? value)
        {
            AppStoreVersionLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem32 FromAppStoreVersionLocalizations(global::AppStoreConnect.AppStoreVersionLocalization? value) => new IncludedItem32(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem32(
            global::AppStoreConnect.AppScreenshotSetResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppCustomProductPageLocalization? appCustomProductPageLocalizations,
            global::AppStoreConnect.AppScreenshot? appScreenshots,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalizations,
            global::AppStoreConnect.AppStoreVersionLocalization? appStoreVersionLocalizations
            )
        {
            Type = type;

            AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
            AppScreenshots = appScreenshots;
            AppStoreVersionExperimentTreatmentLocalizations = appStoreVersionExperimentTreatmentLocalizations;
            AppStoreVersionLocalizations = appStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersionLocalizations as object ??
            AppStoreVersionExperimentTreatmentLocalizations as object ??
            AppScreenshots as object ??
            AppCustomProductPageLocalizations as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppCustomProductPageLocalizations?.ToString() ??
            AppScreenshots?.ToString() ??
            AppStoreVersionExperimentTreatmentLocalizations?.ToString() ??
            AppStoreVersionLocalizations?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppCustomProductPageLocalizations && !IsAppScreenshots && !IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppCustomProductPageLocalizations && IsAppScreenshots && !IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppCustomProductPageLocalizations && !IsAppScreenshots && IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppCustomProductPageLocalizations && !IsAppScreenshots && !IsAppStoreVersionExperimentTreatmentLocalizations && IsAppStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppCustomProductPageLocalization, TResult>? appCustomProductPageLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppScreenshot, TResult>? appScreenshots = null,
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
            else if (IsAppScreenshots && appScreenshots != null)
            {
                return appScreenshots(AppScreenshots!);
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

            global::System.Action<global::AppStoreConnect.AppScreenshot>? appScreenshots = null,

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
            else if (IsAppScreenshots)
            {
                appScreenshots?.Invoke(AppScreenshots!);
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
            global::System.Action<global::AppStoreConnect.AppScreenshot>? appScreenshots = null,
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
            else if (IsAppScreenshots)
            {
                appScreenshots?.Invoke(AppScreenshots!);
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
                AppScreenshots,
                typeof(global::AppStoreConnect.AppScreenshot),
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
        public bool Equals(IncludedItem32 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageLocalization?>.Default.Equals(AppCustomProductPageLocalizations, other.AppCustomProductPageLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppScreenshot?>.Default.Equals(AppScreenshots, other.AppScreenshots) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?>.Default.Equals(AppStoreVersionExperimentTreatmentLocalizations, other.AppStoreVersionExperimentTreatmentLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionLocalization?>.Default.Equals(AppStoreVersionLocalizations, other.AppStoreVersionLocalizations)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem32 obj1, IncludedItem32 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem32>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem32 obj1, IncludedItem32 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem32 o && Equals(o);
        }
    }
}
