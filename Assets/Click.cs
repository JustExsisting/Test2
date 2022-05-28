using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public static MeshRenderer cubeMeshRenderer;//���� ��� �������� MeshRenderer ����, �� ������� ����� ����� 
    public static Image panelImage;//���� ��� �������� Image ������, �� ������� ����� �����
    public static bool type;//true - Panel, false - cube
    public static bool isClicked = false;//��� �� ������ ���� �� ���� ������
    public static float colorR, colorG, colorB;//�������� RGB
    public void OnMouseClick()
    {
        if (gameObject.GetComponent<MeshRenderer>() == true)
        {
            type = false;
            isClicked = true;
            cubeMeshRenderer = gameObject.GetComponent<MeshRenderer>();//���������� ������� � ����
            Debug.Log($"{gameObject.GetComponent<MeshRenderer>().material.color.gamma.maxColorComponent}\t{gameObject.GetComponent<MeshRenderer>().material.color.g}\t{gameObject.GetComponent<MeshRenderer>().material.color.b}");
            GameHalper.countR.text = Mathf.Round(gameObject.GetComponent<MeshRenderer>().material.color.r * 255f).ToString();   
            colorR = gameObject.GetComponent<MeshRenderer>().material.color.r;

            GameHalper.countG.text = Mathf.Round(gameObject.GetComponent<MeshRenderer>().material.color.g * 255f).ToString();   
            colorG = gameObject.GetComponent<MeshRenderer>().material.color.g;
            SliderG.slider.value = colorG;

            GameHalper.countB.text = Mathf.Round(gameObject.GetComponent<MeshRenderer>().material.color.b * 255f).ToString();  
            colorB = gameObject.GetComponent<MeshRenderer>().material.color.b;
        }
        else
        {
            type = true;
            isClicked = true;
            panelImage = gameObject.GetComponent<Image>();
            Debug.Log($"{gameObject.GetComponent<Image>().color.r}\t{gameObject.GetComponent<Image>().color.g}\t{gameObject.GetComponent<Image>().color.b}");
            GameHalper.countR.text = Mathf.Round(gameObject.GetComponent<Image>().color.r * 255f).ToString();   
            colorR = gameObject.GetComponent<Image>().color.r;

            GameHalper.countG.text = Mathf.Round(gameObject.GetComponent<Image>().color.g * 255f).ToString();   
            colorG = gameObject.GetComponent<Image>().color.g;
            SliderG.slider.value = colorG;
            SliderG.isClick = false;

            GameHalper.countB.text = Mathf.Round(gameObject.GetComponent<Image>().color.b * 255f).ToString();   
            colorB = gameObject.GetComponent<Image>().color.b;
        }
    }
}
