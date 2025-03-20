using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class Button_Controller : MonoBehaviour
{
    int Count = 0;

    public Sprite[] image;
    public Image selectImage;

    public GameObject Massage;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        Massage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushBtn()
    {
        Count++;
        txt.text = "´©¸¥ È½¼ö : "+Count.ToString();

        if(Count % 10 == 0)
        {
            end();
        }

    }

    public void end()
    {
        int score = Random.Range(0, image.Length - 1);
        selectImage.sprite = image[score];

        Massage.SetActive(true);
    }
}
