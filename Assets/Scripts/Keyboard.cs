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
                txt.text = "Aqu� est� " + Pseudo;
                clavier = null;

            }

            //Est� l�nea de c�digo me permite saber el nombre
            //del edificio que est� buscando el usuario
            if(txt.text == "Aqu� est� Berna")
            {
                btn.SetActive(false);
            }
        }

        
        
    }


}
