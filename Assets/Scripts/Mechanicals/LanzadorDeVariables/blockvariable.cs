using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockvariable : MonoBehaviour
{
    [SerializeField] string[] tipoDeVariable = new string[] { "String", "Int", "Real", "Boolean" };
    public int tipoVariableEscogido = 0;
    
    //Este script se le agregará a un bloque que puede ser agarrado por el jugador.
    private void Awake()
    {
        //validamos que el objeto tenga un tag variableable que le permitirá al detector saber qué tipo de tag es
        if(gameObject.tag!= "variableable")
        {
            #if UNITY_EDITOR
                Debug.LogError("Objeto variableable sin tag asignado, porfavor asigne un tag y vuelvalo a intentar", gameObject.transform);
                UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_WEBPLAYER
                     Application.OpenURL(webplayerQuitURL);
            #else
                     Application.Quit();
            #endif
        }
    }

    public bool EresTipo(int tipo)
    {
        return tipoVariableEscogido == tipo;
    }
}
