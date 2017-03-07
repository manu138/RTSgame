using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlyWeight.Characters;

public class SoldierFactory : MonoBehaviour
{
    Dictionary<int, GameObject> SoldierCollection;

    public int SoldierIndex;
    public GameObject soldierTypeOne;
    public Transform soldierTypeOneTransform;
    public GameObject soldierTypeTwo;
    public Transform soldierTypeTwoTransform;


    public void Start()
    {
        
    }
    public void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GetSoldier(0);
            GetSoldier(1);
          
        }
    }
    public SoldierFactory()
    {
        SoldierCollection = new Dictionary<int, GameObject>();
    }

    public GameObject GetSoldier(int SoldierIndex)
    {
        if (!SoldierCollection.ContainsKey(SoldierIndex))
        {
            Debug.Log("objeto creado");
         
            switch (SoldierIndex)
            {
                case  0:
                    CreateSoldierTypeOne();
                    SoldierCollection.Add(SoldierIndex, soldierTypeOne);
                
                    break;
                case 1:
                    CreateSoldierTypeTwo();
                    SoldierCollection.Add(SoldierIndex, soldierTypeTwo);
                  
                    break;
            }
        }
        else
        {
            Debug.Log("Objeto reusado");
        }
        return SoldierCollection[SoldierIndex];
    }
 
    public void CreateSoldierTypeOne()
    {
        Instantiate(soldierTypeOne);
    }
    public void CreateSoldierTypeTwo()
    {
        Instantiate(soldierTypeTwo);
    }
}
