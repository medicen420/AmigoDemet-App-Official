using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
                clavier = null;

            }
            //**********************************************************************************************************

            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESTAMBUL
            if ((Pseudo == "Estambul") || (Pseudo == "estambul") || (Pseudo == "Estambul ") || (Pseudo == "estambul ") ||
                (Pseudo == "ESTAMBUL") || (Pseudo == "ESTAMBUL "))
            {
                //Activamos vibración del celular
                Handheld.Vibrate();


                //SI NO HAY UN EDIFICIO AZUL EN ESCENA
                if (edificio_blue == false)
                {
                    Estambul_F_blue();
                }

                //SI HAY UN EDIFICIO AZUL EN ESCENA
                if (edificio_blue == true)
                {
                    Estambul_T_blue();
                }
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MOSCÚ
            if ((Pseudo == "Moscú") || (Pseudo == "moscú") || (Pseudo == "Moscu") || (Pseudo == "moscu") ||
                (Pseudo == "Moscú ") || (Pseudo == "moscú ") || (Pseudo == "Moscu ") || (Pseudo == "moscu ") ||
                (Pseudo == "MOSCÚ") || (Pseudo == "MOSCU") || (Pseudo == "MOSCÚ ") || (Pseudo == "MOSCU "))
            {
                //Activamos vibración del celular
                Handheld.Vibrate();

                if (edificio_blue == false)
                {
                    Moscú_F_blue();
                }

                if (edificio_blue == true)
                {
                    Moscú_T_blue();
                }


            }

            //SI EL USUARIO NO TIPEA NADA
            else if (Pseudo == " " || Pseudo == "")
            {
                Pseudo = Pseudo2;
            }
            /*//SI NO SE TIPEA UN NOMBRE EXISTENTE SE EJECUTARÁ LO SIGUIENTE
            else
            {
                //SI TIPEAS UN NOMBRE INEXISTENTE 
                //APARECERÁ UN PANEL QUE TE LO HARÁ SABER

                //ACTIVAMOS EL PANEL DE WRONG NAME
                ui.Wrong_Name_Pan.SetActive(true);

                //BUTTON AMARILLO
                //ACTIVAMOS EL BUTTON QUE NOS AYUDARÁ A CERRAR EL PANEL
                ui.close_panel_go.SetActive(true);

                //DESACTIVAMOS EL BUTTON CLOSE
                //ui.close_go.SetActive(false);

                //DESACTIVAMOS LA SEARCH BAR
                //ui.Inputfield.SetActive(false);
                Pseudo = Pseudo2;

            }*/


        }


    }


    //MÉTODOS PARA SELECCIONAR EDIFICIOS





    //MÉTODO SI NO HAY UN EDIFICIO AZUL EN ESCENA
    //BLUE FALSE
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
        deselect.onClick.AddListener(EstambulClose);
    }


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

    //MÉTODO ASIGANDO AL BUTTON AZUL
    //SIRVE PARA DESELCCIONAR EL EDIFICIO
    public void EstambulClose()
    {
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


        //MÉTODO PARA QUITAR EL MÉTODO DEL BUTTON AZUL
        //ESTO LO HAGO YA QUE EL BUTTON AZUL NO TENDRÁ SIEMPRE EL MISMO COMPORTAMIENTO
        //TENDRÁ QUE IR CAMBIANDO DEPENDIENDO DEL EDIFICIO SELECCIONADO
        Button_Azul_Estambul_X();



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

    }
    //-----------------------------------------

    //MÉTODO PARA QUITAR EL COMPORTAMIENTO DEL BUTTON AZUL
    public void Button_Azul_Estambul_X()
    {
        //BUTTON AZUL
        //REMOVEMOS EL COMPORTAMIENTO DEL BUTTON DESELECT
        deselect.onClick.RemoveListener(EstambulClose);
    }
    //------------------------------------------------
    //*********************************************************
    //AQUÍ TERMINA EL CÓDIGO EN CASO DE QUE NO HAYA UN EDIFICIO AZUL EN ESCENA











    //MÉTODO SI HAY UN EDIFICIO AZUL EN ESCENA
    //BLUE TRUE
    //******************************************
    //ESTAMBUL
    public void Estambul_T_blue()
    {
        //DESACTIVAMOS EL EDIFICIO AZUL QUE ESTA ACTIVADO EN ESCENA
        //(PUEDE SER CUALQUIERA DE LOS EDIFICIOS)
        edificio_blue.SetActive(false);

        //AL ESTAR ACTIVADO UN EDIFICIO AZUL
        //POR ENDE TENDRÉ QUE REGRESAR EL TAG QUE ESTABA AL PRINCIPIO
        //(AL EDIFICIO NORMAL)
        recolector.tag = tagNameNormal;

        //ACTIVAMOS EL EDIFICIO NORMAL 
        //DEL EDIFICIO QUE ESTÁ SELECCIONADO EN LA ESCENA
        recolector.SetActive(true);

        //VACIAMOS EL EDIFICIO DEL RECOLECTOR PARA QUE OTRO PUEDA ENTRAR EN CASO DE SELECCIONARSE
        recolector = null;


        //SI EL RECOLECTOR ESTÁ VACIÓ
        if (recolector == null)
        {
            //ACTIVAREMOS EL EDIFICIO AZUL 
            //(ESTAMBUL)
            azulitos[3].SetActive(true);

            //DESACTIVAMOS EL EDIFICIO NORMAL
            //(ESTAMBUL)
            normalillos[41].SetActive(false);

            //CAMBIAMOS EL TAG DEL EDIFICIO NORMAL
            //POR UNO NUEVO
            normalillos[41].tag = tagNew;

            //A LA VARIABLE RECOLECTOR LE ALAMCENAREMOS
            //EL EDIFICIO NORMAL 
            //(ESTAMBUL)
            recolector = normalillos[41];

            //POR ENDE DESACTIVARÉ EL RECOLECTOR 
            //YA QUE TIENE ALMACENADO MI EDIFICIO NORMAL Y NO NECESITARÉ
            //VERLO YA QUE QUIERO VER EL EDIFICIO AZUL
            recolector.SetActive(false);
        }
    }
    //----------------------------------------------------------------------------------
















    //MÉTODO SI NO HAY UN EDIFICIO AZUL EN ESCENA
    //BLUE FALSE
    //**************************************
    //MOSCÚ

    private void Moscú_F_blue()
    {
        //ACTIVAMOS EL EDIFICIO AZUL
        azulitos[57].SetActive(true);

        //CAMBIAMOS EL TAG DEL EDIFICIO NORMAL
        normalillos[16].tag = tagNew;


        //NUESTRA VARIABLE RECOLECTOR LE ALMACENAREMOS 
        //NUESTRO EDIFICIO NORMAL CON EL NUEVO TAG
        recolector = normalillos[16];


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
        deselect.onClick.AddListener(MoscúClose);

    }


    //MÉTODO ASIGANDO AL BUTTON AZUL
    //SIRVE PARA DESELCCIONAR EL EDIFICIO
    public void MoscúClose()
    {
        //DESACTIVAMOS EL EDIFICIO AZUL
        azulitos[57].SetActive(false);

        //LE DEVOLVEMOS EL TAG QUE TENÍA AL PRINCIPIO MI EDIFICIO NORMAL
        normalillos[16].tag = tagNameNormal;

        //ACTIVAMOS EL RECOLECTOR
        //(RECORDEMOS QUE DENTRO DE ESTE SE ENCUENTRA MI EDIFICIO NORMAL)
        recolector.SetActive(true);

        //VACIAMOS EL EDIFICIO DEL RECOLECTOR PARA QUE OTRO PUEDA ENTRAR EN CASO DE SELECCIONARSE
        recolector = null;













        //PARA REGRESAR LOS BUTTONS COMO ESTABAN ANTES DE SELECCIONAR UN EDIFICIO 
        //MANDAMOS LLAMAR AL SIGUIENTE MÉTODO
        ResetButtons_Moscú();


        //MÉTODO PARA QUITAR EL MÉTODO DEL BUTTON AZUL
        //ESTO LO HAGO YA QUE EL BUTTON AZUL NO TENDRÁ SIEMPRE EL MISMO COMPORTAMIENTO
        //TENDRÁ QUE IR CAMBIANDO DEPENDIENDO DEL EDIFICIO SELECCIONADO
        Button_Azul_Moscú_X();

    }
    //************************************************



    //MÉTODO PARA REGRESAR LOS BUTTONS QUE ESTABAN AL PRINCIPIO POR DEFAULT
    public void ResetButtons_Moscú()
    {
        //ACTIVAMOS EL BITTON VERDE
        //BUTTON OPEN
        open_go.SetActive(true);


        //DESACTIVAMOS EL BUTTON AZUL
        //BUTTON DE DESELECCION
        deselect_go.SetActive(false);
    }
    //---------------------------------------------


    //MÉTODO PARA QUITAR EL COMPORTAMIENTO DEL BUTTON AZUL
    public void Button_Azul_Moscú_X()
    {
        //BUTTON AZUL
        //REMOVEMOS EL COMPORTAMIENTO DEL BUTTON DESELECT
        deselect.onClick.RemoveListener(MoscúClose);
    }
    //--------------------------------------------
    //*********************************************************











    //MÉTODO SI HAY UN EDIFICIO AZUL EN ESCENA
    //BLUE TRUE
    //******************************************
    //MOSCÚ
    private void Moscú_T_blue()
    {
        //DESACTIVAMOS EL EDIFICIO AZUL QUE ESTA ACTIVADO EN ESCENA
        //(PUEDE SER CUALQUIERA DE LOS EDIFICIOS)
        edificio_blue.SetActive(false);

        //AL ESTAR ACTIVADO UN EDIFICIO AZUL
        //POR ENDE TENDRÉ QUE REGRESAR EL TAG QUE ESTABA AL PRINCIPIO
        //(AL EDIFICIO NORMAL)
        recolector.tag = tagNameNormal;


        //ACTIVAMOS EL EDIFICIO NORMAL 
        //DEL EDIFICIO QUE ESTÁ SELECCIONADO EN LA ESCENA
        recolector.SetActive(true);


        //VACIAMOS EL EDIFICIO DEL RECOLECTOR PARA QUE OTRO PUEDA ENTRAR EN CASO DE SELECCIONARSE
        recolector = null;



        //SI EL RECOLECTOR ESTÁ VACIÓ
        if (recolector == null)
        {

            //ACTIVAREMOS EL EDIFICIO AZUL 
            //(MOSCÚ)
            azulitos[57].SetActive(true);

            //DESACTIVAMOS EL EDIFICIO NORMAL
            //(MOSCÚ)
            normalillos[16].SetActive(false);

            //CAMBIAMOS EL TAG DEL EDIFICIO NORMAL
            //POR UNO NUEVO
            normalillos[16].tag = tagNew;

            //A LA VARIABLE RECOLECTOR LE ALAMCENAREMOS
            //EL EDIFICIO NORMAL 
            //(ESTAMBUL)
            recolector = normalillos[16];

            //POR ENDE DESACTIVARÉ EL RECOLECTOR 
            //YA QUE TIENE ALMACENADO MI EDIFICIO NORMAL Y NO NECESITARÉ
            //VERLO YA QUE QUIERO VER EL EDIFICIO AZUL
            recolector.SetActive(false);

        }
    }
    //-----------------------------------------------------------------------
    //AQUÍ TERMINA EL CÓDIGO EN CASO DE QUE NO HAYA UN EDIFICIO AZUL EN ESCENA



















    //COMPORTAMIENTO QUE SE ENCARGA DE 
    //CERRAR EL BUTTON CLOSE Y ACTIVAR EL BUTTON AZUL











}


