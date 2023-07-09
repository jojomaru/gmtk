using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class newsFeed : MonoBehaviour
{
    [Serializable]
    public struct News
    {
        public string news;
    }

    [SerializeField] GameObject newsItem;
    [SerializeField] News[] allNews;

    // Start is called before the first frame update
    void Start()
    {
        GameObject g;
        for(int i = 0; i<4 ; i++)
        {
            g = Instantiate(newsItem, transform);
            g.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = allNews[i].news;
        }

        Destroy(newsItem);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
