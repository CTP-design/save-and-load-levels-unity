using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class slider : MonoBehaviour
{
    public Slider mainSlider;
    public Text namo;

    // Start is called before the first frame update
    void Start()
    {
        mainSlider = this.GetComponent<Slider>();
    }

    public void SubmitSliderSetting()
    {
        //Displays the value of the slider in the console.
        namo.text = ""+mainSlider.value;
    }
}
