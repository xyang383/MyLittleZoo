using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    float timeLeft;
    Spawner spawn;
    //Text time;
    public GameObject SpawnerObject;
    bool CheckTime = false;
    public Text text;
    private timeDisplay timeDisp;

    // Use this for initialization
    void Start () {
       //time = "hellop";
        spawn = SpawnerObject.GetComponent<Spawner>();
        timeDisp = text.GetComponent<timeDisplay>();
    }
	
	// Update is called once per frame
	void Update () {
        if (CheckTime) {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                timeDisp.setText("Congrats!\nA new animal added!");
                spawn.Spawn();
                CheckTime = false;
            } else {
                timeDisp.setTime(timeLeft);


            }

        }
       

    }

    public void setTime(float value)
    {
        timeLeft =  value;
        CheckTime = true;


    }
    public void stopTimer() {
        CheckTime = false;
    }
}
