using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class goButton : MonoBehaviour {

    public timer tt;
    float value;
    public GameObject canvas2;
    public Text timerText;
    public GameObject timeSlider;
    public GameObject self;
    public void hitGo()
    {
        timeSlider.SetActive(false);        //canvas2.SetActive(false);
        self.SetActive(false);

        tt.setTime(value);



    }
    public void setvalue(float f) {
        value = f;
    }


}
