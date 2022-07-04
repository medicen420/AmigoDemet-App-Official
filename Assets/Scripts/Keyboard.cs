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




            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO ESTAMBUL
            if ((Pseudo == "Estambul") || (Pseudo == "estambul") || (Pseudo == "Estambul ") || (Pseudo == "estambul ") ||
                (Pseudo == "ESTAMBUL") || (Pseudo == "ESTAMBUL "))
            {

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




            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MOSCÚ
            if ((Pseudo == "Moscú") || (Pseudo == "moscú") || (Pseudo == "Moscu") || (Pseudo == "moscu") ||
                (Pseudo == "Moscú ") || (Pseudo == "moscú ") || (Pseudo == "Moscu ") || (Pseudo == "moscu ") ||
                (Pseudo == "MOSCÚ") || (Pseudo == "MOSCU") || (Pseudo == "MOSCÚ ") || (Pseudo == "MOSCU "))
            {
                cont_ed.MoscúOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.MoscúClose);
                Pseudo = Pseudo2;
            }



            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO BERNA
            if((Pseudo == "Berna") || (Pseudo == "berna") || (Pseudo == "Berna ") || (Pseudo == "berna ") ||
                (Pseudo == "BERNA") || (Pseudo == "BERNA "))
            {
                cont_ed.BernaOpen();
                User_i.ResetButtons_1();

                User_i.Inputfield.SetActive(false);
                User_i.deselect.onClick.AddListener(cont_ed.BernaClose);
                Pseudo = Pseudo2;
            }


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


            //►►►►►►►►►►►►►►►►►►►►►►
            //EDIFICIO MOSCÚ






        }


    }

}
