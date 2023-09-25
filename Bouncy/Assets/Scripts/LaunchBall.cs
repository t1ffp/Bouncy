using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBall : MonoBehaviour
{
    public float forceApplied = 0;
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("ball") && (Input.GetKey(KeyCode.Space)))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(forceApplied * Vector3.up, ForceMode.Impulse);
        }
    }
}
