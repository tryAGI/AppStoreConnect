#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem46 : global::System.IEquatable<IncludedItem46>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AndroidToIosAppMappingDetail? AndroidToIosAppMappingDetails { get; init; }
#else
        public global::AppStoreConnect.AndroidToIosAppMappingDetail? AndroidToIosAppMappingDetails { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AndroidToIosAppMappingDetails))]
#endif
        public bool IsAndroidToIosAppMappingDetails => AndroidToIosAppMappingDetails != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAndroidToIosAppMappingDetails(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AndroidToIosAppMappingDetail? value)
        {
            value = AndroidToIosAppMappingDetails;
            return IsAndroidToIosAppMappingDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AndroidToIosAppMappingDetail PickAndroidToIosAppMappingDetails() => IsAndroidToIosAppMappingDetails
            ? AndroidToIosAppMappingDetails!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AndroidToIosAppMappingDetails' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClip? AppClips { get; init; }
#else
        public global::AppStoreConnect.AppClip? AppClips { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClips))]
#endif
        public bool IsAppClips => AppClips != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClips(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClip? value)
        {
            value = AppClips;
            return IsAppClips;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClip PickAppClips() => IsAppClips
            ? AppClips!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClips' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPage? AppCustomProductPages { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPage? AppCustomProductPages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPages))]
#endif
        public bool IsAppCustomProductPages => AppCustomProductPages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPage? value)
        {
            value = AppCustomProductPages;
            return IsAppCustomProductPages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPage PickAppCustomProductPages() => IsAppCustomProductPages
            ? AppCustomProductPages!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEncryptionDeclaration? AppEncryptionDeclarations { get; init; }
#else
        public global::AppStoreConnect.AppEncryptionDeclaration? AppEncryptionDeclarations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEncryptionDeclarations))]
#endif
        public bool IsAppEncryptionDeclarations => AppEncryptionDeclarations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEncryptionDeclarations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEncryptionDeclaration? value)
        {
            value = AppEncryptionDeclarations;
            return IsAppEncryptionDeclarations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEncryptionDeclaration PickAppEncryptionDeclarations() => IsAppEncryptionDeclarations
            ? AppEncryptionDeclarations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEncryptionDeclarations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEvent? AppEvents { get; init; }
#else
        public global::AppStoreConnect.AppEvent? AppEvents { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEvents))]
#endif
        public bool IsAppEvents => AppEvents != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEvents(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEvent? value)
        {
            value = AppEvents;
            return IsAppEvents;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEvent PickAppEvents() => IsAppEvents
            ? AppEvents!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEvents' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppInfo? AppInfos { get; init; }
#else
        public global::AppStoreConnect.AppInfo? AppInfos { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppInfos))]
#endif
        public bool IsAppInfos => AppInfos != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppInfos(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppInfo? value)
        {
            value = AppInfos;
            return IsAppInfos;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppInfo PickAppInfos() => IsAppInfos
            ? AppInfos!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppInfos' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperimentV2? AppStoreVersionExperiments1 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperimentV2? AppStoreVersionExperiments1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperiments1))]
#endif
        public bool IsAppStoreVersionExperiments1 => AppStoreVersionExperiments1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperiments1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperimentV2? value)
        {
            value = AppStoreVersionExperiments1;
            return IsAppStoreVersionExperiments1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentV2 PickAppStoreVersionExperiments1() => IsAppStoreVersionExperiments1
            ? AppStoreVersionExperiments1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperiments1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersionExperiments2 { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersionExperiments2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperiments2))]
#endif
        public bool IsAppStoreVersionExperiments2 => AppStoreVersionExperiments2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperiments2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersionExperiments2;
            return IsAppStoreVersionExperiments2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersionExperiments2() => IsAppStoreVersionExperiments2
            ? AppStoreVersionExperiments2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperiments2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaAppLocalization? BetaAppLocalizations { get; init; }
#else
        public global::AppStoreConnect.BetaAppLocalization? BetaAppLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaAppLocalizations))]
#endif
        public bool IsBetaAppLocalizations => BetaAppLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaAppLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaAppLocalization? value)
        {
            value = BetaAppLocalizations;
            return IsBetaAppLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaAppLocalization PickBetaAppLocalizations() => IsBetaAppLocalizations
            ? BetaAppLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaAppLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaAppReviewDetail? BetaAppReviewDetails { get; init; }
#else
        public global::AppStoreConnect.BetaAppReviewDetail? BetaAppReviewDetails { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaAppReviewDetails))]
#endif
        public bool IsBetaAppReviewDetails => BetaAppReviewDetails != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaAppReviewDetails(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaAppReviewDetail? value)
        {
            value = BetaAppReviewDetails;
            return IsBetaAppReviewDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaAppReviewDetail PickBetaAppReviewDetails() => IsBetaAppReviewDetails
            ? BetaAppReviewDetails!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaAppReviewDetails' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaGroup? BetaGroups { get; init; }
#else
        public global::AppStoreConnect.BetaGroup? BetaGroups { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaGroups))]
#endif
        public bool IsBetaGroups => BetaGroups != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaGroup? value)
        {
            value = BetaGroups;
            return IsBetaGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaGroup PickBetaGroups() => IsBetaGroups
            ? BetaGroups!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaGroups' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaLicenseAgreement? BetaLicenseAgreements { get; init; }
#else
        public global::AppStoreConnect.BetaLicenseAgreement? BetaLicenseAgreements { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaLicenseAgreements))]
#endif
        public bool IsBetaLicenseAgreements => BetaLicenseAgreements != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaLicenseAgreements(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaLicenseAgreement? value)
        {
            value = BetaLicenseAgreements;
            return IsBetaLicenseAgreements;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaLicenseAgreement PickBetaLicenseAgreements() => IsBetaLicenseAgreements
            ? BetaLicenseAgreements!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaLicenseAgreements' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BuildIcon? BuildIcons1 { get; init; }
#else
        public global::AppStoreConnect.BuildIcon? BuildIcons1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildIcons1))]
