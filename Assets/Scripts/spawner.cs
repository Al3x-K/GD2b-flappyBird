using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public float queueTime = 1.5f;
    public float time = 0;
    public GameObject obstacle; 
    public float height;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time>queueTime)
        {
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position + new Vector3(0,Random.Range(-height,height),0);
            time = 0;
            Destroy(go,10);
        }
        time += Time.deltaTime;
    }
}
