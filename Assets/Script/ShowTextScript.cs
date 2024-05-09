using System.Collections;
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

    //Random don don ti gandon

    public void getText()
    {
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = "Privet " + text.ToLower() + "!";
    }

}