

namespace BSPluginSDK
{
    //[Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }

        //[Init]
        public Plugin()
        {
            Instance = this;
        }

        //[OnStart]
        public void OnApplicationStart()
        {
        }

        //[OnExit]
        public void OnApplicationQuit()
        {

        }

    }
}
