using UnityEngine;

public class PickupObject : MonoBehaviour
{
    private Camera mainCamera;
    private bool isHeld = false;
    private Vector3 offset;  // Offset between the object's position and the mouse position
    private float currentHeight;  // Stores the current height of the object

    void Start()
    {
        mainCamera = Camera.main;
        currentHeight = transform.position.y;  // Initialize the current height
    }

    void Update()
    {
        if (isHeld)
        {
            // Create a ray from the camera to the mouse position
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            // Get the point where the object should be placed
            Plane plane = new Plane(Vector3.up, new Vector3(0, currentHeight, 0));  // Create a plane at the current height
            if (plane.Raycast(ray, out float distance))
            {
                Vector3 point = ray.GetPoint(distance);  // Calculate the intersection point
                transform.position = point + offset;  // Move the object to the point, applying the offset
            }

            // Adjust the object's height based on scroll wheel input
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            if (scroll != 0.0f)
            {
                currentHeight += scroll;  // Increase or decrease the height
                currentHeight = Mathf.Clamp(currentHeight, 0.1f, 10f);  // Clamp the height to prevent the object from going too high or below the ground
            }

            // Drop the object if the mouse button is released
            if (Input.GetMouseButtonUp(0))
            {
                isHeld = false;
            }
        }
    }

    void OnMouseDown()
    {
        // Calculate the offset between the object position and the mouse click position
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, new Vector3(0, currentHeight, 0));
        if (plane.Raycast(ray, out float distance))
        {
            Vector3 point = ray.GetPoint(distance);
            offset = transform.position - point;  // Store the offset
        }

        isHeld = true;
    }
}