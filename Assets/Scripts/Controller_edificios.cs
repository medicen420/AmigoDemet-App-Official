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
    [SerializeField] GameObject recolector;





    void Start()
    {
        //Esta línea de código nos ayuda a encontrar objetos con el tag "edificio_blue"
        //dado a que tendremos muchos objetos en escena con ese tag

        //ESTOS SON LOS ARRAYS
        //EDIFICIOS AZULES Y NORMALES

        azulitos = GameObject.FindGameObjectsWithTag(tagNameBlue);
        normalillos = GameObject.FindGameObjectsWithTag(tagNameNormal);



        //Esto es para encontrarlos de forma individual

        //EDIFICIOS AZULES
        //En total son 74 edificios en toda la unidad 


        //Siria
        azulitos[0].SetActive(false);
        //Nueva Delhi
        azulitos[1].SetActive(false);
        //Pekin 
        azulitos[2].SetActive(false);
        //Estambul
        azulitos[3].SetActive(false);
        //Guatemala
        azulitos[4].SetActive(false);
        //Copennague
        azulitos[5].SetActive(false);
        //Túnez
        azulitos[6].SetActive(false);
        //Amsterdam
        azulitos[7].SetActive(false);
        //Otawa
        azulitos[8].SetActive(false);
        //Singapur
        azulitos[9].SetActive(false);
        //Dacca
        azulitos[10].SetActive(false);
        //Santo Domingo
        azulitos[11].SetActive(false);
        //San Salvador
        azulitos[12].SetActive(false);
        //Viena
        azulitos[13].SetActive(false);
        //Habana
        azulitos[14].SetActive(false);
        //Bucarest
        azulitos[15].SetActive(false);
        //Lisboa
        azulitos[16].SetActive(false);
        //Tripoli
        azulitos[17].SetActive(false);
        //Tokio
        azulitos[18].SetActive(false);
        //México
        azulitos[19].SetActive(false);
        //Varsovia
        azulitos[20].SetActive(false);
        //El cabo
        azulitos[21].SetActive(false);
        //Yokohama
        azulitos[22].SetActive(false);
        //Washington
        azulitos[23].SetActive(false);
        //Berna
        azulitos[24].SetActive(false);
        //Mónaco
        azulitos[25].SetActive(false);
        //Brasilia
        azulitos[26].SetActive(false);
        //Estocolmo
        azulitos[27].SetActive(false);
        //Buenos aires
        azulitos[28].SetActive(false);
        //Praga
        azulitos[29].SetActive(false);
        //Atenas
        azulitos[30].SetActive(false);
        //Managua
        azulitos[31].SetActive(false);
        //Quito
        azulitos[32].SetActive(false);
        //Ankara
        azulitos[33].SetActive(false);
        //Tegucigalpa
        azulitos[34].SetActive(false);
        //Roma
        azulitos[35].SetActive(false);
        //Asuncion
        azulitos[36].SetActive(false);
        //Canberra
        azulitos[37].SetActive(false);
        //Yakarta
        azulitos[38].SetActive(false);
        //Londres
        azulitos[39].SetActive(false);
        //Belgrado
        azulitos[40].SetActive(false);
        //Honolulu
        azulitos[41].SetActive(false);
        //Nueva York
        azulitos[42].SetActive(false);
        //Sofia
        azulitos[43].SetActive(false);
        //San Juan
        azulitos[44].SetActive(false);
        //Bombay
        azulitos[45].SetActive(false);
        //MonteVideo
        azulitos[46].SetActive(false);
        //Damasco
        azulitos[47].SetActive(false);
        //Kingston
        azulitos[48].SetActive(false);
        //Bruselas
        azulitos[49].SetActive(false);
        //Madrid
        azulitos[50].SetActive(false);
        //Panamá
        azulitos[51].SetActive(false);
        //Bogotá
        azulitos[52].SetActive(false);
        //Oslo
        azulitos[53].SetActive(false);
        //Taipei
        azulitos[54].SetActive(false);
        //Bulgaria
        azulitos[55].SetActive(false);
        //París
        azulitos[56].SetActive(false);
        //Moscú
        azulitos[57].SetActive(false);
        //San José
        azulitos[58].SetActive(false);
        //Teherán
        azulitos[59].SetActive(false);
        //Luanda
        azulitos[60].SetActive(false);
        //Berlín
        azulitos[61].SetActive(false);
        //Hamburgo
        azulitos[62].SetActive(false);
        //Toronto
        azulitos[63].SetActive(false);
        //El Cairo
        azulitos[64].SetActive(false);
        //Minesota
        azulitos[65].SetActive(false);
        //Caracas
        azulitos[66].SetActive(false);
        //Santiago
        azulitos[67].SetActive(false);
        //Argel
        azulitos[68].SetActive(false);
        //Seúl
        azulitos[69].SetActive(false);
        //Zurich
        azulitos[70].SetActive(false);
        //Saigon
        azulitos[71].SetActive(false);
        //Eslovaquia
        azulitos[72].SetActive(false);
        //Manila
        azulitos[73].SetActive(false);






        //***********************************
        //**********************************************



        //Esto es para encontrarlos de forma individual

        //EDIFICIOS NORMALES
        //Todos al principio aparecen en true 
        //es decir aparecen activados en escena
        //*********************************************
        //En total son 74 edificios en toda la unidad 

        //Pekin
        normalillos[0].SetActive(true);
        //Tegucigalpa
        normalillos[1].SetActive(true);
        //Estocolmo
        normalillos[2].SetActive(true);
        //Siria
        normalillos[3].SetActive(true);
        //Copennague
        normalillos[4].SetActive(true);
        //Toronto
        normalillos[5].SetActive(true);
        //Madrid
        normalillos[6].SetActive(true);
        //Managua
        normalillos[7].SetActive(true);
        //Santo Domingo
        normalillos[8].SetActive(true);
        //MonteVideo
        normalillos[9].SetActive(true);
        //París
        normalillos[10].SetActive(true);
        //Bombay
        normalillos[11].SetActive(true);
        //Amsterdam
        normalillos[12].SetActive(true);
        //Bucarest
        normalillos[13].SetActive(true);
        //Damasco
        normalillos[14].SetActive(true);
        //Lisboa
        normalillos[15].SetActive(true);
        //Moscú
        normalillos[16].SetActive(true);
        //Saigon
        normalillos[17].SetActive(true);
        //Bulgaria
        normalillos[18].SetActive(true);
        //Varsovia
        normalillos[19].SetActive(true);
        //México
        normalillos[20].SetActive(true);
        //Yakarta
        normalillos[21].SetActive(true);
        //Luanda
        normalillos[22].SetActive(true);
        //Hamburgo
        normalillos[23].SetActive(true);
        //Roma
        normalillos[24].SetActive(true);
        //Bruselas
        normalillos[25].SetActive(true);
        //Dacca
        normalillos[26].SetActive(true);
        //San Salvador
        normalillos[27].SetActive(true);
        //Túnez
        normalillos[28].SetActive(true);
        //Monaco
        normalillos[29].SetActive(true);
        //Eslovaquia
        normalillos[30].SetActive(true);
        //Taipei
        normalillos[31].SetActive(true);
        //Tripoli
        normalillos[32].SetActive(true);
        //Panamá
        normalillos[33].SetActive(true);
        //San Juan
        normalillos[34].SetActive(true);
        //Buenos Aires
        normalillos[35].SetActive(true);
        //Atenas
        normalillos[36].SetActive(true);
        //Brasilia
        normalillos[37].SetActive(true);
        //Caracas
        normalillos[38].SetActive(true);
        //San José
        normalillos[39].SetActive(true);
        //Teherán
        normalillos[40].SetActive(true);
        //Estambul
        normalillos[41].SetActive(true);
        //Londres
        normalillos[42].SetActive(true);
        //Honolulu
        normalillos[43].SetActive(true);
        //Canberra
        normalillos[44].SetActive(true);
        //El Cabo
        normalillos[45].SetActive(true);
        //Quito
        normalillos[46].SetActive(true);
        //Belgrado
        normalillos[47].SetActive(true);
        //Minesota
        normalillos[48].SetActive(true);
        //Nueva York
        normalillos[49].SetActive(true);
        //Singapur
        normalillos[50].SetActive(true);
        //Otawa
        normalillos[51].SetActive(true);
        //Habana
        normalillos[52].SetActive(true);
        //Argel
        normalillos[53].SetActive(true);
        //El Cairo
        normalillos[54].SetActive(true);
        //Yokohama
        normalillos[55].SetActive(true);
        //Seúl
        normalillos[56].SetActive(true);
        //Kingston
        normalillos[57].SetActive(true);
        //Bogotá
        normalillos[58].SetActive(true);
        //Ankara
        normalillos[59].SetActive(true);
        //Guatemala
        normalillos[60].SetActive(true);
        //Asunción
        normalillos[61].SetActive(true);
        //Berlín
        normalillos[62].SetActive(true);
        //Manila
        normalillos[63].SetActive(true);
        //Oslo
        normalillos[64].SetActive(true);
        //Sofia
        normalillos[65].SetActive(true);
        //Berna
        normalillos[66].SetActive(true);
        //Tokio
        normalillos[67].SetActive(true);
        //Santiago
        normalillos[68].SetActive(true);
        //Praga
        normalillos[69].SetActive(true);
        //Viena
        normalillos[70].SetActive(true);
        //Nueva Delhi
        normalillos[71].SetActive(true);
        //Zurich
        normalillos[72].SetActive(true);
        //Washington
        normalillos[73].SetActive(true);
   

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

                //UNIDAD 1 TORRES DEMET
                if (hit.transform.name == "Estambul")
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
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);
                        //Si le damos touch al edificio Moscú
                        //nos activara el edificio Moscú azul.
                        azulitos[3].SetActive(true);
                        normalillos[41].tag = tagNew;
                        //normalillos[0].tag = "prueba";
                        recolector = normalillos[41];
                        recolector.SetActive(false);

                    }

                    //EDIFICIO AZUL ACTIVADO EN ESCENA :D
                    //*************************************
                    //Si hay un edificio azul activado en la escena 
                    //entonces ejecuta el código 
                    if (edificio_blue == true)
                    {
                        edificio_blue.SetActive(false);
                        recolector.tag = tagNameNormal;
                        recolector.SetActive(true);
                        recolector = null;

                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código de adentro

                        //Esto es para que ahora pueda gu
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul Moscú
                            azulitos[3].SetActive(true);
                            normalillos[41].SetActive(false);
                            normalillos[41].tag = tagNew;
                            recolector = normalillos[41];
                            recolector.SetActive(false);
                            //Se desactiva el edificio azul que estaba en la escena
                            //Se activa el edificio normal que fue desactivado
                            //como le cambiamos el tag para poder desactivarlo le tendremos
                            //que regresa el tag que tenía al principio
                        }
                    }
                }

                if (hit.transform.name == "Estambul_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    //moscú_normal.SetActive(true);
                    azulitos[3].SetActive(false);
                    normalillos[41].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }





                //*********************************************************************************************************************
                //*********************************************************************************************************************
                //*********************************************************************************************************************


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
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);
                        //Si le damos touch al edificio Moscú
                        //nos activara el edificio Moscú azul.
                        azulitos[57].SetActive(true);
                        normalillos[16].tag = tagNew;
                        recolector = normalillos[16];
                        recolector.SetActive(false);
                    }

                    //EDIFICIO AZUL ACTIVADO EN ESCENA :D
                    //*************************************
                    //Si hay un edificio azul activado en la escena 
                    //entonces ejecuta el código 
                    if (edificio_blue == true)
                    {
                        edificio_blue.SetActive(false);
                        recolector.tag = tagNameNormal;
                        recolector.SetActive(true);
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código de adentro

                        //Esto es para que ahora pueda gu
                        if (recolector == null)
                        {

                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul Moscú
                            azulitos[57].SetActive(true);
                            normalillos[16].SetActive(false);
                            normalillos[16].tag = tagNew;
                            recolector = normalillos[16];
                            recolector.SetActive(false);
                            //Se desactiva el edificio azul que estaba en la escena
                            //Se activa el edificio normal que fue desactivado
                            //como le cambiamos el tag para poder desactivarlo le tendremos
                            //que regresa el tag que tenía al principio
                        }
                    }
                }

                if (hit.transform.name == "Moscú_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    //moscú_normal.SetActive(true);
                    azulitos[57].SetActive(false);
                    normalillos[16].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;

                }





                //*********************************************************************************************************
                //*********************************************************************************************************
                //*********************************************************************************************************


                //ESTE COMPORTAMIENTO ES PARA EL EDIFICIO BERNA

                if (hit.transform.name == "Berna")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Berna
                        azulitos[24].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[66].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Berna 
                        recolector = normalillos[66];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[24].SetActive(true);
                            normalillos[66].SetActive(false);
                            normalillos[66].tag = tagNew;
                            recolector = normalillos[66];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Berna_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[24].SetActive(false);
                    normalillos[66].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;


                }





                //**************************************************************************************************************
                //**************************************************************************************************************
                //**************************************************************************************************************


                if (hit.transform.name == "Atenas")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Berna
                        azulitos[30].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[36].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Berna 
                        recolector = normalillos[36];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[30].SetActive(true);
                            normalillos[36].SetActive(false);
                            normalillos[36].tag = tagNew;
                            recolector = normalillos[36];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Atenas_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[30].SetActive(false);
                    normalillos[36].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO ARGEL 

                if (hit.transform.name == "Argel")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[68].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[53].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Argel 
                        recolector = normalillos[53];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[68].SetActive(true);
                            normalillos[53].SetActive(false);
                            normalillos[53].tag = tagNew;
                            recolector = normalillos[53];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Argel_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[68].SetActive(false);
                    normalillos[53].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO OSLO 

                if (hit.transform.name == "Oslo")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[53].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[64].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Oslo 
                        recolector = normalillos[64];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[53].SetActive(true);
                            normalillos[64].SetActive(false);
                            normalillos[64].tag = tagNew;
                            recolector = normalillos[64];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Oslo_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[53].SetActive(false);
                    normalillos[64].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BULGARIA 

                if (hit.transform.name == "Bulgaria")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[55].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[18].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Bulgaria 
                        recolector = normalillos[18];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[55].SetActive(true);
                            normalillos[18].SetActive(false);
                            normalillos[18].tag = tagNew;
                            recolector = normalillos[18];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Bulgaria_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[55].SetActive(false);
                    normalillos[18].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BELGRADO 

                if (hit.transform.name == "Belgrado")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[40].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[47].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Belgrado 
                        recolector = normalillos[47];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[40].SetActive(true);
                            normalillos[47].SetActive(false);
                            normalillos[47].tag = tagNew;
                            recolector = normalillos[47];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Belgrado_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[40].SetActive(false);
                    normalillos[47].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SEÚL 

                if (hit.transform.name == "Seúl")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[69].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[56].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Belgrado 
                        recolector = normalillos[56];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[69].SetActive(true);
                            normalillos[56].SetActive(false);
                            normalillos[56].tag = tagNew;
                            recolector = normalillos[56];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Seúl_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[69].SetActive(false);
                    normalillos[56].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO DAMASCO 

                if (hit.transform.name == "Damasco")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[47].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[14].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Belgrado 
                        recolector = normalillos[14];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[47].SetActive(true);
                            normalillos[14].SetActive(false);
                            normalillos[14].tag = tagNew;
                            recolector = normalillos[14];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Damasco_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[47].SetActive(false);
                    normalillos[14].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO VARSOVIA 

                if (hit.transform.name == "Varsovia")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[20].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[19].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Belgrado 
                        recolector = normalillos[19];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[20].SetActive(true);
                            normalillos[19].SetActive(false);
                            normalillos[19].tag = tagNew;
                            recolector = normalillos[19];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Varsovia_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[20].SetActive(false);
                    normalillos[19].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO ESTOCOLMO 

                if (hit.transform.name == "Estocolmo")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[27].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[2].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Belgrado 
                        recolector = normalillos[2];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[27].SetActive(true);
                            normalillos[2].SetActive(false);
                            normalillos[2].tag = tagNew;
                            recolector = normalillos[2];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Estocolmo_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[27].SetActive(false);
                    normalillos[2].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }







                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO PARÍS 

                if (hit.transform.name == "París")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[56].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[10].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal París 
                        recolector = normalillos[10];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[56].SetActive(true);
                            normalillos[10].SetActive(false);
                            normalillos[10].tag = tagNew;
                            recolector = normalillos[10];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "París_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[56].SetActive(false);
                    normalillos[10].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO MADRID 

                if (hit.transform.name == "Madrid")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[50].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[6].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Madrid 
                        recolector = normalillos[6];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[50].SetActive(true);
                            normalillos[6].SetActive(false);
                            normalillos[6].tag = tagNew;
                            recolector = normalillos[6];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Madrid_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[50].SetActive(false);
                    normalillos[6].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO LISBOA 

                if (hit.transform.name == "Lisboa")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[16].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[15].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Lisboa 
                        recolector = normalillos[15];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[16].SetActive(true);
                            normalillos[15].SetActive(false);
                            normalillos[15].tag = tagNew;
                            recolector = normalillos[15];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Lisboa_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[16].SetActive(false);
                    normalillos[15].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO ROMA 

                if (hit.transform.name == "Roma")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[35].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[24].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Roma 
                        recolector = normalillos[24];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[35].SetActive(true);
                            normalillos[24].SetActive(false);
                            normalillos[24].tag = tagNew;
                            recolector = normalillos[24];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Roma_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[35].SetActive(false);
                    normalillos[24].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BRUSELAS 

                if (hit.transform.name == "Bruselas")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[49].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[25].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Bruselas 
                        recolector = normalillos[25];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[49].SetActive(true);
                            normalillos[25].SetActive(false);
                            normalillos[25].tag = tagNew;
                            recolector = normalillos[25];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Bruselas_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[49].SetActive(false);
                    normalillos[25].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO LONDRES 

                if (hit.transform.name == "Londres")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[39].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[42].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Londres 
                        recolector = normalillos[42];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[39].SetActive(true);
                            normalillos[42].SetActive(false);
                            normalillos[42].tag = tagNew;
                            recolector = normalillos[42];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Londres_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[39].SetActive(false);
                    normalillos[42].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO ZURICH 

                if (hit.transform.name == "Zurich")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[70].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[72].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Zurich 
                        recolector = normalillos[72];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[70].SetActive(true);
                            normalillos[72].SetActive(false);
                            normalillos[72].tag = tagNew;
                            recolector = normalillos[72];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Zurich_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[70].SetActive(false);
                    normalillos[72].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BERLÍN 

                if (hit.transform.name == "Berlín")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[61].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[62].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Berlín 
                        recolector = normalillos[62];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[61].SetActive(true);
                            normalillos[62].SetActive(false);
                            normalillos[62].tag = tagNew;
                            recolector = normalillos[62];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Berlín_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[61].SetActive(false);
                    normalillos[62].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO VIENA 

                if (hit.transform.name == "Viena")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[13].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[70].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Viena 
                        recolector = normalillos[70];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[13].SetActive(true);
                            normalillos[70].SetActive(false);
                            normalillos[70].tag = tagNew;
                            recolector = normalillos[70];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Viena_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[13].SetActive(false);
                    normalillos[70].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO PRAGA 

                if (hit.transform.name == "Praga")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[29].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[69].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Praga 
                        recolector = normalillos[69];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[29].SetActive(true);
                            normalillos[69].SetActive(false);
                            normalillos[69].tag = tagNew;
                            recolector = normalillos[69];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Praga_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[29].SetActive(false);
                    normalillos[69].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO YAKARTA 

                if (hit.transform.name == "Yakarta")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[38].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[21].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Yakarta 
                        recolector = normalillos[21];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[38].SetActive(true);
                            normalillos[21].SetActive(false);
                            normalillos[21].tag = tagNew;
                            recolector = normalillos[21];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Yakarta_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[38].SetActive(false);
                    normalillos[21].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO MONACO 

                if (hit.transform.name == "Monaco")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[25].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[29].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Monaco 
                        recolector = normalillos[29];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[25].SetActive(true);
                            normalillos[29].SetActive(false);
                            normalillos[29].tag = tagNew;
                            recolector = normalillos[29];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Monaco_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[25].SetActive(false);
                    normalillos[29].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO MANILA 

                if (hit.transform.name == "Manila")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[73].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[63].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Manila 
                        recolector = normalillos[63];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[73].SetActive(true);
                            normalillos[63].SetActive(false);
                            normalillos[63].tag = tagNew;
                            recolector = normalillos[63];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Manila_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[73].SetActive(false);
                    normalillos[63].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO NUEVA DELHI 

                if (hit.transform.name == "Nueva Delhi")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[1].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[71].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Nueva Delhi 
                        recolector = normalillos[71];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[1].SetActive(true);
                            normalillos[71].SetActive(false);
                            normalillos[71].tag = tagNew;
                            recolector = normalillos[71];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Nueva Delhi_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[1].SetActive(false);
                    normalillos[71].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO MÉXICO 

                if (hit.transform.name == "México")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[19].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[20].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal México 
                        recolector = normalillos[20];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[19].SetActive(true);
                            normalillos[20].SetActive(false);
                            normalillos[20].tag = tagNew;
                            recolector = normalillos[20];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "México_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[19].SetActive(false);
                    normalillos[20].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO TEHERÁN

                if (hit.transform.name == "Teherán")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[59].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[40].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Teherán 
                        recolector = normalillos[40];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[59].SetActive(true);
                            normalillos[40].SetActive(false);
                            normalillos[40].tag = tagNew;
                            recolector = normalillos[40];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Teherán_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[59].SetActive(false);
                    normalillos[40].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BOMBAY

                if (hit.transform.name == "Bombay")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[45].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[11].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Bombay 
                        recolector = normalillos[11];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[45].SetActive(true);
                            normalillos[11].SetActive(false);
                            normalillos[11].tag = tagNew;
                            recolector = normalillos[11];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Bombay_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[45].SetActive(false);
                    normalillos[11].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO PEKIN

                if (hit.transform.name == "Pekin")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[2].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[0].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Pekin 
                        recolector = normalillos[0];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[2].SetActive(true);
                            normalillos[0].SetActive(false);
                            normalillos[0].tag = tagNew;
                            recolector = normalillos[0];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Pekin_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[2].SetActive(false);
                    normalillos[0].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BUCAREST

                if (hit.transform.name == "Bucarest")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[15].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[13].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Bucarest 
                        recolector = normalillos[13];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[15].SetActive(true);
                            normalillos[13].SetActive(false);
                            normalillos[13].tag = tagNew;
                            recolector = normalillos[13];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Bucarest_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[15].SetActive(false);
                    normalillos[13].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO COPENNAGUE

                if (hit.transform.name == "Copennague")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[5].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[4].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Copennague 
                        recolector = normalillos[4];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[5].SetActive(true);
                            normalillos[4].SetActive(false);
                            normalillos[4].tag = tagNew;
                            recolector = normalillos[4];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Copennague_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[5].SetActive(false);
                    normalillos[4].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO AMSTERDAM

                if (hit.transform.name == "Amsterdam")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[7].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[12].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Amsterdam 
                        recolector = normalillos[12];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[7].SetActive(true);
                            normalillos[12].SetActive(false);
                            normalillos[12].tag = tagNew;
                            recolector = normalillos[12];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Amsterdam_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[7].SetActive(false);
                    normalillos[12].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SAIGON

                if (hit.transform.name == "Saigon")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[71].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[17].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Saigon 
                        recolector = normalillos[17];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[71].SetActive(true);
                            normalillos[17].SetActive(false);
                            normalillos[17].tag = tagNew;
                            recolector = normalillos[17];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Saigon_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[71].SetActive(false);
                    normalillos[17].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO TAIPEI

                if (hit.transform.name == "Taipei")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[54].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[31].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Teipei 
                        recolector = normalillos[31];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[54].SetActive(true);
                            normalillos[31].SetActive(false);
                            normalillos[31].tag = tagNew;
                            recolector = normalillos[31];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Taipei_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[54].SetActive(false);
                    normalillos[31].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO TOKIO

                if (hit.transform.name == "Tokio")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[18].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[67].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Tokio 
                        recolector = normalillos[67];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[18].SetActive(true);
                            normalillos[67].SetActive(false);
                            normalillos[67].tag = tagNew;
                            recolector = normalillos[67];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Tokio_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[18].SetActive(false);
                    normalillos[67].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SAN JUAN

                if (hit.transform.name == "San Juan")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[44].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[34].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal San Juan 
                        recolector = normalillos[34];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[44].SetActive(true);
                            normalillos[34].SetActive(false);
                            normalillos[34].tag = tagNew;
                            recolector = normalillos[34];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "San Juan_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[44].SetActive(false);
                    normalillos[34].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO KINGSTON

                if (hit.transform.name == "Kingston")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[48].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[57].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Kingston 
                        recolector = normalillos[57];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[48].SetActive(true);
                            normalillos[57].SetActive(false);
                            normalillos[57].tag = tagNew;
                            recolector = normalillos[57];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Kingston_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[48].SetActive(false);
                    normalillos[57].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO HABANA

                if (hit.transform.name == "Habana")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[14].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[52].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Habana 
                        recolector = normalillos[52];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[14].SetActive(true);
                            normalillos[52].SetActive(false);
                            normalillos[52].tag = tagNew;
                            recolector = normalillos[52];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Habana_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[14].SetActive(false);
                    normalillos[52].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SAN JOSÉ

                if (hit.transform.name == "San José")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[58].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[39].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal San José 
                        recolector = normalillos[39];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[58].SetActive(true);
                            normalillos[39].SetActive(false);
                            normalillos[39].tag = tagNew;
                            recolector = normalillos[39];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "San José_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[58].SetActive(false);
                    normalillos[39].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO PANAMÁ

                if (hit.transform.name == "Panamá")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[51].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[33].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Panamá 
                        recolector = normalillos[33];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[51].SetActive(true);
                            normalillos[33].SetActive(false);
                            normalillos[33].tag = tagNew;
                            recolector = normalillos[33];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Panamá_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[51].SetActive(false);
                    normalillos[33].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO MANAGUA

                if (hit.transform.name == "Managua")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[31].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[7].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Managua 
                        recolector = normalillos[7];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[31].SetActive(true);
                            normalillos[7].SetActive(false);
                            normalillos[7].tag = tagNew;
                            recolector = normalillos[7];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Managua_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[31].SetActive(false);
                    normalillos[7].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }




                //*******************************************************************************************************
                //UNIDAD 2 TORRES DEMET

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO TEGUCIGALPA

                if (hit.transform.name == "Tegucigalpa")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[34].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[1].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Tegucigalpa 
                        recolector = normalillos[1];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[34].SetActive(true);
                            normalillos[1].SetActive(false);
                            normalillos[1].tag = tagNew;
                            recolector = normalillos[1];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Tegucigalpa_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[34].SetActive(false);
                    normalillos[1].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO NUEVA YORK

                if (hit.transform.name == "Nueva York")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[42].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[49].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Nueva York 
                        recolector = normalillos[49];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[42].SetActive(true);
                            normalillos[49].SetActive(false);
                            normalillos[49].tag = tagNew;
                            recolector = normalillos[49];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Nueva York_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[42].SetActive(false);
                    normalillos[49].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BUENOS AIRES

                if (hit.transform.name == "Buenos Aires")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[28].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[35].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Buenos Aires 
                        recolector = normalillos[35];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[28].SetActive(true);
                            normalillos[35].SetActive(false);
                            normalillos[35].tag = tagNew;
                            recolector = normalillos[35];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Buenos Aires_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[28].SetActive(false);
                    normalillos[35].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO OTAWA

                if (hit.transform.name == "Otawa")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[8].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[51].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Otawa 
                        recolector = normalillos[51];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[8].SetActive(true);
                            normalillos[51].SetActive(false);
                            normalillos[51].tag = tagNew;
                            recolector = normalillos[51];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Otawa_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[8].SetActive(false);
                    normalillos[51].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO EL CAIRO

                if (hit.transform.name == "El Cairo")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[64].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[54].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal El Cairo 
                        recolector = normalillos[54];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[64].SetActive(true);
                            normalillos[54].SetActive(false);
                            normalillos[54].tag = tagNew;
                            recolector = normalillos[54];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "El Cairo_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[64].SetActive(false);
                    normalillos[54].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO TORONTO

                if (hit.transform.name == "Toronto")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[63].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[5].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Toronto 
                        recolector = normalillos[5];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[63].SetActive(true);
                            normalillos[5].SetActive(false);
                            normalillos[5].tag = tagNew;
                            recolector = normalillos[5];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Toronto_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[63].SetActive(false);
                    normalillos[5].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO TORONTO

                if (hit.transform.name == "Toronto")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[63].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[5].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Toronto 
                        recolector = normalillos[5];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[63].SetActive(true);
                            normalillos[5].SetActive(false);
                            normalillos[5].tag = tagNew;
                            recolector = normalillos[5];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Toronto_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[63].SetActive(false);
                    normalillos[5].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO TRIPOLI

                if (hit.transform.name == "Tripoli")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[17].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[32].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Tripoli 
                        recolector = normalillos[32];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[17].SetActive(true);
                            normalillos[32].SetActive(false);
                            normalillos[32].tag = tagNew;
                            recolector = normalillos[32];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Tripoli_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[17].SetActive(false);
                    normalillos[32].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO MONTEVIDEO

                if (hit.transform.name == "MonteVideo")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[46].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[9].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal MonteVideo 
                        recolector = normalillos[9];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[46].SetActive(true);
                            normalillos[9].SetActive(false);
                            normalillos[9].tag = tagNew;
                            recolector = normalillos[9];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "MonteVideo_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[46].SetActive(false);
                    normalillos[9].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO LUANDA

                if (hit.transform.name == "Luanda")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[60].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[22].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Luanda 
                        recolector = normalillos[22];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[60].SetActive(true);
                            normalillos[22].SetActive(false);
                            normalillos[22].tag = tagNew;
                            recolector = normalillos[22];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Luanda_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[60].SetActive(false);
                    normalillos[22].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SANTIAGO

                if (hit.transform.name == "Santiago")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[67].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[68].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Santiago 
                        recolector = normalillos[68];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[67].SetActive(true);
                            normalillos[68].SetActive(false);
                            normalillos[68].tag = tagNew;
                            recolector = normalillos[68];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Santiago_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[67].SetActive(false);
                    normalillos[68].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO ASUNCIÓN

                if (hit.transform.name == "Asunción")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[36].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[61].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Asunción 
                        recolector = normalillos[61];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[36].SetActive(true);
                            normalillos[61].SetActive(false);
                            normalillos[61].tag = tagNew;
                            recolector = normalillos[61];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Asunción_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[36].SetActive(false);
                    normalillos[61].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SAN SALVADOR

                if (hit.transform.name == "San Salvador")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[12].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[27].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal San Salvador 
                        recolector = normalillos[27];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[12].SetActive(true);
                            normalillos[27].SetActive(false);
                            normalillos[27].tag = tagNew;
                            recolector = normalillos[27];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "San Salvador_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[12].SetActive(false);
                    normalillos[27].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BOGOTÁ

                if (hit.transform.name == "Bogotá")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[52].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[58].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Bogotá 
                        recolector = normalillos[58];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[52].SetActive(true);
                            normalillos[58].SetActive(false);
                            normalillos[58].tag = tagNew;
                            recolector = normalillos[58];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Bogotá_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[52].SetActive(false);
                    normalillos[58].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO CARACAS

                if (hit.transform.name == "Caracas")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[66].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[38].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Caracas 
                        recolector = normalillos[38];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[66].SetActive(true);
                            normalillos[38].SetActive(false);
                            normalillos[38].tag = tagNew;
                            recolector = normalillos[38];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Caracas_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[66].SetActive(false);
                    normalillos[38].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SANTO DOMINGO

                if (hit.transform.name == "Santo Domingo")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[11].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[8].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Santo Domingo 
                        recolector = normalillos[8];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[11].SetActive(true);
                            normalillos[8].SetActive(false);
                            normalillos[8].tag = tagNew;
                            recolector = normalillos[8];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Santo Domingo_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[11].SetActive(false);
                    normalillos[8].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO QUITO

                if (hit.transform.name == "Quito")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[32].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[46].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Quito 
                        recolector = normalillos[46];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[32].SetActive(true);
                            normalillos[46].SetActive(false);
                            normalillos[46].tag = tagNew;
                            recolector = normalillos[46];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Quito_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[32].SetActive(false);
                    normalillos[46].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO MINESOTA

                if (hit.transform.name == "Minesota")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[65].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[48].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Quito 
                        recolector = normalillos[48];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[65].SetActive(true);
                            normalillos[48].SetActive(false);
                            normalillos[48].tag = tagNew;
                            recolector = normalillos[48];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Minesota_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[65].SetActive(false);
                    normalillos[48].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SIRIA

                if (hit.transform.name == "Siria")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[0].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[3].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Siria 
                        recolector = normalillos[3];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[0].SetActive(true);
                            normalillos[3].SetActive(false);
                            normalillos[3].tag = tagNew;
                            recolector = normalillos[3];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Siria_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[0].SetActive(false);
                    normalillos[3].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SOFIA

                if (hit.transform.name == "Sofia")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[43].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[65].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Sofia 
                        recolector = normalillos[65];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[43].SetActive(true);
                            normalillos[65].SetActive(false);
                            normalillos[65].tag = tagNew;
                            recolector = normalillos[65];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Sofia_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[43].SetActive(false);
                    normalillos[65].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO EL CABO

                if (hit.transform.name == "El Cabo")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[21].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[45].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal El Cabo 
                        recolector = normalillos[45];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[21].SetActive(true);
                            normalillos[45].SetActive(false);
                            normalillos[45].tag = tagNew;
                            recolector = normalillos[45];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "El Cabo_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[21].SetActive(false);
                    normalillos[45].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO ANKARA

                if (hit.transform.name == "Ankara")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[33].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[59].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Ankara 
                        recolector = normalillos[59];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[33].SetActive(true);
                            normalillos[59].SetActive(false);
                            normalillos[59].tag = tagNew;
                            recolector = normalillos[59];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Ankara_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[33].SetActive(false);
                    normalillos[59].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO TÚNEZ

                if (hit.transform.name == "Túnez")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[6].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[28].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Túnez 
                        recolector = normalillos[28];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[6].SetActive(true);
                            normalillos[28].SetActive(false);
                            normalillos[28].tag = tagNew;
                            recolector = normalillos[28];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Túnez_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[6].SetActive(false);
                    normalillos[28].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO SINGAPUR

                if (hit.transform.name == "Singapur")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[9].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[50].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Singapur 
                        recolector = normalillos[50];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[9].SetActive(true);
                            normalillos[50].SetActive(false);
                            normalillos[50].tag = tagNew;
                            recolector = normalillos[50];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Singapur_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[9].SetActive(false);
                    normalillos[50].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO ESLOVAQUIA

                if (hit.transform.name == "Eslovaquia")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[72].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[30].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Eslovaquia 
                        recolector = normalillos[30];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[72].SetActive(true);
                            normalillos[30].SetActive(false);
                            normalillos[30].tag = tagNew;
                            recolector = normalillos[30];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Eslovaquia_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[72].SetActive(false);
                    normalillos[30].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }

                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO HONOLULU

                if (hit.transform.name == "Honolulu")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[41].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[43].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Honolulu
                        recolector = normalillos[43];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[41].SetActive(true);
                            normalillos[43].SetActive(false);
                            normalillos[43].tag = tagNew;
                            recolector = normalillos[43];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Honolulu_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[41].SetActive(false);
                    normalillos[43].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO CANBERRA

                if (hit.transform.name == "Canberra")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[37].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[44].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Canberra
                        recolector = normalillos[44];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[37].SetActive(true);
                            normalillos[44].SetActive(false);
                            normalillos[44].tag = tagNew;
                            recolector = normalillos[44];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Canberra_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[37].SetActive(false);
                    normalillos[44].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO BRASILIA

                if (hit.transform.name == "Brasilia")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[26].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[37].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Brasilia
                        recolector = normalillos[37];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[26].SetActive(true);
                            normalillos[37].SetActive(false);
                            normalillos[37].tag = tagNew;
                            recolector = normalillos[37];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Brasilia_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[26].SetActive(false);
                    normalillos[37].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO YOKOHAMA

                if (hit.transform.name == "Yokohama")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[22].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[55].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Yokohama
                        recolector = normalillos[55];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[22].SetActive(true);
                            normalillos[55].SetActive(false);
                            normalillos[55].tag = tagNew;
                            recolector = normalillos[55];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Yokohama_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[22].SetActive(false);
                    normalillos[55].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }



                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO GUATEMALA

                if (hit.transform.name == "Guatemala")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[4].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[60].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Guatemala
                        recolector = normalillos[60];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[4].SetActive(true);
                            normalillos[60].SetActive(false);
                            normalillos[60].tag = tagNew;
                            recolector = normalillos[60];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Guatemala_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[4].SetActive(false);
                    normalillos[60].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO WASHINGTON

                if (hit.transform.name == "Washington")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[23].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[73].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Washington
                        recolector = normalillos[73];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[23].SetActive(true);
                            normalillos[73].SetActive(false);
                            normalillos[73].tag = tagNew;
                            recolector = normalillos[73];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Washington_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[23].SetActive(false);
                    normalillos[73].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO DACCA

                if (hit.transform.name == "Dacca")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[10].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[26].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Dacca
                        recolector = normalillos[26];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[10].SetActive(true);
                            normalillos[26].SetActive(false);
                            normalillos[26].tag = tagNew;
                            recolector = normalillos[26];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Dacca_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[10].SetActive(false);
                    normalillos[26].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }


                //*******************************************************************************************************
                //*******************************************************************************************************
                //*******************************************************************************************************

                //EDIFICIO HAMBURGO

                if (hit.transform.name == "Hamburgo")
                {

                    edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);


                    //Comportamiento para cuando no hay un edificio azul en escena
                    //Comportamiento para cuando no hay un edificio seleccionado 
                    if (edificio_blue == false)
                    {
                        //Comentario que imprime en consola que edificio hemos seleccionado
                        Debug.Log("Seleccionaste" + " " + hit.transform.name);

                        //Se activa el edificio azul Argel
                        azulitos[62].SetActive(true);
                        //Al edificio normal se le cambiara el tag 
                        //esto debe hacerse ya que lo tendremos que activar de nuevo 
                        //y en escena hay diferentes gameobjects con el tag que tenía antes
                        //es por eso que debemos cambiarlo cuando se desactive
                        normalillos[23].tag = tagNew;
                        //madrinita es el game object que almacenará a nuestro edificio normal Hamburgo
                        recolector = normalillos[23];
                        //el gameobject se desactiva
                        //ahora tiene un tag diferente al de los edificios normales
                        recolector.SetActive(false);
                    }

                    //Comportamiento para cuando hay un edificio azul en escena 
                    //Comportamiento para cuando hay un edificio seleccionado
                    if (edificio_blue == true)
                    {
                        //mandamos desactivar el edificio azul que esta en la escena
                        edificio_blue.SetActive(false);
                        //Se vuelve a cambiar el tag del edificio normal que fue desactivado 
                        recolector.tag = tagNameNormal;
                        //Se activa el game object que almacena nuestro edificio normal que fue desactivado
                        recolector.SetActive(true);
                        //Para que podamos sacar ese edificio del game object madrinita se deberá igualar a null
                        //Esto quiere decir que toda la variable madrinita regresa a sus valores por default 
                        recolector = null;


                        //Este if() nos ayudará a que una vez que el RECOLECTOR 
                        //este en null o vació, se ejecute el código
                        if (recolector == null)
                        {
                            Debug.Log("Recolector esta en Null");
                            //Este comentario nos muestra el nombre del edificio que seleccionamos
                            Debug.Log("Seleccionaste" + " " + hit.transform.name);
                            //Se activa el edificio azul
                            azulitos[62].SetActive(true);
                            normalillos[23].SetActive(false);
                            normalillos[23].tag = tagNew;
                            recolector = normalillos[23];
                            recolector.SetActive(false);
                        }
                    }
                }

                //Comportamiento que se ejecuta cuando damos click por segunda vez
                //cuando deseleccionamos nuestro edificio básicamente 
                if (hit.transform.name == "Hamburgo_blue")
                {
                    Debug.Log("Deseleccionaste" + " " + hit.transform.name);
                    azulitos[62].SetActive(false);
                    normalillos[23].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                }









            }
        }
    }
}

