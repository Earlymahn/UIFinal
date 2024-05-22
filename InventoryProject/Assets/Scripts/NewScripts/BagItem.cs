using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Product",menuName = "Product/Create New")]
public class BagItem : ScriptableObject
{
    public int cost;
    public Sprite sprite;
}
