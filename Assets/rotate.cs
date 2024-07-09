using UnityEngine;

public class RotateCircle : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed of rotation

    void Update()
    {
        // Get input from the horizontal axis (left/right arrow keys or A/D keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Get input from the vertical axis (up/down arrow keys or W/S keys)
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the rotation amount
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;

        // Apply rotation around the Z axis for 2D or Y axis for 3D
        transform.Rotate(0, 0, -rotationAmount);

        // Alternatively, for 3D rotation
        // transform.Rotate(0, rotationAmount, 0);
    }
}
