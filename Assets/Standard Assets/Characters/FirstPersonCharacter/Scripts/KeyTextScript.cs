using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyTextScript : MonoBehaviour
{
    public FirstPersonController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMeshProUGUI>().text = $"Keys: {player.bKeyCount}";
    }
}
