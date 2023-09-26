using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAnimation : MonoBehaviour
{
    public Animator hitAnim;

    private void Start()
    {
        hitAnim = GetComponentInChildren<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            hitAnim.SetBool("isHit", true);
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        hitAnim.SetBool("isHit", false);
    }

}
