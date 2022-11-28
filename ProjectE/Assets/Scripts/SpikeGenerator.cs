using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject Spike;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;
    public float SpeedMultiplier;
    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        generateSpike();
    }

    public void RandomGenerateSpike()
    {
        float randomWait = Random.Range(0.1f, 1.2f);
        Invoke("generateSpike", randomWait);
    }
    public void generateSpike()
    {
        GameObject SpikeIns = Instantiate(Spike, transform.position, transform.rotation);

        SpikeIns.GetComponent<SpikeScript>().spikeGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}
