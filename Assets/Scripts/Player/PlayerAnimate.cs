using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerAnimate : MonoBehaviour
{
    Animator animator;
    public float motion;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("motion", motion);
    }
}
