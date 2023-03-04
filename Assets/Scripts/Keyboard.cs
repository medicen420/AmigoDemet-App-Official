using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;


public class Keyboard : MonoBehaviour
{

    //--------------------------------------
    //ARRAYS EDIFICIOS 

    //AZULES
    public GameObject[] azulitos;
    //NORMALES
    public GameObject[] normalillos;
    //--------------------------------------

    

    //--------------------------------------
    //TAGS EDIFICIOS

    //AZULES
    string tagNameBlue = "edificio_blue";
    //NORMALES
    string tagNameNormal = "edificio_normal";
    //NUEVO TAG
    string tagNew = "prueba";
    //---------------------------------------


    //TEXTO EN LA SEARCH BAR
    public string Pseudo;
    public string Pseudo2 = " ";


    //TECLADO EN EL CELULAR
    public TouchScreenKeyboard clavier;



    //GAMEOBJECT QUE NOS AYUDARÁ A DETECTAR
    //SI HAY UN EDIFICIO ACTIVADO EN LA ESCENA
    GameObject edificio_blue;


    //RECOLECTOR QUE ALMACENA MI EDIFICIO NORMAL 
    //CON EL NUEVO TAG
    GameObject recolector;








    //UI
    //USER INTERFACE


    //SEARCH BAR
    //NUESTRA BARRA DE BÚSQUEDA
    public GameObject Inputfield;



    //PANEL WRONG NAME
    //EN CASO DE QUE EL USUARIO TIPE UN NOMBRE INEXISTENTE 
    //SE LE MOSTRARÁ UN PANEL INDICANDOLÉ AL USUARIO QUE NO EXISTE EL EDIFICIO
    public GameObject Wrong_Name_Pan;



    //BUTTONS PARA SEARCH BAR

    //BUTTON VERDE*
    //Button para abrir SearchBar
    public Button open;
    //Button declarado en GameObject para activar y desactivarlo
    public GameObject open_go;

    //BUTTON ROJO*
    //Button para cerrar SearchBar
    public Button close;
    //Button declarado en GameObject para activar y desactivarlo
    public GameObject close_go;

    //BUTTON AZUL*
    //Button para deseleccionar un edificio
    public Button deselect;
    //Button declarado en GameObject para activar y desactivarlo
    public GameObject deselect_go;


    //BUTTON PARA CERRAR PANEL WRONG TYPE NAME 


    //BUTTON AMARILLO*
    //Button para cerrar panel de wrong name
    //para cuando el usuario tipe un nombre inexistente
    public Button close_panel;
    //Button declarado en GameObject para activar y desactivarlo
    public GameObject close_panel_go;



    





    public void OpenKeyboard()
    {
        clavier = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }



   

    void Start()
    {
        //ARRAYS DE EDIFICIOS
        azulitos = GameObject.FindGameObjectsWithTag(tagNameBlue);
        normalillos = GameObject.FindGameObjectsWithTag(tagNameNormal);


        //UI
        //USER INTERFACE
        //BUTTONS


        //BUTTON PARA ABRIR SEARCHBAR
        open_go.SetActive(true);
        open.onClick.AddListener(OpenSearchBar);

        //BUTTON PARA CERRAR SEARCHBAR
        close_go.SetActive(false);
        close.onClick.AddListener(CloseSearchBar);

        //BUTTON PARA DESELECCIONAR MI EDIFICIO
        deselect_go.SetActive(false);


        //BUTTON PARA CERRAR PANEL DE WRONG NAME
        close_panel_go.SetActive(false);

        //INPUTFIELD APARECÉ DESACTIVADO AL PRINCIPIO
        Inputfield.SetActive(false);

        //PANEL WRONG NAME APARECÉ DESACTIVADO AL PRINCIPIO
        Wrong_Name_Pan.SetActive(false);



        //ARRAYS 

        //------------------------------------------
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




        //--------------------------------------------------
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

    }
    //-------------------------------------------
    //********************************************************


    //MÉTODOS PARA LOS BUTTONS UI


    //BUTTON VERDE
    //ABRIR MI SEARCH BAR
    public void OpenSearchBar()
    {
        
        //Mensaje en la consola
        print("<color=yellow> Has abierto la SearchBar </color>");


        //BUTTON VERDE SE DESACTIVA
        //Button para abrir SearchBar
        open_go.SetActive(false);


        //BUTTON ROJO SE ACTIVA
        //Button para cerrar SearchBar
        close_go.SetActive(true);


        //ACTIVAMOS LA SEARCHBAR
        Inputfield.SetActive(true);
        

    }


    //BUTTON ROJO
    //CERRAR MI SEARCH BAR
    public void CloseSearchBar()
    {
        //Mensaje en la consola
        print("<color=red> Has cerrado la SearchBar </color>");

        //BUTTON ROJO SE DESACTIVA
        close_go.SetActive(false);


        //BUTTON VERDE SE ACTIVA
        open_go.SetActive(true);


        //DESACTIVAMOS LA SEARCH BAR
        Inputfield.SetActive(false);

    }
    //***************************************************************



