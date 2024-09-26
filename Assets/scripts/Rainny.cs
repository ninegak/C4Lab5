using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainny : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    CharacterController controller;


    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        anim.SetBool("isDancin", false);
        anim.SetBool("isGreeting", false);
        anim.SetBool("isHeadbut", false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKey(KeyCode.W);
    }
}
