using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObisticleProfabs,temp;
   
    private float startDelay = 5;
    private float repeatRate = 5;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpanRandomObsticles", startDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpanRandomObsticles()
    {
        foreach (GameObject i in temp)
            Destroy(i);

        int ObsticleIndex = Random.Range(0, 4);
        temp[0] = Instantiate(ObisticleProfabs[0],  new Vector3(-9f,50f,0),ObisticleProfabs[0].transform.rotation);
        temp[1] = Instantiate(ObisticleProfabs[1],  new Vector3(-4f,50f,0),ObisticleProfabs[0].transform.rotation);
        temp[2] = Instantiate(ObisticleProfabs[2],  new Vector3(1f,50f,0),ObisticleProfabs[0].transform.rotation);
        temp[3] = Instantiate(ObisticleProfabs[3],  new Vector3(6f,50f,0),ObisticleProfabs[0].transform.rotation);
        temp[4] = Instantiate(ObisticleProfabs[4],  new Vector3(11f,50f,0),ObisticleProfabs[0].transform.rotation);
        temp[ObsticleIndex].SetActive(false);
       
    }

}
