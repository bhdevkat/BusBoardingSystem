using BusBoardingSystem.Debugging;

namespace BusBoardingSystem
{
    public class BusBoardingSystemConsts
    {
        public const string LocalizationSourceName = "BusBoardingSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "5c519d4c14c94d53921e254f441529bd";
    }
}