#endif
        public bool IsBuildIcons1 => BuildIcons1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildIcons1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BuildIcon? value)
        {
            value = BuildIcons1;
            return IsBuildIcons1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildIcon PickBuildIcons1() => IsBuildIcons1
            ? BuildIcons1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildIcons1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Build? BuildIcons2 { get; init; }
#else
        public global::AppStoreConnect.Build? BuildIcons2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildIcons2))]
#endif
        public bool IsBuildIcons2 => BuildIcons2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildIcons2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Build? value)
        {
            value = BuildIcons2;
            return IsBuildIcons2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Build PickBuildIcons2() => IsBuildIcons2
            ? BuildIcons2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildIcons2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.CiProduct? CiProducts { get; init; }
#else
        public global::AppStoreConnect.CiProduct? CiProducts { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CiProducts))]
#endif
        public bool IsCiProducts => CiProducts != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCiProducts(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.CiProduct? value)
        {
            value = CiProducts;
            return IsCiProducts;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.CiProduct PickCiProducts() => IsCiProducts
            ? CiProducts!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CiProducts' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.EndUserLicenseAgreement? EndUserLicenseAgreements { get; init; }
#else
        public global::AppStoreConnect.EndUserLicenseAgreement? EndUserLicenseAgreements { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndUserLicenseAgreements))]
#endif
        public bool IsEndUserLicenseAgreements => EndUserLicenseAgreements != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEndUserLicenseAgreements(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.EndUserLicenseAgreement? value)
        {
            value = EndUserLicenseAgreements;
            return IsEndUserLicenseAgreements;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.EndUserLicenseAgreement PickEndUserLicenseAgreements() => IsEndUserLicenseAgreements
            ? EndUserLicenseAgreements!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndUserLicenseAgreements' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterDetail? GameCenterDetails { get; init; }
#else
        public global::AppStoreConnect.GameCenterDetail? GameCenterDetails { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterDetails))]
#endif
        public bool IsGameCenterDetails => GameCenterDetails != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterDetails(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterDetail? value)
        {
            value = GameCenterDetails;
            return IsGameCenterDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterDetail PickGameCenterDetails() => IsGameCenterDetails
            ? GameCenterDetails!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterDetails' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterEnabledVersion? GameCenterEnabledVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterEnabledVersion? GameCenterEnabledVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterEnabledVersions))]
#endif
        public bool IsGameCenterEnabledVersions => GameCenterEnabledVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterEnabledVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterEnabledVersion? value)
        {
            value = GameCenterEnabledVersions;
            return IsGameCenterEnabledVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterEnabledVersion PickGameCenterEnabledVersions() => IsGameCenterEnabledVersions
            ? GameCenterEnabledVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterEnabledVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchase? InAppPurchases { get; init; }
#else
        public global::AppStoreConnect.InAppPurchase? InAppPurchases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchases))]
#endif
        public bool IsInAppPurchases => InAppPurchases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchase? value)
        {
            value = InAppPurchases;
            return IsInAppPurchases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchase PickInAppPurchases() => IsInAppPurchases
            ? InAppPurchases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.PrereleaseVersion? PreReleaseVersions { get; init; }
#else
        public global::AppStoreConnect.PrereleaseVersion? PreReleaseVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreReleaseVersions))]
#endif
        public bool IsPreReleaseVersions => PreReleaseVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreReleaseVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.PrereleaseVersion? value)
        {
            value = PreReleaseVersions;
            return IsPreReleaseVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.PrereleaseVersion PickPreReleaseVersions() => IsPreReleaseVersions
            ? PreReleaseVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreReleaseVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.PromotedPurchase? PromotedPurchases { get; init; }
#else
        public global::AppStoreConnect.PromotedPurchase? PromotedPurchases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromotedPurchases))]
#endif
        public bool IsPromotedPurchases => PromotedPurchases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPromotedPurchases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.PromotedPurchase? value)
        {
            value = PromotedPurchases;
            return IsPromotedPurchases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.PromotedPurchase PickPromotedPurchases() => IsPromotedPurchases
            ? PromotedPurchases!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PromotedPurchases' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.ReviewSubmission? ReviewSubmissions { get; init; }
#else
        public global::AppStoreConnect.ReviewSubmission? ReviewSubmissions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReviewSubmissions))]
#endif
        public bool IsReviewSubmissions => ReviewSubmissions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReviewSubmissions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.ReviewSubmission? value)
        {
            value = ReviewSubmissions;
            return IsReviewSubmissions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.ReviewSubmission PickReviewSubmissions() => IsReviewSubmissions
            ? ReviewSubmissions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReviewSubmissions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionGracePeriod? SubscriptionGracePeriods { get; init; }
#else
        public global::AppStoreConnect.SubscriptionGracePeriod? SubscriptionGracePeriods { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionGracePeriods))]
#endif
        public bool IsSubscriptionGracePeriods => SubscriptionGracePeriods != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionGracePeriods(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionGracePeriod? value)
        {
            value = SubscriptionGracePeriods;
            return IsSubscriptionGracePeriods;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionGracePeriod PickSubscriptionGracePeriods() => IsSubscriptionGracePeriods
            ? SubscriptionGracePeriods!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionGracePeriods' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionGroup? SubscriptionGroups { get; init; }
#else
        public global::AppStoreConnect.SubscriptionGroup? SubscriptionGroups { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionGroups))]
