using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Edificios : MonoBehaviour
{
    //Esta variable de tipo GameObject es donde almacenaremos 
    //nuestro edificio seleccionado = edificio color azul
    //public GameObject edificioblue;

    //Acabo de darme cuenata que serán muchos los objectos que 
    //contengan el tag edificio, por lo que tendremos que ocupar
    //un array 


    public GameObject[] azulitos;

    
    


    //Esta es una variable de tipo string 
    //Variable que contiene texto, en este caso contiene el siguiente texto
    string tagNameBlue = "edificio_blue";
    //string tagNameNormal = "edificio_normal";

    //edificio blue es el tag que tendremos que encontrar en un gameobject en escena


    //Este Game Object es el edificio sin seleccionar
    //[SerializeField] GameObject moscú_normal;
    //Este Game Object es el edificio seleccionado
     GameObject edificio_normal;
     GameObject edificio_blue;

    void Start()
    {
        //Esta línea de código nos ayuda a encontrar objetos con el tag "edificio_blue"
        //dado a que tendremos muchos objetos en escena con ese tag

        azulitos = GameObject.FindGameObjectsWithTag(tagNameBlue);

        //Esto es para encontrarlo de forma individual
        

        //Edifico Estambul
        azulitos[0].SetActive(false);
        //Edificio Berna
        azulitos[1].SetActive(false);
        //Edificio Moscú
        azulitos[2].SetActive(false);

      







        //Esta línea de código nos ayuda a encontrar un objeto en escena con el tag que definimos 
        //en la variable de tagName





        //En consola me debería arrojar el nombre del objeto que buscamos mediante el tag




        /*edificio = GameObject.FindGameObjectWithTag(tagNameNormal);
        Debug.Log(edificio.name);

        //Esta variable desactiva al inicio de la aplicación 
        //el game object que corresponde al edificio azul o edificio seleccionado
        //moscú_normal.SetActive(true);
        //moscú_blue.SetActive(false);

        objectFind.SetActive(false);*/







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
                //Debug.Log(hit.transform.name);

                //********************************************************
                //--------------------------------------------------------

                //ESTE COMPORTAMIENTO ES PARA EL EDIFICIO MOSCÚ
                if (hit.transform.name == "Moscú")
                {
                    

                    Debug.Log("Has seleccionado el edificio: " + hit.transform.name);
                    azulitos[2].SetActive(true);

                    //Si le damos touch al edificio Moscú
                    //nos activara el edificio azul o edificio seleccionado


                    //Estos comportamientos nos ayudarán a desactivar 
                    //elementos de nuestra array donde están los edificios azules

                    if (azulitos[0] || azulitos[1].activeInHierarchy)
                    {
                        azulitos[0].SetActive(false);
                        azulitos[1].SetActive(false);
                        Debug.Log("Había un edificio seleccionado");

                    }

                    /*edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);
                    if (edificio_blue.activeInHierarchy)
                    {
                        Debug.Log("yea baby yea");
                        edificio_blue.SetActive(false);
                    }*/

                   

                }

                if (hit.transform.name == "Moscú_blue")
                {
                    Debug.Log("Has deseleccionado el edificio" + hit.transform.name);
                    //moscú_normal.SetActive(true);
                    azulitos[2].SetActive(false);

                }



                //************************************************
                //------------------------------------------------

                //ESTE COMPORTAMIENTO ES PARA EL EDIFICIO BERNA

                if (hit.transform.name == "Berna")
                {

                    azulitos[1].SetActive(true);
                    Debug.Log("Has seleccionado el edificio: " + hit.transform.name);


                    //Si le damos touch al edificio Moscú
                    //nos activara el edificio azul o edificio seleccionado


                    if (azulitos[0] || azulitos[2].activeInHierarchy)
                    {
                        azulitos[0].SetActive(false);
                        azulitos[2].SetActive(false);
                        Debug.Log("Había un edificio seleccionado");

                    }

                }

                if (hit.transform.name == "Berna_blue")
                {
                    Debug.Log("Has deseleccionado el edificio" + hit.transform.name);
                    //moscú_normal.SetActive(true);
                    azulitos[1].SetActive(false);

                }



                //ESTE COMPORTAMIENTO ES PARA EL EDIFICIO BERNA

                if (hit.transform.name == "Estambul")
                {
                    //Si le damos touch al edificio Moscú
                    //nos activara el edificio azul o edificio seleccionado
                    Debug.Log("Has seleccionado el edificio: " + hit.transform.name);
                    azulitos[0].SetActive(true);


                    if (azulitos[1] || azulitos[2].activeInHierarchy)
                    {

                        azulitos[1].SetActive(false);
                        azulitos[2].SetActive(false);
                 
                    }


                }

                if (hit.transform.name == "Estambul_blue")
                {
                    Debug.Log("Has deseleccionado el edificio" + hit.transform.name);
                    //moscú_normal.SetActive(true);
                    azulitos[0].SetActive(false);


                }



            }

        }

    }







}
