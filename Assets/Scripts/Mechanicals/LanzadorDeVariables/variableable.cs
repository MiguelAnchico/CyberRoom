using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variableable : MonoBehaviour
{
    public int tipoDeVariableAceptada=0;
    public int capacidad=3;
    int cantidadRecibida=0;
    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<blockvariable>().EresTipo(tipoDeVariableAceptada))
        {
            cantidadRecibida++;
            Debug.Log("Se ha recibido una variable, hay" + cantidadRecibida);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<blockvariable>().EresTipo(tipoDeVariableAceptada))
        {
            cantidadRecibida--;
            Debug.Log("Se ha recibido una variable, hay" + cantidadRecibida);
        }
    }

    public bool Cantidad()
    {
        return cantidadRecibida >= capacidad;
    }
}
