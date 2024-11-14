using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Coroutine semaforo = StartCoroutine(ejemploSemaforo());

        //StopAllCoroutines();

        StopCoroutine(semaforo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ejemploSemaforo()
    {
        while (true) 
        {

            Debug.Log("Verde");
            yield return new WaitForSeconds(1);
            Debug.Log("Amarillo");
            yield return new WaitForSeconds(1);
            Debug.Log("Rojo");
            yield return new WaitForSeconds(1);

        }

    }
}
