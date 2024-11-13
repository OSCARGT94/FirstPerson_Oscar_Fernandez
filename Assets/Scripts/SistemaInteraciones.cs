using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaInteraciones : MonoBehaviour
{
    Camera cam;
    int contadroInteraciones;
    [SerializeField] float distaciaRayo;
    CajaAmmo cajaMunicion;
    Transform interacuableActual;

    Color rayColor = Color.red;

    // Start is called before the first frame update
    void Start()
    {
        contadroInteraciones = 0;
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

        Caja();
    }
    private void Caja()
    {
        if ( Physics.Raycast (cam.transform.position, cam.transform.forward, out RaycastHit hit, distaciaRayo ) )
        {
            Debug.DrawRay(cam.transform.position, cam.transform.forward * distaciaRayo, rayColor );

            if (hit.transform.TryGetComponent(out CajaAmmo cajaMunicion ))
            {
                contadroInteraciones++;

                Debug.Log("INTERACTUA acción numero: " + contadroInteraciones);

                interacuableActual = cajaMunicion.transform;

                interacuableActual.GetComponent<Outline>().enabled = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    cajaMunicion.AbrirCaja();

                }

            }
            else if (interacuableActual != null)
            {

                interacuableActual.GetComponent<Outline>().enabled = false;

                interacuableActual = null;
            }

        }
        

    }
}
