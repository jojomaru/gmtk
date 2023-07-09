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
    public List<string> questions = new List<string>();
    public GameObject questDisp;
    public OverallStat overallStat;
    public Button g1, g2;
    GameManager gm;
    public int i = 0;
    int rng;
    // Start is called before the first frame update
    void Start()
    {
        questions.Add("What's wrong with Cheap Meat?\nMultiple citizens have been getting food poisoning from a certain meat vendor you’ve been supporting, if an investigation is launched you could very well be discovered to be a co-conspirator.");
        questions.Add("1 State Development Scandal? Again? Is he that dumb?\r\nOne of your supporters was recently exposed for multiple issues regarding corruption and money laundering, he has ties to some of your forms of income.");
        questions.Add("How convenient. Ok that could be a problem.\r\nAn Opposing member of the council was recently murdered by a hired gun contracted by one of your subordinates. That idiot could spill the beans on our top secret affairs.");
        questions.Add("I can see potential.\r\nWhile doing a routine check we've come across a report detailing a shady fairly new company and their dealings, you could either completely shut down their operations or sponsor them.\r\n");
        questions.Add("I did not do that, I did not.\r\nThere have been allegations about your various underhanded methods you've committed to win the mayoral election. What should we do?\r\n");
        questions.Add("Homelessness? Nah it's just a lifestyle\r\nThe number of homeless people have been increasing over the past quarter, the public are not happy about them taking up public spaces.\r\n");
        questions.Add("Good Ol' Embezzlement\r\nWe've managed to secretly syphon a sizable sum of money from the city's budget, you could try to take more at a risk or be content with what we got.\r\n");
        questions.Add("Bribe? I think you mean monetary incentive.\r\nYou've been given an offer from a construction company that promises to give you kickbacks for lucrative contracts & permits.\r\n");
        questions.Add("Sleeping with your secretary is normal right?\r\nYour illicit relationship with me has been exposed by a nosy reporter, no, the reporter demands a sum for their silence.\r\n");
        questions.Add("Look at me, I am the Cartel now.\r\nA local Crime Ring has reached out to us to discuss a potential partnership after hearing about your past dealings. Should we entertain them?\r\n");
        questions.Add("Did someone say drugs?\nUpon investigating a seemingly innocent business we’ve stumbled across a drug trafficking ring, you could confront them to offer them a deal.");
        questions.Add("That’s not cool, we care for the Future. Maybe.\nWe have discovered a company dumping toxic waste into the city’s rivers and parks.");
        questions.Add("Hey, I don’t judge based on race! Just wallet size.\nWe are drafting new housing initiatives and can choose between supporting wealthy housing developers or the minority communities.");
        questions.Add("What, so you mean I can’t call a SWAT car on a civilian?\nIn order to cover up a previous blunder, you diverted a portion of law enforcement to raid a specific house. NO.");
        questions.Add("That’s the fifth one this year, do they really think it does anything?\nA number of protests that involve companies you support have been repeatedly occurring for the past Quarter, perhaps it’s time to cut ties?");
        questions.Add("Your Honour, my client clearly did it in self defence.\nThere have been several cases of police brutality from a police captain we know, the captain says that if you are able to have his officers avoid the charges he will make sure that the Crime Rates drop.");
        questions.Add("You did this? Nah, I did this.\nAn investment I made in the past to reduce poverty has turned a huge profit, you could cash out now or help reduce poverty even more so that your future endeavours are more profitable.");
        questions.Add("Dammit, investing in them was a bad idea.\nAn oil rig on the outskirts of the city has been spilling its oil into the ocean, it is only a matter of time before the oil reaches the water pipes of the city forcing us to turn off the water supply until everything is fixed.");
        questions.Add("Stop panicking, EVERYONE STOP PANICKING.\nThe stock market is currently crashing, if you wanna sell your stocks you better do it now before it drops any further. Also stop hyperventilating, you’re not losing that much money.");
        questions.Add("I thought games were the future…\nWinter Enjoyment, a video game studio you’ve been backing has recently come under fire by multiple allegations, the wisest choice would be to cut your ties.");
        questions.Add("Who even sends physical mail nowadays?!?!\nA letter from an unknown person was sent to the council, addressed to you. The letter details information about a plot to start a violent riot, one of the locations is the Town Hall.");
        questions.Add("Who is he? The Devil?\nUh sir we have a visitor who insisted to meet you urgently, he says that he has a deal for you can’t refuse. I don’t know.");
        questions.Add("I’m sorry but who?\nA local celebrity is coming back to our city after a long time away due to a contract. We could hold a welcome back ceremony to show the citizens that we care about local talents.");
        questions.Add("Jerry? Really? There’s no one else?\nAn urgent issue has come up and the only person around who is ready to depart is…Jerry. Yes I know it’s absurd, …No there’s no one else. I shall leave the final decision to you.");
        questions.Add("A cheap way to stop being cheap.\nThe man wearing a lab coat has arrived. He says that he’s able to help us with our Poverty issue, there is the guaranteed way and the risky one. Which to use is your choice mayor.");
        questions.Add("HOW DID YOU TRIP ON AIR?\nWhile transporting the large stacks of documents from the archives, Terry tripped on air and scattered all the documents out the window and onto the city streets…");
        questions.Add("How on earth did he manage that?\nExcuse me Mayor but I have some urgent news, Freddy has somehow managed to offend the entire city’s vegan activist group. No, I don't know how. They’re gathered in front of the Town Hall. What do we do?");
        questions.Add("Ah a wedding, when a man’s life is over.\nA wedding will be taking place in the Town Hall next month and you will be the Marriage officiant. Try not to say that to the bride and groom please.");
        questions.Add("Hahahaha I smell blood in the water!\nThe fraudulent company you had your eye on the past year or so seems to have fallen far from grace, this indeed would be the most opportune time to strike.");
        questions.Add("There are how many?\n16 different applicants have come in today regarding the permit to build near the new station, 16. Out of all the applicants only two should catch your eye, the prestigious Jung Academy and Chan Constructions.");
        questions.Add("A stupid bet.\nWhat did you agree to? I can’t believe you bet a million on a coin toss while you were drunk, how are we going to write this one off on the books?");
        questions.Add("Hey! That’s my job!\nA fellow council member was found embezzling funds without your knowledge, punishing him would be the best course of action. How to do so is up to your volition.");

        questDisp = transform.GetChild(1).gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        questDisp.GetComponent<TextMeshProUGUI>().text = questions[i];
        rng = Random.Range(0, 1);
    }

    public void event1a()
    {
        Debug.Log(i);
        switch (i)
        {
            case 0:
                overallStat.moneyVal += 1000;
                overallStat.repRate -= 0.1f;
                overallStat.crimeVal += 0.1f;
                i++;
                break;
            case 1:
                overallStat.moneyVal -= 2000;
                overallStat.repRate += 0.2f;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 2:
                if (rng == 0)
                {
                    overallStat.repRate += 0.2f;
                }
                else overallStat.repRate -= 0.2f;
                overallStat.crimeVal -= 0.1f;
                i++;
                break;
            case 3:
                overallStat.repRate += 0.2f;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 4:
                overallStat.repRate -= 0.1f;
                overallStat.crimeVal -= 0.1f;
                i++;
                break;
            case 5:
                overallStat.moneyVal += 2000;
                overallStat.repRate -= 0.2f;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 6:
                overallStat.moneyVal += 2000;
                i++;
                break;
            case 7:
                overallStat.moneyVal += 2000;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 8:
                overallStat.moneyVal -= 1000;
                i++;
                break;
            case 9:
                overallStat.moneyVal += 3000;
                overallStat.crimeVal += 0.2f;
                i++;
                break;
            case 10:
                overallStat.moneyVal += 1000;
                overallStat.crimeVal += 0.1f;
                i++;
                break;
            case 11:
                overallStat.moneyVal += 3000;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 12:
                overallStat.moneyVal += 3000;
                i++;
                break;
            case 13:
                overallStat.repRate -= 0.1f;
                overallStat.crimeVal += 0.3f;
                overallStat.moneyVal += 1000;
                i++;
                break;
            case 14:
                overallStat.repRate += 0.2f;
                i++;
                break;
            case 15:
                overallStat.repRate -= 0.1f;
                overallStat.crimeVal -= 0.2f;
                i++;
                break;
            case 16:
                overallStat.moneyVal += 3000;
                overallStat.povVal -= 0.1f;
                i++;
                break;
            case 17:
                overallStat.repRate += 0.2f;
                overallStat.moneyVal -= 2000;
                overallStat.povVal -= 0.1f;
                i++;
                break;
            case 18:
                overallStat.moneyVal += 1000;
                overallStat.repRate -= 0.1f;
                i++;
                break;
            case 19:
                overallStat.repRate += 0.3f;
                overallStat.moneyVal -= 1000;
                i++;
                break;
            case 20:
                overallStat.moneyVal -= 1000;
                overallStat.crimeVal += 0.2f;
                overallStat.repRate += 0.3f;
                i++;
                break;
            case 21:
                //int rng = Random.Range(0, 1);
                if (rng == 0) overallStat.moneyVal += 2000;
                else overallStat.moneyVal -= 2000;

                if (rng == 0) overallStat.repRate += 0.2f;
                else overallStat.repRate -= 0.2f;

                i++;
                break;
            case 22:
                overallStat.repRate += 0.2f;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 23:
                overallStat.repRate += 0.1f;
                overallStat.moneyVal += 1000;
                i++;
                break;
            case 24:
                if (rng == 0) overallStat.moneyVal += 2000;
                else overallStat.moneyVal -= 2000;

                if (rng == 0) overallStat.povVal -= 0.2f;
                else overallStat.povVal += 0.2f;
                i++;
                break;
            case 25:
                overallStat.moneyVal += 1000;
                overallStat.repRate += 0.1f;
                overallStat.crimeVal += 0.1f;
                i++;
                break;
            case 26:
                overallStat.repRate += 0.2f;
                overallStat.crimeVal += 0.1f;
                i++;
                break;
            case 27:
                overallStat.repRate += 0.1f;
                i++;
                break;
            case 28:
                overallStat.crimeVal -= 0.2f;
                overallStat.moneyVal -= 1000;
                i++;
                break;
            case 29:
                overallStat.povVal -= 0.3f;
                overallStat.moneyVal -= 2000;
                i++;
                break;
            case 30:
                if(rng == 0) overallStat.moneyVal += 2000;
                else overallStat.moneyVal -= 2000;
                i++;
                break;
            case 31:
                overallStat.repRate += 0.2f;
                overallStat.crimeVal += 0.1f;
                i++;
                break;
        }
    }
    public void event1b()
    {
        switch (i)
        {
            case 0:
                overallStat.moneyVal -= 1000;
                overallStat.repRate += 0.1f;
                overallStat.crimeVal -= 0.1f;
                i++;
                break;
            case 1:
                overallStat.moneyVal += 2000;
                overallStat.repRate -= 0.2f;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 2:
                overallStat.moneyVal -= 1000;
                overallStat.repRate -= 0.1f;
                i++;
                break;
            case 3:
                overallStat.moneyVal += 2000;
                overallStat.crimeVal += 0.1f;
                i++;
                break;
            case 4:
                overallStat.moneyVal -= 1000;
                overallStat.repRate += 0.1f;
                i++;
                break;
            case 5:
                overallStat.moneyVal += 1000;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 6:
                overallStat.moneyVal += 4000;
                if (rng == 0) overallStat.repRate -= 0.3f;
                overallStat.povVal += 0.2f;
                i++;
                break;
            case 7:
                overallStat.repRate += 0.2f;
                overallStat.povVal -= 0.1f;
                i++;
                break;
            case 8:
                overallStat.repRate -= 0.2f;
                i++;
                break;
            case 9:
                overallStat.repRate += 0.1f;
                overallStat.povVal -= 0.1f;
                i++;
                break;
            case 10:
                overallStat.moneyVal -= 2000;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 11:
                overallStat.repRate += 0.2f;
                overallStat.povVal -= 0.1f;
                i++;
                break;
            case 12:
                overallStat.moneyVal -= 1000;
                overallStat.povVal -= 0.2f;
                i++;
                break;
            case 13:
                overallStat.moneyVal -= 1000;
                overallStat.crimeVal -= 0.2f;
                i++;
                break;
            case 14:
                overallStat.repRate -= 0.1f;
                overallStat.povVal -= 0.2f;
                i++;
                break;
            case 15:
                overallStat.repRate += 0.2f;
                overallStat.crimeVal += 0.2f;
                i++;
                break;
            case 16:
                overallStat.moneyVal += 1000;
                overallStat.povVal -= 0.3f;
                i++;
                break;
            case 17:
                overallStat.moneyVal += 2000;
                overallStat.repRate -= 0.2f;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 18:
                overallStat.moneyVal -= 1000;
                overallStat.povVal -= 0.1f;
                i++;
                break;
            case 19:
                overallStat.moneyVal += 2000;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 20:
                overallStat.repRate -= 0.2f;
                overallStat.crimeVal += 0.1f;
                overallStat.moneyVal += 1000;
                i++;
                break;
            case 21:
                if (rng == 0) overallStat.crimeVal += 0.2f;
                else overallStat.crimeVal -= 0.2f;

                if (rng == 0) overallStat.povVal += 0.2f;
                else overallStat.povVal -= 0.2f;
                i++;
                break;
            case 22:
                overallStat.repRate -= 0.1f;
                overallStat.povVal -= 0.1f;
                i++;
                break;
            case 23:
                if (rng == 0) overallStat.repRate += 0.3f;
                else overallStat.repRate -= 0.3f;

                if (rng == 0) overallStat.moneyVal += 3000;
                else overallStat.moneyVal -= 3000;
                i++;
                break;
            case 24:
                overallStat.moneyVal += 1000;
                overallStat.povVal -= 0.1f;
                i++;
                break;
            case 25:
                overallStat.repRate -= 0.2f;
                overallStat.crimeVal -= 0.1f;
                i++;
                break;
            case 26:
                overallStat.repRate += 0.2f;
                overallStat.povVal += 0.1f;
                i++;
                break;
            case 27:
                if (rng == 0) overallStat.repRate += 0.3f;
                else overallStat.repRate -= 0.3f;
                i++;
                break;
            case 28:
                overallStat.moneyVal += 1000;
                overallStat.crimeVal += 0.2f;
                i++;
                break;
            case 29:
                overallStat.moneyVal += 3000;
                overallStat.povVal += 0.2f;
                i++;
                break;
            case 30:
                if (rng == 0) overallStat.moneyVal += 2000;
                else overallStat.moneyVal -= 2000;
                i++;
                break;
            case 31:
                overallStat.moneyVal += 2000;
                overallStat.povVal += 0.1f;
                i++;
                break;
        }
    }
}
