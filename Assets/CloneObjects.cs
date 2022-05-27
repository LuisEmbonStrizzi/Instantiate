using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObjects : MonoBehaviour
{
    public GameObject objectToClone;

    public void InstantiateObject()
    {
        int i = 0;
        while (i < 3)
        {
            Instantiate(objectToClone);
            i++;
        }
        
    }
}
