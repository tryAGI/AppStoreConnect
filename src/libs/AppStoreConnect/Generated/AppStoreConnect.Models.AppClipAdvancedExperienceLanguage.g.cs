
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipAdvancedExperienceLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceLanguage value)
        {
            return value switch
            {
                AppClipAdvancedExperienceLanguage.Ar => "AR",
                AppClipAdvancedExperienceLanguage.Ca => "CA",
                AppClipAdvancedExperienceLanguage.Cs => "CS",
                AppClipAdvancedExperienceLanguage.Da => "DA",
                AppClipAdvancedExperienceLanguage.De => "DE",
                AppClipAdvancedExperienceLanguage.El => "EL",
                AppClipAdvancedExperienceLanguage.En => "EN",
                AppClipAdvancedExperienceLanguage.Es => "ES",
                AppClipAdvancedExperienceLanguage.Fi => "FI",
                AppClipAdvancedExperienceLanguage.Fr => "FR",
                AppClipAdvancedExperienceLanguage.He => "HE",
                AppClipAdvancedExperienceLanguage.Hi => "HI",
                AppClipAdvancedExperienceLanguage.Hr => "HR",
                AppClipAdvancedExperienceLanguage.Hu => "HU",
                AppClipAdvancedExperienceLanguage.Id => "ID",
                AppClipAdvancedExperienceLanguage.It => "IT",
                AppClipAdvancedExperienceLanguage.Ja => "JA",
                AppClipAdvancedExperienceLanguage.Ko => "KO",
                AppClipAdvancedExperienceLanguage.Ms => "MS",
                AppClipAdvancedExperienceLanguage.Nl => "NL",
                AppClipAdvancedExperienceLanguage.No => "NO",
                AppClipAdvancedExperienceLanguage.Pl => "PL",
                AppClipAdvancedExperienceLanguage.Pt => "PT",
                AppClipAdvancedExperienceLanguage.Ro => "RO",
                AppClipAdvancedExperienceLanguage.Ru => "RU",
                AppClipAdvancedExperienceLanguage.Sk => "SK",
                AppClipAdvancedExperienceLanguage.Sv => "SV",
                AppClipAdvancedExperienceLanguage.Th => "TH",
                AppClipAdvancedExperienceLanguage.Tr => "TR",
                AppClipAdvancedExperienceLanguage.Uk => "UK",
                AppClipAdvancedExperienceLanguage.Vi => "VI",
                AppClipAdvancedExperienceLanguage.Zh => "ZH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceLanguage? ToEnum(string value)
        {
            return value switch
            {
                "AR" => AppClipAdvancedExperienceLanguage.Ar,
                "CA" => AppClipAdvancedExperienceLanguage.Ca,
                "CS" => AppClipAdvancedExperienceLanguage.Cs,
                "DA" => AppClipAdvancedExperienceLanguage.Da,
                "DE" => AppClipAdvancedExperienceLanguage.De,
                "EL" => AppClipAdvancedExperienceLanguage.El,
                "EN" => AppClipAdvancedExperienceLanguage.En,
                "ES" => AppClipAdvancedExperienceLanguage.Es,
                "FI" => AppClipAdvancedExperienceLanguage.Fi,
                "FR" => AppClipAdvancedExperienceLanguage.Fr,
                "HE" => AppClipAdvancedExperienceLanguage.He,
                "HI" => AppClipAdvancedExperienceLanguage.Hi,
                "HR" => AppClipAdvancedExperienceLanguage.Hr,
                "HU" => AppClipAdvancedExperienceLanguage.Hu,
                "ID" => AppClipAdvancedExperienceLanguage.Id,
                "IT" => AppClipAdvancedExperienceLanguage.It,
                "JA" => AppClipAdvancedExperienceLanguage.Ja,
                "KO" => AppClipAdvancedExperienceLanguage.Ko,
                "MS" => AppClipAdvancedExperienceLanguage.Ms,
                "NL" => AppClipAdvancedExperienceLanguage.Nl,
                "NO" => AppClipAdvancedExperienceLanguage.No,
                "PL" => AppClipAdvancedExperienceLanguage.Pl,
                "PT" => AppClipAdvancedExperienceLanguage.Pt,
                "RO" => AppClipAdvancedExperienceLanguage.Ro,
                "RU" => AppClipAdvancedExperienceLanguage.Ru,
                "SK" => AppClipAdvancedExperienceLanguage.Sk,
                "SV" => AppClipAdvancedExperienceLanguage.Sv,
                "TH" => AppClipAdvancedExperienceLanguage.Th,
                "TR" => AppClipAdvancedExperienceLanguage.Tr,
                "UK" => AppClipAdvancedExperienceLanguage.Uk,
                "VI" => AppClipAdvancedExperienceLanguage.Vi,
                "ZH" => AppClipAdvancedExperienceLanguage.Zh,
                _ => null,
            };
        }
    }
}