using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera CameraMini; // —сылка на вашу камеру CameraMini

    public Transform upView;
    public Transform downView;
    public Transform LeftView;
    public Transform FaceView;

    private void Awake()
    {
        SetCameraPosition(upView);
    }
    public void SwitchToFaceView()
    {
        SetCameraPosition(FaceView);
        CameraMini.fieldOfView = 114.2f;
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
