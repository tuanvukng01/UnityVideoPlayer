using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color originalColor;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    void OnMouseDown()
    {
        // Change the object's color to a random color when clicked
        objectRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }

    void OnMouseUp()
    {
        // Revert to the original color when the mouse is released
        objectRenderer.material.color = originalColor;
    }
}