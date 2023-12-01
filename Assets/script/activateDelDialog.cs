using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateDelDialog : MonoBehaviour
{
    public GameObject mypdl;
    public string txtString;
    public GameObject globalDel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void vkl()
    {

        mypdl.SetActive(true);
        globalDel.GetComponent<delsegm>().txtString = txtString;
    }
}
