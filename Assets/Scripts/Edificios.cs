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
    [SerializeField] GameObject moscú_normal;

    //Este Game Object es el edificio seleccionado
    [SerializeField] GameObject moscú_blue;

    void Start()
    {
        //Esta variable desactiva al inicio de la aplicación 
        //el game object que corresponde al edificio azul o edificio seleccionado
        moscú_normal.SetActive(true);
        moscú_blue.SetActive(false);
       


    }

    void Update()
    {

        //Estas líneas de código nos permiten detectar un touch sobre un objeto dentro de la escena
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //En este caso le estamos indicando al programa que en consola
                //arroje el nombre del objeto que se le esta dando touch
                Debug.Log(hit.transform.name);


                //ESTE COMPORTAMIENTO ES PARA EL EDIFICIO MOSCÚ
                if (hit.transform.name == "Moscú")
                {
                    //Si le damos touch al edificio Moscú
                    //nos activara el edificio azul o edificio seleccionado
                    Debug.Log("Has seleccionado el edificio: " + hit.transform.name);
                    moscú_normal.SetActive(false);
                    moscú_blue.SetActive(true);
  
                }

                if (hit.transform.name == "Moscú_blue")
                {
                    Debug.Log("Has deseleccionado el edificio" + hit.transform.name);
                    moscú_normal.SetActive(true);
                    moscú_blue.SetActive(false);

                }

            }

        }

    }







}
