using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private float curCountDown;
    public float timeToNextSpawn = 10;
    public GameObject animal;
    public GameObject[] ListOfAnimals;
    public float XrangeLower = 0;
    public float XrangeUpper = 0;
    public float ZrangeLower = 0;
    public float ZrangeUpper = 0;

	// Use this for initialization
	void Start () {
		
	}
	/*
	// Update is called once per frame
	void Update () {
        curCountDown = curCountDown + Time.deltaTime;
        if (curCountDown > timeToNextSpawn)
        {
            Vector3 nextSpawnPoint = new Vector3(Random.Range(XrangeLower, XrangeUpper), 0, Random.Range(ZrangeLower, ZrangeUpper));
            Instantiate(animal, nextSpawnPoint, new Quaternion(0, 0, 0, 0));
            curCountDown = 0;
        }
        
		
	}
    */
    public void Spawn() {
        Vector3 nextSpawnPoint = new Vector3(Random.Range(XrangeLower, XrangeUpper), 0, Random.Range(ZrangeLower, ZrangeUpper));
        Instantiate(animal, nextSpawnPoint, new Quaternion(0, 0, 0, 0));
    }

    public void setTimeToNextSpawn(float time) 
    {
        timeToNextSpawn = time;
    }


}
