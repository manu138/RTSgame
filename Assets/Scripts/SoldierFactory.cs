using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyWeight.Characters;

public class SoldierFactory : MonoBehaviour
{
    Dictionary<string, Soldier> SoldierCollection;

    public string SoldierIndex;



    public void Start()
    {
        GetSoldier(SoldierIndex);
    }
    public SoldierFactory()
    {
        SoldierCollection = new Dictionary<string, Soldier>();
    }

    public Soldier GetSoldier(string SoldierIndex)
    {
        if (!SoldierCollection.ContainsKey(SoldierIndex))
        {
            Debug.Log("objeto creado");
         
            switch (SoldierIndex)
            {
                case "0":
                    SoldierCollection.Add(SoldierIndex, new SoldierTypeOne());
                    break;
                case "1":
                    SoldierCollection.Add(SoldierIndex, new SoldierTypeTwo());
                    break;
            }
        }
        else
        {
            Debug.Log("Objeto reusado");
        }
        return SoldierCollection[SoldierIndex];
    }
 

}
