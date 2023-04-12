using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator animator;
    public bool habilitada;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.CompareTag("Player") && habilitada)
        {
            animator.SetBool("character_nearby", true);
        }
    }

    void OnTriggerExit(Collider col) {
        if (col.gameObject.CompareTag("Player") && habilitada)
        {
            animator.SetBool("character_nearby", false);
        }
    }
}
