using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kall : MonoBehaviour
{
    public string txtString;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseUp()
    {
       
        PlayerPrefs.SetString("WorldName", txtString);
       
        SceneManager.LoadScene("intro-3");
    }
}
