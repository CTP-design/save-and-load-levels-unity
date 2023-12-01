using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class levellista : MonoBehaviour
{
    public GameObject lvl;
    public GameObject clonelo;
    public GameObject cubello;
    public RawImage Test;
    // Start is called before the first frame update
    void Start()
    {
         string saves = PlayerPrefs.GetString("saves", "");
        
        if (saves.Length > 1)
        {
            
            string[] alltext = saves.Split(","[0]);
                    
                       
            for (int i = alltext.Length-1; i > -1; i--)
            {
                if (alltext[i].Length > 1)
                {

                    
                    
                    clonelo = Instantiate(lvl.gameObject);
                   
                    clonelo.transform.SetParent(this.transform, false);
                  
                    
                    clonelo.GetComponent<ret>().tak = alltext[i];
                    clonelo.GetComponent<ret>().wg.text = "Chunk size-" + PlayerPrefs.GetString(alltext[i] + "-wg") + " | Frequency - " + PlayerPrefs.GetString(alltext[i] + "-frq") + " | Amplitude - " + PlayerPrefs.GetString(alltext[i] + "-amp") + " | Seed - " + PlayerPrefs.GetString(alltext[i] + "-seed") + " | ID - " + PlayerPrefs.GetString(alltext[i] + "-ideha");

                   
                    string capa = File.ReadAllText(Application.persistentDataPath + "/" + alltext[i] + "-capt");
                    if (capa != "")
                    {
                        Test = clonelo.GetComponent<RawImage>();
                        

                        if (!string.IsNullOrEmpty(capa))
                        {
                            
                            byte[] texByte = System.Convert.FromBase64String(capa);
                            Texture2D tex = new Texture2D(2, 2, TextureFormat.ARGB32, false);

                            
                            if (tex.LoadImage(texByte))
                            {
                                clonelo.GetComponentInChildren<RawImage>().texture = tex;

                            }
                        }
                    }


                   



                }
            }
          
        }
    }

  

    
}
