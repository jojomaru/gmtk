using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallStat : MonoBehaviour
{
    public int myMoney; //money (score)
    public float povRate; //poverty rate
    public float crimeRate; //crime rate
    public float repRate; //reputation rate
    public int timeCycle; //runs per quarter up to 4 years

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //placeholder for random event
    float Choose(float[] probs)
    {
        float total = 0;

        foreach (float elem in probs)
        {
            total += elem;
        }

        float randomPoint = Random.value * total;

        for (int i = 0; i < probs.Length; i++)
        {
            if (randomPoint < probs[i])
            {
                return i;
            }
            else
            {
                randomPoint -= probs[i];
            }
        }
        return probs.Length - 1;
    }
}
