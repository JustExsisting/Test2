using UnityEngine;
using UnityEngine.UI;

public class GameHalper : MonoBehaviour
{
    public static Text countR, countG, countB;
    public const float percentageToColorUnitRatio = 0.39f; //100f / 255f
    private void Start()
    {
        countR = GameObject.Find("CountR").GetComponent<Text>();
        countG = GameObject.Find("CountG").GetComponent<Text>();
        countB = GameObject.Find("CountB").GetComponent<Text>();
        SliderG.slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    static public void ChangeColor()
    {
        if (Click.type)
        {
            ChangePanelColor();
        }
        else
        {
            ChangeColorCube();
        }
    }

    static private void ChangeColorCube()
    {
        Click.cubeMeshRenderer.material.color = NewColor();
    }

    static private void ChangePanelColor()
    {
        Click.panelImage.color = NewColor();
    }

    static private Color NewColor()
    { 
        return new Color(Click.colorR, Click.colorG, Click.colorB);
    }

   
}
