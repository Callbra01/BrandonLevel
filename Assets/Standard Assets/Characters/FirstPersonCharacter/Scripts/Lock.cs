using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public int lockIndex;
    public bool isInRangeOfPlayer;
    public GameObject player;
    public bool isUnlocked = false;
    public Collider block;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<FirstPersonController>().bKeyCount >= this.lockIndex && isInRangeOfPlayer)
        {
            if (Input.GetKeyDown(KeyCode.E) && this.isUnlocked == false)
            {
                block.gameObject.SetActive(false);
                this.isUnlocked = true;
            }
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
