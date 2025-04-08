using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMonedas : MonoBehaviour
{
    // 1- declaracion de variables
    public float montoAConvertir;
    public string codigoMoneda;

    float cotizacionMoneda;
    float montoConvertido;
    float cotizacionDolar = 1204.35f;
    float cotizacionEuro = 1541.11f;
    float cotizacionReal = 201.34f;
    float MinimoAConvertir = 1000;

    // Start is called before the first frame update
    void Start()
    {
        // 2- ingreso y validacion de datos
        if (montoAConvertir < MinimoAConvertir)
        {
            Debug.Log("El monto mínimo es $1000");
            return;
        }
        if (codigoMoneda == "D")
        {
            cotizacionMoneda = cotizacionDolar;
        }
        else if (codigoMoneda == "E")
        {
            cotizacionMoneda = cotizacionEuro;
        }
        else if (codigoMoneda == "R")
        {
            cotizacionMoneda = cotizacionReal;
        }
        else
        {
            Debug.Log("Opción de moneda extranjera no válida");
            return;
        }
        // 3- Procesamiento de los datos

        montoConvertido = montoAConvertir / cotizacionMoneda;

        // 4- Salida de los datos

        Debug.Log("Monto convertido: " + montoConvertido);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
