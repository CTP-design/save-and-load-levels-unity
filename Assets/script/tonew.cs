using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tonew : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
       
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnMouseUp()
    {
       
        SceneManager.LoadScene("new");
    }

    public void loadHome()
    {

        SceneManager.LoadScene("activator");
    }
}
