using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdminPanelScript : MonoBehaviour
{
    public GameObject[] kLight;

    public bool k1Open = false;
    public bool k2Open = false;
    public bool k3Open = false;

    public GameObject powerLock;
    public bool kLightEffectEnabled = false;

    public int keysOpen = 0;

    public GameObject EndDoor;
    public float minIntensity = 0.1f;
    public float maxIntensity = 1.63f;
    public float flashDuration = 0.5f;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < kLight.Length; i++)
        {
            kLight[i].SetActive(false);
        }
        _timer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (kLightEffectEnabled)
        {
            _timer += Time.deltaTime;

            if (_timer >= flashDuration)
            {
                kLight[0].GetComponent<Light>().intensity = kLight[0].GetComponent<Light>().intensity == minIntensity ? maxIntensity : minIntensity;
                kLight[1].GetComponent<Light>().intensity = kLight[1].GetComponent<Light>().intensity == minIntensity ? maxIntensity : minIntensity;
                kLight[2].GetComponent<Light>().intensity = kLight[2].GetComponent<Light>().intensity == minIntensity ? maxIntensity : minIntensity;
                _timer = 0;
            }

        }
    }

}
