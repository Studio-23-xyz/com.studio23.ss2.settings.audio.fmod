
using Studio23.SS2.AudioSystem.fmod.Core;
using Studio23.SS2.AudioSystem.fmod.Data;
using Studio23.SS2.Settings.Audio.fmod.Data;
using UnityEngine;

namespace  Studio23.SS2.Settings.Audio.fmod.Samples
{
    public class SampleAudioSettingsController : MonoBehaviour
    {
        public static SampleAudioSettingsController Instance;

        public FMODVCASettings MasterSetting;
        public FMODVCASettings MusicSetting;
        public FMODVCASettings SFXSetting;
        public FMODVCASettings VOSetting;

        private void Awake()
        {
            if (Instance == null)
                Instance = this;
        }


        public void Initialize()
        {
            //TODO load from save

            FMODManager.Instance.Initialize();
            //MasterSetting.Initialize(FMODBusList.Master, MasterSetting.GetDefaultVolume());
            //MusicSetting.Initialize(FMODBusList.Music, MusicSetting.GetDefaultVolume());
            //SFXSetting.Initialize(FMODBusList.SFX, SFXSetting.GetDefaultVolume());
            //VOSetting.Initialize(FMODBusList.VO, VOSetting.GetDefaultVolume());
        }

    }

}