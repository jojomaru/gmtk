using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OverallStat : MonoBehaviour
{
    public TextMeshProUGUI myMoney; //money (score)
    public int moneyVal;
    [Range(0, 1)] public Slider povRate; //poverty rate
    [Range(0, 1)] public Slider crimeRate; //crime rate
    public float repRate; //reputation rate
    
    public Animator animator;

    //testing purpose
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
        if (crimeRate.value == 1) GameOverDead();
        //if(repRate == 0) GameOverBoo();
        
        //checkMoney();
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

    void checkMoney()
    {
        if (povRate.value >= 0 && povRate.value <= 0.25)
        {
            moneyVal += moneyVal/2;
        }else if (povRate.value > 0.25 && povRate.value <= 0.5)
        {
            return;
        }else if(povRate.value > 0.5 && povRate.value <= 0.75)
        {
            moneyVal -= moneyVal/5;
            crimeRate.value += 0.1f;
        }else if(povRate.value >0.75 && povRate.value <= 1.00)
        {
            moneyVal -= moneyVal * 4 / 5;
            repRate -= repRate / 4;
        }
    }

    void GameOverDead()
    {
        animator.SetTrigger("GameOver");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOverBoo()
    {
        animator.SetTrigger("GameOver");
    }

    
}
