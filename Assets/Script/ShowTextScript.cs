﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    public int kadrs = 0;
    // Update is called once per frame
    void Update()
    {
        kadrs++;
        Debug.Log(kadrs);
    }
    */

    string text;
    public GameObject inputField;
    public GameObject displayField;
    string[] words = {"Sveiki ", "Jauku dienu ", "Labrīt ", "Labdien ", "Labvakar "};
    int randomNumb;

    public void getText()
    {
        randomNumb = Random.Range(0, words.Length);
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = words[randomNumb] + text.ToLower() + "!";
    }

}