using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorRotation : MonoBehaviour
{

    public float speed;

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver == false)
        {
            transform.Rotate(10, 0, 0 * speed * Time.deltaTime);
        }
    }
}
