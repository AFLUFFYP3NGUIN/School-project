using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliRotation : MonoBehaviour
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
            transform.Rotate(0, 10, 0 * speed * Time.deltaTime);
        }
    }
}
