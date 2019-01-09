using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeDisplay : MonoBehaviour {
    Text time;

    //Spawner spawn;

    private void Start()
    {
        time = GetComponent<Text>();
    }


    public void setTime(float value)
    {
        time.text = Mathf.RoundToInt(value%100) + " minutes";


    }
    public void setText(string t) {
        time.text = t;
    }

}
