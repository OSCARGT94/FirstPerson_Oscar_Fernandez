using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bazoka : MonoBehaviour
{
    [SerializeField] GameObject grandaPrefab;
    [SerializeField] Transform Spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //instanciar una grnada en la boca del bazoka
            Instantiate(grandaPrefab,Spawnpoint.position, transform.rotation);
        }
    }
}
