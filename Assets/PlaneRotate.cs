using UnityEngine;

public class PlaneRotate : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public float touchRotationSpeed = 50.0f;


    private void Update()
    {

        if (Input.GetMouseButton(0))
        {

            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;


            transform.Rotate(Vector3.up, -mouseX, Space.World);

        }
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            
            if (touch.phase == TouchPhase.Moved)
            {

                float touchX = touch.deltaPosition.x * touchRotationSpeed * Time.deltaTime;
                transform.Rotate(Vector3.up, -touchX, Space.World);
            
        }
        }
    }
}
 
