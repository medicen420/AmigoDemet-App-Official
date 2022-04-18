using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_edificios : MonoBehaviour
{

    //COMPORTAMIENTOS DE INTERACCION PARA LOS EDIFICIOS 

    //1. Seleccionar un edificio dando touch sobre él
    //2. Deseleccionar un edificio dando touch por segunda vez sobre él
    //3. Deseleccionar un edificio seleccionando otro 


  

    //Acabo de darme cuenata que serán muchos los objectos que 
    //contengan el tag edificio, por lo que tendremos que ocupar
    //2 Arrays 

    //Array para los edificios azules
    public GameObject[] azulitos;
    //[SerializeField] bool noblue = false;

    //Array para los edificios normales
    public GameObject[] normalillos;


    //Ahora vamos a desactivar lso edificios normales 
    //una vez que se haya seleccionado y cambiado por el edificio azul
    //GameObject edificio_normalnewtag;
    //Para esto voy a necesitar crear una variable de tipo GameObject
    //está variable va almacenar el edificio normal con un diferente tag al de los otros
    //en este caso el tag es: "prueba"

    //el tag se le debe de cambiar al momento de desactivarse


    //Esta es una variable de tipo string 
    //Variable que contiene texto, en este caso contiene el siguiente texto
    string tagNameBlue = "edificio_blue";
    string tagNameNormal = "edificio_normal";
    string tagNew = "prueba";
    

    //******************************************

    //[SerializeField] bool banana = false;


    //edificio blue es el tag que tendremos que encontrar en un gameobject en escena



    //[SerializeField] GameObject moscú_normal;
    //Este Game Object es el edificio seleccionado
    //EDIFICIO AZUL
    GameObject edificio_blue;


    //Este GameObject es el edificio sin seleccionar
    //con el tag "edificio_blue"
    //EDIFICIO NORMAL CON NUEVO TAG
    //Esto se hace para que al momento de seleccionar un edificio
    //el edificio normal se cambie de tag
    GameObject edificio_newtag;

    //Este es el GameObject para cuando se cambie el tag de 
    //edificio_normal por "prueba"
    //EDIFICIO NORMAL CON NUEVO TAG
    //GameObject newedificiotag;
    //[SerializeField] bool normalout = false;

    //En esta variable GameObject almacenaremos nuestro edificio normal 
    //cuando se le haya cambiado el tag y este desactivado
    [SerializeField] GameObject madrinita;
    
    



    void Start()
    {
        //Esta línea de código nos ayuda a encontrar objetos con el tag "edificio_blue"
        //dado a que tendremos muchos objetos en escena con ese tag

        //ESTOS SON LOS ARRAYS
        //EDIFICIOS AZULES Y NORMALES
        
        azulitos = GameObject.FindGameObjectsWithTag(tagNameBlue);
        
        

        //Esto es para encontrarlos de forma individual

        //EDIFICIOS AZULES

        //Edifico Berna
        azulitos[0].SetActive(false);

        //Edificio Estambul
        azulitos[1].SetActive(false);

        //Edificio Moscú
        azulitos[2].SetActive(false);

        //Edificio Oslo
        azulitos[3].SetActive(false);


        //***********************************
        //**********************************************

        normalillos = GameObject.FindGameObjectsWithTag(tagNameNormal);

        //Esto es para encontrarlos de forma individual

        //EDIFICIOS NORMALES
        //Todos al principio aparecen en true 
        //es decir aparecen activados en escena

        //Edificio Moscú
        normalillos[0].SetActive(true);

        //Edifico Berna
        normalillos[1].SetActive(true);

        //Edificio Estambul
        normalillos[2].SetActive(true);

        //Edificio Oslo
        normalillos[3].SetActive(true);





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


        edificio_newtag = GameObject.FindGameObjectWithTag(tagNew);
      

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

                //Este comportamiento era la antigua forma en la que mandabamos a desactivar
                //edificio azules si es que estaban activos en la escena, la desventaja del mismo
                //era que iba a tener que poner básicamente todos los nombres de los elementos dentro
                //de mi Array de edificio azules, es decir... mucho texto para mi script.

                /*if (azulitos[0] || azulitos[1].activeInHierarchy)
              {
                  azulitos[0].SetActive(false);
                  azulitos[1].SetActive(false);
                  Debug.Log("Había un edificio seleccionado");

              }*/

                //Así es que descarte esta opción y traté de generar un código más limpio y funcional
                //--------------------------------------------------------

                //ESTE COMPORTAMIENTO ES PARA EL EDIFICIO MOSCÚ
                if (hit.transform.name == "Moscú")
                {

                    //Tenemos que mandar buscar en la escena un objeto que tengta el tagNameBlue
                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);
                    //edificio_newtag = GameObject.FindGameObjectWithTag(tagNew);

                    //****************************************

                    //Si no hay un edificio azul activado en la escena 
                    //entonces ejecuta el código 
                    if (edificio_blue == false)
                    {
 
                        //edificio_normal = GameObject.FindGameObjectWithTag(tagNameNormal);
                        Debug.Log("Substitucion madre");
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Has seleccionado el edificio: " + hit.transform.name);
                        //Si le damos touch al edificio Moscú
                        //nos activara el edificio Moscú azul.
                        azulitos[2].SetActive(true);
                        normalillos[0].tag = tagNew;
                        //normalillos[0].tag = "prueba";
                        madrinita = normalillos[0];
                        madrinita.SetActive(false);



                    }

                    //EDIFICIO AZUL ACTIVADO EN ESCENA :D
                    //*************************************
                    //Si hay un edificio azul activado en la escena 
                    //entonces ejecuta el código 
                    if (edificio_blue == true)
                    {
                        edificio_blue.SetActive(false);
                        madrinita.tag = tagNameNormal;
                        madrinita.SetActive(true);
                        madrinita = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código de adentro

                        //Esto es para que ahora pueda gu
                        if(madrinita == null)
                        {

                            Debug.Log("Recolector esta en Null");
                            //Se activa el edificio azul Moscú
                            azulitos[2].SetActive(true);
                            normalillos[0].SetActive(false);
                            normalillos[0].tag = tagNew;
                            madrinita = normalillos[0];
                            madrinita.SetActive(false);
                            //Se desactiva el edificio azul que estaba en la escena
                            //Se activa el edificio normal que fue desactivado
                            //como le cambiamos el tag para poder desactivarlo le tendremos
                            //que regresa el tag que tenía al principio


                        }



                    }


                }

                
                
                if (hit.transform.name == "Moscú_blue")
                {
                    Debug.Log("Has deseleccionado el edificio" + hit.transform.name);
                    //moscú_normal.SetActive(true);
                    azulitos[2].SetActive(false);
                    normalillos[0].tag = tagNameNormal;
                    madrinita.SetActive(true);
                    madrinita = null;


                    //normalillos[0].SetActive(true);
                    //normalillos[0].tag = "edificio_normal";


                }



                //************************************************
                //------------------------------------------------

                //ESTE COMPORTAMIENTO ES PARA EL EDIFICIO BERNA

                if (hit.transform.name == "Berna")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);
                   
                   
                    //edificio_normal = GameObject.FindGameObjectWithTag(tagNameNormal);

                    if (edificio_blue == false)
                    {
                        //edificio_newtag = GameObject.FindGameObjectWithTag(tagNew);

                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Has seleccionado el edificio: " + hit.transform.name);
                        //Si le damos touch al edificio Moscú
                        //nos activara el edificio Moscú azul.
                        azulitos[0].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el mismo tag
                        normalillos[1].tag = tagNew;

                        //Script para crear un nuevo GameObject
                        //GameObject m4 = new GameObject("nuevo objeto");
                        madrinita = normalillos[1];
                        madrinita.SetActive(false);


                    }


                    if (edificio_blue == true)
                    {
                        edificio_blue.SetActive(false);
                        madrinita.tag = tagNameNormal;
                        madrinita.SetActive(true);
                        madrinita = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código de adentro

                        //Esto es para que ahora pueda gu
                        if (madrinita == null)
                        {

                            Debug.Log("Recolector esta en Null");
                            //Se activa el edificio azul Moscú
                            azulitos[0].SetActive(true);
                            normalillos[1].SetActive(false);
                            normalillos[1].tag = tagNew;
                            madrinita = normalillos[1];
                            madrinita.SetActive(false);
                           
                            //Se desactiva el edificio azul que estaba en la escena
                            //Se activa el edificio normal que fue desactivado
                            //como le cambiamos el tag para poder desactivarlo le tendremos
                            //que regresa el tag que tenía al principio


                        }



                    }




                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Berna_blue")
                {
                    Debug.Log("Has deseleccionado el edificio" + hit.transform.name);
                    //moscú_normal.SetActive(true);
                    azulitos[0].SetActive(false);
                    normalillos[1].tag = tagNameNormal;
                    madrinita.SetActive(true);
                    madrinita = null;




                }









            }
        }
    }
}
















