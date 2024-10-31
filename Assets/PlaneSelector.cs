using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int currentPlane = 0;
    public Color[] textureColors;
    public Button PrevButton;
    public Button NextButton;
    public Button ButtonRed;
    public Button ButtonBlue;
    public Button ButtonYellow;
    public Button ButtonGreen;
    private void Awake()
    {
        SelectPlane(0);
        if (PrevButton != null)
            PrevButton.onClick.AddListener(() => ChangePlane(-1));
        if (NextButton != null)
            NextButton.onClick.AddListener(() => ChangePlane(1));
        if (ButtonRed != null)
            ButtonRed.onClick.AddListener(() => ChangeTextureColor(0));
        if (ButtonBlue != null)
            ButtonBlue.onClick.AddListener(() => ChangeTextureColor(1));
        if (ButtonYellow != null)
            ButtonYellow.onClick.AddListener(() => ChangeTextureColor(2));
        if (ButtonGreen!=null)
            ButtonGreen.onClick.AddListener(() => ChangeTextureColor(3));

    }
    public void SelectPlane(int _index)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }


    public void ChangePlane(int _change)
    {
        currentPlane = (currentPlane + _change + transform.childCount) % transform.childCount;
        SelectPlane(currentPlane);
    }

    private void OnDestroy()
    { 
       PrevButton.onClick.RemoveAllListeners();
       NextButton.onClick.RemoveAllListeners();
       ButtonRed.onClick.RemoveAllListeners();
       ButtonBlue.onClick.RemoveAllListeners();
       ButtonYellow.onClick.RemoveAllListeners();
       ButtonGreen.onClick.RemoveAllListeners();
    }
    public void ChangeTextureColor(int colorIndex)
    {
        if (textureColors != null && textureColors.Length > colorIndex && colorIndex >= 0)
        {
            GameObject currentPlaneObject = transform.GetChild(currentPlane).gameObject;
            
            if (currentPlaneObject.TryGetComponent<Renderer>(out var planeRenderer))
            {
               
                planeRenderer.material.SetColor("_BaseColor", textureColors[colorIndex]);
            }
            else
            {
                Debug.LogWarning("No Renderer component found on the plane.");
            }
        }
        else
        {
            Debug.LogWarning("Invalid color index.");
        }
    }
}

