using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    public float ElevatorTimer = 0;
    public bool enteredElevator = false;

    public GameObject F1_COLLIDER;
    public GameObject F2_COLLIDER;

    // Start is called before the first frame update
    void Start()
    {
        //F1_COLLIDER.transform.parent
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (enteredElevator)
        {
            ElevatorTimer += Time.deltaTime;
            F1_COLLIDER.SetActive(false);
            F2_COLLIDER.SetActive(false);

        }
        else
        {
            F1_COLLIDER.SetActive(true);
            F2_COLLIDER.SetActive(true);
        }

        if (ElevatorTimer >= 5f)
        {
            enteredElevator = false;
            ElevatorTimer = 0;
        }
    }
}


