using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private GameObject targetObject;
    private float snapDistance = 0.5f; // Adjust this value as needed

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, transform.position.z);
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - mousePosition;
    }

    void OnMouseUp()
    {
        isDragging = false;
        SnapToTarget();
    }

    void SnapToTarget()
    {
        if (targetObject != null)
        {
            float distance = Vector3.Distance(transform.position, targetObject.transform.position);
            if (distance <= snapDistance)
            {
                transform.position = targetObject.transform.position;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isDragging && other.CompareTag("Target")) // Adjust the tag as needed
        {
            targetObject = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Target")) // Adjust the tag as needed
        {
            targetObject = null;
        }
    }
}