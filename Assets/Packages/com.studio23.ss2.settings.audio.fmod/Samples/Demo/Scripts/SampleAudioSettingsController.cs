
using System.Collections.Generic;
using System.Linq;
using Studio23.SS2.AudioSystem.fmod.Core;
using Studio23.SS2.AudioSystem.fmod.Data;
using Studio23.SS2.Settings.Audio.fmod.Data;
using UnityEngine;
using UnityEngine.UI;

namespace Studio23.SS2.Settings.Audio.fmod.Samples
{
    public class SampleAudioSettingsController : MonoBehaviour
    {
        [SerializeField] private List<AudioSettingsData> _audioSettingsData;
        private Dictionary<AudioSettingsData,string> _audioSettingsDictionary;

        void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            //Need sample data for testing
            FMODManager.Instance.Initialize();

            _audioSettingsDictionary[GetAudioSettingsData("Master")] = FMODBusList.Master;
            _audioSettingsDictionary[GetAudioSettingsData("SFX")] = FMODBusList.SFX;
            _audioSettingsDictionary[GetAudioSettingsData("Music")] = FMODBusList.Music;
            _audioSettingsDictionary[GetAudioSettingsData("VO")] = FMODBusList.VO;

            foreach (var data in _audioSettingsData)
            {
                data.Initialize(_audioSettingsDictionary[data],data.FmodBusSettings.GetDefaultVolume());
                data.GetComponent<Slider>().onValueChanged.AddListener(data.FmodBusSettings.UpdateVolume);
            }
        }
        private AudioSettingsData GetAudioSettingsData(string busName)
        {
            return _audioSettingsData.FirstOrDefault(x => x.BusName.Equals(busName));
        }
    }
}
