using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragControl : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform attachToParent;

    public ItemPurchase itemPurchase;

    public BackpackChecker backpackChecker;
    public int baseCost;

    public BagItem bagItemScriptable;

    public void InitialiseThis(BagItem newBagItem)
    {
        bagItemScriptable = newBagItem;
        image.sprite = newBagItem.sprite;
        baseCost = newBagItem.cost;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        attachToParent = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();

        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(attachToParent);
        image.raycastTarget = true;
    }

    public void Sell()
    {
        itemPurchase.ClickSell(baseCost);
        Destroy(this.gameObject);
    }
}