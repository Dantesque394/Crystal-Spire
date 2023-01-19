using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float inputX;
    float inputZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 mouvement = Quaternion.Euler(new Vector3(0,-135.845f,0)) * new Vector3(inputX, 0, inputZ);
        GetComponent<CharacterController>().Move(mouvement); 
    }
}
