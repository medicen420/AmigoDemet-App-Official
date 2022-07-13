using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Keyboard : MonoBehaviour
{
    
    public TouchScreenKeyboard clavier;
    //public Text txt;
    public string Pseudo;
    public string Pseudo2 = " ";
    

    //Mandamos llamar a scripts externos a este código
    public SearchBar Searchb;
    //Declaramos una variable para nuestra Script de UI
    public UI User_i;





    //¡ES HORA DEL CINEMACHINE!

    //Básicamente lo que haremos será crear virtual cameras con ayuda de CineMachine
    //de igual forma para que estas cámaras funcionen tendremos que crear multiples TimeLines

    //Primero vamos a mandar llamar a nuestros GameObjects que contienen nuestros TimeLines

    //ESTAMBUL
    public GameObject TimeL_Estambul;
    //OSLO
    /*public GameObject TimeL_Oslo;*/
    //Por el momento este TimeLine contiene una cámara que redirige a nuestra cámara original
    //hacia el edificio Estambul




    public void Start()
    {
        Searchb = FindObjectOfType<SearchBar>();
        User_i = FindObjectOfType<UI>();

        //TimeLines de los edificios
        //aparecen desactivadas al principio

        //ESTAMBUL
        TimeL_Estambul.SetActive(false);
        //OSLO
        /*TimeL_Oslo.SetActive(false);*/


    }

    public void OpenKeyboard()
    {
        clavier = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }


    //ESTE ARREGLO ES PARA QUE VIBRE EL CELULAR 
    //PERO LO CAMBIAMOS AL SCRIPT "Controller_edificios"
    //PARA QUE VIBRE CUANDO SELECCIONAMOS UN EDIFICIO CON DOUBLETOUCH
    /*public void Vibrate()
    {
        Handheld.Vibrate();
    }*/

    public void Update()
    {
        
        if (TouchScreenKeyboard.visible == false && clavier != null)
        {
            if (clavier.status == TouchScreenKeyboard.Status.Done)
            {
                
                Pseudo = clavier.text; 
                //TEXTO QUE APARECE ARRIBA 
                //txt.text = "Aquí está " + Pseudo;
                clavier = null;


                //********************************************************************************************************************************************************


            }

            //******************************
            //¿QUÉ NOMBRE TIPEO EL USUARIO?

            //LA CAGUE Y AHORA HERE WE GO AGAIN JAJAJA



            //***********************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESTAMBUL
            if ((Pseudo == "Estambul") || (Pseudo == "estambul") || (Pseudo == "Estambul ") || (Pseudo == "estambul ") ||
                (Pseudo == "ESTAMBUL") || (Pseudo == "ESTAMBUL "))
            {
                //TimeLine de nuestro edificio
                TimeL_Estambul.SetActive(true);
                //Está línea de código es para que vibre el celular cuando se seleccione el edificio 
                //mediante el tipeo de su nombre
                Handheld.Vibrate();

                //SELECCIONAMOS NUESTRO EDIFICIO
                Searchb.EstambulOpen();
                //EJECUTAMOS MÉTODO QUE SE ENCARGA DE LOS BOTONES EN LA UI
                User_i.ResetButtons_1();


                //DESACTIVAMOS LA SEARCH BAR YA QUE HABREMOS SELECCIONADO UN EDIFICIO 
                User_i.Inputfield.SetActive(false);



                //NOS METEMOS AL SCRIPT DE "Controller_edificios"
                //vamos a declarar que el button azul corresponde a ejecutar 
                //el método EstambulClose()
                User_i.deselect.onClick.AddListener(Searchb.EstambulClose);


                //ESTO SEGUN YO SIRVE PARA QUE NO NOS GENERE CONFLICTO AL MOMENTO DE QUERER
                //TIPEAR OTRO NOMBRE DISTINTO
                //ESTO HACE QUE SE BORRE EL NOMBRE QUE HABÍAMOS PUESTO EN LA PRIMER BÚSQUEDA
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MOSCÚ
            if ((Pseudo == "Moscú") || (Pseudo == "moscú") || (Pseudo == "Moscu") || (Pseudo == "moscu") ||
                (Pseudo == "Moscú ") || (Pseudo == "moscú ") || (Pseudo == "Moscu ") || (Pseudo == "moscu ") ||
                (Pseudo == "MOSCÚ") || (Pseudo == "MOSCU") || (Pseudo == "MOSCÚ ") || (Pseudo == "MOSCU "))
            {
                Handheld.Vibrate();
                Searchb.MoscúOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.MoscúClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BERNA
            if((Pseudo == "Berna") || (Pseudo == "berna") || (Pseudo == "Berna ") || (Pseudo == "berna ") ||
                (Pseudo == "BERNA") || (Pseudo == "BERNA "))
            {
                Handheld.Vibrate();
                Searchb.BernaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BernaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ATENAS
            if ((Pseudo == "Atenas") || (Pseudo == "atenas") || (Pseudo == "Atenas ") || (Pseudo == "atenas ") ||
                (Pseudo == "ATENAS") || (Pseudo == "ATENAS "))
            {
                Handheld.Vibrate();
                Searchb.AtenasOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.AtenasClose);
                Pseudo = Pseudo2;


            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ARGEL
            if ((Pseudo == "Argel") || (Pseudo == "argel") || (Pseudo == "Argel ") || (Pseudo == "argel ") ||
                (Pseudo == "ARGEL") || (Pseudo == "ARGEL "))
            {
                Handheld.Vibrate();
                Searchb.ArgelOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.ArgelClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO OSLO
            if((Pseudo == "Oslo") || (Pseudo == "oslo") || (Pseudo == "Oslo ") || (Pseudo == "oslo ") ||
                (Pseudo == "OSLO") || (Pseudo == "OSLO "))
            {
                Handheld.Vibrate();
                Searchb.OsloOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.OsloClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BULGARIA
            if((Pseudo == "Bulgaria") || (Pseudo == "bulgaria") || (Pseudo == "Bulgaria ") || (Pseudo == "bulgaria ") ||
                (Pseudo == "BULGARIA") || (Pseudo == "BULGARIA "))
            {
                Handheld.Vibrate();
                Searchb.BulgariaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BulgariaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BELGRADO
            if ((Pseudo == "Belgrado") || (Pseudo == "belgrado") || (Pseudo == "Belgrado ") || (Pseudo == "belgrado ") ||
                (Pseudo == "BELGRADO") || (Pseudo == "BELGRADO "))
            {
                Handheld.Vibrate();
                Searchb.BelgradoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BelgradoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SEÚL
            if((Pseudo == "Seúl") || (Pseudo == "seúl") || (Pseudo == "Seúl ") || (Pseudo == "seúl ") ||
                (Pseudo == "Seul") || (Pseudo == "seul") || (Pseudo == "Seul ") || (Pseudo == "seul ") ||
                (Pseudo == "SEÚL") || (Pseudo == "SEÚL ") || (Pseudo == "SEUL") || (Pseudo == "SEUL "))
            {
                Handheld.Vibrate();
                Searchb.SeúlOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SeúlClose);
                Pseudo = Pseudo2;
            }

            
            if ((Pseudo == "Damasco") || (Pseudo == "damasco") || (Pseudo == "Damasco ") || (Pseudo == "damasco ") ||
                (Pseudo == "DAMASCO") || (Pseudo == "DAMASCO "))
            {
                Handheld.Vibrate();
                Searchb.DamascoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.DamascoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO VARSOVIA
            if((Pseudo == "Varsovia") || (Pseudo == "varsovia") || (Pseudo == "Varsovia ") || (Pseudo == "varsovia ") ||
                (Pseudo == "VARSOVIA") || (Pseudo == "VARSOVIA "))
            {
                Handheld.Vibrate();
                Searchb.VarsoviaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.VarsoviaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESTOCOLMO
            if((Pseudo == "Estocolmo") || (Pseudo == "estocolmo") || (Pseudo == "Estocolmo ") || (Pseudo == "estocolmo ") ||
                (Pseudo == "ESTOCOLMO") || (Pseudo == "ESTOCOLMO "))
            {
                Handheld.Vibrate();
                Searchb.EstocolmoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.EstocolmoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PARÍS
            if((Pseudo == "París") || (Pseudo == "parís") || (Pseudo == "París ") || (Pseudo == "parís ") ||
                (Pseudo == "Paris") || (Pseudo == "paris") || (Pseudo == "Paris ") || (Pseudo == "paris ") ||
                (Pseudo == "PARÍS") || (Pseudo == "PARÍS ") || (Pseudo == "PARIS") || (Pseudo == "PARIS "))
            {
                Handheld.Vibrate();
                Searchb.ParísOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.ParísClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MADRID
            if((Pseudo == "Madrid") || (Pseudo == "madrid") || (Pseudo == "Madrid ") || (Pseudo == "madrid ") ||
                (Pseudo == "MADRID") || (Pseudo == "MADRID "))
            {
                Handheld.Vibrate();
                Searchb.MadridOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.MadridClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LISBOA
            if((Pseudo == "Lisboa") || (Pseudo == "lisboa") || (Pseudo == "Lisboa ") || (Pseudo == "lisboa ") ||
                (Pseudo == "LISBOA") || (Pseudo == "LISBOA "))
            {
                Handheld.Vibrate();
                Searchb.LisboaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.LisboaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ROMA
            if ((Pseudo == "Roma") || (Pseudo == "roma") || (Pseudo == "Roma ") || (Pseudo == "roma ") ||
                (Pseudo == "ROMA") || (Pseudo == "ROMA "))
            {
                Handheld.Vibrate();
                Searchb.RomaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.RomaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BRUSELAS
            if ((Pseudo == "Bruselas") || (Pseudo == "bruselas") || (Pseudo == "Bruselas ") || (Pseudo == "bruselas ") ||
                (Pseudo == "BRUSELAS") || (Pseudo == "BRUSELAS "))
            {
                Handheld.Vibrate();
                Searchb.BruselasOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BruselasClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LONDRES

            if ((Pseudo == "Londres") || (Pseudo == "londres") || (Pseudo == "Londres ") || (Pseudo == "londres ") ||
                (Pseudo == "LONDRES") || (Pseudo == "LONDRES "))
            {
                Handheld.Vibrate();
                Searchb.LondresOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.LondresClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ZURICH

            if ((Pseudo == "Zurich") || (Pseudo == "zurich") || (Pseudo == "Zurich ") || (Pseudo == "zurich ") ||
                (Pseudo == "ZURICH") || (Pseudo == "ZURICH "))
            {
                Handheld.Vibrate();
                Searchb.ZurichOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.ZurichClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BERLÍN

            if((Pseudo == "Berlín") || (Pseudo == "berlín") || (Pseudo == "Berlín ") || (Pseudo == "berlín ") ||
                (Pseudo == "Berlin") || (Pseudo == "berlin") || (Pseudo == "Berlin ") || (Pseudo == "berlin ") ||
                (Pseudo == "BERLÍN") || (Pseudo == "BERLÍN ") || (Pseudo == "BERLIN") || (Pseudo == "BERLIN "))
            {
                Handheld.Vibrate();
                Searchb.BerlínOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BerlínClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO VIENA
            if ((Pseudo == "Viena") || (Pseudo == "viena") || (Pseudo == "Viena ") || (Pseudo == "viena ") ||
                (Pseudo == "VIENA") || (Pseudo == "VIENA "))
            {
                Handheld.Vibrate();
                Searchb.VienaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.VienaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PRAGA
            if ((Pseudo == "Praga") || (Pseudo == "praga") || (Pseudo == "Praga ") || (Pseudo == "praga ") ||
                (Pseudo == "PRAGA") || (Pseudo == "PRAGA "))
            {
                Handheld.Vibrate();
                Searchb.PragaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.PragaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO YAKARTA
            if ((Pseudo == "Yakarta") || (Pseudo == "yakarta") || (Pseudo == "Yakarta ") || (Pseudo == "yakarta ") ||
                (Pseudo == "YAKARTA") || (Pseudo == "YAKARTA "))
            {
                Handheld.Vibrate();
                Searchb.YakartaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.YakartaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MÒNACO

            if ((Pseudo == "Mónaco") || (Pseudo == "mónaco") || (Pseudo == "Mónaco ") || (Pseudo == "mónaco ") ||
                (Pseudo == "Monaco") || (Pseudo == "monaco") || (Pseudo == "Monaco ") || (Pseudo == "monaco ") ||
                (Pseudo == "MÓNACO") || (Pseudo == "MÓNACO ") || (Pseudo == "MONACO") || (Pseudo == "MONACO "))
            {
                Handheld.Vibrate();
                Searchb.MónacoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.MónacoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MANILA
            if ((Pseudo == "Manila") || (Pseudo == "manila") || (Pseudo == "Manila ") || (Pseudo == "manila ") ||
                (Pseudo == "MANILA") || (Pseudo == "MANILA "))
            {
                Handheld.Vibrate();
                Searchb.ManilaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.ManilaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO NUEVADELHI
            if((Pseudo == "NuevaDelhi") || (Pseudo == "nuevadelhi") || (Pseudo == "NuevaDelhi ") || (Pseudo == "nuevadelhi ") ||
                (Pseudo == "Nuevadelhi") || (Pseudo == "Nuevadelhi ") || (Pseudo == "NuevaDeli") || (Pseudo == "NuevaDeli ") || 
                (Pseudo == "nuevadeli") || (Pseudo == "nuevadeli ") || (Pseudo == "Nuevadeli") || (Pseudo == "Nuevadeli ") ||

                (Pseudo == "Nueva Delhi") || (Pseudo == "nueva delhi") || (Pseudo == "Nueva Delhi ") || (Pseudo == "nueva delhi ") ||
                (Pseudo == "Nueva delhi") || (Pseudo == "Nueva delhi ") || (Pseudo == "Nueva Deli") || (Pseudo == "Nueva Deli ") ||
                (Pseudo == "nueva deli") || (Pseudo == "nueva deli ") || (Pseudo == "Nueva deli") || (Pseudo == "Nueva deli ") ||

                (Pseudo == "NUEVADELHI") || (Pseudo == "NUEVADELHI ") || (Pseudo == "NUEVADELI") || (Pseudo == "NUEVADELI ") ||
                (Pseudo == "NUEVA DELHI") || (Pseudo == "NUEVA DELHI ") || (Pseudo == "NUEVA DELI") || (Pseudo == "NUEVA DELI "))
            {

                Handheld.Vibrate();
                Searchb.NuevaDelhiOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.NuevaDelhiClose);
                Pseudo = Pseudo2;

            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MÉXICO

            if ((Pseudo == "México") || (Pseudo == "méxico") || (Pseudo == "México ") || (Pseudo == "méxico ") ||
                (Pseudo == "Mexico") || (Pseudo == "mexico") || (Pseudo == "Mexico ") || (Pseudo == "mexico ") ||
                (Pseudo == "MÉXICO") || (Pseudo == "MÉXICO ") || (Pseudo == "MEXICO") || (Pseudo == "MEXICO "))
            {
                Handheld.Vibrate();
                Searchb.MéxicoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.MéxicoClose);
                Pseudo = Pseudo2;
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
                Handheld.Vibrate();
                Searchb.TeheránOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.TeheránClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PEKÍN

            if ((Pseudo == "Pekín") || (Pseudo == "pekín") || (Pseudo == "Pekín ") || (Pseudo == "pekín ") ||
                (Pseudo == "Pekin") || (Pseudo == "pekin") || (Pseudo == "Pekin ") || (Pseudo == "pekin ") ||
                (Pseudo == "PEKÍN") || (Pseudo == "PEKÍN ") || (Pseudo == "PEKIN") || (Pseudo == "PEKIN "))    
            {
                Handheld.Vibrate();
                Searchb.PekínOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.PekínClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BUCAREST
            if ((Pseudo == "Bucarest") || (Pseudo == "bucarest") || (Pseudo == "Bucarest ") || (Pseudo == "bucarest ") ||
                (Pseudo == "BUCAREST") || (Pseudo == "BUCAREST "))
            {
                Handheld.Vibrate();
                Searchb.BucarestOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BucarestClose);
                Pseudo = Pseudo2;
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
                Handheld.Vibrate();
                Searchb.CopennagueOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.CopennagueClose);
                Pseudo = Pseudo2;

            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO AMSTERDAM
            if ((Pseudo == "Amsterdam") || (Pseudo == "amsterdam") || (Pseudo == "Amsterdam ") || (Pseudo == "amsterdam ") ||
                (Pseudo == "AMSTERDAM") || (Pseudo == "AMSTERDAM "))
            {
                Handheld.Vibrate();
                Searchb.AmsterdamOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.AmsterdamClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SAIGON
            if ((Pseudo == "Saigón") || (Pseudo == "saigón") || (Pseudo == "Saigón ") || (Pseudo == "saigón ") ||
                (Pseudo == "Saigon") || (Pseudo == "saigon") || (Pseudo == "Saigon ") || (Pseudo == "saigon ") ||
                (Pseudo == "SAIGÓN") || (Pseudo == "SAIGÓN ") || (Pseudo == "SAIGON") || (Pseudo == "SAIGON "))
            {
                Handheld.Vibrate();
                Searchb.SaigónOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SaigónClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TAIPÉI
            if ((Pseudo == "Taipéi") || (Pseudo == "taipéi") || (Pseudo == "Taipéi ") || (Pseudo == "taipéi ") ||
                (Pseudo == "Taipei") || (Pseudo == "taipei") || (Pseudo == "Taipei ") || (Pseudo == "taipei ") ||
                (Pseudo == "TAIPÉI") || (Pseudo == "TAIPÉI ") || (Pseudo == "TAIPEI") || (Pseudo == "TAIPEI "))
            {
                Handheld.Vibrate();
                Searchb.TaipéiOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.TaipéiClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TOKIO
            if ((Pseudo == "Tokio") || (Pseudo == "tokio") || (Pseudo == "Tokio ") || (Pseudo == "tokio ") ||
                (Pseudo == "TOKIO") || (Pseudo == "TOKIO "))
            {
                Handheld.Vibrate();
                Searchb.TokioOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.TokioClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SANJUAN
            if((Pseudo == "SanJuan") || (Pseudo == "sanjuan") || (Pseudo == "SanJuan ") || (Pseudo == "sanjuan ") || 
                (Pseudo == "San Juan") || (Pseudo == "san juan") || (Pseudo == "San Juan ") || (Pseudo == "san juan ") || 
                (Pseudo == "San juan") || (Pseudo == "San juan ") ||
                (Pseudo == "SAN JUAN") || (Pseudo == "SAN JUAN ") || (Pseudo == "SANJUAN") || (Pseudo == "SANJUAN "))
            {
                Handheld.Vibrate();
                Searchb.SanJuanOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SanJuanClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO KINGSTON
            if ((Pseudo == "Kingston") || (Pseudo == "kingston") || (Pseudo == "Kingston ") || (Pseudo == "kingston ") ||
                (Pseudo == "KINGSTON") || (Pseudo == "KINGSTON "))
            {
                Handheld.Vibrate();
                Searchb.KingstonOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.KingstonClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO HABANA
            if ((Pseudo == "Habana") || (Pseudo == "habana") || (Pseudo == "Habana ") || (Pseudo == "habana ") ||
                (Pseudo == "HABANA") || (Pseudo == "HABANA "))
            {
                Handheld.Vibrate();
                Searchb.HabanaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.HabanaClose);
                Pseudo = Pseudo2;
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
                Handheld.Vibrate();
                Searchb.SanJoséOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SanJoséClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PANAMÁ
            if ((Pseudo == "Panamá") || (Pseudo == "panamá") || (Pseudo == "Panamá ") || (Pseudo == "panamá ") ||
                (Pseudo == "Panama") || (Pseudo == "panama") || (Pseudo == "Panama ") || (Pseudo == "panama ") ||
                (Pseudo == "PANAMÁ") || (Pseudo == "PANAMÁ ") || (Pseudo == "PANAMA") || (Pseudo == "PANAMA "))
            {
                Handheld.Vibrate();
                Searchb.SaigónOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SaigónClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MANAGUA
            if ((Pseudo == "Managua") || (Pseudo == "managua") || (Pseudo == "Managua ") || (Pseudo == "managua ") ||
                (Pseudo == "MANAGUA") || (Pseudo == "MANAGUA "))
            {
                Handheld.Vibrate();
                Searchb.ManaguaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.ManaguaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TEGUCIGALPA
            if ((Pseudo == "Tegucigalpa") || (Pseudo == "tegucigalpa") || (Pseudo == "Tegucigalpa ") || (Pseudo == "tegucigalpa ") ||
                (Pseudo == "TEGUCIGALPA") || (Pseudo == "TEGUCIGALPA "))
            {
                Handheld.Vibrate();
                Searchb.TegucigalpaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.TegucigalpaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO NUEVAYORK
            if ((Pseudo == "NuevaYork") || (Pseudo == "nuevayork") || (Pseudo == "NuevaYork ") || (Pseudo == "nuevayork ") ||
                (Pseudo == "Nueva York") || (Pseudo == "nueva york") || (Pseudo == "Nueva York ") || (Pseudo == "nueva york ") ||
                (Pseudo == "Nueva york") || (Pseudo == "Nueva york ") || 
                (Pseudo == "NUEVAYORK") || (Pseudo == "NUEVAYORK ") || (Pseudo == "NUEVA YORK") || (Pseudo == "NUEVA YORK "))
            {
                Handheld.Vibrate();
                Searchb.NuevaYorkOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.NuevaYorkClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BUENOSAIRES
            if ((Pseudo == "BuenosAires") || (Pseudo == "buenosaires") || (Pseudo == "BuenosAires ") || (Pseudo == " ") ||
                (Pseudo == "Buenos Aires") || (Pseudo == "buenos aires") || (Pseudo == "Buenos Aires ") || (Pseudo == "buenos aires ") ||
                (Pseudo == "Buenos aires") || (Pseudo == "Buenos aires ") ||
                (Pseudo == "BUENOSAIRES") || (Pseudo == "BUENOSAIRES ") || (Pseudo == "BUENOS AIRES") || (Pseudo == "BUENOS AIRES "))
            {
                Handheld.Vibrate();
                Searchb.BuenosAiresOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BuenosAiresClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO OTAWA
            if ((Pseudo == "Otawa") || (Pseudo == "otawa") || (Pseudo == "Otawa ") || (Pseudo == "otawa ") ||
                (Pseudo == "Otagua") || (Pseudo == "otagua") || (Pseudo == "Otagua ") || (Pseudo == "otagua ") ||
                (Pseudo == "OTAWA") || (Pseudo == "OTAWA ") || (Pseudo == "OTAGUA") || (Pseudo == "OTAGUA "))
            {
                Handheld.Vibrate();
                Searchb.OtawaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.OtawaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO EL CAIRO
            if((Pseudo == "El Cairo") || (Pseudo == "el cairo") || (Pseudo == "El Cairo ") || (Pseudo == "el cairo ") || 
                (Pseudo == "El cairo") || (Pseudo == "El cairo ") || (Pseudo == "Cairo") || (Pseudo == "cairo") || (Pseudo == "Cairo ") || (Pseudo == "cairo ") ||
                (Pseudo == "EL CAIRO") || (Pseudo == "EL CAIRO ") || (Pseudo == "CAIRO") || (Pseudo == "CAIRO "))
            {
                Handheld.Vibrate();
                Searchb.ElCairoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.ElCairoClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TORONTO
            if ((Pseudo == "Toronto") || (Pseudo == "toronto") || (Pseudo == "Toronto ") || (Pseudo == "toronto ") ||
                (Pseudo == "TORONTO") || (Pseudo == "TORONTO "))
            {
                Handheld.Vibrate();
                Searchb.TorontoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.TorontoClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TRÍPOLI
            if ((Pseudo == "Trípoli") || (Pseudo == "trípoli") || (Pseudo == "Trípoli ") || (Pseudo == "trípoli ") ||
                (Pseudo == "Tripoli") || (Pseudo == "tripoli") || (Pseudo == "Tripoli ") || (Pseudo == "tripoli ") ||
                (Pseudo == "TRÍPOLI") || (Pseudo == "TRÍPOLI ") || (Pseudo == "TRIPOLI") || (Pseudo == "TRIPOLI "))
            {
                Handheld.Vibrate();
                Searchb.TrípoliOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.TrípoliClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MONTEVIDEO
            if ((Pseudo == "MonteVideo") || (Pseudo == "montevideo") || (Pseudo == "MonteVideo ") || (Pseudo == "montevideo ") ||
                (Pseudo == "Monte Video") || (Pseudo == "monte video") || (Pseudo == "Monte Video ") || (Pseudo == "monte video ") ||
                (Pseudo == "Monte video") || (Pseudo == "Monte video ") ||
                (Pseudo == "MONTEVIDEO") || (Pseudo == "MONTEVIDEO ") || (Pseudo == "MONTE VIDEO") || (Pseudo == "MONTE VIDEO "))
            {
                Handheld.Vibrate();
                Searchb.MonteVideoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.MonteVideoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LUANDA
            if ((Pseudo == "Luanda") || (Pseudo == "luanda") || (Pseudo == "Luanda ") || (Pseudo == "luanda ") ||
                (Pseudo == "LUANDA") || (Pseudo == "LUANDA "))
            {
                Handheld.Vibrate();
                Searchb.LuandaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.LuandaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SANTIAGO
            if ((Pseudo == "Santiago") || (Pseudo == "santiago") || (Pseudo == "Santiago ") || (Pseudo == "santiago ") ||
                (Pseudo == "SANTIAGO") || (Pseudo == "SANTIAGO "))
            {
                Handheld.Vibrate();
                Searchb.SantiagoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SantiagoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ASUNCIÓN
            if ((Pseudo == "Asunción") || (Pseudo == "asunción") || (Pseudo == "Asunción ") || (Pseudo == "asunción ") ||
                (Pseudo == "Asuncion") || (Pseudo == "asuncion") || (Pseudo == "Asuncion ") || (Pseudo == "asuncion ") ||
                (Pseudo == "ASUNCIÓN") || (Pseudo == "ASUNCIÓN ") || (Pseudo == "ASUNCION") || (Pseudo == "ASUNCION "))
            {
                Handheld.Vibrate();
                Searchb.AsunciónOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.AsunciónClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SAN SALVADOR
            if ((Pseudo == "SanSalvador") || (Pseudo == "sansalvador") || (Pseudo == "SanSalvador ") || (Pseudo == "sansalvador ") ||
                (Pseudo == "San Salvador") || (Pseudo == "san salvador") || (Pseudo == "San Salvador ") || (Pseudo == "san salvador ") ||
                (Pseudo == "San salvador") || (Pseudo == "San salvador ") ||
                (Pseudo == "SANSALVADOR") || (Pseudo == "SANSALVADOR ") || (Pseudo == "SAN SALVADOR") || (Pseudo == "SAN SALVADOR "))
            {
                Handheld.Vibrate();
                Searchb.SanSalvadorOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SanSalvadorClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BOGOTÁ
            if ((Pseudo == "Bogotá") || (Pseudo == "bogotá") || (Pseudo == "Bogotá ") || (Pseudo == "bogotá ") ||
                (Pseudo == "Bogota") || (Pseudo == "bogota") || (Pseudo == "Bogota ") || (Pseudo == "bogota ") ||
                (Pseudo == "BOGOTÁ") || (Pseudo == "BOGOTÁ ") || (Pseudo == "BOGOTA") || (Pseudo == "BOGOTA "))
            {
                Handheld.Vibrate();
                Searchb.BogotáOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BogotáClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO CARACAS
            if ((Pseudo == "Caracas") || (Pseudo == "caracas") || (Pseudo == "Caracas ") || (Pseudo == "caracas ") ||
                (Pseudo == "CARACAS") || (Pseudo == "CARACAS "))
            {
                Handheld.Vibrate();
                Searchb.CaracasOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.CaracasClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SANTO DOMINGO
            if ((Pseudo == "SantoDomingo") || (Pseudo == "santodomingo") || (Pseudo == "SantoDomingo ") || (Pseudo == "santodomingo ") ||
                (Pseudo == "Santo Domingo") || (Pseudo == "santo domingo") || (Pseudo == "Santo Domingo ") || (Pseudo == "santo domingo ") ||
                (Pseudo == "Santo domingo") || (Pseudo == "Santo domingo ") ||
                (Pseudo == "SANTODOMINGO") || (Pseudo == "SANTODOMINGO ") || (Pseudo == "SANTO DOMINGO") || (Pseudo == "SANTO DOMINGO "))
            {
                Handheld.Vibrate();
                Searchb.SantoDomingoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SantoDomingoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO QUITO
            if ((Pseudo == "Quito") || (Pseudo == "quito") || (Pseudo == "Quito ") || (Pseudo == "quito ") ||
                (Pseudo == "QUITO") || (Pseudo == "QUITO "))
            {
                Handheld.Vibrate();
                Searchb.QuitoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.QuitoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MINESOTA
            if ((Pseudo == "Minesota") || (Pseudo == "minesota") || (Pseudo == "Minesota ") || (Pseudo == "minesota ") ||
                (Pseudo == "MINESOTA") || (Pseudo == "MINESOTA "))
            {
                Handheld.Vibrate();
                Searchb.MinesotaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.MinesotaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SIRIA
            if ((Pseudo == "Siria") || (Pseudo == "siria") || (Pseudo == "Siria ") || (Pseudo == "siria ") ||
                (Pseudo == "SIRIA") || (Pseudo == "SIRIA "))
            {
                Handheld.Vibrate();
                Searchb.SiriaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SiriaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SOFÍA
            if((Pseudo == "Sofía") || (Pseudo == "sofía") || (Pseudo == "Sofía ") || (Pseudo == "sofía ") || 
                (Pseudo == "Sofia") || (Pseudo == "sofia") || (Pseudo == "Sofia ") || (Pseudo == "sofia ") ||
                (Pseudo == "SOFÍA") || (Pseudo == "SOFÍA ") || (Pseudo == "SOFIA") || (Pseudo == "SOFIA "))
            {
                Handheld.Vibrate();
                Searchb.SofíaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SofíaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO EL CABO
            if ((Pseudo == "El Cabo") || (Pseudo == "el cabo") || (Pseudo == "El Cabo ") || (Pseudo == "el cabo ") ||
                (Pseudo == "El cabo") || (Pseudo == "El cabo ") || (Pseudo == "Cabo") || (Pseudo == "cabo") || (Pseudo == "Cabo ") || (Pseudo == "cabo ") ||
                (Pseudo == "EL CABO") || (Pseudo == "EL CABO ") || (Pseudo == "CABO") || (Pseudo == "CABO "))
            {
                Handheld.Vibrate();
                Searchb.ElCaboOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.ElCaboClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ANKARA
            if ((Pseudo == "Ankara") || (Pseudo == "ankara") || (Pseudo == "Ankara ") || (Pseudo == "ankara ") ||
                (Pseudo == "ANKARA") || (Pseudo == "ANKARA "))
            {
                Handheld.Vibrate();
                Searchb.AnkaraOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.AnkaraClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TÚNEZ
            if ((Pseudo == "Túnez") || (Pseudo == "túnez") || (Pseudo == "Túnez ") || (Pseudo == "túnez ") ||
                (Pseudo == "Tunez") || (Pseudo == "tunez") || (Pseudo == "Tunez ") || (Pseudo == "tunez ") ||
                (Pseudo == "TÚNEZ") || (Pseudo == "TÚNEZ ") || (Pseudo == "TUNEZ") || (Pseudo == "TUNEZ "))
            {
                Handheld.Vibrate();
                Searchb.TúnezOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.TúnezClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SINGAPUR
            if ((Pseudo == "Singapur") || (Pseudo == "singapur") || (Pseudo == "Singapur ") || (Pseudo == "singapur ") ||
                (Pseudo == "SINGAPUR") || (Pseudo == "SINGAPUR "))
            {
                Handheld.Vibrate();
                Searchb.SingapurOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.SingapurClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESLOVAQUIA
            if ((Pseudo == "Eslovaquia") || (Pseudo == "eslovaquia") || (Pseudo == "Eslovaquia ") || (Pseudo == "eslovaquia ") ||
                (Pseudo == "ESLOVAQUIA") || (Pseudo == "ESLOVAQUIA "))
            {
                Handheld.Vibrate();
                Searchb.EslovaquiaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.EslovaquiaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO HONOLULU
            if ((Pseudo == "Honolulu") || (Pseudo == "honolulu") || (Pseudo == "Honolulu ") || (Pseudo == "honolulu ") ||
                (Pseudo == "Onolulu") || (Pseudo == "onolulu") || (Pseudo == "Onolulu ") || (Pseudo == "onolulu ") ||
                (Pseudo == "HONOLULU") || (Pseudo == "HONOLULU ") || (Pseudo == "ONOLULU") || (Pseudo == "ONOLULU "))
            {
                Handheld.Vibrate();
                Searchb.HonoluluOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.HonoluluClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO CANBERRA
            if ((Pseudo == "Canberra") || (Pseudo == "canberra") || (Pseudo == "Canberra ") || (Pseudo == "canberra ") ||
                (Pseudo == "Canbera") || (Pseudo == "canbera") || (Pseudo == "Canbera ") || (Pseudo == "canbera ") ||
                (Pseudo == "CANBERRA") || (Pseudo == "CANBERRA ") || (Pseudo == "CANBERA") || (Pseudo == "CANBERA "))
            {
                Handheld.Vibrate();
                Searchb.CanberraOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.CanberraClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BRASILIA
            if ((Pseudo == "Brasilia") || (Pseudo == "brasilia") || (Pseudo == "Brasilia ") || (Pseudo == "brasilia ") ||
                (Pseudo == "BRASILIA") || (Pseudo == "BRASILIA "))
            {
                Handheld.Vibrate();
                Searchb.BrasiliaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.BrasiliaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO YOKOHAMA
            if ((Pseudo == "Yokohama") || (Pseudo == "yokohama") || (Pseudo == "Yokohama ") || (Pseudo == "yokohama ") ||
                (Pseudo == "YOKOHAMA") || (Pseudo == "YOKOHAMA "))
            {
                Handheld.Vibrate();
                Searchb.YokohamaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.YokohamaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO GUATEMALA
            if ((Pseudo == "Guatemala") || (Pseudo == "guatemala") || (Pseudo == "Guatemala ") || (Pseudo == "guatemala ") ||
                (Pseudo == "GUATEMALA") || (Pseudo == "GUATEMALA "))
            {
                Handheld.Vibrate();
                Searchb.GuatemalaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.GuatemalaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO WASHINGTON
            if ((Pseudo == "Washington") || (Pseudo == "washington") || (Pseudo == "Washington ") || (Pseudo == "washington ") ||
                (Pseudo == "WASHINGTON") || (Pseudo == "WASHINGTON "))
            {
                Handheld.Vibrate();
                Searchb.WashingtonOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.WashingtonClose);
                Pseudo = Pseudo2;
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
                Handheld.Vibrate();
                Searchb.DaccaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.DaccaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO HAMBURGO
            if ((Pseudo == "Hamburgo") || (Pseudo == "hamburgo") || (Pseudo == "Hamburgo ") || (Pseudo == "hamburgo ") ||
                (Pseudo == "Amburgo") || (Pseudo == "amburgo") || (Pseudo == "Amburgo ") || (Pseudo == "amburgo ") ||
                (Pseudo == "HAMBURGO") || (Pseudo == "HAMBURGO ") || (Pseudo == "AMBURGO") || (Pseudo == "AMBURGO "))
            {
                Handheld.Vibrate();
                Searchb.HamburgoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(Searchb.HamburgoClose);
                Pseudo = Pseudo2;
            }
            //**************************************************************************************************************


            //SI EL USUARIO NO TIPEA NADA
            else if (Pseudo == " " || Pseudo == "")
            {
                Pseudo = Pseudo2;
            }
            //SI NO SE TIPEA UN NOMBRE EXISTENTE SE EJECUTARÁ LO SIGUIENTE
            else
            {
                //SI TIPEAS UN NOMBRE INEXISTENTE 
                //APARECERÁ UN PANEL QUE TE LO HARÁ SABER

                //ACTIVAMOS EL PANEL DE WRONG NAME
                User_i.Panel.SetActive(true);
                //ACTIVAMOS EL BUTTON QUE NOS AYUDARÁ A CERRAR EL PANEL
                User_i.close_panel_go.SetActive(true);

                //DESACTIVAMOS EL BUTTON CLOSE
                User_i.close_go.SetActive(false);
                //DESACTIVAMOS LA SEARCH BAR
                User_i.Inputfield.SetActive(false);
                Pseudo = Pseudo2;

            }






        }


    }

}
