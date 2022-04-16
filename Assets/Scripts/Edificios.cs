using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificios : MonoBehaviour
{
    /*public enum EdificioType
    {
        Moscu,
        Berna,
        Bulgaria
    }*/
    //Lo que quiero es saber como podemos detectar cuando se toca 
    //uno de los edificios

    //Este Game Object es el edificio sin seleccionar
    [SerializeField] GameObject mosc�_normal;

    //Este Game Object es el edificio seleccionado
    [SerializeField] GameObject mosc�_blue;

    void Start()
    {
        //Esta variable desactiva al inicio de la aplicaci�n 
        //el game object que corresponde al edificio azul o edificio seleccionado
        mosc�_normal.SetActive(true);
        mosc�_blue.SetActive(false);
       


    }

    void Update()
    {

        //Estas l�neas de c�digo nos permiten detectar un touch sobre un objeto dentro de la escena
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //En este caso le estamos indicando al programa que en consola
                //arroje el nombre del objeto que se le esta dando touch
                Debug.Log(hit.transform.name);


                //ESTE COMPORTAMIENTO ES PARA EL EDIFICIO MOSC�
                if (hit.transform.name == "Mosc�")
                {
                    //Si le damos touch al edificio Mosc�
                    //nos activara el edificio azul o edificio seleccionado
                    Debug.Log("Has seleccionado el edificio: " + hit.transform.name);
                    mosc�_normal.SetActive(false);
                    mosc�_blue.SetActive(true);
  
                }

                if (hit.transform.name == "Mosc�_blue")
                {
                    Debug.Log("Has deseleccionado el edificio" + hit.transform.name);
                    mosc�_normal.SetActive(true);
                    mosc�_blue.SetActive(false);

                }

            }

        }

    }







}
