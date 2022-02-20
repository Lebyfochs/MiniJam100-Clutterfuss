using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float Speed;
    public bool Moving;

    ChaosHandler chaos;
    void Start()
    {
        Speed = 10f;
        Moving = true;
  
    }

    private void Awake()
    {
        chaos = GameObject.Find("ChaosHandlingOBJ").GetComponent<ChaosHandler>();
    }

    void Update()
    {

        if (Moving == true)
        {

            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 0, Speed) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-Speed, 0, 0) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, 0, -Speed) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
            }
        }

        if (chaos.GameRunning == false)
        {
            Moving = false;
        }
      
    }
}
