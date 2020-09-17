using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public EnemyMovement2 enemyprefab;
    public GameObject rotesfeld;
    public float waitingtime = 0;
    public int testi = 0;
    bool isspawning = true;

    
	// Use this for initialization
	void Update ()
    {
        if (isspawning)
        {
            waitingtime = waitingtime + Time.deltaTime;
            if (waitingtime >= 1)
            {
                EnemyMovement2 temp = Instantiate(enemyprefab, transform.position, Quaternion.identity);
                temp.Setdestination(rotesfeld.transform.position);
                waitingtime = 0;
                testi++;
                if (testi > 19)
                {
                    isspawning = false;
                }
            }
        }
        
    }
	
	
}
