using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]Transform[] puntosSpanw;
    [SerializeField] GameObject enemigoPrefab;
    [SerializeField] int numeroNiveles;
    [SerializeField] int numeroRondas;
    [SerializeField] int spawnsPorRondas;
    [SerializeField] float esperaEntreSpawns;
    [SerializeField] float esperaEntreRondas;
    [SerializeField] float esperaNiveles;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnPedros());
        // sacar una copia de un prefab de un enemigo
        // Quaternion.identity: (0,0,0)
        //Instantiate(enemigoPrefab, puntosSpanw[0].position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnPedros()
    {
        while (true)
        {
            

            for (int i = 0; i < puntosSpanw.Length; i++)//niveles(5)
            {

                for (int j = 0; j < puntosSpanw.Length; j++)//rondas(5)
                {

                    for (int k = 0; k < puntosSpanw.Length; k++)//spawns(10)
                    {

                        int indiceAleatorio = Random.Range(0, puntosSpanw.Length);
                        Instantiate(enemigoPrefab, puntosSpanw[indiceAleatorio].position, Quaternion.identity);
                        yield return new WaitForSeconds(esperaEntreSpawns);

                    }
                    yield return new WaitForSeconds(esperaEntreRondas);

                }

                yield return new WaitForSeconds(esperaNiveles);
            }
        }
    }

}
