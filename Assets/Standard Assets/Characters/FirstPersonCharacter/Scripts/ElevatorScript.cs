using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    public Transform F1POS;
    public Transform F2POS;

    public int currentFloor = 1;
    public float elevatorSpeed = 0.05f;

    public bool isElevatorActive = false;

    public bool playerIsInElevator = false;

    float elevatorTimer = 0;

    public GameObject elevatorText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsInElevator)
        {
            elevatorText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                isElevatorActive = true;
            }
        }
        else
        {
            elevatorText.SetActive(false);
        }

        if (isElevatorActive)
        {
            elevatorTimer += Time.deltaTime;

            if (currentFloor == 1)
            {
                GOTOFLOOR2();
            }

            if (currentFloor == 2)
            {
                GOTOFLOOR1();
            }
        }

        if (elevatorTimer > 3.5f)
        {
            isElevatorActive = false;

            currentFloor++;

            elevatorTimer = 0;
        }

        if (currentFloor > 2)
        {
            currentFloor = 1;
        }
    }

    void GOTOFLOOR1()
    {
        transform.position = Vector3.Lerp(transform.position, F1POS.position, elevatorSpeed);

        if (transform.position == F1POS.position)
        {
            currentFloor = 1;
            isElevatorActive = false;
        }
    }

    void GOTOFLOOR2()
    {
        transform.position = Vector3.Lerp(transform.position, F2POS.position, elevatorSpeed);

        if (transform.position == F2POS.position)
        {
            currentFloor = 2;
            isElevatorActive = false;
        }
    }
}


