using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // Update is called once per frame
    bool coolingdown = false;
    float cooldownTimer = 1;
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !coolingdown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolingdown = true;
        }
        else
        {
            cooldownTimer -= Time.deltaTime;
            if ( cooldownTimer <= 0)
            {
                coolingdown = false;
                cooldownTimer += 1;
            }
        }
    }
}

