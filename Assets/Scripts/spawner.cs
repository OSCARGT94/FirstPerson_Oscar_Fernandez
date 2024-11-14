using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField]Transform[] puntosSpanw;
    [SerializeField] GameObject enemigoPrefab;
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
            Instantiate(enemigoPrefab, puntosSpanw[Random.Range(0,puntosSpanw.Length)].position, Quaternion.identity);
            yield return new WaitForSeconds(2);
        }
    }
}
