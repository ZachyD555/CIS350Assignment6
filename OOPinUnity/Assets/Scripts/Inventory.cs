﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Inventory : MonoBehaviour
{
    [SerializeField] private InventoryItem item;
    public List<InventoryItem> inventory;

    void Start()
    {
        item = new InventoryItem();
        inventory = new List<InventoryItem>();
    }

    void Update()
    {

    }
}