#endif
        public bool IsSubscriptionGroups => SubscriptionGroups != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionGroup? value)
        {
            value = SubscriptionGroups;
            return IsSubscriptionGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroup PickSubscriptionGroups() => IsSubscriptionGroups
            ? SubscriptionGroups!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionGroups' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.AndroidToIosAppMappingDetail value) => new IncludedItem46((global::AppStoreConnect.AndroidToIosAppMappingDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AndroidToIosAppMappingDetail?(IncludedItem46 @this) => @this.AndroidToIosAppMappingDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.AndroidToIosAppMappingDetail? value)
        {
            AndroidToIosAppMappingDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromAndroidToIosAppMappingDetails(global::AppStoreConnect.AndroidToIosAppMappingDetail? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.AppClip value) => new IncludedItem46((global::AppStoreConnect.AppClip?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClip?(IncludedItem46 @this) => @this.AppClips;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.AppClip? value)
        {
            AppClips = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromAppClips(global::AppStoreConnect.AppClip? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.AppCustomProductPage value) => new IncludedItem46((global::AppStoreConnect.AppCustomProductPage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPage?(IncludedItem46 @this) => @this.AppCustomProductPages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.AppCustomProductPage? value)
        {
            AppCustomProductPages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromAppCustomProductPages(global::AppStoreConnect.AppCustomProductPage? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.AppEncryptionDeclaration value) => new IncludedItem46((global::AppStoreConnect.AppEncryptionDeclaration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEncryptionDeclaration?(IncludedItem46 @this) => @this.AppEncryptionDeclarations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.AppEncryptionDeclaration? value)
        {
            AppEncryptionDeclarations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromAppEncryptionDeclarations(global::AppStoreConnect.AppEncryptionDeclaration? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.AppEvent value) => new IncludedItem46((global::AppStoreConnect.AppEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEvent?(IncludedItem46 @this) => @this.AppEvents;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.AppEvent? value)
        {
            AppEvents = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromAppEvents(global::AppStoreConnect.AppEvent? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.AppInfo value) => new IncludedItem46((global::AppStoreConnect.AppInfo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppInfo?(IncludedItem46 @this) => @this.AppInfos;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.AppInfo? value)
        {
            AppInfos = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromAppInfos(global::AppStoreConnect.AppInfo? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.AppStoreVersionExperimentV2 value) => new IncludedItem46((global::AppStoreConnect.AppStoreVersionExperimentV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentV2?(IncludedItem46 @this) => @this.AppStoreVersionExperiments1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.AppStoreVersionExperimentV2? value)
        {
            AppStoreVersionExperiments1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromAppStoreVersionExperiments1(global::AppStoreConnect.AppStoreVersionExperimentV2? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem46((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem46 @this) => @this.AppStoreVersionExperiments2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersionExperiments2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromAppStoreVersionExperiments2(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.BetaAppLocalization value) => new IncludedItem46((global::AppStoreConnect.BetaAppLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaAppLocalization?(IncludedItem46 @this) => @this.BetaAppLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.BetaAppLocalization? value)
        {
            BetaAppLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromBetaAppLocalizations(global::AppStoreConnect.BetaAppLocalization? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.BetaAppReviewDetail value) => new IncludedItem46((global::AppStoreConnect.BetaAppReviewDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaAppReviewDetail?(IncludedItem46 @this) => @this.BetaAppReviewDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.BetaAppReviewDetail? value)
        {
            BetaAppReviewDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromBetaAppReviewDetails(global::AppStoreConnect.BetaAppReviewDetail? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.BetaGroup value) => new IncludedItem46((global::AppStoreConnect.BetaGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaGroup?(IncludedItem46 @this) => @this.BetaGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.BetaGroup? value)
        {
            BetaGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromBetaGroups(global::AppStoreConnect.BetaGroup? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.BetaLicenseAgreement value) => new IncludedItem46((global::AppStoreConnect.BetaLicenseAgreement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaLicenseAgreement?(IncludedItem46 @this) => @this.BetaLicenseAgreements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.BetaLicenseAgreement? value)
        {
            BetaLicenseAgreements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromBetaLicenseAgreements(global::AppStoreConnect.BetaLicenseAgreement? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.BuildIcon value) => new IncludedItem46((global::AppStoreConnect.BuildIcon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BuildIcon?(IncludedItem46 @this) => @this.BuildIcons1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.BuildIcon? value)
        {
            BuildIcons1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromBuildIcons1(global::AppStoreConnect.BuildIcon? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.Build value) => new IncludedItem46((global::AppStoreConnect.Build?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Build?(IncludedItem46 @this) => @this.BuildIcons2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.Build? value)
        {
            BuildIcons2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromBuildIcons2(global::AppStoreConnect.Build? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.CiProduct value) => new IncludedItem46((global::AppStoreConnect.CiProduct?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.CiProduct?(IncludedItem46 @this) => @this.CiProducts;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.CiProduct? value)
        {
            CiProducts = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromCiProducts(global::AppStoreConnect.CiProduct? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.EndUserLicenseAgreement value) => new IncludedItem46((global::AppStoreConnect.EndUserLicenseAgreement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.EndUserLicenseAgreement?(IncludedItem46 @this) => @this.EndUserLicenseAgreements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.EndUserLicenseAgreement? value)
        {
            EndUserLicenseAgreements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromEndUserLicenseAgreements(global::AppStoreConnect.EndUserLicenseAgreement? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.GameCenterDetail value) => new IncludedItem46((global::AppStoreConnect.GameCenterDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterDetail?(IncludedItem46 @this) => @this.GameCenterDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.GameCenterDetail? value)
        {
            GameCenterDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromGameCenterDetails(global::AppStoreConnect.GameCenterDetail? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.GameCenterEnabledVersion value) => new IncludedItem46((global::AppStoreConnect.GameCenterEnabledVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterEnabledVersion?(IncludedItem46 @this) => @this.GameCenterEnabledVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.GameCenterEnabledVersion? value)
        {
            GameCenterEnabledVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromGameCenterEnabledVersions(global::AppStoreConnect.GameCenterEnabledVersion? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.InAppPurchase value) => new IncludedItem46((global::AppStoreConnect.InAppPurchase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchase?(IncludedItem46 @this) => @this.InAppPurchases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.InAppPurchase? value)
        {
            InAppPurchases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromInAppPurchases(global::AppStoreConnect.InAppPurchase? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.PrereleaseVersion value) => new IncludedItem46((global::AppStoreConnect.PrereleaseVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.PrereleaseVersion?(IncludedItem46 @this) => @this.PreReleaseVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.PrereleaseVersion? value)
        {
            PreReleaseVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromPreReleaseVersions(global::AppStoreConnect.PrereleaseVersion? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.PromotedPurchase value) => new IncludedItem46((global::AppStoreConnect.PromotedPurchase?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.PromotedPurchase?(IncludedItem46 @this) => @this.PromotedPurchases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.PromotedPurchase? value)
        {
            PromotedPurchases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromPromotedPurchases(global::AppStoreConnect.PromotedPurchase? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.ReviewSubmission value) => new IncludedItem46((global::AppStoreConnect.ReviewSubmission?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.ReviewSubmission?(IncludedItem46 @this) => @this.ReviewSubmissions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.ReviewSubmission? value)
        {
            ReviewSubmissions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromReviewSubmissions(global::AppStoreConnect.ReviewSubmission? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.SubscriptionGracePeriod value) => new IncludedItem46((global::AppStoreConnect.SubscriptionGracePeriod?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGracePeriod?(IncludedItem46 @this) => @this.SubscriptionGracePeriods;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.SubscriptionGracePeriod? value)
        {
            SubscriptionGracePeriods = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromSubscriptionGracePeriods(global::AppStoreConnect.SubscriptionGracePeriod? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem46(global::AppStoreConnect.SubscriptionGroup value) => new IncludedItem46((global::AppStoreConnect.SubscriptionGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroup?(IncludedItem46 @this) => @this.SubscriptionGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(global::AppStoreConnect.SubscriptionGroup? value)
        {
            SubscriptionGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem46 FromSubscriptionGroups(global::AppStoreConnect.SubscriptionGroup? value) => new IncludedItem46(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem46(
            global::AppStoreConnect.AppsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AndroidToIosAppMappingDetail? androidToIosAppMappingDetails,
            global::AppStoreConnect.AppClip? appClips,
            global::AppStoreConnect.AppCustomProductPage? appCustomProductPages,
            global::AppStoreConnect.AppEncryptionDeclaration? appEncryptionDeclarations,
            global::AppStoreConnect.AppEvent? appEvents,
            global::AppStoreConnect.AppInfo? appInfos,
            global::AppStoreConnect.AppStoreVersionExperimentV2? appStoreVersionExperiments1,
            global::AppStoreConnect.AppStoreVersion? appStoreVersionExperiments2,
            global::AppStoreConnect.BetaAppLocalization? betaAppLocalizations,
            global::AppStoreConnect.BetaAppReviewDetail? betaAppReviewDetails,
            global::AppStoreConnect.BetaGroup? betaGroups,
            global::AppStoreConnect.BetaLicenseAgreement? betaLicenseAgreements,
            global::AppStoreConnect.BuildIcon? buildIcons1,
            global::AppStoreConnect.Build? buildIcons2,
            global::AppStoreConnect.CiProduct? ciProducts,
            global::AppStoreConnect.EndUserLicenseAgreement? endUserLicenseAgreements,
            global::AppStoreConnect.GameCenterDetail? gameCenterDetails,
            global::AppStoreConnect.GameCenterEnabledVersion? gameCenterEnabledVersions,
            global::AppStoreConnect.InAppPurchase? inAppPurchases,
            global::AppStoreConnect.PrereleaseVersion? preReleaseVersions,
            global::AppStoreConnect.PromotedPurchase? promotedPurchases,
            global::AppStoreConnect.ReviewSubmission? reviewSubmissions,
            global::AppStoreConnect.SubscriptionGracePeriod? subscriptionGracePeriods,
            global::AppStoreConnect.SubscriptionGroup? subscriptionGroups
            )
        {
            Type = type;

            AndroidToIosAppMappingDetails = androidToIosAppMappingDetails;
            AppClips = appClips;
            AppCustomProductPages = appCustomProductPages;
            AppEncryptionDeclarations = appEncryptionDeclarations;
            AppEvents = appEvents;
            AppInfos = appInfos;
            AppStoreVersionExperiments1 = appStoreVersionExperiments1;
            AppStoreVersionExperiments2 = appStoreVersionExperiments2;
            BetaAppLocalizations = betaAppLocalizations;
            BetaAppReviewDetails = betaAppReviewDetails;
            BetaGroups = betaGroups;
            BetaLicenseAgreements = betaLicenseAgreements;
            BuildIcons1 = buildIcons1;
            BuildIcons2 = buildIcons2;
            CiProducts = ciProducts;
            EndUserLicenseAgreements = endUserLicenseAgreements;
            GameCenterDetails = gameCenterDetails;
            GameCenterEnabledVersions = gameCenterEnabledVersions;
            InAppPurchases = inAppPurchases;
            PreReleaseVersions = preReleaseVersions;
            PromotedPurchases = promotedPurchases;
            ReviewSubmissions = reviewSubmissions;
            SubscriptionGracePeriods = subscriptionGracePeriods;
            SubscriptionGroups = subscriptionGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SubscriptionGroups as object ??
            SubscriptionGracePeriods as object ??
            ReviewSubmissions as object ??
            PromotedPurchases as object ??
            PreReleaseVersions as object ??
            InAppPurchases as object ??
            GameCenterEnabledVersions as object ??
            GameCenterDetails as object ??
            EndUserLicenseAgreements as object ??
            CiProducts as object ??
            BuildIcons2 as object ??
            BuildIcons1 as object ??
            BetaLicenseAgreements as object ??
            BetaGroups as object ??
            BetaAppReviewDetails as object ??
            BetaAppLocalizations as object ??
            AppStoreVersionExperiments2 as object ??
            AppStoreVersionExperiments1 as object ??
            AppInfos as object ??
            AppEvents as object ??
            AppEncryptionDeclarations as object ??
            AppCustomProductPages as object ??
            AppClips as object ??
            AndroidToIosAppMappingDetails as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AndroidToIosAppMappingDetails?.ToString() ??
            AppClips?.ToString() ??
            AppCustomProductPages?.ToString() ??
            AppEncryptionDeclarations?.ToString() ??
            AppEvents?.ToString() ??
            AppInfos?.ToString() ??
            AppStoreVersionExperiments1?.ToString() ??
            AppStoreVersionExperiments2?.ToString() ??
            BetaAppLocalizations?.ToString() ??
            BetaAppReviewDetails?.ToString() ??
            BetaGroups?.ToString() ??
            BetaLicenseAgreements?.ToString() ??
            BuildIcons1?.ToString() ??
            BuildIcons2?.ToString() ??
            CiProducts?.ToString() ??
            EndUserLicenseAgreements?.ToString() ??
            GameCenterDetails?.ToString() ??
            GameCenterEnabledVersions?.ToString() ??
            InAppPurchases?.ToString() ??
            PreReleaseVersions?.ToString() ??
            PromotedPurchases?.ToString() ??
            ReviewSubmissions?.ToString() ??
            SubscriptionGracePeriods?.ToString() ??
            SubscriptionGroups?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && IsReviewSubmissions && !IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && IsSubscriptionGracePeriods && !IsSubscriptionGroups || !IsAndroidToIosAppMappingDetails && !IsAppClips && !IsAppCustomProductPages && !IsAppEncryptionDeclarations && !IsAppEvents && !IsAppInfos && !IsAppStoreVersionExperiments1 && !IsAppStoreVersionExperiments2 && !IsBetaAppLocalizations && !IsBetaAppReviewDetails && !IsBetaGroups && !IsBetaLicenseAgreements && !IsBuildIcons1 && !IsBuildIcons2 && !IsCiProducts && !IsEndUserLicenseAgreements && !IsGameCenterDetails && !IsGameCenterEnabledVersions && !IsInAppPurchases && !IsPreReleaseVersions && !IsPromotedPurchases && !IsReviewSubmissions && !IsSubscriptionGracePeriods && IsSubscriptionGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AndroidToIosAppMappingDetail, TResult>? androidToIosAppMappingDetails = null,
            global::System.Func<global::AppStoreConnect.AppClip, TResult>? appClips = null,
            global::System.Func<global::AppStoreConnect.AppCustomProductPage, TResult>? appCustomProductPages = null,
            global::System.Func<global::AppStoreConnect.AppEncryptionDeclaration, TResult>? appEncryptionDeclarations = null,
            global::System.Func<global::AppStoreConnect.AppEvent, TResult>? appEvents = null,
            global::System.Func<global::AppStoreConnect.AppInfo, TResult>? appInfos = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentV2, TResult>? appStoreVersionExperiments1 = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersionExperiments2 = null,
            global::System.Func<global::AppStoreConnect.BetaAppLocalization, TResult>? betaAppLocalizations = null,
            global::System.Func<global::AppStoreConnect.BetaAppReviewDetail, TResult>? betaAppReviewDetails = null,
            global::System.Func<global::AppStoreConnect.BetaGroup, TResult>? betaGroups = null,
            global::System.Func<global::AppStoreConnect.BetaLicenseAgreement, TResult>? betaLicenseAgreements = null,
            global::System.Func<global::AppStoreConnect.BuildIcon, TResult>? buildIcons1 = null,
            global::System.Func<global::AppStoreConnect.Build, TResult>? buildIcons2 = null,
            global::System.Func<global::AppStoreConnect.CiProduct, TResult>? ciProducts = null,
            global::System.Func<global::AppStoreConnect.EndUserLicenseAgreement, TResult>? endUserLicenseAgreements = null,
            global::System.Func<global::AppStoreConnect.GameCenterDetail, TResult>? gameCenterDetails = null,
            global::System.Func<global::AppStoreConnect.GameCenterEnabledVersion, TResult>? gameCenterEnabledVersions = null,
            global::System.Func<global::AppStoreConnect.InAppPurchase, TResult>? inAppPurchases = null,
            global::System.Func<global::AppStoreConnect.PrereleaseVersion, TResult>? preReleaseVersions = null,
            global::System.Func<global::AppStoreConnect.PromotedPurchase, TResult>? promotedPurchases = null,
            global::System.Func<global::AppStoreConnect.ReviewSubmission, TResult>? reviewSubmissions = null,
            global::System.Func<global::AppStoreConnect.SubscriptionGracePeriod, TResult>? subscriptionGracePeriods = null,
            global::System.Func<global::AppStoreConnect.SubscriptionGroup, TResult>? subscriptionGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAndroidToIosAppMappingDetails && androidToIosAppMappingDetails != null)
            {
                return androidToIosAppMappingDetails(AndroidToIosAppMappingDetails!);
            }
            else if (IsAppClips && appClips != null)
            {
                return appClips(AppClips!);
            }
            else if (IsAppCustomProductPages && appCustomProductPages != null)
            {
                return appCustomProductPages(AppCustomProductPages!);
            }
            else if (IsAppEncryptionDeclarations && appEncryptionDeclarations != null)
            {
                return appEncryptionDeclarations(AppEncryptionDeclarations!);
            }
            else if (IsAppEvents && appEvents != null)
            {
                return appEvents(AppEvents!);
            }
            else if (IsAppInfos && appInfos != null)
            {
                return appInfos(AppInfos!);
            }
            else if (IsAppStoreVersionExperiments1 && appStoreVersionExperiments1 != null)
            {
                return appStoreVersionExperiments1(AppStoreVersionExperiments1!);
            }
            else if (IsAppStoreVersionExperiments2 && appStoreVersionExperiments2 != null)
            {
                return appStoreVersionExperiments2(AppStoreVersionExperiments2!);
            }
            else if (IsBetaAppLocalizations && betaAppLocalizations != null)
            {
                return betaAppLocalizations(BetaAppLocalizations!);
            }
            else if (IsBetaAppReviewDetails && betaAppReviewDetails != null)
            {
                return betaAppReviewDetails(BetaAppReviewDetails!);
            }
            else if (IsBetaGroups && betaGroups != null)
            {
                return betaGroups(BetaGroups!);
            }
            else if (IsBetaLicenseAgreements && betaLicenseAgreements != null)
            {
                return betaLicenseAgreements(BetaLicenseAgreements!);
            }
            else if (IsBuildIcons1 && buildIcons1 != null)
            {
                return buildIcons1(BuildIcons1!);
            }
            else if (IsBuildIcons2 && buildIcons2 != null)
            {
                return buildIcons2(BuildIcons2!);
            }
            else if (IsCiProducts && ciProducts != null)
            {
                return ciProducts(CiProducts!);
            }
            else if (IsEndUserLicenseAgreements && endUserLicenseAgreements != null)
            {
                return endUserLicenseAgreements(EndUserLicenseAgreements!);
            }
            else if (IsGameCenterDetails && gameCenterDetails != null)
            {
                return gameCenterDetails(GameCenterDetails!);
            }
            else if (IsGameCenterEnabledVersions && gameCenterEnabledVersions != null)
            {
                return gameCenterEnabledVersions(GameCenterEnabledVersions!);
            }
            else if (IsInAppPurchases && inAppPurchases != null)
            {
                return inAppPurchases(InAppPurchases!);
            }
            else if (IsPreReleaseVersions && preReleaseVersions != null)
            {
                return preReleaseVersions(PreReleaseVersions!);
            }
            else if (IsPromotedPurchases && promotedPurchases != null)
            {
                return promotedPurchases(PromotedPurchases!);
            }
            else if (IsReviewSubmissions && reviewSubmissions != null)
            {
                return reviewSubmissions(ReviewSubmissions!);
            }
            else if (IsSubscriptionGracePeriods && subscriptionGracePeriods != null)
            {
                return subscriptionGracePeriods(SubscriptionGracePeriods!);
            }
            else if (IsSubscriptionGroups && subscriptionGroups != null)
            {
                return subscriptionGroups(SubscriptionGroups!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AndroidToIosAppMappingDetail>? androidToIosAppMappingDetails = null,

            global::System.Action<global::AppStoreConnect.AppClip>? appClips = null,

            global::System.Action<global::AppStoreConnect.AppCustomProductPage>? appCustomProductPages = null,

            global::System.Action<global::AppStoreConnect.AppEncryptionDeclaration>? appEncryptionDeclarations = null,

            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,

            global::System.Action<global::AppStoreConnect.AppInfo>? appInfos = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentV2>? appStoreVersionExperiments1 = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersionExperiments2 = null,

            global::System.Action<global::AppStoreConnect.BetaAppLocalization>? betaAppLocalizations = null,

            global::System.Action<global::AppStoreConnect.BetaAppReviewDetail>? betaAppReviewDetails = null,

            global::System.Action<global::AppStoreConnect.BetaGroup>? betaGroups = null,

            global::System.Action<global::AppStoreConnect.BetaLicenseAgreement>? betaLicenseAgreements = null,

            global::System.Action<global::AppStoreConnect.BuildIcon>? buildIcons1 = null,

            global::System.Action<global::AppStoreConnect.Build>? buildIcons2 = null,

            global::System.Action<global::AppStoreConnect.CiProduct>? ciProducts = null,

            global::System.Action<global::AppStoreConnect.EndUserLicenseAgreement>? endUserLicenseAgreements = null,

            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,

            global::System.Action<global::AppStoreConnect.GameCenterEnabledVersion>? gameCenterEnabledVersions = null,

            global::System.Action<global::AppStoreConnect.InAppPurchase>? inAppPurchases = null,

            global::System.Action<global::AppStoreConnect.PrereleaseVersion>? preReleaseVersions = null,

            global::System.Action<global::AppStoreConnect.PromotedPurchase>? promotedPurchases = null,

            global::System.Action<global::AppStoreConnect.ReviewSubmission>? reviewSubmissions = null,

            global::System.Action<global::AppStoreConnect.SubscriptionGracePeriod>? subscriptionGracePeriods = null,

            global::System.Action<global::AppStoreConnect.SubscriptionGroup>? subscriptionGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAndroidToIosAppMappingDetails)
            {
                androidToIosAppMappingDetails?.Invoke(AndroidToIosAppMappingDetails!);
            }
            else if (IsAppClips)
            {
                appClips?.Invoke(AppClips!);
            }
            else if (IsAppCustomProductPages)
            {
                appCustomProductPages?.Invoke(AppCustomProductPages!);
            }
            else if (IsAppEncryptionDeclarations)
            {
                appEncryptionDeclarations?.Invoke(AppEncryptionDeclarations!);
            }
            else if (IsAppEvents)
            {
                appEvents?.Invoke(AppEvents!);
            }
            else if (IsAppInfos)
            {
                appInfos?.Invoke(AppInfos!);
            }
            else if (IsAppStoreVersionExperiments1)
            {
                appStoreVersionExperiments1?.Invoke(AppStoreVersionExperiments1!);
            }
            else if (IsAppStoreVersionExperiments2)
            {
                appStoreVersionExperiments2?.Invoke(AppStoreVersionExperiments2!);
            }
            else if (IsBetaAppLocalizations)
            {
                betaAppLocalizations?.Invoke(BetaAppLocalizations!);
            }
            else if (IsBetaAppReviewDetails)
            {
                betaAppReviewDetails?.Invoke(BetaAppReviewDetails!);
            }
            else if (IsBetaGroups)
            {
                betaGroups?.Invoke(BetaGroups!);
            }
            else if (IsBetaLicenseAgreements)
            {
                betaLicenseAgreements?.Invoke(BetaLicenseAgreements!);
            }
            else if (IsBuildIcons1)
            {
                buildIcons1?.Invoke(BuildIcons1!);
            }
            else if (IsBuildIcons2)
            {
                buildIcons2?.Invoke(BuildIcons2!);
            }
            else if (IsCiProducts)
            {
                ciProducts?.Invoke(CiProducts!);
            }
            else if (IsEndUserLicenseAgreements)
            {
                endUserLicenseAgreements?.Invoke(EndUserLicenseAgreements!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterEnabledVersions)
            {
                gameCenterEnabledVersions?.Invoke(GameCenterEnabledVersions!);
            }
            else if (IsInAppPurchases)
            {
                inAppPurchases?.Invoke(InAppPurchases!);
            }
            else if (IsPreReleaseVersions)
            {
                preReleaseVersions?.Invoke(PreReleaseVersions!);
            }
            else if (IsPromotedPurchases)
            {
                promotedPurchases?.Invoke(PromotedPurchases!);
            }
            else if (IsReviewSubmissions)
            {
                reviewSubmissions?.Invoke(ReviewSubmissions!);
            }
            else if (IsSubscriptionGracePeriods)
            {
                subscriptionGracePeriods?.Invoke(SubscriptionGracePeriods!);
            }
            else if (IsSubscriptionGroups)
            {
                subscriptionGroups?.Invoke(SubscriptionGroups!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AndroidToIosAppMappingDetail>? androidToIosAppMappingDetails = null,
            global::System.Action<global::AppStoreConnect.AppClip>? appClips = null,
            global::System.Action<global::AppStoreConnect.AppCustomProductPage>? appCustomProductPages = null,
            global::System.Action<global::AppStoreConnect.AppEncryptionDeclaration>? appEncryptionDeclarations = null,
            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,
            global::System.Action<global::AppStoreConnect.AppInfo>? appInfos = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentV2>? appStoreVersionExperiments1 = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersionExperiments2 = null,
            global::System.Action<global::AppStoreConnect.BetaAppLocalization>? betaAppLocalizations = null,
            global::System.Action<global::AppStoreConnect.BetaAppReviewDetail>? betaAppReviewDetails = null,
            global::System.Action<global::AppStoreConnect.BetaGroup>? betaGroups = null,
            global::System.Action<global::AppStoreConnect.BetaLicenseAgreement>? betaLicenseAgreements = null,
            global::System.Action<global::AppStoreConnect.BuildIcon>? buildIcons1 = null,
            global::System.Action<global::AppStoreConnect.Build>? buildIcons2 = null,
            global::System.Action<global::AppStoreConnect.CiProduct>? ciProducts = null,
            global::System.Action<global::AppStoreConnect.EndUserLicenseAgreement>? endUserLicenseAgreements = null,
            global::System.Action<global::AppStoreConnect.GameCenterDetail>? gameCenterDetails = null,
            global::System.Action<global::AppStoreConnect.GameCenterEnabledVersion>? gameCenterEnabledVersions = null,
            global::System.Action<global::AppStoreConnect.InAppPurchase>? inAppPurchases = null,
            global::System.Action<global::AppStoreConnect.PrereleaseVersion>? preReleaseVersions = null,
            global::System.Action<global::AppStoreConnect.PromotedPurchase>? promotedPurchases = null,
            global::System.Action<global::AppStoreConnect.ReviewSubmission>? reviewSubmissions = null,
            global::System.Action<global::AppStoreConnect.SubscriptionGracePeriod>? subscriptionGracePeriods = null,
            global::System.Action<global::AppStoreConnect.SubscriptionGroup>? subscriptionGroups = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAndroidToIosAppMappingDetails)
            {
                androidToIosAppMappingDetails?.Invoke(AndroidToIosAppMappingDetails!);
            }
            else if (IsAppClips)
            {
                appClips?.Invoke(AppClips!);
            }
            else if (IsAppCustomProductPages)
            {
                appCustomProductPages?.Invoke(AppCustomProductPages!);
            }
            else if (IsAppEncryptionDeclarations)
            {
                appEncryptionDeclarations?.Invoke(AppEncryptionDeclarations!);
            }
            else if (IsAppEvents)
            {
                appEvents?.Invoke(AppEvents!);
            }
            else if (IsAppInfos)
            {
                appInfos?.Invoke(AppInfos!);
            }
            else if (IsAppStoreVersionExperiments1)
            {
                appStoreVersionExperiments1?.Invoke(AppStoreVersionExperiments1!);
            }
            else if (IsAppStoreVersionExperiments2)
            {
                appStoreVersionExperiments2?.Invoke(AppStoreVersionExperiments2!);
            }
            else if (IsBetaAppLocalizations)
            {
                betaAppLocalizations?.Invoke(BetaAppLocalizations!);
            }
            else if (IsBetaAppReviewDetails)
            {
                betaAppReviewDetails?.Invoke(BetaAppReviewDetails!);
            }
            else if (IsBetaGroups)
            {
                betaGroups?.Invoke(BetaGroups!);
            }
            else if (IsBetaLicenseAgreements)
            {
                betaLicenseAgreements?.Invoke(BetaLicenseAgreements!);
            }
            else if (IsBuildIcons1)
            {
                buildIcons1?.Invoke(BuildIcons1!);
            }
            else if (IsBuildIcons2)
            {
                buildIcons2?.Invoke(BuildIcons2!);
            }
            else if (IsCiProducts)
            {
                ciProducts?.Invoke(CiProducts!);
            }
            else if (IsEndUserLicenseAgreements)
            {
                endUserLicenseAgreements?.Invoke(EndUserLicenseAgreements!);
            }
            else if (IsGameCenterDetails)
            {
                gameCenterDetails?.Invoke(GameCenterDetails!);
            }
            else if (IsGameCenterEnabledVersions)
            {
                gameCenterEnabledVersions?.Invoke(GameCenterEnabledVersions!);
            }
            else if (IsInAppPurchases)
            {
                inAppPurchases?.Invoke(InAppPurchases!);
            }
            else if (IsPreReleaseVersions)
            {
                preReleaseVersions?.Invoke(PreReleaseVersions!);
            }
            else if (IsPromotedPurchases)
            {
                promotedPurchases?.Invoke(PromotedPurchases!);
            }
            else if (IsReviewSubmissions)
            {
                reviewSubmissions?.Invoke(ReviewSubmissions!);
            }
            else if (IsSubscriptionGracePeriods)
            {
                subscriptionGracePeriods?.Invoke(SubscriptionGracePeriods!);
            }
            else if (IsSubscriptionGroups)
            {
                subscriptionGroups?.Invoke(SubscriptionGroups!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AndroidToIosAppMappingDetails,
                typeof(global::AppStoreConnect.AndroidToIosAppMappingDetail),
                AppClips,
                typeof(global::AppStoreConnect.AppClip),
                AppCustomProductPages,
                typeof(global::AppStoreConnect.AppCustomProductPage),
                AppEncryptionDeclarations,
                typeof(global::AppStoreConnect.AppEncryptionDeclaration),
                AppEvents,
                typeof(global::AppStoreConnect.AppEvent),
                AppInfos,
                typeof(global::AppStoreConnect.AppInfo),
                AppStoreVersionExperiments1,
                typeof(global::AppStoreConnect.AppStoreVersionExperimentV2),
                AppStoreVersionExperiments2,
                typeof(global::AppStoreConnect.AppStoreVersion),
                BetaAppLocalizations,
                typeof(global::AppStoreConnect.BetaAppLocalization),
                BetaAppReviewDetails,
                typeof(global::AppStoreConnect.BetaAppReviewDetail),
                BetaGroups,
                typeof(global::AppStoreConnect.BetaGroup),
                BetaLicenseAgreements,
                typeof(global::AppStoreConnect.BetaLicenseAgreement),
                BuildIcons1,
                typeof(global::AppStoreConnect.BuildIcon),
                BuildIcons2,
                typeof(global::AppStoreConnect.Build),
                CiProducts,
                typeof(global::AppStoreConnect.CiProduct),
                EndUserLicenseAgreements,
                typeof(global::AppStoreConnect.EndUserLicenseAgreement),
                GameCenterDetails,
                typeof(global::AppStoreConnect.GameCenterDetail),
                GameCenterEnabledVersions,
                typeof(global::AppStoreConnect.GameCenterEnabledVersion),
                InAppPurchases,
                typeof(global::AppStoreConnect.InAppPurchase),
                PreReleaseVersions,
                typeof(global::AppStoreConnect.PrereleaseVersion),
                PromotedPurchases,
                typeof(global::AppStoreConnect.PromotedPurchase),
                ReviewSubmissions,
                typeof(global::AppStoreConnect.ReviewSubmission),
                SubscriptionGracePeriods,
                typeof(global::AppStoreConnect.SubscriptionGracePeriod),
                SubscriptionGroups,
                typeof(global::AppStoreConnect.SubscriptionGroup),
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
        public bool Equals(IncludedItem46 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AndroidToIosAppMappingDetail?>.Default.Equals(AndroidToIosAppMappingDetails, other.AndroidToIosAppMappingDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClip?>.Default.Equals(AppClips, other.AppClips) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPage?>.Default.Equals(AppCustomProductPages, other.AppCustomProductPages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEncryptionDeclaration?>.Default.Equals(AppEncryptionDeclarations, other.AppEncryptionDeclarations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEvent?>.Default.Equals(AppEvents, other.AppEvents) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppInfo?>.Default.Equals(AppInfos, other.AppInfos) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentV2?>.Default.Equals(AppStoreVersionExperiments1, other.AppStoreVersionExperiments1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersionExperiments2, other.AppStoreVersionExperiments2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaAppLocalization?>.Default.Equals(BetaAppLocalizations, other.BetaAppLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaAppReviewDetail?>.Default.Equals(BetaAppReviewDetails, other.BetaAppReviewDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaGroup?>.Default.Equals(BetaGroups, other.BetaGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaLicenseAgreement?>.Default.Equals(BetaLicenseAgreements, other.BetaLicenseAgreements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BuildIcon?>.Default.Equals(BuildIcons1, other.BuildIcons1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Build?>.Default.Equals(BuildIcons2, other.BuildIcons2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.CiProduct?>.Default.Equals(CiProducts, other.CiProducts) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.EndUserLicenseAgreement?>.Default.Equals(EndUserLicenseAgreements, other.EndUserLicenseAgreements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterDetail?>.Default.Equals(GameCenterDetails, other.GameCenterDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterEnabledVersion?>.Default.Equals(GameCenterEnabledVersions, other.GameCenterEnabledVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchase?>.Default.Equals(InAppPurchases, other.InAppPurchases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.PrereleaseVersion?>.Default.Equals(PreReleaseVersions, other.PreReleaseVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.PromotedPurchase?>.Default.Equals(PromotedPurchases, other.PromotedPurchases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.ReviewSubmission?>.Default.Equals(ReviewSubmissions, other.ReviewSubmissions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionGracePeriod?>.Default.Equals(SubscriptionGracePeriods, other.SubscriptionGracePeriods) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionGroup?>.Default.Equals(SubscriptionGroups, other.SubscriptionGroups)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem46 obj1, IncludedItem46 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem46>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem46 obj1, IncludedItem46 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem46 o && Equals(o);
        }
    }
}
