using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class DestroyTool : MonoBehaviour
{
    public void RemoveObject()
    {
        Destroy(gameObject);
        Debug.Log(gameObject.name + " was destroyed.");
    }

}
