using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public int keyIndex;
    public bool isCollectable = false;
    bool isCollected = false;
    public GameObject player;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isCollectable && !isCollected)
        {
            if (player.GetComponent<FirstPersonController>().bKeyCount < keyIndex)
            {
                player.GetComponent<FirstPersonController>().bKeyCount = keyIndex;
            }
            isCollected = true;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isCollectable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isCollectable = false;
        }
    }
}
