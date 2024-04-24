
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Studio23.SS2.Settings.Audio.fmod.Samples
{
    public class LabeledSlider : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI LabelText;
        [SerializeField] private TextMeshProUGUI DisplayText;
        [SerializeField] Slider _slider;
        [SerializeField] private bool _updateImmedietly;
        public UnityEvent<float> SliderValueUpdated;
        private CancellationTokenSource _sliderCancelToken;
        public float Value => _slider.value;

        void Start()
        {

            _slider.onValueChanged.AddListener((_ => { SliderValueUpdateAction(); }));
        }


        public void InitializeData(string label, float minValue = 0, float maxValue = 1, float value = 0)
        {
            LabelText.text = label;
            _slider.value = value;
            _slider.minValue = minValue;
            _slider.maxValue = maxValue;
            SliderValueUpdateAction(false);
        }


        private void ShowText()
        {
            DisplayText.text = _slider.value.ToString("P0");
        }


        public void SliderValueUpdateAction(bool checkLiveStatus = true)
        {
            ShowText();
            if (checkLiveStatus && !_updateImmedietly) return;
            ApplyAction(_slider.value);
        }

        private void ApplyAction(float value)
        {
            SliderValueUpdated?.Invoke(_slider.value);
        }
    }

}
