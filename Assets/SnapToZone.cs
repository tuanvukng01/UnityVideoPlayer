using UnityEngine;

public class SnapToZone : MonoBehaviour
{
    public Transform[] dropZones; // Assign drop zones in the Inspector

    private bool isHeld = false;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (isHeld)
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                transform.position = hitInfo.point + Vector3.up * 0.5f;
            }

            if (Input.GetMouseButtonDown(0))
            {
                // Find the nearest drop zone and snap to it
                Transform nearestZone = null;
                float nearestDistance = float.MaxValue;

                foreach (Transform zone in dropZones)
                {
                    float distance = Vector3.Distance(transform.position, zone.position);
                    if (distance < nearestDistance)
                    {
                        nearestDistance = distance;
                        nearestZone = zone;
                    }
                }

                if (nearestZone != null)
                {
                    transform.position = nearestZone.position + Vector3.up * 0.5f;
                }

                isHeld = false;
            }
        }
    }

    void OnMouseDown()
    {
        isHeld = true;
    }
}