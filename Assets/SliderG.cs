using UnityEngine;
using UnityEngine.UI;

public class SliderG : MonoBehaviour
{
    static public Slider slider;
    static public bool isClick;
    public void OnSliderChanged()
    {
        if (Click.isClicked)
        {
            if (isClick)
            {
                Click.colorG = slider.value;
                GameHalper.countG.text = Mathf.Round(slider.value * 255f).ToString();
                GameHalper.ChangeColor();
            }
        }
    }
    public void PointerEnter()
    {
        isClick = true;
    }
    public void PointerExit()
    {
        isClick = false;
    }
}
