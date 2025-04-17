using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerKey : MonoBehaviour
{
    public bool isInRangeOfPlayer = false;
    public FirstPersonController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInRangeOfPlayer)
        {
            player.bHasEndKey = true;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInRangeOfPlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInRangeOfPlayer = false;
        }
    }
}
