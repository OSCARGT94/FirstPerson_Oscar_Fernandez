using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ThirdPerson : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    CharacterController Controller;
    [SerializeField]float tiempoSuave;
    [SerializeField]float velocidadRot;

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

        if (input.magnitude > 0)
        {

            float angulo = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;

            float anguloSuave = Mathf.SmoothDampAngle(transform.eulerAngles.y, angulo, ref velocidadRot, tiempoSuave);

            transform.eulerAngles = new Vector3(0, anguloSuave, 0);


            Vector3 movimiento = Quaternion.Euler(0, angulo, 0) * Vector3.forward;

            Controller.Move(movimiento * velocidadMovimiento * Time.deltaTime);

        }






    }

}
