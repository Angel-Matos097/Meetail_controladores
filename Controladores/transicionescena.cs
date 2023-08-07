using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transicionescena : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private AnimationClip animacionFinal;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
    }


}
