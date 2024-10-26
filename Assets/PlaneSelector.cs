using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int currentPlane = 0;
    public Color[] textureColors; 

    private void Awake()
    {
        SelectPlane(0);
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

 
    public void ChangeTextureColor(int colorIndex)
    {
        if (colorIndex >= 0 && colorIndex < textureColors.Length)
        {
            GameObject currentPlaneObject = transform.GetChild(currentPlane).gameObject;
            Renderer planeRenderer = currentPlaneObject.GetComponent<Renderer>();

            if (planeRenderer != null)
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

