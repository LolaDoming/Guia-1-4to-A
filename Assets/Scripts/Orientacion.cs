using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientacion : MonoBehaviour
{
    public string NombreAlumno;
    public int AñoAlumno;
    public string OrientacionAlumno;

    string T;
    string D;
    string H;
    string G;
    string M;



    // Start is called before the first frame update
    void Start()
    {
        if (NombreAlumno == " ") 
        {
            Debug.Log("Error. El nombre del alumno no puede estar vacío.");
        }
        if (AñoAlumno == 1 || AñoAlumno == 2)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }
        if (AñoAlumno != 1 || AñoAlumno != 2 || AñoAlumno != 3 || AñoAlumno != 4 || AñoAlumno != 5)
        {
            Debug.Log("Error. El año del alumno debe ser desde el primer año hasta el quinto año.");
        }
        if (OrientacionAlumno != "T" || OrientacionAlumno != "D" || OrientacionAlumno != "H" || OrientacionAlumno != "G" || OrientacionAlumno != "M")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
