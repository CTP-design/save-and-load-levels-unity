using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opsend : MonoBehaviour
{
    public string txtString;

    public void OnMouseUp()
    {
       
        PlayerPrefs.SetString("WorldName", txtString);
        
        SceneManager.LoadScene("Senda");
    }
}
