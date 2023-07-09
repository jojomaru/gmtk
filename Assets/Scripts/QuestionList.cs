using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static newsFeed;

public class QuestionList : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    List<string> questions = new List<string>();
    GameObject questDisp;
    OverallStat overallStat;
    public Button g1, g2;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        questions.Add("What’s wrong with cheap meat?\nMultiple citizens have been getting food poisoning from a certain meat vendor you’ve been supporting and have been gaining attention, if an investigation is launched you could very well be discovered to be a co-conspirator.");
        questions.Add("1 State Development Scandal? Again? Is he that dumb?\nOne of your supporters was recently exposed for multiple issues regarding corruption and money laundering, he has ties to some of your forms of income.");
        questions.Add("How convenient. Ok that could be a problem.\nAn Opposing member of the council was recently murdered by a hired gun contracted by one of your subordinates. The scandal could be good or bad for your reputation if you do nothing, depending on if your subordinate points fingers at you.\r\n");
        questions.Add("I can see potential.\r\nWhile doing a routine check we’ve come across a report detailing a shady fairly new company and their dealings, you could either completely shut down their operations or sponsor them.\r\n");
        questions.Add("I did not do that, I did not.\r\nThere have been allegations about your various underhanded methods you’ve committed to win the mayoral election. What should we do?\r\n");
        questions.Add("Homelessness? Nah it’s just a lifestyle\r\nThe number of homeless people have been increasing over the past quarter, the public are not happy about them taking up public spaces.\r\n");
        questions.Add("Good Ol’ Embezzlement\r\nWe’ve managed to secretly syphon a sizable sum of money from the city’s budget, you could try to take more at a risk or be content with what we got.\r\n");
        questions.Add("Bribe? I think you mean monetary incentive.\r\nYou’ve been given an offer from a construction company that promises to give you kickbacks for lucrative contracts & permits.\r\n");
        questions.Add("Sleeping with your secretary is normal right?\r\nYour illicit relationship with me has been exposed by a nosy reporter, no, the reporter demands a sum for their silence.\r\n");
        questions.Add("Look at me, I am the Cartel now.\r\nA local Crime Ring has reached out to us to discuss a potential partnership after hearing about your past dealings. Should we entertain them?\r\n");

        questDisp = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void newQuest()
    {
        questDisp.GetComponent<TextMeshProUGUI>().text = questions[0];
        /*switch(randQuest)
        {
            case 0:
                g1.onClick.AddListener(event1a);
                g2.onClick.AddListener(event1b);
                break;
            case 1:
                g1.onClick.AddListener(event2a);
                g2.onClick.AddListener(event2b);
                break;
            case 2:
                g1.onClick.AddListener(event3a);
                g2.onClick.AddListener(event3b);
                break;
            case 3:
                g1.onClick.AddListener(event4a);
                g2.onClick.AddListener(event4b);
                break;
            case 4:
                g1.onClick.AddListener(event5a);
                g2.onClick.AddListener(event5b);
                break;
            case 5:
                g1.onClick.AddListener(event6a);
                g2.onClick.AddListener(event6b);
                break;
            case 6:
                g1.onClick.AddListener(event7a);
                g2.onClick.AddListener(event7b);
                break;
            case 7:
                g1.onClick.AddListener(event8a);
                g2.onClick.AddListener(event8b);
                break;
            case 8:
                g1.onClick.AddListener(event9a);
                g2.onClick.AddListener(event9b);
                break;
            case 9:
                g1.onClick.AddListener(event10a);
                g2.onClick.AddListener(event10b);
                break;
            default:
                break;
        }*/
    }

    void event1a()
    {
        overallStat.moneyVal += 1000;
        overallStat.repRate -= 0.1f;
        overallStat.crimeRate.value += 0.1f;
        gm.timeCycle++;
    }
    void event1b()
    {
        overallStat.moneyVal -= 1000;
        overallStat.repRate += 0.1f;
        overallStat.crimeRate.value -= 0.1f;
        gm.timeCycle++;
    }
    void event2a()
    {
        overallStat.moneyVal -= 2000;
        overallStat.repRate += 0.2f;
        overallStat.povRate.value += 0.1f;
        gm.timeCycle++;
    }
    void event2b()
    {
        overallStat.moneyVal += 2000;
        overallStat.repRate -= 0.2f;
        overallStat.povRate.value += 0.1f;
        gm.timeCycle++;
    }
    void event3a()
    {
        int i = Random.Range(0,1);
        if (i == 0)
        {
            overallStat.repRate += 0.2f;
        }else overallStat.repRate -= 0.2f;
        overallStat.crimeRate.value -= 0.1f;
        gm.timeCycle++;
    }
    void event3b()
    {
        overallStat.moneyVal -= 1000;
        overallStat.repRate -= 0.1f;
        gm.timeCycle++;
    }
    void event4a()
    {
        overallStat.repRate += 0.2f;
        overallStat.povRate.value += 0.1f;
        gm.timeCycle++;
    }
    void event4b()
    {
        overallStat.moneyVal += 2000;
        overallStat.crimeRate.value += 0.1f;
        gm.timeCycle++;
    }
    void event5a()
    {
        overallStat.repRate -= 0.1f;
        overallStat.crimeRate.value -= 0.1f;
        gm.timeCycle++;
    }
    void event5b()
    {
        overallStat.moneyVal -= 1000;
        overallStat.repRate += 0.1f;
        gm.timeCycle++;
    }
    void event6a()
    {
        overallStat.moneyVal += 2000;
        overallStat.repRate -= 0.2f;
        overallStat.povRate.value += 0.1f;
        gm.timeCycle++;
    }
    void event6b()
    {

    }
    void event7a()
    {

    }
    void event7b()
    {

    }
    void event8a()
    {

    }
    void event8b()
    {

    }
    void event9a()
    {

    }
    void event9b()
    {

    }
    void event10a()
    {

    }
    void event10b()
    {

    }
}
