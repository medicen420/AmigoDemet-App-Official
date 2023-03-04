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


    //Este m�todo es llamada despu�s de el m�todo OnEnable
    //solo si este script esta desactivado
    void OnApplicationPause(bool isApplicationPause)
    {
        Debug.Log("isApplicationPause" + isApplicationPause);
    }
}
