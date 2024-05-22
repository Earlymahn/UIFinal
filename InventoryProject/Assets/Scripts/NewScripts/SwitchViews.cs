using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchViews : MonoBehaviour
{
    public Animator animator;
    public Button ToChest;
    public Button ToShop;

    private void Start()
    {
        ToChest.onClick.AddListener(GoRight);
        ToShop.onClick.AddListener(GoLeft);
        ToShop.interactable = false;
    }

    public void GoRight()
    {
        animator.SetBool("move", true);
        ToChest.interactable = false;
        ToShop.interactable = true;
    }

    public void GoLeft()
    {
        animator.SetBool("move", false);
        ToChest.interactable = true;
        ToShop.interactable = false;
    }
}
