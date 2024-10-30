using UnityEngine;

public class SwitchCam : MonoBehaviour
{
    public Camera CameraMini; // —сылка на вашу камеру CameraMini
    public Transform downView;
    public Transform leftView;
    public Transform upView;
    public Transform faceView;

    public void SwitchToUpView()
    {
        SetCameraPosition(upView);
    }

    public void SwitchToDownView()
    {
        SetCameraPosition(downView);
    }

    public void SwitchToFaceView()
    {
        SetCameraPosition(faceView);
    }

    public void SwitchToLeftView()
    {
        SetCameraPosition(leftView);
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