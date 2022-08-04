using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BusBoardingSystem.Localization
{
    public static class BusBoardingSystemLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BusBoardingSystemConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BusBoardingSystemLocalizationConfigurer).GetAssembly(),
                        "BusBoardingSystem.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
