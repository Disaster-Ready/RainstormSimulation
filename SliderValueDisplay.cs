using UnityEngine;
using UnityEngine.UI;

public class SliderValueDisplay : MonoBehaviour
{
    public Slider slider;
    public Text valueText;

    public void Update()
    {
        valueText.text = slider.value.ToString();
    }
}
