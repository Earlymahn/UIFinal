using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackpackSlots : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject isPlaced = eventData.pointerDrag;
            DragControl dragControl = isPlaced.GetComponent<DragControl>();
            dragControl.attachToParent = transform;
        }
    }
}
