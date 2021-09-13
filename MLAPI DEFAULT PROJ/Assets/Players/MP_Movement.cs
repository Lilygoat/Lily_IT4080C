using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAPI;

public class MP_Movement : NetworkBehaviour
{
    public float moveSpeed = 1.0f;
    public CharacterController player;
    private Camera playerCam;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        playerCam = GetComponentInChildren<Camera>();

        //Set Color
        if(IsLocalPlayer)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }

        //Disable Cameras
        if(!IsLocalPlayer)
        {
            playerCam.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(IsLocalPlayer)
        {
            MovePlayer();
        }
    }

    public void MovePlayer()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        player.SimpleMove(movement*moveSpeed);
    }
}
