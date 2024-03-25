
using UnityEngine;

namespace Studio23.SS2.Settings.Audio.fmod.Data
{
    public class AudioSettingsData : MonoBehaviour
    {
        public string BusName;
        public FMODBusSettings FmodBusSettings;

        public void Initialize(string busName, float volume)
        {
            //TODO need to load data from save file
            
            FmodBusSettings.Initialize(busName, volume);
        }
    }

}