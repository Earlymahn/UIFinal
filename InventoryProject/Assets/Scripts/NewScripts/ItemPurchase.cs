using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemPurchase : MonoBehaviour
{
    public BagItem[] boughtItems;
    public BackpackChecker checker;

    public int coinsLeft = 100;
    public Text coinText;

    public DragControl dragControl;


    private void Start()
    {
        ConvertToText();
    }
    public void ConvertToText()
    {
        coinText.text= "COINS:" + coinsLeft.ToString();

    }

    public void ClickBuy(int i)
    {

        if (coinsLeft - boughtItems[i].cost >= 0)
        {
            checker.PlaceItem(boughtItems[i]);
            coinsLeft -= boughtItems[i].cost;
            ConvertToText();

        }
        else if (coinsLeft - boughtItems[i].cost < 0)
        {
            Debug.Log("No money nigga");
        }  

    }

    public void ClickSell(int i)
    {
        if (coinsLeft + boughtItems[i].cost >= 0)
        {
            coinsLeft += boughtItems[i].cost;
            ConvertToText();

        }
    }

    public void Awake()
    {
        
        /*GameObject clone = (GameObject)Instantiate(dragItem, transform.position, Quaternion.identity);
        Destroy(clone);*//*

        if (coinsLeft + boughtItems[i].cost >= 0)
        {
            coinsLeft += boughtItems[i].cost;
            ConvertToText();
        }*/
    }

}
