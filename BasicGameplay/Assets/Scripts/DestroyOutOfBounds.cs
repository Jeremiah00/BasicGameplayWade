using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBounds = 30;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > sideBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -sideBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            gameManager.Addlives(-1);
            Destroy(gameObject);
        }
    }
}
