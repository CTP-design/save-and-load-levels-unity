using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class delsegm : MonoBehaviour
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

        string saves = PlayerPrefs.GetString("saves", "");
        if (saves.Length > 0)
        {
           
            string[] ListofLvl = saves.Split(","[0]);
            string gad = "";
            string zpt = ",";
            for (int i = 0; i < ListofLvl.Length; i++)
            {
                if (i == ListofLvl.Length ) { zpt = ""; }
                if (ListofLvl[i] == txtString) {  }
                else
                {

                    if (ListofLvl[i].Length > 1)
                    {
                        gad = gad + ListofLvl[i] + zpt;
                    }

                }
            }
            //gad = gad + WorldName;
            ///print(gad);
            PlayerPrefs.SetString("saves", gad);

            PlayerPrefs.SetString(txtString + "-idd", "");

            PlayerPrefs.SetString(txtString + "-spoint", "");

            PlayerPrefs.SetString(txtString + "-amp", "");
            PlayerPrefs.SetString(txtString + "-frq", "");
            PlayerPrefs.SetString(txtString + "-damval", "");
            PlayerPrefs.SetString(txtString + "-time", "");
            PlayerPrefs.SetString(txtString + "-seed", "");
            PlayerPrefs.SetString(txtString + "-wg", "");
            PlayerPrefs.SetString(txtString + "-trees", "");
            PlayerPrefs.SetString(txtString + "-water", "");
            PlayerPrefs.SetString(txtString + "-animals", "");
            PlayerPrefs.SetString(txtString + "-chundliks", "");
            PlayerPrefs.SetString(txtString + "-endls", "");
            PlayerPrefs.SetString(txtString + "-physica", "");
            PlayerPrefs.SetString(txtString + "-bobo", "");
            PlayerPrefs.SetString(txtString + "-numtr", "");
            PlayerPrefs.SetString(txtString + "-dellist", "");
            PlayerPrefs.SetString(txtString + "-stadotype", "");
            PlayerPrefs.SetString(txtString + "-stado", "");
            PlayerPrefs.SetString(txtString + "-rbvec", "");
            PlayerPrefs.SetString(txtString + "-rbtype", "");
            PlayerPrefs.SetString(txtString + "-rbmod", "");
            PlayerPrefs.SetString(txtString + "-playerpos", "");

            PlayerPrefs.SetString(txtString + "-far", "");
            PlayerPrefs.SetString(txtString + "-fars", "");
            PlayerPrefs.SetString(txtString + "-joystick", "");
            PlayerPrefs.SetString(txtString + "-delanto", "");

            PlayerPrefs.SetString(txtString + "-trancaballo", "");
            PlayerPrefs.SetString(txtString + "-capt", "");

            PlayerPrefs.SetString(txtString + "-alrun", "");

            PlayerPrefs.SetString(txtString + "-adddamm", "");




            SceneManager.LoadScene("load");



        }





    }

}
