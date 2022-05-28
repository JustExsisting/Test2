using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusButtonClick : MonoBehaviour
{
    public void OnMouseClick()
    {
        if (Click.isClicked)
        {
            if (float.Parse(GameHalper.countR.text) > 1)
            {
                Click.colorR = Click.colorR -  GameHalper.percentageToColorUnitRatio / 100f;
                GameHalper.countR.text = Mathf.Round(Click.colorR * 255f).ToString();
                GameHalper.ChangeColor();
            }
        }
    }
}
