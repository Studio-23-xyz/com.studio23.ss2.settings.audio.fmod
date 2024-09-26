
using Studio23.SS2.AudioSystem.fmod.Core;
using UnityEngine;

namespace Studio23.SS2.Settings.Audio.fmod.Samples
{
    public class SampleAudioSettingsUI : MonoBehaviour
    {
        [SerializeField] private LabeledSlider _masterVolumeSlider;
        [SerializeField] private LabeledSlider _musicVolumeSlider;
        [SerializeField] private LabeledSlider _sfxVolumeSlider;
        [SerializeField] private LabeledSlider _voVolumeSlider;
        private SampleAudioSettingsController _controller;

        void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            _controller = SampleAudioSettingsController.Instance;
            _controller.Initialize();

            _masterVolumeSlider.InitializeData("Master", 0f, 1f, .5f);
            _masterVolumeSlider.SliderValueUpdated.AddListener(_controller.MasterSetting.UpdateVolume);

            _musicVolumeSlider.InitializeData("Music", 0f, 1f, .5f);
            _musicVolumeSlider.SliderValueUpdated.AddListener(_controller.MusicSetting.UpdateVolume);

            _sfxVolumeSlider.InitializeData("SFX", 0f, 1f, .5f);
            _sfxVolumeSlider.SliderValueUpdated.AddListener(_controller.SFXSetting.UpdateVolume);

            _voVolumeSlider.InitializeData("VO", 0f, 1f, .5f);
            _voVolumeSlider.SliderValueUpdated.AddListener(_controller.VOSetting.UpdateVolume);

        }

    }
}
