using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    [SerializeField] float Speed;

    //Para llamar a una variable ubicada desde otro script 
    //definiremos un campo con visibilidad pública y asignaremos 
    //el script manualmente desde el inspector
    public ScrollAndPinch sc;




    // Start is called before the first frame update
    void Start()
    {
        //Para enocntrar una referencia ubicada en el script de ScrollAndPinch
        //escribimos lo siguiente:
        sc = FindObjectOfType<ScrollAndPinch>();
        Debug.Log(sc.CameraUpperHeightBound);
        Debug.Log(sc.CameraLowerHeightBound);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-TouchDeltaPosition.x * Speed, -TouchDeltaPosition.y * Speed, 0);

            //La funcion Mathf.Clamp se utiliza para restringir la posicion de la camara
            //dentro de ciertos limites en cada eje (x,y,z) esto ayuda a evitar que la camara 
            //se salga de la pantalla o del area de juego
                transform.position = new Vector3(

                    //delimitamos en x 
                    //posmax y posmin
                Mathf.Clamp(transform.position.x, -53.4f, 10f),
                //delimitamos en y
                //ocupamos las variables que nos ayudan
                //a hacer un zoom in zoom out desde otro codigo

                //esas variables las toma como referencia para delimitar
                //el zoom in zoom out
                Mathf.Clamp(transform.position.y, sc.CameraLowerHeightBound, sc.CameraUpperHeightBound),

                //delimitamos en z 
                //posmax y posmin
                Mathf.Clamp(transform.position.z, -58.61f, 15.8f));


        }
    
    }
}
