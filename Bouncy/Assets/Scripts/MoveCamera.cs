using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public int boundry = 50;
    public float speed = 5;
    public GameObject player;


    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = transform.position;
        float playerPos = player.transform.position.x;

        if (playerPos > 0 - boundry)
        {
            Debug.Log("hit");
            camPos.x += speed * Time.deltaTime;

        }
        if (playerPos < 0 + boundry)
        {
            Debug.Log("hit");
            camPos.x -= speed * Time.deltaTime;
        }
    }
}
