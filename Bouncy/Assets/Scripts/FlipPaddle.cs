using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FlipPaddle : MonoBehaviour
{
    public Animator paddleAnim;

    private void Start()
    {
        paddleAnim = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            paddleAnim.SetBool("spacePressed", true);
        }
        else
        {
            paddleAnim.SetBool("spacePressed", false);
        }
    }

}