    void Update()
    {

        
        //CON AYUDA DE NUESTRA VARIABLE DE TIPO GAMEOBJECT
        //QUE DECLARAMOS EL PRINCIPIO, BUSCAREMOS SI HAY UN EDIFICIO AZUL EN ESCENA
        edificio_blue = GameObject.FindGameObjectWithTag(tagNameBlue);

        if (TouchScreenKeyboard.visible == false && clavier != null)
        {
            if (clavier.status == TouchScreenKeyboard.Status.Done)
            {

                Pseudo = clavier.text;
                //TEXTO QUE APARECE ARRIBA 
                //txt.text = "Aquí está " + Pseudo;
                //clavier = null;

            }
            //**********************************************************************************************************

            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESTAMBUL
            if ((Pseudo == "Estambul") || (Pseudo == "estambul") || (Pseudo == "Estambul ") || (Pseudo == "estambul ") ||
                (Pseudo == "ESTAMBUL") || (Pseudo == "ESTAMBUL "))
            {
                clavier.text = "";
                //TimeLine_Estambul.SetActive(true);
                Handheld.Vibrate();
                Estambul_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MOSCÚ
            if ((Pseudo == "Moscú") || (Pseudo == "moscú") || (Pseudo == "Moscu") || (Pseudo == "moscu") ||
                (Pseudo == "Moscú ") || (Pseudo == "moscú ") || (Pseudo == "Moscu ") || (Pseudo == "moscu ") ||
                (Pseudo == "MOSCÚ") || (Pseudo == "MOSCU") || (Pseudo == "MOSCÚ ") || (Pseudo == "MOSCU "))
            {
                
                clavier.text = "";
                Handheld.Vibrate();
                Moscú_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BERNA
            if ((Pseudo == "Berna") || (Pseudo == "berna") || (Pseudo == "Berna ") || (Pseudo == "berna ") ||
                (Pseudo == "BERNA") || (Pseudo == "BERNA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Berna_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ATENAS
            if ((Pseudo == "Atenas") || (Pseudo == "atenas") || (Pseudo == "Atenas ") || (Pseudo == "atenas ") ||
                (Pseudo == "ATENAS") || (Pseudo == "ATENAS "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Atenas_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ARGEL
            if ((Pseudo == "Argel") || (Pseudo == "argel") || (Pseudo == "Argel ") || (Pseudo == "argel ") ||
                (Pseudo == "ARGEL") || (Pseudo == "ARGEL "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Argel_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO OSLO
            if ((Pseudo == "Oslo") || (Pseudo == "oslo") || (Pseudo == "Oslo ") || (Pseudo == "oslo ") ||
                (Pseudo == "OSLO") || (Pseudo == "OSLO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Oslo_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BULGARIA
            if ((Pseudo == "Bulgaria") || (Pseudo == "bulgaria") || (Pseudo == "Bulgaria ") || (Pseudo == "bulgaria ") ||
                (Pseudo == "BULGARIA") || (Pseudo == "BULGARIA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Bulgaria_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BELGRADO
            if ((Pseudo == "Belgrado") || (Pseudo == "belgrado") || (Pseudo == "Belgrado ") || (Pseudo == "belgrado ") ||
                (Pseudo == "BELGRADO") || (Pseudo == "BELGRADO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Belgrado_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SEÚL
            if ((Pseudo == "Seúl") || (Pseudo == "seúl") || (Pseudo == "Seúl ") || (Pseudo == "seúl ") ||
                (Pseudo == "Seul") || (Pseudo == "seul") || (Pseudo == "Seul ") || (Pseudo == "seul ") ||
                (Pseudo == "SEÚL") || (Pseudo == "SEÚL ") || (Pseudo == "SEUL") || (Pseudo == "SEUL "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Seúl_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO DAMASCO
            if ((Pseudo == "Damasco") || (Pseudo == "damasco") || (Pseudo == "Damasco ") || (Pseudo == "damasco ") ||
                (Pseudo == "DAMASCO") || (Pseudo == "DAMASCO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Damasco_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO VARSOVIA
            if ((Pseudo == "Varsovia") || (Pseudo == "varsovia") || (Pseudo == "Varsovia ") || (Pseudo == "varsovia ") ||
                (Pseudo == "VARSOVIA") || (Pseudo == "VARSOVIA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Varsovia_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESTOCOLMO
            if ((Pseudo == "Estocolmo") || (Pseudo == "estocolmo") || (Pseudo == "Estocolmo ") || (Pseudo == "estocolmo ") ||
                (Pseudo == "ESTOCOLMO") || (Pseudo == "ESTOCOLMO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Estocolmo_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PARÍS
            if ((Pseudo == "París") || (Pseudo == "parís") || (Pseudo == "París ") || (Pseudo == "parís ") ||
                (Pseudo == "Paris") || (Pseudo == "paris") || (Pseudo == "Paris ") || (Pseudo == "paris ") ||
                (Pseudo == "PARÍS") || (Pseudo == "PARÍS ") || (Pseudo == "PARIS") || (Pseudo == "PARIS "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                París_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MADRID
            if ((Pseudo == "Madrid") || (Pseudo == "madrid") || (Pseudo == "Madrid ") || (Pseudo == "madrid ") ||
                (Pseudo == "MADRID") || (Pseudo == "MADRID "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Madrid_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LISBOA
            if ((Pseudo == "Lisboa") || (Pseudo == "lisboa") || (Pseudo == "Lisboa ") || (Pseudo == "lisboa ") ||
                (Pseudo == "LISBOA") || (Pseudo == "LISBOA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Lisboa_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ROMA
            if ((Pseudo == "Roma") || (Pseudo == "roma") || (Pseudo == "Roma ") || (Pseudo == "roma ") ||
                (Pseudo == "ROMA") || (Pseudo == "ROMA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Roma_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BRUSELAS
            if ((Pseudo == "Bruselas") || (Pseudo == "bruselas") || (Pseudo == "Bruselas ") || (Pseudo == "bruselas ") ||
                (Pseudo == "BRUSELAS") || (Pseudo == "BRUSELAS "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Bruselas_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LONDRES

            if ((Pseudo == "Londres") || (Pseudo == "londres") || (Pseudo == "Londres ") || (Pseudo == "londres ") ||
                (Pseudo == "LONDRES") || (Pseudo == "LONDRES "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Londres_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ZURICH

            if ((Pseudo == "Zurich") || (Pseudo == "zurich") || (Pseudo == "Zurich ") || (Pseudo == "zurich ") ||
                (Pseudo == "ZURICH") || (Pseudo == "ZURICH "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Zurich_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BERLÍN

            if ((Pseudo == "Berlín") || (Pseudo == "berlín") || (Pseudo == "Berlín ") || (Pseudo == "berlín ") ||
                (Pseudo == "Berlin") || (Pseudo == "berlin") || (Pseudo == "Berlin ") || (Pseudo == "berlin ") ||
                (Pseudo == "BERLÍN") || (Pseudo == "BERLÍN ") || (Pseudo == "BERLIN") || (Pseudo == "BERLIN "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Berlín_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO VIENA
            if ((Pseudo == "Viena") || (Pseudo == "viena") || (Pseudo == "Viena ") || (Pseudo == "viena ") ||
                (Pseudo == "VIENA") || (Pseudo == "VIENA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Viena_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PRAGA
            if ((Pseudo == "Praga") || (Pseudo == "praga") || (Pseudo == "Praga ") || (Pseudo == "praga ") ||
                (Pseudo == "PRAGA") || (Pseudo == "PRAGA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Praga_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO YAKARTA
            if ((Pseudo == "Yakarta") || (Pseudo == "yakarta") || (Pseudo == "Yakarta ") || (Pseudo == "yakarta ") ||
                (Pseudo == "YAKARTA") || (Pseudo == "YAKARTA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Yakarta_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MÒNACO

            if ((Pseudo == "Mónaco") || (Pseudo == "mónaco") || (Pseudo == "Mónaco ") || (Pseudo == "mónaco ") ||
                (Pseudo == "Monaco") || (Pseudo == "monaco") || (Pseudo == "Monaco ") || (Pseudo == "monaco ") ||
                (Pseudo == "MÓNACO") || (Pseudo == "MÓNACO ") || (Pseudo == "MONACO") || (Pseudo == "MONACO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Mónaco_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MANILA
            if ((Pseudo == "Manila") || (Pseudo == "manila") || (Pseudo == "Manila ") || (Pseudo == "manila ") ||
                (Pseudo == "MANILA") || (Pseudo == "MANILA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Manila_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO NUEVADELHI
            if ((Pseudo == "NuevaDelhi") || (Pseudo == "nuevadelhi") || (Pseudo == "NuevaDelhi ") || (Pseudo == "nuevadelhi ") ||
                (Pseudo == "Nuevadelhi") || (Pseudo == "Nuevadelhi ") || (Pseudo == "NuevaDeli") || (Pseudo == "NuevaDeli ") ||
                (Pseudo == "nuevadeli") || (Pseudo == "nuevadeli ") || (Pseudo == "Nuevadeli") || (Pseudo == "Nuevadeli ") ||

                (Pseudo == "Nueva Delhi") || (Pseudo == "nueva delhi") || (Pseudo == "Nueva Delhi ") || (Pseudo == "nueva delhi ") ||
                (Pseudo == "Nueva delhi") || (Pseudo == "Nueva delhi ") || (Pseudo == "Nueva Deli") || (Pseudo == "Nueva Deli ") ||
                (Pseudo == "nueva deli") || (Pseudo == "nueva deli ") || (Pseudo == "Nueva deli") || (Pseudo == "Nueva deli ") ||

                (Pseudo == "NUEVADELHI") || (Pseudo == "NUEVADELHI ") || (Pseudo == "NUEVADELI") || (Pseudo == "NUEVADELI ") ||
                (Pseudo == "NUEVA DELHI") || (Pseudo == "NUEVA DELHI ") || (Pseudo == "NUEVA DELI") || (Pseudo == "NUEVA DELI "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Nueva_Delhi_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MÉXICO

            if ((Pseudo == "México") || (Pseudo == "méxico") || (Pseudo == "México ") || (Pseudo == "méxico ") ||
                (Pseudo == "Mexico") || (Pseudo == "mexico") || (Pseudo == "Mexico ") || (Pseudo == "mexico ") ||
                (Pseudo == "MÉXICO") || (Pseudo == "MÉXICO ") || (Pseudo == "MEXICO") || (Pseudo == "MEXICO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                México_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TEHERÁN

            if ((Pseudo == "Teherán") || (Pseudo == "teherán") || (Pseudo == "Teherán ") || (Pseudo == "teherán ") ||
                (Pseudo == "Teheran") || (Pseudo == "teheran") || (Pseudo == "Teheran ") || (Pseudo == "teheran ") ||

                (Pseudo == "Terán") || (Pseudo == "Terán ") || (Pseudo == "Teran") || (Pseudo == "Teran ") ||
                (Pseudo == "terán") || (Pseudo == "terán ") || (Pseudo == "teran") || (Pseudo == "teran ") ||

                (Pseudo == "TERÁN") || (Pseudo == "TERÁN ") || (Pseudo == "TERAN") || (Pseudo == "TERAN ") ||

                (Pseudo == "TEHERÁN") || (Pseudo == "TEHERÁN ") || (Pseudo == "TEHERAN") || (Pseudo == "TEHERAN "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Teherán_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PEKÍN

            if ((Pseudo == "Pekín") || (Pseudo == "pekín") || (Pseudo == "Pekín ") || (Pseudo == "pekín ") ||
                (Pseudo == "Pekin") || (Pseudo == "pekin") || (Pseudo == "Pekin ") || (Pseudo == "pekin ") ||
                (Pseudo == "PEKÍN") || (Pseudo == "PEKÍN ") || (Pseudo == "PEKIN") || (Pseudo == "PEKIN "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Pekín_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BUCAREST
            if ((Pseudo == "Bucarest") || (Pseudo == "bucarest") || (Pseudo == "Bucarest ") || (Pseudo == "bucarest ") ||
                (Pseudo == "BUCAREST") || (Pseudo == "BUCAREST "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Bucarest_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO COPENNAGUE
            if ((Pseudo == "Copennague") || (Pseudo == "copennague") || (Pseudo == "Copennague ") || (Pseudo == "copennague ") ||
                (Pseudo == "Copenague") || (Pseudo == "copenague") || (Pseudo == "Copenague ") || (Pseudo == "copenague ") ||
                (Pseudo == "Copenage") || (Pseudo == "copenage") || (Pseudo == "Copenage ") || (Pseudo == "copenage ") ||
                (Pseudo == "COPENNAGUE") || (Pseudo == "COPENNAGUE ") || (Pseudo == "COPENAGUE") || (Pseudo == "COPENAGUE ") ||
                (Pseudo == "COPENAGE") || (Pseudo == "COPENAGE "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Copennague_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO AMSTERDAM
            if ((Pseudo == "Amsterdam") || (Pseudo == "amsterdam") || (Pseudo == "Amsterdam ") || (Pseudo == "amsterdam ") ||
                (Pseudo == "AMSTERDAM") || (Pseudo == "AMSTERDAM "))
            {

                //TimeL_Amsterdam.SetActive(true);
                clavier.text = "";
                Handheld.Vibrate();
                Amsterdam_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SAIGON
            if ((Pseudo == "Saigón") || (Pseudo == "saigón") || (Pseudo == "Saigón ") || (Pseudo == "saigón ") ||
                (Pseudo == "Saigon") || (Pseudo == "saigon") || (Pseudo == "Saigon ") || (Pseudo == "saigon ") ||
                (Pseudo == "SAIGÓN") || (Pseudo == "SAIGÓN ") || (Pseudo == "SAIGON") || (Pseudo == "SAIGON "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Saigón_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TAIPÉI
            if ((Pseudo == "Taipéi") || (Pseudo == "taipéi") || (Pseudo == "Taipéi ") || (Pseudo == "taipéi ") ||
                (Pseudo == "Taipei") || (Pseudo == "taipei") || (Pseudo == "Taipei ") || (Pseudo == "taipei ") ||
                (Pseudo == "TAIPÉI") || (Pseudo == "TAIPÉI ") || (Pseudo == "TAIPEI") || (Pseudo == "TAIPEI "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Taipéi_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TOKIO
            if ((Pseudo == "Tokio") || (Pseudo == "tokio") || (Pseudo == "Tokio ") || (Pseudo == "tokio ") ||
                (Pseudo == "TOKIO") || (Pseudo == "TOKIO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Tokio_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SANJUAN
            if ((Pseudo == "SanJuan") || (Pseudo == "sanjuan") || (Pseudo == "SanJuan ") || (Pseudo == "sanjuan ") ||
                (Pseudo == "San Juan") || (Pseudo == "san juan") || (Pseudo == "San Juan ") || (Pseudo == "san juan ") ||
                (Pseudo == "San juan") || (Pseudo == "San juan ") ||
                (Pseudo == "SAN JUAN") || (Pseudo == "SAN JUAN ") || (Pseudo == "SANJUAN") || (Pseudo == "SANJUAN "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                San_Juan_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO KINGSTON
            if ((Pseudo == "Kingston") || (Pseudo == "kingston") || (Pseudo == "Kingston ") || (Pseudo == "kingston ") ||
                (Pseudo == "KINGSTON") || (Pseudo == "KINGSTON "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Kingston_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO HABANA
            if ((Pseudo == "Habana") || (Pseudo == "habana") || (Pseudo == "Habana ") || (Pseudo == "habana ") ||
                (Pseudo == "HABANA") || (Pseudo == "HABANA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Habana_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SANJOSÉ
            if ((Pseudo == "SanJosé") || (Pseudo == "sanjosé") || (Pseudo == "SanJosé ") || (Pseudo == "sanjosé ") ||
                (Pseudo == "San José") || (Pseudo == "san josé") || (Pseudo == "San José ") || (Pseudo == "san josé ") ||
                (Pseudo == "San jose") || (Pseudo == "San jose ") || (Pseudo == "sanjose") || (Pseudo == "sanjose ") ||
                (Pseudo == "SAN JOSÉ") || (Pseudo == "SAN JOSÉ ") || (Pseudo == "SANJOSE") || (Pseudo == "SANJOSE ") ||
                (Pseudo == "SAN JOSE") || (Pseudo == "SAN JOSE "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                San_José_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PANAMÁ
            if ((Pseudo == "Panamá") || (Pseudo == "panamá") || (Pseudo == "Panamá ") || (Pseudo == "panamá ") ||
                (Pseudo == "Panama") || (Pseudo == "panama") || (Pseudo == "Panama ") || (Pseudo == "panama ") ||
                (Pseudo == "PANAMÁ") || (Pseudo == "PANAMÁ ") || (Pseudo == "PANAMA") || (Pseudo == "PANAMA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Panamá_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MANAGUA
            if ((Pseudo == "Managua") || (Pseudo == "managua") || (Pseudo == "Managua ") || (Pseudo == "managua ") ||
                (Pseudo == "MANAGUA") || (Pseudo == "MANAGUA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Managua_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TEGUCIGALPA
            if ((Pseudo == "Tegucigalpa") || (Pseudo == "tegucigalpa") || (Pseudo == "Tegucigalpa ") || (Pseudo == "tegucigalpa ") ||
                (Pseudo == "TEGUCIGALPA") || (Pseudo == "TEGUCIGALPA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Tegucigalpa_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO NUEVAYORK
            if ((Pseudo == "NuevaYork") || (Pseudo == "nuevayork") || (Pseudo == "NuevaYork ") || (Pseudo == "nuevayork ") ||
                (Pseudo == "Nueva York") || (Pseudo == "nueva york") || (Pseudo == "Nueva York ") || (Pseudo == "nueva york ") ||
                (Pseudo == "Nueva york") || (Pseudo == "Nueva york ") ||
                (Pseudo == "NUEVAYORK") || (Pseudo == "NUEVAYORK ") || (Pseudo == "NUEVA YORK") || (Pseudo == "NUEVA YORK "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Nueva_York_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BUENOSAIRES
            if ((Pseudo == "BuenosAires") || (Pseudo == "buenosaires") || (Pseudo == "BuenosAires ") || (Pseudo == " ") ||
                (Pseudo == "Buenos Aires") || (Pseudo == "buenos aires") || (Pseudo == "Buenos Aires ") || (Pseudo == "buenos aires ") ||
                (Pseudo == "Buenos aires") || (Pseudo == "Buenos aires ") ||
                (Pseudo == "BUENOSAIRES") || (Pseudo == "BUENOSAIRES ") || (Pseudo == "BUENOS AIRES") || (Pseudo == "BUENOS AIRES "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Buenos_Aires_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO OTAWA
            if ((Pseudo == "Otawa") || (Pseudo == "otawa") || (Pseudo == "Otawa ") || (Pseudo == "otawa ") ||
                (Pseudo == "Otagua") || (Pseudo == "otagua") || (Pseudo == "Otagua ") || (Pseudo == "otagua ") ||
                (Pseudo == "OTAWA") || (Pseudo == "OTAWA ") || (Pseudo == "OTAGUA") || (Pseudo == "OTAGUA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Ottawa_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO EL CAIRO
            if ((Pseudo == "El Cairo") || (Pseudo == "el cairo") || (Pseudo == "El Cairo ") || (Pseudo == "el cairo ") ||
                (Pseudo == "El cairo") || (Pseudo == "El cairo ") || (Pseudo == "Cairo") || (Pseudo == "cairo") || (Pseudo == "Cairo ") || (Pseudo == "cairo ") ||
                (Pseudo == "EL CAIRO") || (Pseudo == "EL CAIRO ") || (Pseudo == "CAIRO") || (Pseudo == "CAIRO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                El_Cairo_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TORONTO
            if ((Pseudo == "Toronto") || (Pseudo == "toronto") || (Pseudo == "Toronto ") || (Pseudo == "toronto ") ||
                (Pseudo == "TORONTO") || (Pseudo == "TORONTO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Toronto_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TRÍPOLI
            if ((Pseudo == "Trípoli") || (Pseudo == "trípoli") || (Pseudo == "Trípoli ") || (Pseudo == "trípoli ") ||
                (Pseudo == "Tripoli") || (Pseudo == "tripoli") || (Pseudo == "Tripoli ") || (Pseudo == "tripoli ") ||
                (Pseudo == "TRÍPOLI") || (Pseudo == "TRÍPOLI ") || (Pseudo == "TRIPOLI") || (Pseudo == "TRIPOLI "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Trípoli_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MONTEVIDEO
            if ((Pseudo == "MonteVideo") || (Pseudo == "montevideo") || (Pseudo == "MonteVideo ") || (Pseudo == "montevideo ") ||
                (Pseudo == "Monte Video") || (Pseudo == "monte video") || (Pseudo == "Monte Video ") || (Pseudo == "monte video ") ||
                (Pseudo == "Monte video") || (Pseudo == "Monte video ") ||
                (Pseudo == "MONTEVIDEO") || (Pseudo == "MONTEVIDEO ") || (Pseudo == "MONTE VIDEO") || (Pseudo == "MONTE VIDEO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Monte_video_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LUANDA
            if ((Pseudo == "Luanda") || (Pseudo == "luanda") || (Pseudo == "Luanda ") || (Pseudo == "luanda ") ||
                (Pseudo == "LUANDA") || (Pseudo == "LUANDA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Luanda_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SANTIAGO
            if ((Pseudo == "Santiago") || (Pseudo == "santiago") || (Pseudo == "Santiago ") || (Pseudo == "santiago ") ||
                (Pseudo == "SANTIAGO") || (Pseudo == "SANTIAGO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Santiago_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ASUNCIÓN
            if ((Pseudo == "Asunción") || (Pseudo == "asunción") || (Pseudo == "Asunción ") || (Pseudo == "asunción ") ||
                (Pseudo == "Asuncion") || (Pseudo == "asuncion") || (Pseudo == "Asuncion ") || (Pseudo == "asuncion ") ||
                (Pseudo == "ASUNCIÓN") || (Pseudo == "ASUNCIÓN ") || (Pseudo == "ASUNCION") || (Pseudo == "ASUNCION "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Asunción_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SAN SALVADOR
            if ((Pseudo == "SanSalvador") || (Pseudo == "sansalvador") || (Pseudo == "SanSalvador ") || (Pseudo == "sansalvador ") ||
                (Pseudo == "San Salvador") || (Pseudo == "san salvador") || (Pseudo == "San Salvador ") || (Pseudo == "san salvador ") ||
                (Pseudo == "San salvador") || (Pseudo == "San salvador ") ||
                (Pseudo == "SANSALVADOR") || (Pseudo == "SANSALVADOR ") || (Pseudo == "SAN SALVADOR") || (Pseudo == "SAN SALVADOR "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                San_Salvador_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BOGOTÁ
            if ((Pseudo == "Bogotá") || (Pseudo == "bogotá") || (Pseudo == "Bogotá ") || (Pseudo == "bogotá ") ||
                (Pseudo == "Bogota") || (Pseudo == "bogota") || (Pseudo == "Bogota ") || (Pseudo == "bogota ") ||
                (Pseudo == "BOGOTÁ") || (Pseudo == "BOGOTÁ ") || (Pseudo == "BOGOTA") || (Pseudo == "BOGOTA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Bogotá_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO CARACAS
            if ((Pseudo == "Caracas") || (Pseudo == "caracas") || (Pseudo == "Caracas ") || (Pseudo == "caracas ") ||
                (Pseudo == "CARACAS") || (Pseudo == "CARACAS "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Caracas_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SANTO DOMINGO
            if ((Pseudo == "SantoDomingo") || (Pseudo == "santodomingo") || (Pseudo == "SantoDomingo ") || (Pseudo == "santodomingo ") ||
                (Pseudo == "Santo Domingo") || (Pseudo == "santo domingo") || (Pseudo == "Santo Domingo ") || (Pseudo == "santo domingo ") ||
                (Pseudo == "Santo domingo") || (Pseudo == "Santo domingo ") ||
                (Pseudo == "SANTODOMINGO") || (Pseudo == "SANTODOMINGO ") || (Pseudo == "SANTO DOMINGO") || (Pseudo == "SANTO DOMINGO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Santo_Domingo_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO QUITO
            if ((Pseudo == "Quito") || (Pseudo == "quito") || (Pseudo == "Quito ") || (Pseudo == "quito ") ||
                (Pseudo == "QUITO") || (Pseudo == "QUITO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Quito_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MINESOTA
            if ((Pseudo == "Minesota") || (Pseudo == "minesota") || (Pseudo == "Minesota ") || (Pseudo == "minesota ") ||
                (Pseudo == "MINESOTA") || (Pseudo == "MINESOTA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Minesota_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SIRIA
            if ((Pseudo == "Siria") || (Pseudo == "siria") || (Pseudo == "Siria ") || (Pseudo == "siria ") ||
                (Pseudo == "SIRIA") || (Pseudo == "SIRIA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Siria_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SOFÍA
            if ((Pseudo == "Sofía") || (Pseudo == "sofía") || (Pseudo == "Sofía ") || (Pseudo == "sofía ") ||
                (Pseudo == "Sofia") || (Pseudo == "sofia") || (Pseudo == "Sofia ") || (Pseudo == "sofia ") ||
                (Pseudo == "SOFÍA") || (Pseudo == "SOFÍA ") || (Pseudo == "SOFIA") || (Pseudo == "SOFIA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Sofía_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO EL CABO
            if ((Pseudo == "El Cabo") || (Pseudo == "el cabo") || (Pseudo == "El Cabo ") || (Pseudo == "el cabo ") ||
                (Pseudo == "El cabo") || (Pseudo == "El cabo ") || (Pseudo == "Cabo") || (Pseudo == "cabo") || (Pseudo == "Cabo ") || (Pseudo == "cabo ") ||
                (Pseudo == "EL CABO") || (Pseudo == "EL CABO ") || (Pseudo == "CABO") || (Pseudo == "CABO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                El_Cabo_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ANKARA
            if ((Pseudo == "Ankara") || (Pseudo == "ankara") || (Pseudo == "Ankara ") || (Pseudo == "ankara ") ||
                (Pseudo == "ANKARA") || (Pseudo == "ANKARA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Ankara_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TÚNEZ
            if ((Pseudo == "Túnez") || (Pseudo == "túnez") || (Pseudo == "Túnez ") || (Pseudo == "túnez ") ||
                (Pseudo == "Tunez") || (Pseudo == "tunez") || (Pseudo == "Tunez ") || (Pseudo == "tunez ") ||
                (Pseudo == "TÚNEZ") || (Pseudo == "TÚNEZ ") || (Pseudo == "TUNEZ") || (Pseudo == "TUNEZ "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Túnez_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SINGAPUR
            if ((Pseudo == "Singapur") || (Pseudo == "singapur") || (Pseudo == "Singapur ") || (Pseudo == "singapur ") ||
                (Pseudo == "SINGAPUR") || (Pseudo == "SINGAPUR "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Singapur_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESLOVAQUIA
            if ((Pseudo == "Eslovaquia") || (Pseudo == "eslovaquia") || (Pseudo == "Eslovaquia ") || (Pseudo == "eslovaquia ") ||
                (Pseudo == "ESLOVAQUIA") || (Pseudo == "ESLOVAQUIA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Eslovaquia_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO HONOLULU
            if ((Pseudo == "Honolulu") || (Pseudo == "honolulu") || (Pseudo == "Honolulu ") || (Pseudo == "honolulu ") ||
                (Pseudo == "Onolulu") || (Pseudo == "onolulu") || (Pseudo == "Onolulu ") || (Pseudo == "onolulu ") ||
                (Pseudo == "HONOLULU") || (Pseudo == "HONOLULU ") || (Pseudo == "ONOLULU") || (Pseudo == "ONOLULU "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Honolulu_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO CANBERRA
            if ((Pseudo == "Canberra") || (Pseudo == "canberra") || (Pseudo == "Canberra ") || (Pseudo == "canberra ") ||
                (Pseudo == "Canbera") || (Pseudo == "canbera") || (Pseudo == "Canbera ") || (Pseudo == "canbera ") ||
                (Pseudo == "CANBERRA") || (Pseudo == "CANBERRA ") || (Pseudo == "CANBERA") || (Pseudo == "CANBERA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Canberra_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BRASILIA
            if ((Pseudo == "Brasilia") || (Pseudo == "brasilia") || (Pseudo == "Brasilia ") || (Pseudo == "brasilia ") ||
                (Pseudo == "BRASILIA") || (Pseudo == "BRASILIA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Brasilia_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO YOKOHAMA
            if ((Pseudo == "Yokohama") || (Pseudo == "yokohama") || (Pseudo == "Yokohama ") || (Pseudo == "yokohama ") ||
                (Pseudo == "YOKOHAMA") || (Pseudo == "YOKOHAMA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Yokohama_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO GUATEMALA
            if ((Pseudo == "Guatemala") || (Pseudo == "guatemala") || (Pseudo == "Guatemala ") || (Pseudo == "guatemala ") ||
                (Pseudo == "GUATEMALA") || (Pseudo == "GUATEMALA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Guatemala_F_blue();
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO WASHINGTON
            if ((Pseudo == "Washington") || (Pseudo == "washington") || (Pseudo == "Washington ") || (Pseudo == "washington ") ||
                (Pseudo == "WASHINGTON") || (Pseudo == "WASHINGTON "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Washington_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO DACCA
            if ((Pseudo == "Dacca") || (Pseudo == "dacca") || (Pseudo == "Dacca ") || (Pseudo == "dacca ") ||
                (Pseudo == "Daca") || (Pseudo == "daca") || (Pseudo == "Daca ") || (Pseudo == "daca ") ||
                (Pseudo == "Dakka") || (Pseudo == "dakka") || (Pseudo == "Dakka ") || (Pseudo == "dakka ") ||
                (Pseudo == "Daka") || (Pseudo == "daka ") || (Pseudo == "Daka ") || (Pseudo == "daka ") ||
                (Pseudo == "DACCA") || (Pseudo == "DACCA ") || (Pseudo == "DACA") || (Pseudo == "DACA ") ||
                (Pseudo == "DAKKA") || (Pseudo == "DAKKA ") || (Pseudo == "DAKA") || (Pseudo == "DAKA "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Dacca_F_blue();
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO HAMBURGO
            if ((Pseudo == "Hamburgo") || (Pseudo == "hamburgo") || (Pseudo == "Hamburgo ") || (Pseudo == "hamburgo ") ||
                (Pseudo == "Amburgo") || (Pseudo == "amburgo") || (Pseudo == "Amburgo ") || (Pseudo == "amburgo ") ||
                (Pseudo == "HAMBURGO") || (Pseudo == "HAMBURGO ") || (Pseudo == "AMBURGO") || (Pseudo == "AMBURGO "))
            {
                clavier.text = "";
                Handheld.Vibrate();
                Hamburgo_F_blue();
            }
            //**************************************************************************************************************



        }



    }



    //
    //UNIDAD 1

    //******************************************
    //ESTAMBUL
    public void Estambul_F_blue()
    {

        //ACTIVAMOS EL EDIFICIO AZUL
        azulitos[3].SetActive(true);

        //CAMBIAMOS EL TAG DEL EDIFICIO NORMAL
        normalillos[41].tag = tagNew;

        //NUESTRA VARIABLE RECOLECTOR LE ALMACENAREMOS 
        //NUESTRO EDIFICIO NORMAL CON EL NUEVO TAG
        recolector = normalillos[41];

        //POR LO TANTO RECOLECTOR LO DESACTIVAMOS
        //PARA QUE SE DESACTIVE SU CONTENIDO EN ESTE CASO EL EDIFICIO NORMAL
        recolector.SetActive(false);


        //MÉTODO PARA ACTIVAR BUTTON AZUL
        //(BUTTON PARA DESELECCIONAR UN EDIFICIO)
        ResetButtons_UI();



        //DESACTIVAMOS INPUTFIELD
        InputField_F();

        //AGREGAMOS MÉTODO AL BUTTON AZUL
        //SERÁ DIFERENTE PARA CADA EDIFICIO
        deselect.onClick.AddListener(Estambul_Close);
    }


    //MÉTODO ASIGANDO AL BUTTON AZUL
    //SIRVE PARA DESELCCIONAR EL EDIFICIO
    public void Estambul_Close()
    {
        //CINEMACHINE
        //TIMELINES

        //ESTAMBUL
        //TimeL_Estambul.SetActive(false);


        //DESACTIVAMOS EL EDIFICIO AZUL
        azulitos[3].SetActive(false);

        //LE DEVOLVEMOS EL TAG QUE TENÍA AL PRINCIPIO MI EDIFICIO NORMAL
        normalillos[41].tag = tagNameNormal;

        //ACTIVAMOS EL RECOLECTOR
        //(RECORDEMOS QUE DENTRO DE ESTE SE ENCUENTRA MI EDIFICIO NORMAL)
        recolector.SetActive(true);

        //VACIAMOS EL EDIFICIO DEL RECOLECTOR PARA QUE OTRO PUEDA ENTRAR EN CASO DE SELECCIONARSE
        recolector = null;



        //PARA REGRESAR LOS BUTTONS COMO ESTABAN ANTES DE SELECCIONAR UN EDIFICIO 
        //MANDAMOS LLAMAR AL SIGUIENTE MÉTODO
        ResetButtons_Estambul();





    }
    //**********************************************


    //MÉTODO PARA REGRESAR LOS BUTTONS QUE ESTABAN AL PRINCIPIO POR DEFAULT
    public void ResetButtons_Estambul()
    {
        //ACTIVAMOS EL BITTON VERDE
        //BUTTON OPEN
        open_go.SetActive(true);


        //DESACTIVAMOS EL BUTTON AZUL
        //BUTTON DE DESELECCION
        deselect_go.SetActive(false);

        //MÉTODO QUE ELIMINA EL COMPORTAMIENTO DEL BUTTON AZUL
        Button_Azul_Estambul_X();



    }
    //-----------------------------------------

    //MÉTODO PARA QUITAR EL COMPORTAMIENTO DEL BUTTON AZUL
    public void Button_Azul_Estambul_X()
    {
        //BUTTON AZUL
        //REMOVEMOS EL COMPORTAMIENTO DEL BUTTON DESELECT
        deselect.onClick.RemoveListener(Estambul_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //MOSCÚ

    public void Moscú_F_blue()
    {
        azulitos[57].SetActive(true);
        normalillos[16].tag = tagNew;
        recolector = normalillos[16];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Moscú_Close);

    }


    //MÉTODO ASIGANDO AL BUTTON AZUL
    //SIRVE PARA DESELCCIONAR EL EDIFICIO
    public void Moscú_Close()
    {
        azulitos[57].SetActive(false);
        normalillos[16].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Moscú();
        Pseudo = Pseudo2;

    }
    //************************************************



    //MÉTODO PARA REGRESAR LOS BUTTONS QUE ESTABAN AL PRINCIPIO POR DEFAULT
    public void ResetButtons_Moscú()
    {
        open_go.SetActive(true);
        deselect_go.SetActive(false);
        Button_Azul_Moscú_X();

    }
    //---------------------------------------------


    //MÉTODO PARA QUITAR EL COMPORTAMIENTO DEL BUTTON AZUL
    public void Button_Azul_Moscú_X()
    {
        deselect.onClick.RemoveListener(Moscú_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //BERNA
    public void Berna_F_blue()
    {
        azulitos[24].SetActive(true);
        normalillos[66].tag = tagNew;
        recolector = normalillos[66];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Berna_Close);
    }


    public void Berna_Close()
    {
        azulitos[24].SetActive(false);
        normalillos[66].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Berna();
        Pseudo = Pseudo2;
    }


    public void ResetButtons_Berna()
    {

        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Berna_X();

    }

    public void Button_Azul_Berna_X()
    {
        deselect.onClick.RemoveListener(Berna_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //ATENAS
    public void Atenas_F_blue()
    {

        azulitos[30].SetActive(true);
        normalillos[36].tag = tagNew;
        recolector = normalillos[36];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Atenas_Close);

    }

    public void Atenas_Close()
    {
        azulitos[30].SetActive(false);
        normalillos[36].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Atenas();
        Pseudo = Pseudo2;
    }


    //***********************************************************************
    public void ResetButtons_Atenas()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Atenas_X();
    }

    public void Button_Azul_Atenas_X()
    {
        deselect.onClick.RemoveListener(Atenas_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //ARGEL
    public void Argel_F_blue()
    {
        azulitos[68].SetActive(true);
        normalillos[53].tag = tagNew;
        recolector = normalillos[53];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Argel_Close);

    }

    public void Argel_Close()
    {
        azulitos[68].SetActive(false);
        normalillos[53].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Argel();


    }

    public void ResetButtons_Argel()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Argel_X();
    }

    public void Button_Azul_Argel_X()
    {
        deselect.onClick.RemoveListener(Argel_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //OSLO
    public void Oslo_F_blue()
    {
        azulitos[53].SetActive(true);
        normalillos[64].tag = tagNew;
        recolector = normalillos[64];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Oslo_Close);
    }


    public void Oslo_Close()
    {
        azulitos[53].SetActive(false);
        normalillos[53].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Oslo();

    }

    public void ResetButtons_Oslo()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Oslo_X();
    }

    public void Button_Azul_Oslo_X()
    {
        deselect.onClick.RemoveListener(Oslo_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //BULGARIA
    public void Bulgaria_F_blue()
    {
        azulitos[55].SetActive(true);
        normalillos[18].tag = tagNew;
        recolector = normalillos[18];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Bulgaria_Close);
    }

    public void Bulgaria_Close()
    {
        azulitos[55].SetActive(false);
        normalillos[18].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Bulgaria();
    }

    public void ResetButtons_Bulgaria()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Bulgaria_X();
    }

    public void Button_Azul_Bulgaria_X()
    {
        deselect.onClick.RemoveListener(Bulgaria_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //BELGRADO
    public void Belgrado_F_blue()
    {
        azulitos[40].SetActive(true);
        normalillos[47].tag = tagNew;
        recolector = normalillos[47];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Belgrado_Close);
    }

    public void Belgrado_Close()
    {
        azulitos[40].SetActive(false);
        normalillos[47].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Belgrado();
    }

    public void ResetButtons_Belgrado()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Belgrado_X();

    }

    public void Button_Azul_Belgrado_X()
    {
        deselect.onClick.RemoveListener(Belgrado_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //SEÚL
    public void Seúl_F_blue()
    {
        azulitos[69].SetActive(true);
        normalillos[56].tag = tagNew;
        recolector = normalillos[56];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Seúl_Close);

    }

    public void Seúl_Close()
    {
        azulitos[69].SetActive(false);
        normalillos[56].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Seúl();
    }

    public void ResetButtons_Seúl()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Seúl_X();
    }

    public void Button_Azul_Seúl_X()
    {
        deselect.onClick.RemoveListener(Seúl_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //DAMASCO
    public void Damasco_F_blue()
    {
        azulitos[47].SetActive(true);
        normalillos[14].tag = tagNew;
        recolector = normalillos[14];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Damasco_Close);
    }

    public void Damasco_Close()
    {
        azulitos[47].SetActive(false);
        normalillos[14].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Damasco();
    }

    public void ResetButtons_Damasco()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Damasco_X();

    }

    public void Button_Azul_Damasco_X()
    {
        deselect.onClick.RemoveListener(Damasco_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //VARSOVIA
    public void Varsovia_F_blue()
    {
        azulitos[20].SetActive(true);
        normalillos[19].tag = tagNew;
        recolector = normalillos[19];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Varsovia_Close);
    }

    public void Varsovia_Close()
    {
        azulitos[20].SetActive(false);
        normalillos[19].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Varsovia();

    }

    public void ResetButtons_Varsovia()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Varsovia_X();
    }

    public void Button_Azul_Varsovia_X()
    {
        deselect.onClick.RemoveListener(Varsovia_Close);
    }
    //--------------------------------------------
    //*********************************************************









    //**************************************
    //ESTOCOLMO
    public void Estocolmo_F_blue()
    {
        azulitos[27].SetActive(true);
        normalillos[2].tag = tagNew;
        recolector = normalillos[2];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Estocolmo_Close);

    }

    public void Estocolmo_Close()
    {
        azulitos[27].SetActive(false);
        normalillos[19].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Estocolmo();
    }

    public void ResetButtons_Estocolmo()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Estocolmo_X();
    }

    public void Button_Azul_Estocolmo_X()
    {
        deselect.onClick.RemoveListener(Estocolmo_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //PARÍS
    public void París_F_blue()
    {
        azulitos[56].SetActive(true);
        normalillos[10].tag = tagNew;
        recolector = normalillos[10];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(París_Close);
    }

    public void París_Close()
    {
        azulitos[56].SetActive(false);
        normalillos[10].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_París();

    }

    public void ResetButtons_París()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_París_X();

    }

    public void Button_Azul_París_X()
    {
        deselect.onClick.RemoveListener(París_Close);
    }
    //--------------------------------------------
    //*********************************************************





    //**************************************
    //MADRID
    public void Madrid_F_blue()
    {
        azulitos[50].SetActive(true);
        normalillos[6].tag = tagNew;
        recolector = normalillos[6];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Madrid_Close);
    }

    public void Madrid_Close()
    {
        azulitos[50].SetActive(false);
        normalillos[6].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Madrid();

    }

    public void ResetButtons_Madrid()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Madrid_X();
    }

    public void Button_Azul_Madrid_X()
    {
        deselect.onClick.RemoveListener(Madrid_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //LISBOA

    public void Lisboa_F_blue()
    {
        azulitos[16].SetActive(true);
        normalillos[15].tag = tagNew;
        recolector = normalillos[15];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Lisboa_Close);
    }

    public void Lisboa_Close()
    {
        azulitos[16].SetActive(false);
        normalillos[15].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Lisboa();

    }

    public void ResetButtons_Lisboa()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Lisboa_X();

    }

    public void Button_Azul_Lisboa_X()
    {
        deselect.onClick.RemoveListener(Lisboa_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //ROMA
    public void Roma_F_blue()
    {
        azulitos[35].SetActive(true);
        normalillos[24].tag = tagNew;
        recolector = normalillos[24];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Roma_Close);
    }

    public void Roma_Close()
    {
        azulitos[35].SetActive(false);
        normalillos[24].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Roma();
    }

    public void ResetButtons_Roma()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Roma_X();

    }

    public void Button_Azul_Roma_X()
    {
        deselect.onClick.RemoveListener(Roma_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //BRUSELAS
    public void Bruselas_F_blue()
    {
        azulitos[49].SetActive(true);
        normalillos[25].tag = tagNew;
        recolector = normalillos[25];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Bruselas_Close);
    }

    public void Bruselas_Close()
    {
        azulitos[49].SetActive(false);
        normalillos[25].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Bruselas();
    }

    public void ResetButtons_Bruselas()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Bruselas_X();
    }

    public void Button_Azul_Bruselas_X()
    {
        deselect.onClick.RemoveListener(Bruselas_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //LONDRES
    public void Londres_F_blue()
    {
        azulitos[39].SetActive(true);
        normalillos[42].tag = tagNew;
        recolector = normalillos[42];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Londres_Close);
    }

    public void Londres_Close()
    {
        azulitos[39].SetActive(false);
        normalillos[42].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Londres();
    }

    public void ResetButtons_Londres()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Londres_X();
    }

    public void Button_Azul_Londres_X()
    {
        deselect.onClick.RemoveListener(Londres_Close);
    }
    //--------------------------------------------
    //*********************************************************




    //**************************************
    //ZURICH
    public void Zurich_F_blue()
    {
        azulitos[70].SetActive(true);
        normalillos[72].tag = tagNew;
        recolector = normalillos[72];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Zurich_Close);
    }

    public void Zurich_Close()
    {
        azulitos[70].SetActive(false);
        normalillos[72].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Zurich();
    }

    public void ResetButtons_Zurich()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Zurich_X();
    }

    public void Button_Azul_Zurich_X()
    {
        deselect.onClick.RemoveListener(Zurich_Close);
    }
    //--------------------------------------------
    //*********************************************************





    //**************************************
    //BERLÍN
    public void Berlín_F_blue()
    {
        azulitos[61].SetActive(true);
        normalillos[62].tag = tagNew;
        recolector = normalillos[62];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Berlín_Close);
    }

    public void Berlín_Close()
    {
        azulitos[61].SetActive(false);
        normalillos[62].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Berlín();
    }

    public void ResetButtons_Berlín()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Berlín_X();
    }

    public void Button_Azul_Berlín_X()
    {
        deselect.onClick.RemoveListener(Berlín_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //VIENA
    public void Viena_F_blue()
    {
        azulitos[13].SetActive(true);
        normalillos[70].tag = tagNew;
        recolector = normalillos[70];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Viena_Close);
    }

    public void Viena_Close()
    {
        azulitos[13].SetActive(false);
        normalillos[70].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Viena();
    }

    public void ResetButtons_Viena()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Viena_X();
    }

    public void Button_Azul_Viena_X()
    {
        deselect.onClick.RemoveListener(Viena_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //PRAGA
    public void Praga_F_blue()
    {
        azulitos[29].SetActive(true);
        normalillos[69].tag = tagNew;
        recolector = normalillos[69];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Praga_Close);
    }

    public void Praga_Close()
    {
        azulitos[29].SetActive(false);
        normalillos[69].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Praga();
    }

    public void ResetButtons_Praga()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Praga_X();
    }

    public void Button_Azul_Praga_X()
    {
        deselect.onClick.RemoveListener(Praga_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //YAKARTA
    public void Yakarta_F_blue()
    {
        azulitos[38].SetActive(true);
        normalillos[21].tag = tagNew;
        recolector = normalillos[21];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Yakarta_Close);
    }

    public void Yakarta_Close()
    {
        azulitos[38].SetActive(false);
        normalillos[21].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Yakarta();
    }

    public void ResetButtons_Yakarta()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Yakarta_X();
    }

    public void Button_Azul_Yakarta_X()
    {
        deselect.onClick.RemoveListener(Yakarta_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //MÓNACO
    public void Mónaco_F_blue()
    {
        azulitos[25].SetActive(true);
        normalillos[29].tag = tagNew;
        recolector = normalillos[29];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Mónaco_Close);
    }

    public void Mónaco_Close()
    {
        azulitos[25].SetActive(false);
        normalillos[29].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Mónaco();
    }

    public void ResetButtons_Mónaco()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Mónaco_X();
    }

    public void Button_Azul_Mónaco_X()
    {
        deselect.onClick.RemoveListener(Mónaco_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //MANILA
    public void Manila_F_blue()
    {
        azulitos[73].SetActive(true);
        normalillos[63].tag = tagNew;
        recolector = normalillos[63];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Manila_Close);
    }

    public void Manila_Close()
    {
        azulitos[73].SetActive(false);
        normalillos[63].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Manila();
    }

    public void ResetButtons_Manila()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Manila_X();
    }

    public void Button_Azul_Manila_X()
    {
        deselect.onClick.RemoveListener(Manila_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //NUEVA DELHI
    public void Nueva_Delhi_F_blue()
    {
        azulitos[1].SetActive(true);
        normalillos[71].tag = tagNew;
        recolector = normalillos[71];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Nueva_Delhi_Close);
    }

    public void Nueva_Delhi_Close()
    {
        azulitos[1].SetActive(false);
        normalillos[71].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Nueva_Delhi();
    }

    public void ResetButtons_Nueva_Delhi()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Nueva_Delhi_X();
    }

    public void Button_Azul_Nueva_Delhi_X()
    {
        deselect.onClick.RemoveListener(Nueva_Delhi_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //MÉXICO
    public void México_F_blue()
    {
        azulitos[19].SetActive(true);
        normalillos[20].tag = tagNew;
        recolector = normalillos[20];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(México_Close);

    }

    public void México_Close()
    {
        azulitos[19].SetActive(false);
        normalillos[20].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_México();
    }

    public void ResetButtons_México()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_México_X();
    }

    public void Button_Azul_México_X()
    {
        deselect.onClick.RemoveListener(México_Close);
    }
    //--------------------------------------------
    //*********************************************************





    //**************************************
    //TEHERÁN
    public void Teherán_F_blue()
    {
        azulitos[59].SetActive(true);
        normalillos[40].tag = tagNew;
        recolector = normalillos[40];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Teherán_Close);
    }

    public void Teherán_Close()
    {
        azulitos[59].SetActive(false);
        normalillos[40].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Teherán();
    }

    public void ResetButtons_Teherán()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Teherán_X();
    }

    public void Button_Azul_Teherán_X()
    {
        deselect.onClick.RemoveListener(Teherán_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //BOMBAY
    public void Bombay_F_blue()
    {
        azulitos[45].SetActive(true);
        normalillos[11].tag = tagNew;
        recolector = normalillos[11];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Bombay_Close);
    }

    public void Bombay_Close()
    {
        azulitos[45].SetActive(false);
        normalillos[11].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Bombay();
    }

    public void ResetButtons_Bombay()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Bombay_X();
    }

    public void Button_Azul_Bombay_X()
    {
        deselect.onClick.RemoveListener(Bombay_Close);
    }
    //--------------------------------------------
    //*********************************************************









    //**************************************
    //PEKÍN
    public void Pekín_F_blue()
    {
        azulitos[2].SetActive(true);
        normalillos[0].tag = tagNew;
        recolector = normalillos[0];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Pekín_Close);
    }

    public void Pekín_Close()
    {
        azulitos[2].SetActive(false);
        normalillos[0].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Pekín();
    }

    public void ResetButtons_Pekín()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Pekín_X();
    }

    public void Button_Azul_Pekín_X()
    {
        deselect.onClick.RemoveListener(Pekín_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //BUCAREST
    public void Bucarest_F_blue()
    {
        azulitos[15].SetActive(true);
        normalillos[13].tag = tagNew;
        recolector = normalillos[13];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Bucarest_Close);
    }

    public void Bucarest_Close()
    {
        azulitos[15].SetActive(false);
        normalillos[13].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Bucarest();
    }


    public void ResetButtons_Bucarest()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Bucarest_X();
    }


    public void Button_Azul_Bucarest_X()
    {
        deselect.onClick.RemoveListener(Bucarest_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //COPENNNAGUE
    public void Copennague_F_blue()
    {
        azulitos[5].SetActive(true);
        normalillos[4].tag = tagNew;
        recolector = normalillos[4];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Copennague_Close);
    }

    public void Copennague_Close()
    {
        azulitos[5].SetActive(false);
        normalillos[4].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Copennague();
    }

    public void ResetButtons_Copennague()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Copennague_X();
    }

    public void Button_Azul_Copennague_X()
    {
        deselect.onClick.RemoveListener(Copennague_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //AMSTERDAM
    public void Amsterdam_F_blue()
    {
        azulitos[7].SetActive(true);
        normalillos[12].tag = tagNew;
        recolector = normalillos[12];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Amsterdam_Close);
    }

    public void Amsterdam_Close()
    {
        azulitos[7].SetActive(false);
        normalillos[12].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Amsterdam();
    }

    public void ResetButtons_Amsterdam()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Amsterdam_X();
    }

    public void Button_Azul_Amsterdam_X()
    {
        deselect.onClick.RemoveListener(Amsterdam_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //SAIGÓN
    public void Saigón_F_blue()
    {
        azulitos[71].SetActive(true);
        normalillos[17].tag = tagNew;
        recolector = normalillos[17];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Saigón_Close);
    }

    public void Saigón_Close()
    {
        azulitos[71].SetActive(false);
        normalillos[17].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Saigón();
    }

    public void ResetButtons_Saigón()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Saigón_X();
    }

    public void Button_Azul_Saigón_X()
    {
        deselect.onClick.RemoveListener(Saigón_Close);
    }
    //--------------------------------------------
    //*********************************************************





    //**************************************
    //TAIPÉI
    public void Taipéi_F_blue()
    {
        azulitos[54].SetActive(true);
        normalillos[31].tag = tagNew;
        recolector = normalillos[31];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Taipéi_Close);
    }

    public void Taipéi_Close()
    {
        azulitos[54].SetActive(false);
        normalillos[31].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Taipéi();
    }

    public void ResetButtons_Taipéi()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Taipéi_X();
    }

    public void Button_Azul_Taipéi_X()
    {
        deselect.onClick.RemoveListener(Taipéi_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //TOKIO
    public void Tokio_F_blue()
    {
        azulitos[18].SetActive(true);
        normalillos[67].tag = tagNew;
        recolector = normalillos[67];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Tokio_Close);
    }

    public void Tokio_Close()
    {
        azulitos[18].SetActive(false);
        normalillos[67].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Tokio();
    }

    public void ResetButtons_Tokio()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Tokio_X();
    }

    public void Button_Azul_Tokio_X()
    {
        deselect.onClick.RemoveListener(Tokio_Close);
    }
    //--------------------------------------------
    //*********************************************************









    //**************************************
    //SAN JUAN
    public void San_Juan_F_blue()
    {
        azulitos[44].SetActive(true);
        normalillos[34].tag = tagNew;
        recolector = normalillos[34];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(San_Juan_Close);
    }

    public void San_Juan_Close()
    {
        azulitos[44].SetActive(false);
        normalillos[34].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_San_Juan();
    }

    public void ResetButtons_San_Juan()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_San_Juan_X();
    }

    public void Button_Azul_San_Juan_X()
    {
        deselect.onClick.RemoveListener(San_Juan_Close);
    }
    //--------------------------------------------
    //*********************************************************









    //**************************************
    //KINGSTON
    public void Kingston_F_blue()
    {
        azulitos[48].SetActive(true);
        normalillos[57].tag = tagNew;
        recolector = normalillos[57];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Kingston_Close);
    }

    public void Kingston_Close()
    {
        azulitos[48].SetActive(false);
        normalillos[57].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Kingston();
    }

    public void ResetButtons_Kingston()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Kingston_X();
    }


    public void Button_Azul_Kingston_X()
    {
        deselect.onClick.RemoveListener(Kingston_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //HABANA
    public void Habana_F_blue()
    {
        azulitos[14].SetActive(true);
        normalillos[52].tag = tagNew;
        recolector = normalillos[52];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Habana_Close);
    }

    public void Habana_Close()
    {
        azulitos[14].SetActive(false);
        normalillos[52].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Habana();
    }

    public void ResetButtons_Habana()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Habana_X();
    }

    public void Button_Azul_Habana_X()
    {
        deselect.onClick.RemoveListener(Habana_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //SAN JOSÉ
    public void San_José_F_blue()
    {
        azulitos[58].SetActive(true);
        normalillos[39].tag = tagNew;
        recolector = normalillos[39];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(San_José_Close);
    }

    public void San_José_Close()
    {
        azulitos[58].SetActive(false);
        normalillos[39].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_San_José();
    }

    public void ResetButtons_San_José()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_San_José_X();
    }

    public void Button_Azul_San_José_X()
    {
        deselect.onClick.RemoveListener(San_José_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //PANAMÁ
    public void Panamá_F_blue()
    {
        azulitos[51].SetActive(true);
        normalillos[33].tag = tagNew;
        recolector = normalillos[33];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Panamá_Close);
    }

    public void Panamá_Close()
    {
        azulitos[51].SetActive(false);
        normalillos[33].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Panamá();
    }

    public void ResetButtons_Panamá()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Panamá_X();
    }

    public void Button_Azul_Panamá_X()
    {
        deselect.onClick.RemoveListener(Panamá_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //MANAGUA
    public void Managua_F_blue()
    {
        azulitos[31].SetActive(true);
        normalillos[7].tag = tagNew;
        recolector = normalillos[7];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Managua_Close);
    }

    public void Managua_Close()
    {
        azulitos[31].SetActive(false);
        normalillos[7].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Managua();
    }

    public void ResetButtons_Managua()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Managua_X();
    }

    public void Button_Azul_Managua_X()
    {
        deselect.onClick.RemoveListener(Managua_Close);
    }
    //--------------------------------------------
    //*********************************************************



    //
    //UNIDAD 2


    //**************************************
    //TEGUCIGALPA
    public void Tegucigalpa_F_blue()
    {
        azulitos[34].SetActive(true);
        normalillos[1].tag = tagNew;
        recolector = normalillos[1];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Tegucigalpa_Close);
    }

    public void Tegucigalpa_Close()
    {
        azulitos[34].SetActive(false);
        normalillos[1].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Tegucigalpa();
    }

    public void ResetButtons_Tegucigalpa()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Tegucigalpa_X();
    }

    public void Button_Azul_Tegucigalpa_X()
    {
        deselect.onClick.RemoveListener(Tegucigalpa_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //NUEVA YORK
    public void Nueva_York_F_blue()
    {
        azulitos[42].SetActive(true);
        normalillos[49].tag = tagNew;
        recolector = normalillos[49];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Nueva_York_Close);
    }

    public void Nueva_York_Close()
    {
        azulitos[42].SetActive(false);
        normalillos[49].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Nueva_York();
    }

    public void ResetButtons_Nueva_York()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Nueva_York_X();
    }

    public void Button_Azul_Nueva_York_X()
    {
        deselect.onClick.RemoveListener(Nueva_York_Close);
    }
    //--------------------------------------------
    //*********************************************************





    //**************************************
    //BUENOS AIRES
    public void Buenos_Aires_F_blue()
    {
        azulitos[28].SetActive(true);
        normalillos[35].tag = tagNew;
        recolector = normalillos[35];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Buenos_Aires_Close);
    }

    public void Buenos_Aires_Close()
    {
        azulitos[28].SetActive(false);
        normalillos[35].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Buenos_Aires();
    }

    public void ResetButtons_Buenos_Aires()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Buenos_Aires_X();
    }

    public void Button_Azul_Buenos_Aires_X()
    {
        deselect.onClick.RemoveListener(Buenos_Aires_Close);
    }
    //--------------------------------------------
    //*********************************************************





    //**************************************
    //OTTAWA
    public void Ottawa_F_blue()
    {
        azulitos[8].SetActive(true);
        normalillos[51].tag = tagNew;
        recolector = normalillos[51];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Ottawa_Close);
    }

    public void Ottawa_Close()
    {
        azulitos[8].SetActive(false);
        normalillos[51].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Ottawa();
    }

    public void ResetButtons_Ottawa()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Ottawa_X();
    }

    public void Button_Azul_Ottawa_X()
    {
        deselect.onClick.RemoveListener(Ottawa_Close);
    }
    //--------------------------------------------
    //*********************************************************





    //**************************************
    //EL CAIRO
    public void El_Cairo_F_blue()
    {
        azulitos[64].SetActive(true);
        normalillos[54].tag = tagNew;
        recolector = normalillos[54];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(El_Cairo_Close);
    }

    public void El_Cairo_Close()
    {
        azulitos[64].SetActive(false);
        normalillos[54].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_El_Cairo();
    }

    public void ResetButtons_El_Cairo()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_El_Cairo_X();
    }

    public void Button_Azul_El_Cairo_X()
    {
        deselect.onClick.RemoveListener(El_Cairo_Close);
    }
    //--------------------------------------------
    //*********************************************************





    //**************************************
    //TORONTO
    public void Toronto_F_blue()
    {
        azulitos[63].SetActive(true);
        normalillos[5].tag = tagNew;
        recolector = normalillos[5];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Toronto_Close);
    }

    public void Toronto_Close()
    {
        azulitos[63].SetActive(false);
        normalillos[5].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Toronto();
    }

    public void ResetButtons_Toronto()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Toronto_X();
    }

    public void Button_Azul_Toronto_X()
    {
        deselect.onClick.RemoveListener(Toronto_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //TRÍPOLI
    public void Trípoli_F_blue()
    {
        azulitos[17].SetActive(true);
        normalillos[32].tag = tagNew;
        recolector = normalillos[32];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Trípoli_Close);
    }

    public void Trípoli_Close()
    {
        azulitos[17].SetActive(false);
        normalillos[32].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Trípoli();
    }

    public void ResetButtons_Trípoli()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Trípoli_X();
    }

    public void Button_Azul_Trípoli_X()
    {
        deselect.onClick.RemoveListener(Trípoli_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //MONTEVIDEO
    public void Monte_video_F_blue()
    {
        azulitos[46].SetActive(true);
        normalillos[9].tag = tagNew;
        recolector = normalillos[9];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Monte_video_Close);
    }

    public void Monte_video_Close()
    {
        azulitos[46].SetActive(false);
        normalillos[9].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Monte_video();
    }

    public void ResetButtons_Monte_video()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Monte_video_X();
    }

    public void Button_Azul_Monte_video_X()
    {
        deselect.onClick.RemoveListener(Monte_video_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //LUANDA
    public void Luanda_F_blue()
    {
        azulitos[60].SetActive(true);
        normalillos[22].tag = tagNew;
        recolector = normalillos[22];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Luanda_Close);
    }

    public void Luanda_Close()
    {
        azulitos[60].SetActive(false);
        normalillos[22].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Luanda();
    }

    public void ResetButtons_Luanda()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Luanda_X();
    }

    public void Button_Azul_Luanda_X()
    {
        deselect.onClick.RemoveListener(Luanda_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //SANTIAGO
    public void Santiago_F_blue()
    {
        azulitos[67].SetActive(true);
        normalillos[68].tag = tagNew;
        recolector = normalillos[68];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Santiago_Close);
    }

    public void Santiago_Close()
    {
        azulitos[67].SetActive(false);
        normalillos[68].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Santiago();
    }

    public void ResetButtons_Santiago()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Santiago_X();
    }

    public void Button_Azul_Santiago_X()
    {
        deselect.onClick.RemoveListener(Santiago_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //ASUNCIÓN
    public void Asunción_F_blue()
    {
        azulitos[36].SetActive(true);
        normalillos[61].tag = tagNew;
        recolector = normalillos[61];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Asunción_Close);
    }

    public void Asunción_Close()
    {
        azulitos[36].SetActive(false);
        normalillos[61].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Asunción();
    }

    public void ResetButtons_Asunción()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Asunción_X();
    }

    public void Button_Azul_Asunción_X()
    {
        deselect.onClick.RemoveListener(Asunción_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //SAN SALVADOR
    public void San_Salvador_F_blue()
    {
        azulitos[12].SetActive(true);
        normalillos[27].tag = tagNew;
        recolector = normalillos[27];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(San_Salvador_Close);
    }

    public void San_Salvador_Close()
    {
        azulitos[12].SetActive(false);
        normalillos[27].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_San_Salvador();
    }

    public void ResetButtons_San_Salvador()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_San_Salvador_X();
    }

    public void Button_Azul_San_Salvador_X()
    {
        deselect.onClick.RemoveListener(San_Salvador_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //BOGOTÁ
    public void Bogotá_F_blue()
    {
        azulitos[52].SetActive(true);
        normalillos[58].tag = tagNew;
        recolector = normalillos[58];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Bogotá_Close);
    }

    public void Bogotá_Close()
    {
        azulitos[52].SetActive(false);
        normalillos[58].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Bogotá();
    }

    public void ResetButtons_Bogotá()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Bogotá_X();
    }

    public void Button_Azul_Bogotá_X()
    {
        deselect.onClick.RemoveListener(Bogotá_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //CARACAS
    public void Caracas_F_blue()
    {
        azulitos[66].SetActive(true);
        normalillos[38].tag = tagNew;
        recolector = normalillos[38];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Caracas_Close);
    }

    public void Caracas_Close()
    {
        azulitos[66].SetActive(false);
        normalillos[38].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Caracas();
    }

    public void ResetButtons_Caracas()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Caracas_X();
    }

    public void Button_Azul_Caracas_X()
    {
        deselect.onClick.RemoveListener(Caracas_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //SANTO DOMINGO
    public void Santo_Domingo_F_blue()
    {
        azulitos[11].SetActive(true);
        normalillos[8].tag = tagNew;
        recolector = normalillos[8];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Santo_Domingo_Close);
    }

    public void Santo_Domingo_Close()
    {
        azulitos[11].SetActive(false);
        normalillos[8].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Santo_Domingo();
    }

    public void ResetButtons_Santo_Domingo()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Santo_Domingo_X();
    }

    public void Button_Azul_Santo_Domingo_X()
    {
        deselect.onClick.RemoveListener(Santo_Domingo_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //QUITO
    public void Quito_F_blue()
    {
        azulitos[32].SetActive(true);
        normalillos[46].tag = tagNew;
        recolector = normalillos[46];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Quito_Close);
    }

    public void Quito_Close()
    {
        azulitos[32].SetActive(false);
        normalillos[46].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Quito();
    }

    public void ResetButtons_Quito()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Quito_X();
    }

    public void Button_Azul_Quito_X()
    {
        deselect.onClick.RemoveListener(Quito_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //MINESOTA
    public void Minesota_F_blue()
    {
        azulitos[65].SetActive(true);
        normalillos[48].tag = tagNew;
        recolector = normalillos[48];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Minesota_Close);
    }

    public void Minesota_Close()
    {
        azulitos[65].SetActive(false);
        normalillos[48].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Minesota();
    }

    public void ResetButtons_Minesota()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Minesota_X();
    }

    public void Button_Azul_Minesota_X()
    {
        deselect.onClick.RemoveListener(Minesota_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //SIRIA
    public void Siria_F_blue()
    {
        azulitos[0].SetActive(true);
        normalillos[3].tag = tagNew;
        recolector = normalillos[3];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Siria_Close);
    }

    public void Siria_Close()
    {
        azulitos[0].SetActive(false);
        normalillos[3].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Siria();
    }

    public void ResetButtons_Siria()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Siria_X();
    }

    public void Button_Azul_Siria_X()
    {
        deselect.onClick.RemoveListener(Siria_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //SOFÍA
    public void Sofía_F_blue()
    {
        azulitos[43].SetActive(true);
        normalillos[65].tag = tagNew;
        recolector = normalillos[65];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Sofía_Close);
    }

    public void Sofía_Close()
    {
        azulitos[43].SetActive(false);
        normalillos[65].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Sofía();
    }

    public void ResetButtons_Sofía()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Sofía_X();
    }

    public void Button_Azul_Sofía_X()
    {
        deselect.onClick.RemoveListener(Sofía_Close);
    }
    //--------------------------------------------
    //*********************************************************









    //**************************************
    //EL CABO
    public void El_Cabo_F_blue()
    {
        azulitos[21].SetActive(true);
        normalillos[45].tag = tagNew;
        recolector = normalillos[45];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(El_Cabo_Close);
    }

    public void El_Cabo_Close()
    {
        azulitos[21].SetActive(false);
        normalillos[45].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_El_Cabo();
    }

    public void ResetButtons_El_Cabo()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_El_Cabo_X();
    }

    public void Button_Azul_El_Cabo_X()
    {
        deselect.onClick.RemoveListener(El_Cabo_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //ANKARA
    public void Ankara_F_blue()
    {
        azulitos[33].SetActive(true);
        normalillos[59].tag = tagNew;
        recolector = normalillos[59];
        recolector.SetActive(false);
        ResetButtons_Ankara();
    }

    public void Ankara_Close()
    {
        azulitos[33].SetActive(false);
        normalillos[59].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Ankara();
    }

    public void ResetButtons_Ankara()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Ankara_X();
    }

    public void Button_Azul_Ankara_X()
    {
        deselect.onClick.RemoveListener(Ankara_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //TÚNEZ
    public void Túnez_F_blue()
    {
        azulitos[6].SetActive(true);
        normalillos[28].tag = tagNew;
        recolector = normalillos[28];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Túnez_Close);
    }

    public void Túnez_Close()
    {
        azulitos[6].SetActive(false);
        normalillos[28].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Túnez();
    }

    public void ResetButtons_Túnez()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Túnez_X();
    }

    public void Button_Azul_Túnez_X()
    {
        deselect.onClick.RemoveListener(Túnez_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //SINGAPUR
    public void Singapur_F_blue()
    {
        azulitos[9].SetActive(true);
        normalillos[50].tag = tagNew;
        recolector = normalillos[50];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Singapur_Close);
    }

    public void Singapur_Close()
    {
        azulitos[9].SetActive(false);
        normalillos[50].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Singapur();
    }

    public void ResetButtons_Singapur()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Singapur_X();
    }

    public void Button_Azul_Singapur_X()
    {
        deselect.onClick.RemoveListener(Singapur_Close);
    }
    //--------------------------------------------
    //*********************************************************




    //**************************************
    //ESLOVAQUIA
    public void Eslovaquia_F_blue()
    {
        azulitos[72].SetActive(true);
        normalillos[30].tag = tagNew;
        recolector = normalillos[30];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Eslovaquia_Close);
    }

    public void Eslovaquia_Close()
    {
        azulitos[72].SetActive(false);
        normalillos[30].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Eslovaquia();
    }

    public void ResetButtons_Eslovaquia()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Eslovaquia_X();
    }

    public void Button_Azul_Eslovaquia_X()
    {
        deselect.onClick.RemoveListener(Eslovaquia_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //HONOLULU
    public void Honolulu_F_blue()
    {
        azulitos[41].SetActive(true);
        normalillos[43].tag = tagNew;
        recolector = normalillos[43];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Honolulu_Close);
    }

    public void Honolulu_Close()
    {
        azulitos[41].SetActive(false);
        normalillos[43].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Honolulu();
    }

    public void ResetButtons_Honolulu()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Honolulu_X();
    }

    public void Button_Azul_Honolulu_X()
    {
        deselect.onClick.RemoveListener(Honolulu_Close);
    }
    //--------------------------------------------
    //*********************************************************








    //**************************************
    //CANBERRA
    public void Canberra_F_blue()
    {
        azulitos[37].SetActive(true);
        normalillos[44].tag = tagNew;
        recolector = normalillos[44];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Canberra_Close);
    }

    public void Canberra_Close()
    {
        azulitos[37].SetActive(false);
        normalillos[44].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Canberra();
    }

    public void ResetButtons_Canberra()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Canberra_X();
    }

    public void Button_Azul_Canberra_X()
    {
        deselect.onClick.RemoveListener(Canberra_Close);
    }
    //--------------------------------------------
    //*********************************************************










    //**************************************
    //BRASILIA
    public void Brasilia_F_blue()
    {
        azulitos[26].SetActive(true);
        normalillos[37].tag = tagNew;
        recolector = normalillos[37];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Brasilia_Close);
    }

    public void Brasilia_Close()
    {
        azulitos[26].SetActive(false);
        normalillos[37].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Brasilia();
    }

    public void ResetButtons_Brasilia()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Brasilia_X();
    }

    public void Button_Azul_Brasilia_X()
    {
        deselect.onClick.RemoveListener(Brasilia_Close);
    }
    //--------------------------------------------
    //*********************************************************









    //**************************************
    //YOKOHAMA
    public void Yokohama_F_blue()
    {
        azulitos[22].SetActive(true);
        normalillos[55].tag = tagNew;
        recolector = normalillos[55];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Yokohama_Close);
    }

    public void Yokohama_Close()
    {
        azulitos[22].SetActive(false);
        normalillos[55].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Yokohama();
    }


    public void ResetButtons_Yokohama()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Yokohama_X();
    }

    public void Button_Azul_Yokohama_X()
    {
        deselect.onClick.RemoveListener(Yokohama_Close);
    }
    //--------------------------------------------
    //*********************************************************










    //**************************************
    //GUATEMALA
    public void Guatemala_F_blue()
    {
        azulitos[4].SetActive(true);
        normalillos[60].tag = tagNew;
        recolector = normalillos[60];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Guatemala_Close);
    }

    public void Guatemala_Close()
    {
        azulitos[4].SetActive(false);
        normalillos[60].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Guatemala();
    }

    public void ResetButtons_Guatemala()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Guatemala_X();
    }

    public void Button_Azul_Guatemala_X()
    {
        deselect.onClick.RemoveListener(Guatemala_Close);
    }
    //--------------------------------------------
    //*********************************************************







    //**************************************
    //WASHINGTON
    public void Washington_F_blue()
    {
        azulitos[23].SetActive(true);
        normalillos[73].tag = tagNew;
        recolector = normalillos[73];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Washington_Close);
    }

    public void Washington_Close()
    {
        azulitos[23].SetActive(false);
        normalillos[73].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Washington();
    }

    public void ResetButtons_Washington()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Washington_X();
    }

    public void Button_Azul_Washington_X()
    {
        deselect.onClick.RemoveListener(Washington_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //DACCA
    public void Dacca_F_blue()
    {
        azulitos[10].SetActive(true);
        normalillos[26].tag = tagNew;
        recolector = normalillos[26];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Dacca_Close);

    }

    public void Dacca_Close()
    {
        azulitos[10].SetActive(false);
        normalillos[26].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Dacca();
    }

    public void ResetButtons_Dacca()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Dacca_X();
    }

    public void Button_Azul_Dacca_X()
    {
        deselect.onClick.RemoveListener(Dacca_Close);
    }
    //--------------------------------------------
    //*********************************************************






    //**************************************
    //HAMBURGO
    public void Hamburgo_F_blue()
    {
        azulitos[62].SetActive(true);
        normalillos[23].tag = tagNew;
        recolector = normalillos[23];
        recolector.SetActive(false);
        ResetButtons_UI();
        InputField_F();
        deselect.onClick.AddListener(Hamburgo_Close);
    }

    public void Hamburgo_Close()
    {
        azulitos[62].SetActive(false);
        normalillos[23].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ResetButtons_Hamburgo();
    }

    public void ResetButtons_Hamburgo()
    {
        deselect_go.SetActive(false);
        open_go.SetActive(true);
        Button_Azul_Hamburgo_X();
    }

    public void Button_Azul_Hamburgo_X()
    {
        deselect.onClick.RemoveListener(Hamburgo_Close);
    }
    //--------------------------------------------
    //*********************************************************




    //AQUÍ TERMINAN LOS EDIFICIOS 
    //************************************

    //AMBOS MÉTODOS SON PARA TODOS LOS EDIFICIOS POR ESO LOS PONGO AL FINAL DE
    //LAS LÍNEAS DE CÓDIGO PARA CUANDO NO TENGAMOS UN EDIFICIO AZUL ACTIVADO EN ESCENA

    //MÉTODO ENCARGADO DE ACTIVAR EL BUTTON AZUL
    //(BUTTON PARA DESELECCIONAR UN EDIFICIO) Y AL MISMO TIEMPO
    //DESACTIVAMOS EL BUTTON ROJO 
    public void ResetButtons_UI()
    {
        //BUTTON ROJO SE DESACTIVA
        close_go.SetActive(false);

        //BUTTON AZUL SE ACTIVA
        deselect_go.SetActive(true);
    }
    //---------------------------------------------------------



    //MÉTODO PARA DESACTIVAR LA INPUTFIELD
    public void InputField_F()
    {
        Inputfield.SetActive(false);
    }
    //----------------------------------------------------------
    //*********************************************************
    //AQUÍ TERMINA EL CÓDIGO EN CASO DE QUE NO HAYA UN EDIFICIO AZUL EN ESCENA :) 
}


