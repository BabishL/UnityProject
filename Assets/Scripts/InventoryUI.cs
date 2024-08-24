using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI fuelText;
    void Start()
    {
        fuelText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateFuelText(PlayerInventory playerInventory)
    {
        fuelText.text = playerInventory.NumberOfFuel.ToString();
    }

}

    