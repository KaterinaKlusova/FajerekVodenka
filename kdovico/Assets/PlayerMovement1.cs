using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool skok = false;
    bool dolu = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("LevaPrava") * runSpeed;
        if (Input.GetButtonDown("Skok"))
        {
            skok = true;
        }

        if (Input.GetButtonDown("Dolu"))
        {
            dolu = true;
        }
        else if (Input.GetButtonDown("Dolu"))
        {
            dolu = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, dolu, skok);
        skok = false;


    }
}
