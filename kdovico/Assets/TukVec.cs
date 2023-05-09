using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TukVec : MonoBehaviour
{
    public GameObject otherPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown ()
    {
        otherPlayer.GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerMovement>().enabled = true;
    }      

}
