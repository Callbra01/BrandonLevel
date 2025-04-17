using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerLock : MonoBehaviour
{
    public GameObject blocker;

    FirstPersonController player;
    AdminPanelScript manager;
    public bool canOpen = false;
    public bool isInRangeOfPlayer = false;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
        manager = GameObject.FindGameObjectWithTag("Admin").GetComponent<AdminPanelScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.keysOpen == 3)
        {
            canOpen = true;
        }

        if (Input.GetKeyDown(KeyCode.F) && canOpen && isInRangeOfPlayer && player.bHasEndKey)
        {
            manager.kLightEffectEnabled = true;
            blocker.SetActive(false);
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
