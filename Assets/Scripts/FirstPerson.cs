using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    CharacterController Controller;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moverYRotar();
    }
    void moverYRotar()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 movimiento = new Vector3(h, 0, v).normalized;

        float anguloRotcaion = Mathf.Atan2(movimiento.x, movimiento.z) * Mathf.Rad2Deg + Camera.main.transform.rotation.eulerAngles.y;

        if (movimiento.magnitude > 0)
        {
            transform.eulerAngles = new Vector3(0, anguloRotcaion, 0);

        }

        Controller.Move(movimiento * velocidadMovimiento * Time.deltaTime);

    }
}
