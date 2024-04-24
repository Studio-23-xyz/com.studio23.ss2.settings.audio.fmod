
using Studio23.SS2.AudioSystem.fmod.Core;
using UnityEngine;

namespace Studio23.SS2.Settings.Audio.fmod.Data
{
    [CreateAssetMenu(fileName = "FmodVCASettings", menuName = "Studio-23/Settings/Audio/VCAAudioSettingsData", order = 1)]
    public class FMODVCASettings : ScriptableObject
    {
        private string _vcaName;
        [Range(0,1)] [SerializeField] private float _defaultVolume;
        private float _currentVolume;

        /// <summary>
        /// This function initializes bus name and have to call at least once
        /// </summary>
        /// <param name="vcaName"></param>
        /// <param name="volume"></param>
        public void Initialize(string vcaName, float volume)
        {
            _vcaName = vcaName;
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
            FMODManager.Instance.MixerManager.SetVCAVolume(_vcaName, _currentVolume);
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

