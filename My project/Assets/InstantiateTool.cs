using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTool : MonoBehaviour
{

    public void AddObject()
    {
        Instantiate(gameObject, Vector3.zero, Quaternion.identity); 
    }

}
