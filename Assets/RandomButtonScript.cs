using UnityEngine;
using UnityEngine.UI;

public class RandomButtonScript : MonoBehaviour
{
    public void OnMouseClick()
    {
        if (Click.isClicked)
        {
            Click.colorB = Random.Range(0f, 1f);
            GameHalper.countB.text = Mathf.Round(Click.colorB * 255f).ToString();
            GameHalper.ChangeColor();
        }
    }
}
