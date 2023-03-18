namespace BSPluginGenerated.Subnamespace
{
    //[Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        internal static Plugin Instance { get; private set; }
        /// <summary>
        /// Use to send log messages through BSIPA.
        /// </summary>
        //internal static IPALogger Log { get; private set; }

        //[Init]
        public Plugin()
        {
            Instance = this;
        }

        //[OnStart]
        public void OnApplicationStart()
        {
            //Plugin.Log.Info("OnApplicationStart");
        }

        //[OnExit]
        public void OnApplicationQuit()
        {

        }

    }
}
