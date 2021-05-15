using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAwake : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Obj;
    public GameObject mainPlayer;
    // public float pZ;
    public int n;
    public GameObject[] objectList;
    public Vector3 latestEndPosition;
    // public Vector3 previousEndPosition;

    void Awake(){
        // print("in awake");
        // Instantiate(Obj,transform.position,Quaternion.identity);
        // Instantiate(Obj,new Vector3(715.96f,-366.9872f,-191.6f),Quaternion.identity);
        // pZ-=;
    }
    void Update(){
        // print(Vector3.Distance(mainPlayer.transform.position,latestEndPosition));   
        if(Vector3.Distance(mainPlayer.transform.position,latestEndPosition)>780||Vector3.Distance(mainPlayer.transform.position,latestEndPosition)<170){
            GameObject g = clone();
            // previousEndPosition=latestEndPosition;
            latestEndPosition = g.transform.Find("EndPosition").transform.position;
            // print(previousEndPosition);
            // print(latestEndPosition);
            // for(int i=0;i<3;i++){
                // GameObject objectToInsert = objectList[Random.Range(0,objectList.Length)];
                // Instantiate(objectToInsert,new Vector3(latestEndPosition.x-Random.Range(70f,125f),latestEndPosition.y,Random.Range(latestEndPosition.z,previousEndPosition.z)),Quaternion.identity);
                // Instantiate(objectToInsert,new Vector3(latestEndPosition.x,latestEndPosition.y,Random.Range(latestEndPosition.z,previousEndPosition.z)),Quaternion.identity);
            // }
            
        }
    }

    GameObject clone(){
        GameObject t=Instantiate(Obj,new Vector3(715.96f,-366.9872f,-191.6f-(95.9f*n)),Quaternion.identity);
        n++;
        return t;
    }
}
