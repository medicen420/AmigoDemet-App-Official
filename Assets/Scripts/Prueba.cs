using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    public GameObject objectFind;
    //Esta es una variable de tipo string 
    //Variable que contiene texto, en este caso contiene el siguiente texto
    string tagName = "edificio_blue";
    //edificio blue es el tag que tendremos que encontrar en un gameobject en escena


    // Start is called before the first frame update
    void Start()
    {

        //Esta línea de código nos ayuda a encontrar un objeto en escena con el tag que definimos 
        //en la variable de tagName
        objectFind = GameObject.FindGameObjectWithTag(tagName);
        //En consola me debería arrojar el nombre del objeto que buscamos mediante el tag
        Debug.Log(objectFind.name);
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
