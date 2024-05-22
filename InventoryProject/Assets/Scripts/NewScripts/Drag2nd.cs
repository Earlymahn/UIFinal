using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag2nd : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        // Implement code for when dragging begins
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Implement code for when object is being dragged
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Implement code for when dragging ends
        Debug.Log("Drag ended");
    }
}
