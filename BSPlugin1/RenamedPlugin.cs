using IPA;
using IPALogger = IPA.Logging.Logger;

namespace BSPlugin1
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class RenamedPlugin
    {
        internal static RenamedPlugin Instance { get; private set; }
        /// <summary>
        /// Use to send log messages through BSIPA.
        /// </summary>
        internal static IPALogger Log { get; private set; }

        [Init]
        public RenamedPlugin(IPALogger logger)
        {
            Instance = this;
            Log = logger;
        }

        [OnStart]
        public void OnApplicationStart()
        {
            RenamedPlugin.Log.Info("OnApplicationStart");
        }

        [OnExit]
        public void OnApplicationQuit()
        {

        }

    }
}
