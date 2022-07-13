using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchBar : MonoBehaviour
{

    //Arrays que guardaran todos los edificios de mi escena
    //Hay 2 tipos: Los normales y los Azules
    public GameObject[] azulitos;
    public GameObject[] normalillos;


    //Variables de tipo string que contienen el nombre de algunas etiquetas
    //que existen en mi inspector
    //string tagNameBlue = "edificio_blue";
    string tagNameNormal = "edificio_normal";
    string tagNew = "prueba";


    //AQUÍ EMPIEZA MI SCRIPT PARA LA OPCIÓN SEARCHBAR EN LOS EDIFICIOS
    //*************************************************************
    //MÉTODOS PARA LA SEARCHBAR

    //-------------------------------------------------------------------
    //Crearemos métodos para compartir al script de Keyboard
    //estos métodos nos servirán para seleccionar un edificio 
    //mediante el tipeo de su nombre en la barra de búsqueda

    //[SerializeField] GameObject moscú_normal;
    //Este Game Object es el edificio seleccionado
    //EDIFICIO AZUL
    GameObject edificio_blue;


    //Este GameObject es el edificio sin seleccionar
    //con el tag "edificio_blue"
    //EDIFICIO NORMAL CON NUEVO TAG
    //Esto se hace para que al momento de seleccionar un edificio
    //el edificio normal se cambie de tag
    GameObject edificio_newtag;
    GameObject edificio_supernewtag;



    //En esta variable GameObject almacenaremos nuestro edificio normal 
    //cuando se le haya cambiado el tag y este desactivado
    [SerializeField] GameObject recolector;

    public UI ux;

    //*******************************************************************
    //EDIFICIO ESTAMBUL
    public void EstambulOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[3].SetActive(true);
            normalillos[41].tag = tagNew;
            recolector = normalillos[41];
            recolector.SetActive(false);

        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[3].SetActive(true);
                normalillos[41].SetActive(false);
                normalillos[41].tag = tagNew;
                recolector = normalillos[41];
                recolector.SetActive(false);
            }

        }

    }
    //-------------------------------------------------------------------

    public void EstambulClose()
    {

        azulitos[3].SetActive(false);
        normalillos[41].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Estambul();

    }
    //*******************************************************************************



    //********************************************************************
    //EDIFICIO MOSCÚ
    public void MoscúOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[57].SetActive(true);
            normalillos[16].tag = tagNew;
            recolector = normalillos[16];
            recolector.SetActive(false);

        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {

                azulitos[57].SetActive(true);
                normalillos[16].SetActive(false);
                recolector = normalillos[16];
                recolector.SetActive(false);

            }

        }
    }
    //----------------------------------------------------------------------------------

    public void MoscúClose()
    {
        azulitos[57].SetActive(false);
        normalillos[16].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Moscú();
    }
    //***********************************************************************************



    //****************************************************************
    //EDIFICIO BERNA
    public void BernaOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[24].SetActive(true);
            normalillos[66].tag = tagNew;
            recolector = normalillos[66];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {

                azulitos[24].SetActive(true);
                normalillos[66].SetActive(false);
                normalillos[66].tag = tagNew;
                recolector = normalillos[66];
                recolector.SetActive(false);
            }
        }
    }


    public void BernaClose()
    {
        azulitos[24].SetActive(false);
        normalillos[66].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Berna();
    }
    //****************************************************************************




    //***********************************************************************
    //EDIFICIO ATENAS
    public void AtenasOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[30].SetActive(true);
            normalillos[36].tag = tagNew;
            recolector = normalillos[36];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[30].SetActive(true);
                normalillos[36].SetActive(false);
                normalillos[36].tag = tagNew;
                recolector = normalillos[36];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------------------------

    public void AtenasClose()
    {
        azulitos[30].SetActive(false);
        normalillos[36].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Atenas();
    }
    //*************************************************************************************




    //****************************************************************************
    //EDIFICIO ARGEL
    public void ArgelOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[68].SetActive(true);
            normalillos[53].tag = tagNew;
            recolector = normalillos[53];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[68].SetActive(true);
                normalillos[53].SetActive(false);
                normalillos[53].tag = tagNew;
                recolector = normalillos[53];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------------------

    public void ArgelClose()
    {
        azulitos[68].SetActive(false);
        normalillos[53].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Argel();
    }
    //*****************************************************************************



    //****************************************************************************
    //EDIFICIO OSLO
    public void OsloOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[53].SetActive(true);
            normalillos[64].tag = tagNew;
            recolector = normalillos[64];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[53].SetActive(true);
                normalillos[64].SetActive(false);
                normalillos[64].tag = tagNew;
                recolector = normalillos[64];
                recolector.SetActive(false);
            }
        }
    }

    public void OsloClose()
    {
        azulitos[53].SetActive(false);
        normalillos[64].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Oslo();
    }
    //**********************************************************************************


    //***********************************************************************************
    //EDIFICIO BULGARIA
    public void BulgariaOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[55].SetActive(true);
            normalillos[18].tag = tagNew;
            recolector = normalillos[18];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[55].SetActive(true);
                normalillos[18].SetActive(false);
                normalillos[18].tag = tagNew;
                recolector = normalillos[18];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------

    public void BulgariaClose()
    {
        azulitos[55].SetActive(false);
        normalillos[18].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Bulgaria();
    }
    //**************************************************************************************



    //*************************************************************************************
    //EDIFICIO BELGRADO
    public void BelgradoOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[40].SetActive(true);
            normalillos[47].tag = tagNew;
            recolector = normalillos[47];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {

                azulitos[40].SetActive(true);
                normalillos[47].SetActive(false);
                normalillos[47].tag = tagNew;
                recolector = normalillos[47];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------

    public void BelgradoClose()
    {
        azulitos[40].SetActive(false);
        normalillos[47].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Belgrado();
    }
    //******************************************************************************************



    //******************************************************************************************
    //EDIFICIO SEÚL 
    public void SeúlOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[69].SetActive(true);
            normalillos[56].tag = tagNew;
            recolector = normalillos[56];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[69].SetActive(true);
                normalillos[56].SetActive(false);
                normalillos[56].tag = tagNew;
                recolector = normalillos[56];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------

    public void SeúlClose()
    {
        azulitos[69].SetActive(false);
        normalillos[56].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Seúl();
    }
    //******************************************************************************************




    //******************************************************************************************
    //EDIFICIO DAMASCO
    public void DamascoOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[47].SetActive(true);
            normalillos[14].tag = tagNew;
            recolector = normalillos[14];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[47].SetActive(true);
                normalillos[14].SetActive(false);
                normalillos[14].tag = tagNew;
                recolector = normalillos[14];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------------------------------
    public void DamascoClose()
    {
        azulitos[47].SetActive(false);
        normalillos[14].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Damasco();
    }
    //*********************************************************************************************



    //*********************************************************************************************
    //EDIFICIO VARSOVIA
    public void VarsoviaOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[20].SetActive(true);
            normalillos[19].tag = tagNew;
            recolector = normalillos[19];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[20].SetActive(true);
                normalillos[19].SetActive(false);
                normalillos[19].tag = tagNew;
                recolector = normalillos[19];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------

    public void VarsoviaClose()
    {
        azulitos[20].SetActive(false);
        normalillos[19].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Varsovia();
    }
    //************************************************************************************************




    //************************************************************************************************
    //EDIFICIO ESTOCOLMO
    public void EstocolmoOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[27].SetActive(true);
            normalillos[2].tag = tagNew;
            recolector = normalillos[2];
            recolector.SetActive(false);
        }



        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[27].SetActive(true);
                normalillos[2].SetActive(false);
                normalillos[2].tag = tagNew;
                recolector = normalillos[2];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------

    public void EstocolmoClose()
    {
        azulitos[27].SetActive(false);
        normalillos[2].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Estocolmo();
    }
    //**********************************************************************************************


    //*********************************************************************************************
    //EDIFICIO PARÍS

    public void ParísOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[56].SetActive(true);
            normalillos[10].tag = tagNew;
            recolector = normalillos[10];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[56].SetActive(true);
                normalillos[10].SetActive(false);
                normalillos[10].tag = tagNew;
                recolector = normalillos[10];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------

    public void ParísClose()
    {
        azulitos[56].SetActive(false);
        normalillos[10].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_París();
    }
    //********************************************************************************************

    //**********************************************************************************************
    //EDIFICIO MADRID

    public void MadridOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[50].SetActive(true);
            normalillos[6].tag = tagNew;
            recolector = normalillos[6];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[50].SetActive(true);
                normalillos[6].SetActive(false);
                normalillos[6].tag = tagNew;
                recolector = normalillos[6];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------

    public void MadridClose()
    {
        azulitos[50].SetActive(false);
        normalillos[6].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Madrid();
    }
    //***********************************************************************************************




    //************************************************************************************************
    //EDIFICIO LISBOA
    public void LisboaOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[16].SetActive(true);
            normalillos[15].tag = tagNew;
            recolector = normalillos[15];
            recolector.SetActive(false);
        }



        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[16].SetActive(true);
                normalillos[15].SetActive(false);
                normalillos[15].tag = tagNew;
                recolector = normalillos[15];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------

    public void LisboaClose()
    {
        azulitos[16].SetActive(false);
        normalillos[15].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Lisboa();
    }
    //*************************************************************************************************


    //************************************************************************************************
    //EDIFICIO ROMA

    public void RomaOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[35].SetActive(true);
            normalillos[24].tag = tagNew;
            recolector = normalillos[24];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[35].SetActive(true);
                normalillos[24].SetActive(false);
                normalillos[24].tag = tagNew;
                recolector = normalillos[24];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------

    public void RomaClose()
    {
        azulitos[35].SetActive(false);
        normalillos[24].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Roma();
    }
    //***********************************************************************************************



    //***********************************************************************************************
    //EDIFICIO BRUSELAS

    public void BruselasOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[49].SetActive(true);
            normalillos[25].tag = tagNew;
            recolector = normalillos[25];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;



            if (recolector == null)
            {
                azulitos[49].SetActive(true);
                normalillos[25].SetActive(false);
                normalillos[25].tag = tagNew;
                recolector = normalillos[25];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------------------------------

    public void BruselasClose()
    {
        azulitos[49].SetActive(false);
        normalillos[25].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Bruselas();
    }
    //**************************************************************************************************



    //*************************************************************************************************
    //EDIFICIO LONDRES

    public void LondresOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[39].SetActive(true);
            normalillos[42].tag = tagNew;
            recolector = normalillos[42];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[39].SetActive(true);
                normalillos[42].SetActive(false);
                normalillos[42].tag = tagNew;
                recolector = normalillos[42];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------

    public void LondresClose()
    {
        azulitos[39].SetActive(false);
        normalillos[42].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Londres();
    }
    //****************************************************************************************************




    //**************************************************************************************************
    //EDIFICIO ZURICH

    public void ZurichOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[70].SetActive(true);
            normalillos[72].tag = tagNew;
            recolector = normalillos[72];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[70].SetActive(true);
                normalillos[72].SetActive(false);
                normalillos[72].tag = tagNew;
                recolector = normalillos[72];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------------------------------------

    public void ZurichClose()
    {
        azulitos[70].SetActive(false);
        normalillos[72].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Zurich();
    }
    //****************************************************************************************************



    //***************************************************************************************************
    //EDIFICIO BERLÍN

    public void BerlínOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[61].SetActive(true);
            normalillos[62].tag = tagNew;
            recolector = normalillos[62];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[61].SetActive(true);
                normalillos[62].SetActive(false);
                normalillos[62].tag = tagNew;
                recolector = normalillos[62];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------------------------------

    public void BerlínClose()
    {
        azulitos[61].SetActive(false);
        normalillos[62].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
    }


    //**************************************************************************************************
    //EDIFICIO VIENA

    public void VienaOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[13].SetActive(true);
            normalillos[70].tag = tagNew;
            recolector = normalillos[70];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[13].SetActive(true);
                normalillos[70].SetActive(false);
                normalillos[70].tag = tagNew;
                recolector = normalillos[70];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------

    public void VienaClose()
    {
        azulitos[13].SetActive(false);
        normalillos[70].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Viena();
    }
    //***********************************************************************************************



    //************************************************************************************************
    //EDIFICIO PRAGA

    public void PragaOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[29].SetActive(true);
            normalillos[69].tag = tagNew;
            recolector = normalillos[69];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[29].SetActive(true);
                normalillos[69].SetActive(false);
                normalillos[69].tag = tagNew;
                recolector = normalillos[69];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------------------------------

    public void PragaClose()
    {
        azulitos[29].SetActive(false);
        normalillos[69].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Praga();
    }
    //**************************************************************************************************



    //*************************************************************************************************
    //EDIFICIO YAKARTA

    public void YakartaOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[38].SetActive(true);
            normalillos[21].tag = tagNew;
            recolector = normalillos[21];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[38].SetActive(true);
                normalillos[21].SetActive(false);
                normalillos[21].tag = tagNew;
                recolector = normalillos[21];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------

    public void YakartaClose()
    {
        azulitos[38].SetActive(false);
        normalillos[21].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Yakarta();
    }
    //***********************************************************************************************




    //**********************************************************************************************
    //EDIFICIO MÓNACO
    public void MónacoOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[25].SetActive(true);
            normalillos[29].tag = tagNew;
            recolector = normalillos[29];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[25].SetActive(true);
                normalillos[29].SetActive(false);
                normalillos[29].tag = tagNew;
                recolector = normalillos[29];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------------------------------

    public void MónacoClose()
    {
        azulitos[25].SetActive(false);
        normalillos[29].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Mónaco();
    }
    //*************************************************************************************************


    //**************************************************************************************************
    //EDIFICIO MANILA


    public void ManilaOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[73].SetActive(true);
            normalillos[63].tag = tagNew;
            recolector = normalillos[63];
            recolector.SetActive(false);
        }



        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[73].SetActive(true);
                normalillos[63].SetActive(false);
                normalillos[63].tag = tagNew;
                recolector = normalillos[63];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------

    public void ManilaClose()
    {
        azulitos[73].SetActive(false);
        normalillos[63].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Manila();
    }
    //*************************************************************************************************



    //**************************************************************************************************
    //EDIFICIO NUEVA DELHI

    public void NuevaDelhiOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[1].SetActive(true);
            normalillos[71].tag = tagNew;
            recolector = normalillos[71];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[1].SetActive(true);
                normalillos[71].SetActive(false);
                normalillos[71].tag = tagNew;
                recolector = normalillos[71];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------------

    public void NuevaDelhiClose()
    {
        azulitos[1].SetActive(false);
        normalillos[71].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_NuevaDelhi();
    }



    //*****************************************************************************************************
    //EDIFICIO MÉXICO

    public void MéxicoOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[19].SetActive(true);
            normalillos[20].tag = tagNew;
            recolector = normalillos[20];
            recolector.SetActive(false);
        }



        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[19].SetActive(true);
                normalillos[20].SetActive(false);
                normalillos[20].tag = tagNew;
                recolector = normalillos[20];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------

    public void MéxicoClose()
    {
        azulitos[19].SetActive(false);
        normalillos[20].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_México();
    }

    //****************************************************************************************************
    //EDIFICIO TEHERÁN


    public void TeheránOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[59].SetActive(true);
            normalillos[40].tag = tagNew;
            recolector = normalillos[40];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[59].SetActive(true);
                normalillos[40].SetActive(false);
                normalillos[40].tag = tagNew;
                recolector = normalillos[40];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------


    public void TeheránClose()
    {
        azulitos[59].SetActive(false);
        normalillos[40].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Teherán();
    }


    //******************************************************************************************************
    //EDIFICIO BOMBAY

    public void BombayOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[45].SetActive(true);
            normalillos[11].tag = tagNew;
            recolector = normalillos[11];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[45].SetActive(true);
                normalillos[11].SetActive(false);
                normalillos[11].tag = tagNew;
                recolector = normalillos[11];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------------

    public void BombayClose()
    {
        azulitos[45].SetActive(false);
        normalillos[11].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Bombay();
    }

    //******************************************************************************************************
    //EDIFICIO PEKIN

    public void PekínOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[2].SetActive(true);
            normalillos[0].tag = tagNew;
            recolector = normalillos[0];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[2].SetActive(true);
                normalillos[0].SetActive(false);
                normalillos[0].tag = tagNew;
                recolector = normalillos[0];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------

    public void PekínClose()
    {
        azulitos[2].SetActive(false);
        normalillos[0].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Pekín();
    }
    //*********************************************************************************************************



    //*********************************************************************************************************
    //EDIFICIO BUCAREST
    public void BucarestOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[15].SetActive(true);
            normalillos[13].tag = tagNew;
            recolector = normalillos[13];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[15].SetActive(true);
                normalillos[13].SetActive(false);
                normalillos[13].tag = tagNew;
                recolector = normalillos[13];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------------------------------------------

    public void BucarestClose()
    {
        azulitos[15].SetActive(false);
        normalillos[13].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Bucarest();
    }


    //************************************************************************************************************
    //EDIFICIO COPENNAGUE
    public void CopennagueOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[5].SetActive(true);
            normalillos[4].tag = tagNew;
            recolector = normalillos[4];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[5].SetActive(true);
                normalillos[4].SetActive(false);
                normalillos[4].tag = tagNew;
                recolector = normalillos[4];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------
    public void CopennagueClose()
    {
        azulitos[5].SetActive(false);
        normalillos[4].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Copennague();
    }


    //*****************************************************************************************************************
    //EDIFICIO AMSTERDAM

    public void AmsterdamOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[7].SetActive(true);
            normalillos[12].tag = tagNew;
            recolector = normalillos[12];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[7].SetActive(true);
                normalillos[12].SetActive(false);
                normalillos[12].tag = tagNew;
                recolector = normalillos[12];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------

    public void AmsterdamClose()
    {
        azulitos[7].SetActive(false);
        normalillos[12].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Amsterdam();
    }
    //****************************************************************************************************************



    //*****************************************************************************************************************
    //EDIFICIO SAIGON
    public void SaigónOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[71].SetActive(true);
            normalillos[17].tag = tagNew;
            recolector = normalillos[17];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[71].SetActive(true);
                normalillos[17].SetActive(false);
                normalillos[17].tag = tagNew;
                recolector = normalillos[17];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------


    public void SaigónClose()
    {
        azulitos[71].SetActive(false);
        normalillos[17].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Saígon();

    }
    //****************************************************************************************************************

    //*****************************************************************************************************************
    //EDIFICIO TAIPEI
    public void TaipéiOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[54].SetActive(true);
            normalillos[31].tag = tagNew;
            recolector = normalillos[31];
            recolector.SetActive(false);
        }



        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {

                azulitos[54].SetActive(true);
                normalillos[31].SetActive(false);
                normalillos[31].tag = tagNew;
                recolector = normalillos[31];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------------------------------------------------

    public void TaipéiClose()
    {
        azulitos[54].SetActive(false);
        normalillos[31].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Taipéi();
    }
    //******************************************************************************************************************


    //*******************************************************************************************************************
    //EDIFICIO TOKIO
    public void TokioOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[18].SetActive(true);
            normalillos[67].tag = tagNew;
            recolector = normalillos[67];
            recolector.SetActive(false);
        }



        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[18].SetActive(true);
                normalillos[67].SetActive(false);
                normalillos[67].tag = tagNew;
                recolector = normalillos[67];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------------------

    public void TokioClose()
    {
        azulitos[18].SetActive(false);
        normalillos[67].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Tokio();
    }
    //********************************************************************************************************************


    //*********************************************************************************************************************
    //EDIFICIO SAN JUAN
    public void SanJuanOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[44].SetActive(true);
            normalillos[34].tag = tagNew;
            recolector = normalillos[34];
            recolector.SetActive(false);
        }

        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[44].SetActive(true);
                normalillos[34].SetActive(false);
                normalillos[34].tag = tagNew;
                recolector = normalillos[34];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------------------


    public void SanJuanClose()
    {
        azulitos[44].SetActive(false);
        normalillos[34].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_SanJuan();
    }
    //*********************************************************************************************************************



    //*********************************************************************************************************************
    //EDIFICIO KINGSTON
    public void KingstonOpen()

    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[48].SetActive(true);
            normalillos[57].tag = tagNew;
            recolector = normalillos[57];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[48].SetActive(true);
                normalillos[57].SetActive(false);
                normalillos[57].tag = tagNew;
                recolector = normalillos[57];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------

    public void KingstonClose()
    {
        azulitos[48].SetActive(false);
        normalillos[57].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Kingston();
    }


    //**********************************************************************************************************************
    //EDIFICIO HABANA
    public void HabanaOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[14].SetActive(true);
            normalillos[52].tag = tagNew;
            recolector = normalillos[52];
            recolector.SetActive(false);
        }



        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[14].SetActive(true);
                normalillos[52].SetActive(false);
                normalillos[52].tag = tagNew;
                recolector = normalillos[52];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------------------

    public void HabanaClose()
    {
        azulitos[14].SetActive(false);
        normalillos[52].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Habana();
    }
    //*********************************************************************************************************************


    //*********************************************************************************************************************
    //EDIFICIO SAN JOSÉ
    public void SanJoséOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[58].SetActive(true);
            normalillos[39].tag = tagNew;
            recolector = normalillos[39];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;



            if (recolector == null)
            {
                azulitos[58].SetActive(true);
                normalillos[39].SetActive(false);
                normalillos[39].tag = tagNew;
                recolector = normalillos[39];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------

    public void SanJoséClose()
    {
        azulitos[58].SetActive(false);
        normalillos[39].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_SanJosé();
    }
    //************************************************************************************************************************



    //************************************************************************************************************************
    //EDIFICIO PANAMÁ
    public void PanamáOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[51].SetActive(true);
            normalillos[33].tag = tagNew;
            recolector = normalillos[33];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[51].SetActive(true);
                normalillos[33].SetActive(false);
                normalillos[33].tag = tagNew;
                recolector = normalillos[33];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------


    public void PanamáClose()
    {
        azulitos[51].SetActive(false);
        normalillos[33].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Panamá();
    }
    //***************************************************************************************************************************



    //****************************************************************************************************************************
    //EDIFICIO MANAGUA

    public void ManaguaOpen()
    {

        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[31].SetActive(true);
            normalillos[7].tag = tagNew;
            recolector = normalillos[7];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[31].SetActive(true);
                normalillos[7].SetActive(false);
                normalillos[7].tag = tagNew;
                recolector = normalillos[7];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------------------------------------------------------------

    public void ManaguaClose()
    {
        azulitos[31].SetActive(false);
        normalillos[7].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Managua();
    }
    //*************************************************************************************************************************



    //**************************************************************************************************************************
    //EDIFICIO TEGUCIGALPA
    public void TegucigalpaOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {

            azulitos[34].SetActive(true);
            normalillos[1].tag = tagNew;
            recolector = normalillos[1];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[34].SetActive(true);
                normalillos[1].SetActive(false);
                normalillos[1].tag = tagNew;
                recolector = normalillos[1];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------------------------------------------------------------

    public void TegucigalpaClose()
    {
        azulitos[34].SetActive(false);
        normalillos[1].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Tegucigalpa();
    }
    //**************************************************************************************************************************



    //**************************************************************************************************************************
    //EDIFICIO NUEVA YORK
    public void NuevaYorkOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[42].SetActive(true);
            normalillos[49].tag = tagNew;
            recolector = normalillos[49];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[42].SetActive(true);
                normalillos[49].SetActive(false);
                normalillos[49].tag = tagNew;
                recolector = normalillos[49];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------

    public void NuevaYorkClose()
    {
        azulitos[42].SetActive(false);
        normalillos[49].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_NuevaYork();
    }
    //***************************************************************************************************************************



    //****************************************************************************************************************************
    //EDIFICIO BUENOS AIRES
    public void BuenosAiresOpen()
    {
        //SI NO HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == false)
        {
            azulitos[28].SetActive(true);
            normalillos[35].tag = tagNew;
            recolector = normalillos[35];
            recolector.SetActive(false);
        }


        //SI HAY UN EDIFICIO SELECCIONADO
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {

                azulitos[28].SetActive(true);
                normalillos[35].SetActive(false);
                normalillos[35].tag = tagNew;
                recolector = normalillos[35];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------

    public void BuenosAiresClose()
    {
        azulitos[28].SetActive(false);
        normalillos[35].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_BuenosAires();
    }


    //**********************************************************************************************************************************
    //EDIFICIO OTAWA
    public void OtawaOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[8].SetActive(true);
            normalillos[51].tag = tagNew;
            recolector = normalillos[51];
            recolector.SetActive(false);
        }



        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;



            if (recolector == null)
            {
                azulitos[8].SetActive(true);
                normalillos[51].SetActive(false);
                normalillos[51].tag = tagNew;
                recolector = normalillos[51];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------------


    public void OtawaClose()
    {
        azulitos[8].SetActive(false);
        normalillos[51].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Otawa();
    }
    //************************************************************************************************************************************



    //*************************************************************************************************************************************
    //EDIFICIO EL CAIRO
    public void ElCairoOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[64].SetActive(true);
            normalillos[54].tag = tagNew;
            recolector = normalillos[54];
            recolector.SetActive(false);
        }


        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[64].SetActive(true);
                normalillos[54].SetActive(false);
                normalillos[54].tag = tagNew;
                recolector = normalillos[54];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------------------------------------------------------------------------

    public void ElCairoClose()
    {
        azulitos[64].SetActive(false);
        normalillos[54].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_ElCairo();
    }
    //****************************************************************************************************************************************



    //*****************************************************************************************************************************************
    //EDIFICIO TORONTO
    public void TorontoOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[63].SetActive(true);
            normalillos[5].tag = tagNew;
            recolector = normalillos[5];
            recolector.SetActive(false);
        }



        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[63].SetActive(true);
                normalillos[5].SetActive(false);
                normalillos[5].tag = tagNew;
                recolector = normalillos[5];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------

    public void TorontoClose()
    {
        azulitos[63].SetActive(false);
        normalillos[5].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Toronto();
    }



    //****************************************************************************************************************************************
    //EDIFICIO TRIPOLI
    public void TrípoliOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[17].SetActive(true);
            normalillos[32].tag = tagNew;
            recolector = normalillos[32];
            recolector.SetActive(false);
        }


        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[17].SetActive(true);
                normalillos[32].SetActive(false);
                normalillos[32].tag = tagNew;
                recolector = normalillos[32];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------

    public void TrípoliClose()
    {
        azulitos[17].SetActive(false);
        normalillos[32].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Trípoli();
    }
    //**************************************************************************************************************************************



    //***************************************************************************************************************************************
    //EDIFICIO MONTEVIDEO
    public void MonteVideoOpen()
    {

        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[46].SetActive(true);
            normalillos[9].tag = tagNew;
            recolector = normalillos[9];
            recolector.SetActive(false);
        }


        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;



            if (recolector == null)
            {
                azulitos[46].SetActive(true);
                normalillos[9].SetActive(false);
                normalillos[9].tag = tagNew;
                recolector = normalillos[9];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------------------------------------------------------------------

    public void MonteVideoClose()
    {
        azulitos[46].SetActive(false);
        normalillos[9].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_MonteVideo();
    }
    //*************************************************************************************************************************************


    //****************************************************************************************************************************************
    //EDIFICIO LUANDA
    public void LuandaOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[60].SetActive(true);
            normalillos[22].tag = tagNew;
            recolector = normalillos[22];
            recolector.SetActive(false);
        }



        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;



            if (recolector == null)
            {
                azulitos[60].SetActive(true);
                normalillos[22].SetActive(false);
                normalillos[22].tag = tagNew;
                recolector = normalillos[22];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------------

    public void LuandaClose()
    {
        azulitos[60].SetActive(false);
        normalillos[22].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Luanda();
    }
    //*********************************************************************************************************************************************


    //*********************************************************************************************************************************************
    //EDIFICIO SANTIAGO
    public void SantiagoOpen()
    {
        if (edificio_blue == false)
        {

            azulitos[67].SetActive(true);
            normalillos[68].tag = tagNew;
            recolector = normalillos[68];
            recolector.SetActive(false);
        }


        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[67].SetActive(true);
                normalillos[68].SetActive(false);
                normalillos[68].tag = tagNew;
                recolector = normalillos[68];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------

    public void SantiagoClose()
    {
        azulitos[67].SetActive(false);
        normalillos[68].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Santiago();
    }
    //*****************************************************************************************************************************************



    //******************************************************************************************************************************************
    //EDIFICIO ASUNCIÓN
    public void AsunciónOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {

            azulitos[36].SetActive(true);
            normalillos[61].tag = tagNew;
            recolector = normalillos[61];
            recolector.SetActive(false);
        }



        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[36].SetActive(true);
                normalillos[61].SetActive(false);
                normalillos[61].tag = tagNew;
                recolector = normalillos[61];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------------

    public void AsunciónClose()
    {
        azulitos[36].SetActive(false);
        normalillos[61].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Asunción();
    }
    //*********************************************************************************************************************************************



    //**********************************************************************************************************************************************
    //EDIFICIO SAN SALVADOR
    public void SanSalvadorOpen()
    {
        if (edificio_blue == false)
        {

            azulitos[12].SetActive(true);
            normalillos[27].tag = tagNew;
            recolector = normalillos[27];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            //Este if() nos ayudará a que una vez que el RECOLECTOR 
            //este en null o vació, se ejecute el código
            if (recolector == null)
            {
                azulitos[12].SetActive(true);
                normalillos[27].SetActive(false);
                normalillos[27].tag = tagNew;
                recolector = normalillos[27];
                recolector.SetActive(false);
            }
        }
    }
    //-------------------------------------------------------------------------

    public void SanSalvadorClose()
    {
        azulitos[12].SetActive(false);
        normalillos[27].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_SanSalvador();
    }

    //*************************************************************************
    //EDIFICIO BOGOTÁ
    public void BogotáOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[52].SetActive(true);
            normalillos[58].tag = tagNew;
            recolector = normalillos[58];
            recolector.SetActive(false);

        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[52].SetActive(true);
                normalillos[58].SetActive(false);
                normalillos[58].tag = tagNew;
                recolector = normalillos[58];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------------

    public void BogotáClose()
    {
        azulitos[52].SetActive(false);
        normalillos[58].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Bogotá();
    }
    //**************************************************************************


    //**************************************************************************
    //EDIFICIO CARACAS
    public void CaracasOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[66].SetActive(true);
            normalillos[38].tag = tagNew;
            recolector = normalillos[38];
            recolector.SetActive(false);
        }





        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[66].SetActive(true);
                normalillos[38].SetActive(false);
                normalillos[38].tag = tagNew;
                recolector = normalillos[38];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------------

    public void CaracasClose()
    {
        azulitos[66].SetActive(false);
        normalillos[38].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Caracas();
    }
    //************************************************************************





    //*************************************************************************
    //EDIFICIO SANTO DOMINGO
    public void SantoDomingoOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[11].SetActive(true);
            normalillos[8].tag = tagNew;
            recolector = normalillos[8];
            recolector.SetActive(false);
        }






        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[11].SetActive(true);
                normalillos[8].SetActive(false);
                normalillos[8].tag = tagNew;
                recolector = normalillos[8];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------

    public void SantoDomingoClose()
    {
        azulitos[11].SetActive(false);
        normalillos[8].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_SantoDomingo();
    }
    //**************************************************************************************************


    //**************************************************************************************************
    //EDIFICIO QUITO
    public void QuitoOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[32].SetActive(true);
            normalillos[46].tag = tagNew;
            recolector = normalillos[46];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[32].SetActive(true);
                normalillos[46].SetActive(false);
                normalillos[46].tag = tagNew;
                recolector = normalillos[46];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------------


    public void QuitoClose()
    {
        azulitos[32].SetActive(false);
        normalillos[46].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Quito();
    }
    //********************************************************************

    //*********************************************************************
    //EDIFICIO MINESOTA
    public void MinesotaOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {

            azulitos[65].SetActive(true);
            normalillos[48].tag = tagNew;
            recolector = normalillos[48];
            recolector.SetActive(false);
        }



        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[65].SetActive(true);
                normalillos[48].SetActive(false);
                normalillos[48].tag = tagNew;
                recolector = normalillos[48];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------


    public void MinesotaClose()
    {
        azulitos[65].SetActive(false);
        normalillos[48].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Minesota();
    }

    //*************************************************************************************************************************************************
    //EDIFICIO SIRIA
    public void SiriaOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {

            azulitos[0].SetActive(true);
            normalillos[3].tag = tagNew;
            recolector = normalillos[3];
            recolector.SetActive(false);
        }



        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[0].SetActive(true);
                normalillos[3].SetActive(false);
                normalillos[3].tag = tagNew;
                recolector = normalillos[3];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------

    public void SiriaClose()
    {
        azulitos[0].SetActive(false);
        normalillos[3].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Siria();
    }
    //********************************************************************


    //*********************************************************************
    //EDIFICIO SOFÍA
    public void SofíaOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {


            azulitos[43].SetActive(true);
            normalillos[65].tag = tagNew;
            recolector = normalillos[65];
            recolector.SetActive(false);
        }



        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;



            if (recolector == null)
            {
                azulitos[43].SetActive(true);
                normalillos[65].SetActive(false);
                normalillos[65].tag = tagNew;
                recolector = normalillos[65];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------

    public void SofíaClose()
    {
        azulitos[43].SetActive(false);
        normalillos[65].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Sofía();
    }
    //***********************************************************



    //***********************************************************
    //EDIFICIO EL CABO
    public void ElCaboOpen()
    {
        //***************************************************
        //Código para cuando no haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[21].SetActive(true);
            normalillos[45].tag = tagNew;
            recolector = normalillos[45];
            recolector.SetActive(false);
        }

        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[21].SetActive(true);
                normalillos[45].SetActive(false);
                normalillos[45].tag = tagNew;
                recolector = normalillos[45];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------

    public void ElCaboClose()
    {
        azulitos[21].SetActive(false);
        normalillos[45].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_ElCabo();
    }


    //**************************************************************************************************************************************************************
    //EDIFICIO ANKARA
    public void AnkaraOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[33].SetActive(true);
            normalillos[59].tag = tagNew;
            recolector = normalillos[59];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {

            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[33].SetActive(true);
                normalillos[59].SetActive(false);
                normalillos[59].tag = tagNew;
                recolector = normalillos[59];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------

    public void AnkaraClose()
    {
        azulitos[33].SetActive(false);
        normalillos[59].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Ankara();
    }


    //************************************************************************************************************************************************************
    //EDIFICIO TUNÉZ
    public void TúnezOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[6].SetActive(true);
            normalillos[28].tag = tagNew;
            recolector = normalillos[28];
            recolector.SetActive(false);
        }





        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;



            if (recolector == null)
            {
                azulitos[6].SetActive(true);
                normalillos[28].SetActive(false);
                normalillos[28].tag = tagNew;
                recolector = normalillos[28];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------------

    public void TúnezClose()
    {
        azulitos[6].SetActive(false);
        normalillos[28].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Túnez();
    }
    //*******************************************************************


    //*******************************************************************
    //EDIFICIO SINGAPUR
    public void SingapurOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[9].SetActive(true);
            normalillos[50].tag = tagNew;
            recolector = normalillos[50];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[9].SetActive(true);
                normalillos[50].SetActive(false);
                normalillos[50].tag = tagNew;
                recolector = normalillos[50];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------

    public void SingapurClose()
    {
        azulitos[9].SetActive(false);
        normalillos[50].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Singapur();
    }
    //**********************************************************************



    //*************************************************************************
    //EDIFICIO ESLOVAQUIA
    public void EslovaquiaOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {

            azulitos[72].SetActive(true);
            normalillos[30].tag = tagNew;
            recolector = normalillos[30];
            recolector.SetActive(false);
        }





        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[72].SetActive(true);
                normalillos[30].SetActive(false);
                normalillos[30].tag = tagNew;
                recolector = normalillos[30];
                recolector.SetActive(false);
            }
        }
    }
    //-----------------------------------------------------------------
    public void EslovaquiaClose()
    {
        azulitos[72].SetActive(false);
        normalillos[30].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Eslovaquia();
    }
    //*********************************************************



    //*******************************************************************
    public void HonoluluOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[41].SetActive(true);
            normalillos[43].tag = tagNew;
            recolector = normalillos[43];
            recolector.SetActive(false);
        }



        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[41].SetActive(true);
                normalillos[43].SetActive(false);
                normalillos[43].tag = tagNew;
                recolector = normalillos[43];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------

    public void HonoluluClose()
    {
        azulitos[41].SetActive(false);
        normalillos[43].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Honolulu();
    }
    //*********************************************************



    //**********************************************************
    public void CanberraOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[37].SetActive(true);
            normalillos[44].tag = tagNew;
            recolector = normalillos[44];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[37].SetActive(true);
                normalillos[44].SetActive(false);
                normalillos[44].tag = tagNew;
                recolector = normalillos[44];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------
    public void CanberraClose()
    {
        azulitos[37].SetActive(false);
        normalillos[44].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Canberra();
    }
    //**********************************************************************



    //************************************************************************
    //EDIFICIO BRASILIA
    public void BrasiliaOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {

            azulitos[26].SetActive(true);
            normalillos[37].tag = tagNew;
            recolector = normalillos[37];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[26].SetActive(true);
                normalillos[37].SetActive(false);
                normalillos[37].tag = tagNew;
                recolector = normalillos[37];
                recolector.SetActive(false);
            }
        }
    }
    //----------------------------------------------------------------
    public void BrasiliaClose()
    {
        azulitos[26].SetActive(false);
        normalillos[37].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Brasilia();
    }
    //*****************************************************************



    //*****************************************************************
    //EDIFICIO YOKOHAMA
    public void YokohamaOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[22].SetActive(true);
            normalillos[55].tag = tagNew;
            recolector = normalillos[55];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[22].SetActive(true);
                normalillos[55].SetActive(false);
                normalillos[55].tag = tagNew;
                recolector = normalillos[55];
                recolector.SetActive(false);
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public void YokohamaClose()
    {
        azulitos[22].SetActive(false);
        normalillos[55].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Yokohama();
    }
    //*******************************************************


    //**********************************************************
    //EDIFICIO GUATEMALA
    public void GuatemalaOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[4].SetActive(true);
            normalillos[60].tag = tagNew;
            recolector = normalillos[60];
            recolector.SetActive(false);
        }





        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[4].SetActive(true);
                normalillos[60].SetActive(false);
                normalillos[60].tag = tagNew;
                recolector = normalillos[60];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------

    public void GuatemalaClose()
    {
        azulitos[4].SetActive(false);
        normalillos[60].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Guatemala();
    }
    //*********************************************************************


    //*********************************************************************
    //EDIFICIO WASHINGTON
    public void WashingtonOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {

            azulitos[23].SetActive(true);
            normalillos[73].tag = tagNew;
            recolector = normalillos[73];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[23].SetActive(true);
                normalillos[73].SetActive(false);
                normalillos[73].tag = tagNew;
                recolector = normalillos[73];
                recolector.SetActive(false);
            }
        }
    }
    //--------------------------------------------------------------
    public void WashingtonClose()
    {
        azulitos[23].SetActive(false);
        normalillos[73].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Washington();
    }
    //*************************************************************



    //**************************************************************
    //EDIFICIO DACCA 
    public void DaccaOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {
            azulitos[10].SetActive(true);
            normalillos[26].tag = tagNew;
            recolector = normalillos[26];
            recolector.SetActive(false);
        }




        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;

            if (recolector == null)
            {
                azulitos[10].SetActive(true);
                normalillos[26].SetActive(false);
                normalillos[26].tag = tagNew;
                recolector = normalillos[26];
                recolector.SetActive(false);
            }
        }
    }
    //---------------------------------------------------------------------

    public void DaccaClose()
    {
        azulitos[10].SetActive(false);
        normalillos[26].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Dacca();
    }
    //********************************************************************


    //*********************************************************************
    //EDIFICIO HAMBURGO
    public void HamburgoOpen()
    {
        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == false)
        {

            azulitos[62].SetActive(true);
            normalillos[23].tag = tagNew;
            recolector = normalillos[23];
            recolector.SetActive(false);
        }





        //************************************************
        //Código para cuando haya un edificio seleccionado
        if (edificio_blue == true)
        {
            edificio_blue.SetActive(false);
            recolector.tag = tagNameNormal;
            recolector.SetActive(true);
            recolector = null;


            if (recolector == null)
            {
                azulitos[62].SetActive(true);
                normalillos[23].SetActive(false);
                normalillos[23].tag = tagNew;
                recolector = normalillos[23];
                recolector.SetActive(false);
            }
        }
    }


    public void HamburgoClose()
    {
        azulitos[62].SetActive(false);
        normalillos[23].tag = tagNameNormal;
        recolector.SetActive(true);
        recolector = null;
        ux.ResetButtons_Hamburgo();
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //************************************************************************************************************************************************************************
    //FIN DEL CÓDIGO
}
