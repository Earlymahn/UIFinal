using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackChecker : MonoBehaviour
{
    public BackpackSlots[] bagSlots;
    public GameObject bagItemPrefab;

    public void PlaceItem(BagItem bagItem)
    {
        for (int i = 0; i < bagSlots.Length; i++)
        {
            BackpackSlots slot = bagSlots[i];
            DragControl itemInSlot = slot.GetComponentInChildren<DragControl>();
            if (itemInSlot == null)
            {
                SpawnIn(bagItem, slot);
                return;
            }
        }
    }

    public void SpawnIn(BagItem bagItem, BackpackSlots slot)
    {
        GameObject newObject = Instantiate(bagItemPrefab, slot.transform);
        DragControl backpackItem = newObject.GetComponent<DragControl>();
        backpackItem.InitialiseThis(bagItem);
    }
}
