using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseGlasses : MonoBehaviour
{
    public GameObject Glasses1;
    public GameObject Glasses2;
    public GameObject Glasses3;

    Button Glasses1Button;
    Button Glasses2Button;
    Button Glasses3Button;


    // Start is called before the first frame update
    void Start()
    {
       Glasses1Button = GameObject.Find("Canvas/Glasses 1").GetComponent<Button>();
       Glasses2Button = GameObject.Find("Canvas/Glasses 2").GetComponent<Button>(); 
       Glasses3Button = GameObject.Find("Canvas/Glasses 3").GetComponent<Button>(); 

       Glasses1Button.onClick.AddListener(Glasses1Selected);
       Glasses2Button.onClick.AddListener(Glasses2Selected);
       Glasses3Button.onClick.AddListener(Glasses3Selected);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Glasses1Selected()
    {
        Glasses1.SetActive(true);
        Glasses2.SetActive(false);
        Glasses3.SetActive(false);
    }
     public void Glasses2Selected()
    {
        Glasses1.SetActive(false);
        Glasses2.SetActive(true);
        Glasses3.SetActive(false);
    }
     public void Glasses3Selected()
    {
        Glasses1.SetActive(false);
        Glasses2.SetActive(false);
        Glasses3.SetActive(true);
    }
}
