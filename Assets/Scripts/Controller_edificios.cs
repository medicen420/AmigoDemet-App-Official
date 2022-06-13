using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller_edificios : MonoBehaviour
{

    //**********************************************************************************
    //Nuestra variable TapCount nos ayudará a contar los touch que se han dado 
    [SerializeField] int TapCount;
    //Arrays que guardaran todos los edificios de mi escena
    //Hay 2 tipos: Los normales y los Azules
    public GameObject[] azulitos;
    public GameObject[] normalillos;

    //Variables de tipo string que contienen el nombre de algunas etiquetas
    //que existen en mi inspector
    string tagNameBlue = "edificio_blue";
    string tagNameNormal = "edificio_normal";
    string tagNew = "prueba";

    [SerializeField] float Timewait;


    

   
 

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
    GameObject edificio_supernewtag;

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
        //TapCount tiene que estar en 0 al principio ya que no se ha dado ningun touch hasta este punto
        TapCount = 0;

        Timewait = 0f;

        


        //newValue = 0;
        //Variable booleana es false al inicio

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
        edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);



        //Estas líneas de código nos permiten detectar un touch sobre un objeto dentro de la escena
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                //*************************************************************************************
                //EDIFICIO ESTAMBUL
                if (hit.transform.name == "Estambul")
                {
                    TapCount++;
                    //print("<color=green> Has dado" + " " + TapCount + " " + "touch </color>");
                    if (TapCount == 1)
                    {
                        Debug.Log("Has dado 1 touch");
                        StartCoroutine("OneTouchError");
                        

                    }
                    else if (TapCount == 2)
                    {
                        StopCoroutine("OneTouchError");
                        Debug.Log("Has dado 2 touch");
                        TapCount = 0;
                        Debug.Log("Ahora TapCount vale:" + " " + TapCount);

                        //CONDICIONAL IF PARA SELECCIONAR EDIFICIO
                        //NINGUN EDIFICIO SELECCIONADO
                        if (edificio_blue == false)
                        {
                            Debug.Log("No hay edificio blue");
                            azulitos[3].SetActive(true);
                            normalillos[41].tag = tagNew;
                            recolector = normalillos[41];
                            recolector.SetActive(false);

                            Debug.Log("Ahora TapCount es: " + " " + TapCount);
      

                        }

                        //CONDICIONAL IF PARA DESELECCIONAR UN EDIFICIO 
                        //HAY UN EDIFICIO SELECCIONADO
                        if (edificio_blue == true)
                        {
                            edificio_blue.SetActive(false);
                            recolector.tag = tagNameNormal;
                            recolector.SetActive(true);
                            recolector = null;

                            if (recolector == null)
                            {
                                azulitos[3].SetActive(true);
                                normalillos[41].SetActive(false);
                                normalillos[41].tag = tagNew;
                                recolector = normalillos[41];
                                recolector.SetActive(false);
                            }

                        }

                    }

                }

                //CONDICIONAL IF PARA DESACTIVAR EDIFICIO SELECCIONADO
                if (hit.transform.name == "Estambul_blue")
                {
                    

                    TapCount++;
                    if(TapCount == 1)
                    {
                        Debug.Log("Deseleccionaste el edificio");
                        azulitos[3].SetActive(false);
                        normalillos[41].tag = tagNameNormal;
                        recolector.SetActive(true);
                        recolector = null;
                        TapCount = 0;

                    }
                }
                //*******************************************************************************





                //*********************************************************************************
                //EDIFICIO MOSCÚ
                if(hit.transform.name == "Moscú")
                {
                    TapCount++;
                    if (TapCount == 1)
                    {
                        Debug.Log("Has dado 1 touch");
                        StartCoroutine("OneTouchError");


                    }
                    else if (TapCount == 2)
                    {
                        StopCoroutine("OneTouchError");
                        Debug.Log("Has dado 2 touch");
                        TapCount = 0;
                        Debug.Log("Ahora TapCount vale:" + " " + TapCount);

                        if (edificio_blue == false)
                        {
                            //Si le damos touch al edificio Moscú
                            //nos activara el edificio Moscú azul.
                            azulitos[57].SetActive(true);
                            normalillos[16].tag = tagNew;
                            recolector = normalillos[16];
                            recolector.SetActive(false);
                            Debug.Log("Ahora TapCount es: " + " " + TapCount);
                        }


                        if (edificio_blue == true)
                        {
                            edificio_blue.SetActive(false);
                            recolector.tag = tagNameNormal;
                            recolector.tag = tagNameNormal;
                            recolector.SetActive(true);
                            recolector = null;

                            if (recolector == null)
                            {

                                azulitos[57].SetActive(true);
                                normalillos[16].SetActive(false);
                                recolector = normalillos[16];
                                recolector.SetActive(false);

                            }

                        }

                    }

                }
                if(hit.transform.name == "Moscú_blue")
                {
                    print("<color=cyan>  Has seleccionado el edificio" + " " + hit.transform.name + " " + "</color>");
                    azulitos[57].SetActive(false);
                    normalillos[16].tag = tagNameNormal;
                    recolector.SetActive(true);
                    recolector = null;
                    TapCount = 0;
                }

            }
        }

    }

    private IEnumerator OneTouchError()
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Desactivando touch accidental");
        Timewait = 0.5f;

        if (Timewait == 0.5f)
        {
            TapCount = 0;
            print("<color=blue> TapCount vale:" + " " + TapCount + "</color>");
        }

    }



    

 
  

    
}






