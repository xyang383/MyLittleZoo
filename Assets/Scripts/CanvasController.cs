using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {
    public GameObject timeSlider;
    public GameObject goButton;
    public Text timeText;
    public GameObject mainCanvas;
    public GameObject focusCanvas;
    public GameObject Timer;
    private timer timerScript;

	// Use this for initialization
	void Start () {
        timerScript = Timer.GetComponent<timer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void mainToFocus() {
        mainCanvas.SetActive(false);
        focusCanvas.SetActive(true);
        timeSlider.SetActive(true);
        goButton.SetActive(true);
        timeText.text = "Set Timer";
    }

    public void  otherToMain() {
        timerScript.stopTimer();
        focusCanvas.SetActive(false);
        mainCanvas.SetActive(true);

    }
}
