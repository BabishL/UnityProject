using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   
    public int NumberOfFuel {  get; private set; }

    public UnityEvent<PlayerInventory> OnFuelCollected;

    public void FuelCollected()
    {
        NumberOfFuel++;
        OnFuelCollected.Invoke(this);
    }
}
