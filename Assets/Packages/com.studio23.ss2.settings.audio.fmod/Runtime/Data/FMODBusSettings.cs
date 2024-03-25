
using Studio23.SS2.AudioSystem.fmod.Core;
using UnityEngine;

namespace Studio23.SS2.Settings.Audio.fmod.Data
{
    [CreateAssetMenu(fileName = "FmodBusSettings", menuName = "Studio-23/Settings/Audio/BusAudioSettingsData", order = 1)]
    public class FMODBusSettings : ScriptableObject
    {
        private string _busName;
        [Range(0,1)] [SerializeField] private float _defaultVolume;
        private float _currentVolume;

        /// <summary>
        /// This function initializes bus name and have to call at least once
        /// </summary>
        /// <param name="busName"></param>
        /// <param name="volume"></param>
        public void Initialize(string busName, float volume )
        {
            _busName = busName;
            _currentVolume = volume;
            UpdateVolume(_currentVolume);
        }
        /// <summary>
        /// This function updates bus volume 
        /// </summary>
        /// <param name="volume"></param>
        public void UpdateVolume(float volume)
        {
            _currentVolume = volume;
            FMODManager.Instance.MixerManager.SetBusVolume(_busName, _currentVolume);
        }

        /// <summary>
        /// This function returns default volume 
        /// </summary>
        /// <returns></returns>
        public float GetDefaultVolume()
        {
            return _defaultVolume;
        }

        /// <summary>
        /// This function returns current volume
        /// </summary>
        /// <returns></returns>
        public float GetCurrentVolume()
        {
            return _currentVolume;
        }
    }
}

