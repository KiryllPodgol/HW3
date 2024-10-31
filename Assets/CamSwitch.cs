using UnityEngine;
using UnityEngine.UI;

public class CameraSwitch : MonoBehaviour
{
    public Camera CameraMini; 

    public Button ButtonUp;
    public Button ButtonDown;
    public Button ButtonLeft;
    public Button ButtonFace;

    public Transform upView;
    public Transform downView;
    public Transform LeftView;
    public Transform FaceView;

    private void Awake()
    {
        ButtonUp.onClick.AddListener(SwitchToUpView);
        ButtonDown.onClick.AddListener(SwitchToDownView);
        ButtonLeft.onClick.AddListener(SwitchToLeftView);
        ButtonFace.onClick.AddListener(SwitchToFaceView);
        SetCameraPosition(upView);
    }
    public void SwitchToFaceView()
    {
        SetCameraPosition(FaceView);
       
    }
    public void SwitchToUpView()
    {
        SetCameraPosition(upView);
    }
    public void SwitchToDownView()
    {
        SetCameraPosition(downView);
    }
    public void SwitchToLeftView()
    {
        SetCameraPosition(LeftView);
    }



    private void SetCameraPosition(Transform targetView)
    {
        if (CameraMini != null)
        {
            CameraMini.transform.position = targetView.position;
            CameraMini.transform.rotation = targetView.rotation;
        }
        else
        {
            Debug.LogError("CameraMini is not assigned in the inspector!");
        }
    }
}
