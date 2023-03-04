using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam : MonoBehaviour
{
    [SerializeField] GameObject Cam_Dem;
    [SerializeField] GameObject Cam_Other;
    // Start is called before the first frame update
    void Start()
    {
        //Declaramos las camaras al principio
        //Camara que sale al inicio
        Cam_Dem.SetActive(true);
        //Camara utilizada para transición
        Cam_Other.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Otherexample();

    }

    public void Otherexample()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //Camara que sale al inicio
            Cam_Dem.SetActive(false);
            //Camara utilizada para transición
            Cam_Other.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Camara que sale al inicio
            Cam_Dem.SetActive(true);
            //Camara utilizada para transición
            Cam_Other.SetActive(false);
        }
    }
}
