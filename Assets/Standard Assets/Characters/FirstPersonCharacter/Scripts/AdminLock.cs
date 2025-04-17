using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminLock : MonoBehaviour
{
    public int lockIndex;
    public bool isInRangeOfPlayer;
    public GameObject player;
    public bool isUnlocked = false;
    public AdminPanelScript manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Admin").GetComponent<AdminPanelScript>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInRangeOfPlayer && player.GetComponent<FirstPersonController>().bKeyCount >= lockIndex && isUnlocked == false)
        {
            manager.keysOpen += 1;
            manager.kLight[lockIndex - 1].SetActive(true);
            isUnlocked = true;
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
