using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{

    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("Estas dentro de la app");
    }


    //Este método es llamada después de el método OnEnable
    //solo si este script esta desactivado
    void OnApplicationPause(bool isApplicationPause)
    {
        Debug.Log("isApplicationPause" + isApplicationPause);
    }
}
