using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Globalization;
public class createworld : MonoBehaviour
{
    public Slider dam;
    public Dropdown dayn;
    public InputField namo;
    public Dropdown wg;
    public InputField seed;
    public Toggle tree;
    public GameObject err;
    public GameObject err1;
    public Slider frq;
    public Slider amp;
    public Toggle wtr;
    public Slider numtr;
    public Toggle endls;
    public Toggle animals;
    public Toggle chundliks;
    public Toggle physica;
    public Toggle bobo;
    public Toggle adddamm;
    public Toggle lava;
    public Toggle srv;

    public string saves = "";
    public string[] alltext;
    public GameObject loadd;
    string WorldName;
    private string cpt = "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";


    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.DeleteKey("saves");
        err.SetActive(false);
        err1.SetActive(false);
        loadd.SetActive(false);
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
    }

   

    public void OnMouseDown()
    {
                
        if (namo.text.Length == 0)
        {
            namo.text = "MyWorld - " + Random.Range(0, 4700000);
        }

        if (namo.text.Length < 3) {  err.SetActive(true); } else {  err.SetActive(false); }
        WorldName = namo.text;

      


        saves = PlayerPrefs.GetString("saves", "");
        if (saves.Length > 2 && namo.text.Length >= 3)
        {
            err1.SetActive(false);
            alltext = saves.Split(","[0]);

            for (int i = 0; i < alltext.Length; i++)
            {
                if (alltext[i] == WorldName) { err1.SetActive(true);return; }

            }


        }





        PlayerPrefs.SetString("WorldName", WorldName);

       
        PlayerPrefs.SetString(WorldName + "-needsave", "0");
        PlayerPrefs.SetString(WorldName + "-onlyplay", "0");
        PlayerPrefs.SetString(WorldName + "-dopslot", "0");
        PlayerPrefs.SetString(WorldName + "-dopsloter", "0");

        

        string sparam = "" + frq.value;

        if (sparam.IndexOf('.') != -1)
        {
            sparam = sparam.Replace('.', ',');
        }
        else
        {
            sparam = sparam.Replace(',', '.');
        }

        

        float frr = float.Parse(sparam);

        string asparam = "" + amp.value;

        if (asparam.IndexOf('.') != -1)
        {
            asparam = asparam.Replace('.', ',');
        }
        else
        {
            asparam = asparam.Replace(',', '.');
        }


        float amm = float.Parse(asparam);

       
        PlayerPrefs.SetString(WorldName + "-frq", ""+ frq.value);
        PlayerPrefs.SetString(WorldName + "-amp", ""+ amp.value);
        PlayerPrefs.SetString(WorldName + "-numtr", "" + numtr.value);

        PlayerPrefs.SetString(WorldName + "-damval", "" + dam.value);

        if (namo.text.Length >= 3)
        {
            loadd.SetActive(true);
            saves = PlayerPrefs.GetString("saves", "");
            if (saves.Length > 1)
            {
                err1.SetActive(false);
                alltext = saves.Split(","[0]);
                string collecttext = "";
                for (int i = 0; i < alltext.Length; i++)
                {
                    if (alltext[i] == WorldName) { err1.SetActive(true); }
                    else
                    {
                        collecttext = collecttext + alltext[i] + ",";
                        
                    }
                }
                collecttext = collecttext + WorldName;
                
                PlayerPrefs.SetString("saves", collecttext);
               
                

            }
            else
            {

                PlayerPrefs.SetString("saves", WorldName + "");
                
            }

            PlayerPrefs.SetString(WorldName + "-time", dayn.options[dayn.value].text);

            PlayerPrefs.SetString(WorldName + "-seed", seed.text);
            PlayerPrefs.SetString(WorldName + "-wg", wg.options[wg.value].text);
            if (tree.isOn == true) { PlayerPrefs.SetString(WorldName + "-trees", "1"); }
            if (tree.isOn == false) { PlayerPrefs.SetString(WorldName + "-trees", "0"); }

            if (wtr.isOn == true) { PlayerPrefs.SetString(WorldName + "-water", "1"); }
            if (wtr.isOn == false) { PlayerPrefs.SetString(WorldName + "-water", "0"); }

            if (endls.isOn == true) { PlayerPrefs.SetString(WorldName + "-endls", "1"); }
            if (endls.isOn == false) { PlayerPrefs.SetString(WorldName + "-endls", "0"); }

            if (animals.isOn == true) { PlayerPrefs.SetString(WorldName + "-animals", "1"); }
            if (animals.isOn == false) { PlayerPrefs.SetString(WorldName + "-animals", "0"); }

            if (chundliks.isOn == true) { PlayerPrefs.SetString(WorldName + "-chundliks", "1"); }
            if (chundliks.isOn == false) { PlayerPrefs.SetString(WorldName + "-chundliks", "0"); }

            if (physica.isOn == true) { PlayerPrefs.SetString(WorldName + "-physica", "1"); }
            if (physica.isOn == false) { PlayerPrefs.SetString(WorldName + "-physica", "0"); }

            if (bobo.isOn == true) { PlayerPrefs.SetString(WorldName + "-bobo", "1"); }
            if (bobo.isOn == false) { PlayerPrefs.SetString(WorldName + "-bobo", "0"); }

            if (adddamm.isOn == true) { PlayerPrefs.SetString(WorldName + "-adddamm", "1"); }
            if (adddamm.isOn == false) { PlayerPrefs.SetString(WorldName + "-adddamm", "0"); }

            if (lava.isOn == true) { PlayerPrefs.SetString(WorldName + "-dopsloter", "1"); }
            if (lava.isOn == false) { PlayerPrefs.SetString(WorldName + "-dopsloter", "0"); }

            PlayerPrefs.SetString(WorldName + "-delanto", "0");

            
            File.WriteAllText(Application.persistentDataPath + "/" + PlayerPrefs.GetString("WorldName") + "-capt", cpt);
           


            if (srv.isOn == true)
            {
                PlayerPrefs.SetString(WorldName + "-needsave", "1");
                PlayerPrefs.SetString(WorldName + "-onlyplay", "1");
                PlayerPrefs.SetString(WorldName + "-bobo", "1");
            }

            int pooz = Random.Range(0, 4700000);
            PlayerPrefs.SetString(WorldName + "-ideha", ""+ pooz);

            SceneManager.LoadScene("load");

        }
    }

}
