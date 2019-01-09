using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandom : MonoBehaviour {

    NavMeshAgent navMeshAgent;

    public float timerForNewPath;

    public float xLow;
    public float xHigh;
    public float yLow;
    public float yHigh;

    bool inCoRoutine;

	// Use this for initialization
	void Start () {
        navMeshAgent = GetComponent<NavMeshAgent>();
	}

    Vector3 getNewRandomPosition() 
    {
        float x = Random.Range(xLow, xHigh);
        float z = Random.Range(yLow, yHigh);
        float y = 0.0F;

        Vector3 pos = new Vector3(x, y, z);
        return pos;

    }
	
    IEnumerator DoSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timerForNewPath);
        GetNewPath();
        inCoRoutine = false;

    }


    void GetNewPath()
    {
        navMeshAgent.SetDestination(getNewRandomPosition());
    }
	// Update is called once per frame
	void Update () {
        if (!inCoRoutine)
        {
            StartCoroutine(DoSomething());
        }
		
	}

}
