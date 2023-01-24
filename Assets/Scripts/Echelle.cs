using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Echelle : MonoBehaviour
{
    public string destination ;
    bool playerProche = false;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        playerProche = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerProche = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerProche == true)
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = GameObject.Find(destination).GetComponent<Transform>().position;
            player.GetComponent<CharacterController>().enabled = true;
            print(destination);
        }
    }
}
