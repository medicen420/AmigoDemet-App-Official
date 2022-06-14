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

                transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, -64.7f, -2f),
                Mathf.Clamp(transform.position.y, sc.CameraLowerHeightBound, sc.CameraUpperHeightBound),
                Mathf.Clamp(transform.position.z, -72.86f, 12.6f));


        }
    
    }
}
