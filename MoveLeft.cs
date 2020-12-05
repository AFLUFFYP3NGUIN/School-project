using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 5.0f;

    private float zDestroy = -16.0f;

    private Rigidbody enemyRb;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.gameOver == false)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
