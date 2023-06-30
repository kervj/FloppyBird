using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 5;
    public GameObject prefabPipe;
    public GameObject prefabRedPipe;

    // Update is called once per frame
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnPipe();
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
       // GameObject newPipe = Instantiate(prefabPipe);
        //GameObject newRedPipe = Instantiate(prefabRedPipe);
        int random = Random.Range(0,2);
 
        if (random == 1)
        {
            GameObject newPipe = Instantiate(prefabPipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10f);
        }
        else
        {
            GameObject newPipe = Instantiate(prefabRedPipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10f);
        }

        

        
    }
}
