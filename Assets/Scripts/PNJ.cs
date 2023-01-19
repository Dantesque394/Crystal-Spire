using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PNJ : MonoBehaviour
{
    int CompteurTexte = 0;
    bool playeurProche = false;
    public GameObject ZoneDeTexte;
    public TextMeshProUGUI ContenuTexte;
    public string[] TextAffiche;


    // Start is called before the first frame update
    void Start()
    {
        ContenuTexte.text = "text test";
    }
    private void OnTriggerEnter(Collider other)
    {
        playeurProche = true;
    }
    private void OnTriggerExit(Collider other)
    {
        playeurProche = false;
        ZoneDeTexte.SetActive(false);
        CompteurTexte = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playeurProche == true)
        {
            ZoneDeTexte.SetActive(true);
            if (CompteurTexte <= TextAffiche.Length-1)
            {
                ContenuTexte.text = TextAffiche[CompteurTexte];
                CompteurTexte += 1;
            }
            else
            {
                CompteurTexte = 0;
                ZoneDeTexte.SetActive(false);
            }

            //GetComponent<MeshCollider>().enabled = true;
        }
    }
}
