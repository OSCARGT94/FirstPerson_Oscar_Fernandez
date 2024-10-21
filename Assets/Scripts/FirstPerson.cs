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
        Vector3 input = new Vector2(h, v).normalized;

        float angulo = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;

        transform.eulerAngles = new Vector3(0, angulo, 0);


        if (input.magnitude > 0)
        {

            Vector3 movimiento = Quaternion.Euler(0, angulo, 0) * Vector3.forward;

            Controller.Move(movimiento * velocidadMovimiento * Time.deltaTime);

        }






    }
}
