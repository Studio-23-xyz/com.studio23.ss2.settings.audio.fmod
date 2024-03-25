
using Studio23.SS2.AudioSystem.fmod.Core;
using UnityEngine;

namespace Studio23.SS2.Settings.Audio.fmod.Data
{
    [CreateAssetMenu(fileName = "FmodBusSettings", menuName = "Studio-23/Settings/BusAudioSettingsData/Bus BusAudioSettingsData Setting", order = 1)]
    public class FMODBusSettings : ScriptableObject
    {
        public string _busName;
        [Range(0,1)] [SerializeField] private float _defaultVolume;
        private float _currentVolume;


        public void Initialize(string busName, float volume )
        {
            _busName = busName;
            _currentVolume = volume;
            UpdateVolume(_currentVolume);
        }

        public void UpdateVolume(float volume)
        {
            FMODManager.Instance.MixerManager.SetBusVolume(_busName, volume);
        }

        public float GetDefaultVolume()
        {
            return _defaultVolume;
        }

        public float GetCurrentVolume()
        {
            return _currentVolume;
        }
    }
}

