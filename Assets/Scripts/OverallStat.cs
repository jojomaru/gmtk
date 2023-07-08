using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OverallStat : MonoBehaviour
{
    public TextMeshProUGUI myMoney; //money (score)
    public Slider povRate; //poverty rate
    public Slider crimeRate; //crime rate
    public float repRate; //reputation rate
    public int timeCycle; //4 quarters per year, so 16 in total

    //testing purpose
    [SerializeField] int moneyVal;
    [Range(0, 1)] public float povVal;
    [Range(0, 1)] public float crimeVal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myMoney.text = moneyVal.ToString();
        povRate.value = povVal;
        crimeRate.value = crimeVal;
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

    void GameOver()
    {

    }
}
