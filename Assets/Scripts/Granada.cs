using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float impulso;
    [SerializeField] GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().AddForce(transform.forward * impulso, ForceMode.Impulse);
        Destroy(gameObject,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(1,1,1) * Random.Range(0,3) * Time.deltaTime);
    }
    private void OnDestroy()
    {
        Instantiate(explosion,transform.position,Quaternion.identity);
    }
}
