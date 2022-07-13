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
    public Controller_edificios cont_ed;
    //Declaramos una variable para nuestra Script de UI
    public UI User_i;

    


    public void Start()
    {
        cont_ed = FindObjectOfType<Controller_edificios>();
        User_i = FindObjectOfType<UI>();
        
       

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
                //Está línea de código es para que vibre el celular cuando se seleccione el edificio 
                //mediante el tipeo de su nombre
                Handheld.Vibrate();

                //SELECCIONAMOS NUESTRO EDIFICIO
                cont_ed.EstambulOpen();
                //EJECUTAMOS MÉTODO QUE SE ENCARGA DE LOS BOTONES EN LA UI
                User_i.ResetButtons_1();


                //DESACTIVAMOS LA SEARCH BAR YA QUE HABREMOS SELECCIONADO UN EDIFICIO 
                User_i.Inputfield.SetActive(false);



                //NOS METEMOS AL SCRIPT DE "Controller_edificios"
                //vamos a declarar que el button azul corresponde a ejecutar 
                //el método EstambulClose()
                User_i.deselect.onClick.AddListener(cont_ed.EstambulClose);


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
                cont_ed.MoscúOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.MoscúClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BERNA
            if((Pseudo == "Berna") || (Pseudo == "berna") || (Pseudo == "Berna ") || (Pseudo == "berna ") ||
                (Pseudo == "BERNA") || (Pseudo == "BERNA "))
            {
                Handheld.Vibrate();
                cont_ed.BernaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BernaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ATENAS
            if ((Pseudo == "Atenas") || (Pseudo == "atenas") || (Pseudo == "Atenas ") || (Pseudo == "atenas ") ||
                (Pseudo == "ATENAS") || (Pseudo == "ATENAS "))
            {
                Handheld.Vibrate();
                cont_ed.AtenasOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.AtenasClose);
                Pseudo = Pseudo2;


            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ARGEL
            if ((Pseudo == "Argel") || (Pseudo == "argel") || (Pseudo == "Argel ") || (Pseudo == "argel ") ||
                (Pseudo == "ARGEL") || (Pseudo == "ARGEL "))
            {
                Handheld.Vibrate();
                cont_ed.ArgelOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.ArgelClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO OSLO
            if((Pseudo == "Oslo") || (Pseudo == "oslo") || (Pseudo == "Oslo ") || (Pseudo == "oslo ") ||
                (Pseudo == "OSLO") || (Pseudo == "OSLO "))
            {
                Handheld.Vibrate();
                cont_ed.OsloOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.OsloClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BULGARIA
            if((Pseudo == "Bulgaria") || (Pseudo == "bulgaria") || (Pseudo == "Bulgaria ") || (Pseudo == "bulgaria ") ||
                (Pseudo == "BULGARIA") || (Pseudo == "BULGARIA "))
            {
                Handheld.Vibrate();
                cont_ed.BulgariaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BulgariaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BELGRADO
            if ((Pseudo == "Belgrado") || (Pseudo == "belgrado") || (Pseudo == "Belgrado ") || (Pseudo == "belgrado ") ||
                (Pseudo == "BELGRADO") || (Pseudo == "BELGRADO "))
            {
                Handheld.Vibrate();
                cont_ed.BelgradoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BelgradoClose);
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
                cont_ed.SeúlOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SeúlClose);
                Pseudo = Pseudo2;
            }

            
            if ((Pseudo == "Damasco") || (Pseudo == "damasco") || (Pseudo == "Damasco ") || (Pseudo == "damasco ") ||
                (Pseudo == "DAMASCO") || (Pseudo == "DAMASCO "))
            {
                Handheld.Vibrate();
                cont_ed.DamascoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.DamascoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO VARSOVIA
            if((Pseudo == "Varsovia") || (Pseudo == "varsovia") || (Pseudo == "Varsovia ") || (Pseudo == "varsovia ") ||
                (Pseudo == "VARSOVIA") || (Pseudo == "VARSOVIA "))
            {
                Handheld.Vibrate();
                cont_ed.VarsoviaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.VarsoviaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESTOCOLMO
            if((Pseudo == "Estocolmo") || (Pseudo == "estocolmo") || (Pseudo == "Estocolmo ") || (Pseudo == "estocolmo ") ||
                (Pseudo == "ESTOCOLMO") || (Pseudo == "ESTOCOLMO "))
            {
                Handheld.Vibrate();
                cont_ed.EstocolmoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.EstocolmoClose);
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
                cont_ed.ParísOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.ParísClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MADRID
            if((Pseudo == "Madrid") || (Pseudo == "madrid") || (Pseudo == "Madrid ") || (Pseudo == "madrid ") ||
                (Pseudo == "MADRID") || (Pseudo == "MADRID "))
            {
                Handheld.Vibrate();
                cont_ed.MadridOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.MadridClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LISBOA
            if((Pseudo == "Lisboa") || (Pseudo == "lisboa") || (Pseudo == "Lisboa ") || (Pseudo == "lisboa ") ||
                (Pseudo == "LISBOA") || (Pseudo == "LISBOA "))
            {
                Handheld.Vibrate();
                cont_ed.LisboaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.LisboaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ROMA
            if ((Pseudo == "Roma") || (Pseudo == "roma") || (Pseudo == "Roma ") || (Pseudo == "roma ") ||
                (Pseudo == "ROMA") || (Pseudo == "ROMA "))
            {
                Handheld.Vibrate();
                cont_ed.RomaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.RomaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BRUSELAS
            if ((Pseudo == "Bruselas") || (Pseudo == "bruselas") || (Pseudo == "Bruselas ") || (Pseudo == "bruselas ") ||
                (Pseudo == "BRUSELAS") || (Pseudo == "BRUSELAS "))
            {
                Handheld.Vibrate();
                cont_ed.BruselasOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BruselasClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LONDRES

            if ((Pseudo == "Londres") || (Pseudo == "londres") || (Pseudo == "Londres ") || (Pseudo == "londres ") ||
                (Pseudo == "LONDRES") || (Pseudo == "LONDRES "))
            {
                Handheld.Vibrate();
                cont_ed.LondresOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.LondresClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ZURICH

            if ((Pseudo == "Zurich") || (Pseudo == "zurich") || (Pseudo == "Zurich ") || (Pseudo == "zurich ") ||
                (Pseudo == "ZURICH") || (Pseudo == "ZURICH "))
            {
                Handheld.Vibrate();
                cont_ed.ZurichOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.ZurichClose);
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
                cont_ed.BerlínOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BerlínClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO VIENA
            if ((Pseudo == "Viena") || (Pseudo == "viena") || (Pseudo == "Viena ") || (Pseudo == "viena ") ||
                (Pseudo == "VIENA") || (Pseudo == "VIENA "))
            {
                Handheld.Vibrate();
                cont_ed.VienaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.VienaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO PRAGA
            if ((Pseudo == "Praga") || (Pseudo == "praga") || (Pseudo == "Praga ") || (Pseudo == "praga ") ||
                (Pseudo == "PRAGA") || (Pseudo == "PRAGA "))
            {
                Handheld.Vibrate();
                cont_ed.PragaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.PragaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO YAKARTA
            if ((Pseudo == "Yakarta") || (Pseudo == "yakarta") || (Pseudo == "Yakarta ") || (Pseudo == "yakarta ") ||
                (Pseudo == "YAKARTA") || (Pseudo == "YAKARTA "))
            {
                Handheld.Vibrate();
                cont_ed.YakartaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.YakartaClose);
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
                cont_ed.MónacoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.MónacoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MANILA
            if ((Pseudo == "Manila") || (Pseudo == "manila") || (Pseudo == "Manila ") || (Pseudo == "manila ") ||
                (Pseudo == "MANILA") || (Pseudo == "MANILA "))
            {
                Handheld.Vibrate();
                cont_ed.ManilaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.ManilaClose);
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
                cont_ed.NuevaDelhiOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.NuevaDelhiClose);
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
                cont_ed.MéxicoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.MéxicoClose);
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
                cont_ed.TeheránOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.TeheránClose);
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
                cont_ed.PekínOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.PekínClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BUCAREST
            if ((Pseudo == "Bucarest") || (Pseudo == "bucarest") || (Pseudo == "Bucarest ") || (Pseudo == "bucarest ") ||
                (Pseudo == "BUCAREST") || (Pseudo == "BUCAREST "))
            {
                Handheld.Vibrate();
                cont_ed.BucarestOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BucarestClose);
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
                cont_ed.CopennagueOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.CopennagueClose);
                Pseudo = Pseudo2;

            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO AMSTERDAM
            if ((Pseudo == "Amsterdam") || (Pseudo == "amsterdam") || (Pseudo == "Amsterdam ") || (Pseudo == "amsterdam ") ||
                (Pseudo == "AMSTERDAM") || (Pseudo == "AMSTERDAM "))
            {
                Handheld.Vibrate();
                cont_ed.AmsterdamOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.AmsterdamClose);
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
                cont_ed.SaigónOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SaigónClose);
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
                cont_ed.TaipéiOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.TaipéiClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TOKIO
            if ((Pseudo == "Tokio") || (Pseudo == "tokio") || (Pseudo == "Tokio ") || (Pseudo == "tokio ") ||
                (Pseudo == "TOKIO") || (Pseudo == "TOKIO "))
            {
                Handheld.Vibrate();
                cont_ed.TokioOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.TokioClose);
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
                cont_ed.SanJuanOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SanJuanClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO KINGSTON
            if ((Pseudo == "Kingston") || (Pseudo == "kingston") || (Pseudo == "Kingston ") || (Pseudo == "kingston ") ||
                (Pseudo == "KINGSTON") || (Pseudo == "KINGSTON "))
            {
                Handheld.Vibrate();
                cont_ed.KingstonOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.KingstonClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO HABANA
            if ((Pseudo == "Habana") || (Pseudo == "habana") || (Pseudo == "Habana ") || (Pseudo == "habana ") ||
                (Pseudo == "HABANA") || (Pseudo == "HABANA "))
            {
                Handheld.Vibrate();
                cont_ed.HabanaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.HabanaClose);
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
                cont_ed.SanJoséOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SanJoséClose);
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
                cont_ed.SaigónOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SaigónClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MANAGUA
            if ((Pseudo == "Managua") || (Pseudo == "managua") || (Pseudo == "Managua ") || (Pseudo == "managua ") ||
                (Pseudo == "MANAGUA") || (Pseudo == "MANAGUA "))
            {
                Handheld.Vibrate();
                cont_ed.ManaguaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.ManaguaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TEGUCIGALPA
            if ((Pseudo == "Tegucigalpa") || (Pseudo == "tegucigalpa") || (Pseudo == "Tegucigalpa ") || (Pseudo == "tegucigalpa ") ||
                (Pseudo == "TEGUCIGALPA") || (Pseudo == "TEGUCIGALPA "))
            {
                Handheld.Vibrate();
                cont_ed.TegucigalpaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.TegucigalpaClose);
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
                cont_ed.NuevaYorkOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.NuevaYorkClose);
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
                cont_ed.BuenosAiresOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BuenosAiresClose);
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
                cont_ed.OtawaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.OtawaClose);
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
                cont_ed.ElCairoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.ElCairoClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO TORONTO
            if ((Pseudo == "Toronto") || (Pseudo == "toronto") || (Pseudo == "Toronto ") || (Pseudo == "toronto ") ||
                (Pseudo == "TORONTO") || (Pseudo == "TORONTO "))
            {
                Handheld.Vibrate();
                cont_ed.TorontoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.TorontoClose);
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
                cont_ed.TrípoliOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.TrípoliClose);
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
                cont_ed.MonteVideoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.MonteVideoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO LUANDA
            if ((Pseudo == "Luanda") || (Pseudo == "luanda") || (Pseudo == "Luanda ") || (Pseudo == "luanda ") ||
                (Pseudo == "LUANDA") || (Pseudo == "LUANDA "))
            {
                Handheld.Vibrate();
                cont_ed.LuandaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.LuandaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SANTIAGO
            if ((Pseudo == "Santiago") || (Pseudo == "santiago") || (Pseudo == "Santiago ") || (Pseudo == "santiago ") ||
                (Pseudo == "SANTIAGO") || (Pseudo == "SANTIAGO "))
            {
                Handheld.Vibrate();
                cont_ed.SantiagoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SantiagoClose);
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
                cont_ed.AsunciónOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.AsunciónClose);
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
                cont_ed.SanSalvadorOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SanSalvadorClose);
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
                cont_ed.BogotáOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BogotáClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO CARACAS
            if ((Pseudo == "Caracas") || (Pseudo == "caracas") || (Pseudo == "Caracas ") || (Pseudo == "caracas ") ||
                (Pseudo == "CARACAS") || (Pseudo == "CARACAS "))
            {
                Handheld.Vibrate();
                cont_ed.CaracasOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.CaracasClose);
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
                cont_ed.SantoDomingoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SantoDomingoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO QUITO
            if ((Pseudo == "Quito") || (Pseudo == "quito") || (Pseudo == "Quito ") || (Pseudo == "quito ") ||
                (Pseudo == "QUITO") || (Pseudo == "QUITO "))
            {
                Handheld.Vibrate();
                cont_ed.QuitoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.QuitoClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MINESOTA
            if ((Pseudo == "Minesota") || (Pseudo == "minesota") || (Pseudo == "Minesota ") || (Pseudo == "minesota ") ||
                (Pseudo == "MINESOTA") || (Pseudo == "MINESOTA "))
            {
                Handheld.Vibrate();
                cont_ed.MinesotaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.MinesotaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SIRIA
            if ((Pseudo == "Siria") || (Pseudo == "siria") || (Pseudo == "Siria ") || (Pseudo == "siria ") ||
                (Pseudo == "SIRIA") || (Pseudo == "SIRIA "))
            {
                Handheld.Vibrate();
                cont_ed.SiriaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SiriaClose);
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
                cont_ed.SofíaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SofíaClose);
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
                cont_ed.ElCaboOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.ElCaboClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ANKARA
            if ((Pseudo == "Ankara") || (Pseudo == "ankara") || (Pseudo == "Ankara ") || (Pseudo == "ankara ") ||
                (Pseudo == "ANKARA") || (Pseudo == "ANKARA "))
            {
                Handheld.Vibrate();
                cont_ed.AnkaraOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.AnkaraClose);
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
                cont_ed.TúnezOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.TúnezClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO SINGAPUR
            if ((Pseudo == "Singapur") || (Pseudo == "singapur") || (Pseudo == "Singapur ") || (Pseudo == "singapur ") ||
                (Pseudo == "SINGAPUR") || (Pseudo == "SINGAPUR "))
            {
                Handheld.Vibrate();
                cont_ed.SingapurOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.SingapurClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESLOVAQUIA
            if ((Pseudo == "Eslovaquia") || (Pseudo == "eslovaquia") || (Pseudo == "Eslovaquia ") || (Pseudo == "eslovaquia ") ||
                (Pseudo == "ESLOVAQUIA") || (Pseudo == "ESLOVAQUIA "))
            {
                Handheld.Vibrate();
                cont_ed.EslovaquiaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.EslovaquiaClose);
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
                cont_ed.HonoluluOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.HonoluluClose);
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
                cont_ed.CanberraOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.CanberraClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BRASILIA
            if ((Pseudo == "Brasilia") || (Pseudo == "brasilia") || (Pseudo == "Brasilia ") || (Pseudo == "brasilia ") ||
                (Pseudo == "BRASILIA") || (Pseudo == "BRASILIA "))
            {
                Handheld.Vibrate();
                cont_ed.BrasiliaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BrasiliaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO YOKOHAMA
            if ((Pseudo == "Yokohama") || (Pseudo == "yokohama") || (Pseudo == "Yokohama ") || (Pseudo == "yokohama ") ||
                (Pseudo == "YOKOHAMA") || (Pseudo == "YOKOHAMA "))
            {
                Handheld.Vibrate();
                cont_ed.YokohamaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.YokohamaClose);
                Pseudo = Pseudo2;
            }


            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO GUATEMALA
            if ((Pseudo == "Guatemala") || (Pseudo == "guatemala") || (Pseudo == "Guatemala ") || (Pseudo == "guatemala ") ||
                (Pseudo == "GUATEMALA") || (Pseudo == "GUATEMALA "))
            {
                Handheld.Vibrate();
                cont_ed.GuatemalaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.GuatemalaClose);
                Pseudo = Pseudo2;
            }

            //*************************************************************************************************************
            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO WASHINGTON
            if ((Pseudo == "Washington") || (Pseudo == "washington") || (Pseudo == "Washington ") || (Pseudo == "washington ") ||
                (Pseudo == "WASHINGTON") || (Pseudo == "WASHINGTON "))
            {
                Handheld.Vibrate();
                cont_ed.WashingtonOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.WashingtonClose);
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
                cont_ed.DaccaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.DaccaClose);
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
                cont_ed.HamburgoOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.HamburgoClose);
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
