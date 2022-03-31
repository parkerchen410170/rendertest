using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve: MonoBehaviour
{
    public GameObject AnimGameObject;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = AnimGameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() 
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "MainCharacter")
        {
            animator.SetBool("DISPLAY", true);
        }
        else
        {
            animator.SetBool("DISPLAY", false);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "MainCharacter")
        {
            animator.SetBool("DISPLAY", false);
        }
        else
        {
            animator.SetBool("DISPLAY", true);
        }
    }
}