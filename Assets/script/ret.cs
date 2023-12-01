using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ret : MonoBehaviour
{
    public Text wg;
    public Text solo;
    public string tak;
    public GameObject openbutton;
    public GameObject dell;
    public GameObject raw;
    public GameObject share;
    // Start is called before the first frame update
    void Start()
    {
        solo.text = tak;
        openbutton.GetComponent<kall>().txtString = tak;
        dell.GetComponent<activateDelDialog>().txtString = tak;
        share.GetComponent<opsend>().txtString = tak;
    }

    
}
