using Input;
using Input.Desktop;
using Localization;
using ResourceLoading;
using Save;

namespace Structure
{
    public static class Services
    {
        public static IInputService InputService { get; private set; }
        public static ISaveService SaveService { get; private set; }
        public static IResourceLoaderService ResourceLoaderService { get; private set; }
        public static ILocalizationService LocalizationService { get; private set; }
    
        public static void Init()
        {
            RegisterResourceLoaderService();
            RegisterSaveService();
            RegisterLocalizationService();
            RegisterInputService();
        }

        private static void RegisterInputService()
        {
#if UNITY_EDITOR
            InputService = new DesktopInputService();
#else
            InputService = Agava.WebUtility.Device.IsMobile ? new MobileInputService() : new DesktopInputService();
#endif
            InputService.SetActive(false);
        }

        private static void RegisterSaveService()
        {
            SaveService = new SaveService();
        }

        private static void RegisterResourceLoaderService()
        {
            ResourceLoaderService = new ResourceLoaderService();
        }

        private static void RegisterLocalizationService()
        {
            LocalizationService = new LocalizationService();
#if UNITY_EDITOR
            LocalizationService.ChangeLanguage("ru");
#else
            LocalizationService.ChangeLanguage(Agava.YandexGames.YandexGamesSdk.Environment.i18n.lang);
#endif
        }
    }
}