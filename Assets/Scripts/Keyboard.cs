using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    TouchScreenKeyboard clavier;
    public Text txt;
    string Pseudo;
    [SerializeField] GameObject btn;
    



    public void Start()
    {
        btn.SetActive(true);
        
    }

    public void OpenKeyboard()
    {
        clavier = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    }

    public void Vibrate()
    {
        Handheld.Vibrate();
    }
    
    void Update()
    {
        if(TouchScreenKeyboard.visible == false && clavier != null)
        {
            if(clavier.status == TouchScreenKeyboard.Status.Done)
            {
                Pseudo = clavier.text;
                txt.text = "Aquí está " + Pseudo;
                clavier = null;

            }

            //Está línea de código me permite saber el nombre
            //del edificio que está buscando el usuario
            if(txt.text == "Aquí está Berna")
            {
                btn.SetActive(false);
            }
        }

        
        
    }


}
