using UnityEngine;

public class PlaneRotate : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

  

    private void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
           
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;

            
            transform.Rotate(Vector3.up, -mouseX, Space.World);
        }
    }
}
