using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int timeCycle = 0; //4 quarters per year, so 16 in total
    public TextMeshProUGUI quarterDisp; //show Q(n) Year(n)

    // Start is called before the first frame update
    void Start()
    {
        timeCycle++;
    }

    // Update is called once per frame
    void Update()
    {
        checkQuarter();
        //if(timeCycle == 0)
    }

    void checkQuarter()
    {
        int year = 1 + (timeCycle / 4);
        int quarter = timeCycle;
        if (timeCycle % 4 == 0)
        {
            year--;
        }
        if (quarter > 4)
        {
            quarter -= 4 * (year - 1);
        }
        quarterDisp.text = "Q" + quarter + "\nYear " + year;
    }
}
