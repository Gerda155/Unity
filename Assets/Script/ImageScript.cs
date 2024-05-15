using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject beast;
    public GameObject babka;
    public GameObject mishka;
    public GameObject mashinka;
    public GameObject left;
    public GameObject right;
    public GameObject imageHolder;
    public Sprite[] spriteArray;

    public void showBeast(bool value)
    {
        beast.SetActive(value);
        left.GetComponent<Toggle>().interactable = value;
        right.GetComponent<Toggle>().interactable = value;
    }
    public void showBabka(bool value)
    {
        babka.SetActive(value);
    }
    public void showMishka(bool value)
    {
        mishka.SetActive(value);
    }
    public void showMashinka(bool value)
    {
        mashinka.SetActive(value);
    }
    public void toLeft()
    {
        beast.transform.localScale = new Vector2(1, 1);
    }
    public void toRight()
    {
        beast.transform.localScale = new Vector2(-1, 1);
    }
    public void changeImage(int index)
    {
        if (index == 0)
            imageHolder.GetComponent<Image>().sprite = spriteArray[0];
        else if (index == 1)
            imageHolder.GetComponent<Image>().sprite = spriteArray[1];
        else if (index == 2)
            imageHolder.GetComponent<Image>().sprite = spriteArray[2];
        //imageHolder.GetComponent<Image>().sprite = spriteArray[index];
    }
}
