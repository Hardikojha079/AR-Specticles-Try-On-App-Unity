using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour
{

    public GameObject G1Settings;
    public GameObject G2Settings;
    public GameObject G3Settings;

    public Material G1Mat;
    public Material G2Mat;
    public Material G3Mat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void G1InfoBoxEnable()
    {
        G1Settings.SetActive(true);
    }
    public void G1InfoBoxDisable()
    {
        G1Settings.SetActive(false);
    }

     public void G2InfoBoxEnable()
    {
        G2Settings.SetActive(true);
    }
    public void G2InfoBoxDisable()
    {
        G2Settings.SetActive(false);
    }

     public void G3InfoBoxEnable()
    {
        G3Settings.SetActive(true);
    }
    public void G3InfoBoxDisable()
    {
        G3Settings.SetActive(false);
    }

    public void G1ColourChange()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        if (ButtonName == "Black Colour Button")
        {
            G1Mat.color = new Color(0,0,0);
        }
        else if (ButtonName == "Blue Colour Button")
        {
            G1Mat.color = new Color(0.1f,0.3f,0.8f);
        }
    }

    public void G2ColourChange()
    {
       string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        if (ButtonName == "Black Colour Button")
        {
            G2Mat.color = new Color(0,0,0);
        }
        else if (ButtonName == "Blue Colour Button")
        {
            G2Mat.color = new Color(0.1f,0.3f,0.8f);
        } 
    }

    public void G3ColourChange()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        if (ButtonName == "Black Colour Button")
        {
            G3Mat.color = new Color(0,0,0);
        }
        else if (ButtonName == "Blue Colour Button")
        {
            G3Mat.color = new Color(0.1f,0.3f,0.8f);
        }
    }

    public void G1BuyNow()
    {
        Application.OpenURL("https://www.amazon.in/Lenskart-Bluecut-Antiglare-Computer-Eyeglasses/dp/B09FM3S6SN/ref=sxin_23_pa_sp_search_thematic_sspa?content-id=amzn1.sym.37bad8da-0499-4510-838e-af217f0a67c4%3Aamzn1.sym.37bad8da-0499-4510-838e-af217f0a67c4&crid=2UZ2WUPO540KJ&cv_ct_cx=spectacles&dib=eyJ2IjoiMSJ9.xcRQgJdbzhPmJdzMaDM18IxYtAXus_C93ncAwTsdrLt14JFbT3JcvNjIg_TnZFam9smyH0YkwT_hvfh62so4eg.0ld7mXD7uuB1meMp2CkKaaQ0RPT6rkPAO7K3lDMnf94&dib_tag=se&keywords=spectacles&pd_rd_i=B09FM3S6SN&pd_rd_r=21e16ec8-2b27-4dc9-b786-8c469bb091cd&pd_rd_w=yjgVc&pd_rd_wg=0TT2K&pf_rd_p=37bad8da-0499-4510-838e-af217f0a67c4&pf_rd_r=N2FVM4VJWFP7QS79MYPJ&qid=1709706237&sbo=RZvfv%2F%2FHxDF%2BO5021pAnSA%3D%3D&sprefix=specticle%2Caps%2C215&sr=1-2-ced4eeeb-b190-41d6-902a-1ecb3fb8b7c4-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9zZWFyY2hfdGhlbWF0aWM&psc=1");
    }

    public void G2BuyNow()
    {
        Application.OpenURL("https://www.amazon.in/John-Jacobs-Eyeglasses-JJ-E13732/dp/B0BW7PNWJV/ref=sr_1_1_sspa?crid=2UZ2WUPO540KJ&dib=eyJ2IjoiMSJ9.Dw3wFrC8608kkNV_XrDMkzK0wvOP_vfBr-g8WFj1MRTBFnB_bocWf64xiLihA45nvpvOfYEnLOVJ2qay09XbuBXNpscBDh3MY1lJv2QhCc4_tYxf1_4smi_ePbFgIjB2i4BJ4tjpxHNsO67XkPQ9w7rmNtQZ7c0z7yTp1OerkBkBVBuNdaX4Sh-x2mfsDJA8JcM_ca_GUR-dIFaiuKMMBWzlASc6vKRVWvWme1QsE00nf87Dgu7mhAm4U6vqqS8_N13tIpFGnL7CLavzPP-fj8cYIW2pa0R_no680GDPGW4.YS0Xglv-_MsCkVLSAg19ZV8Va5jwuwQX9_VI3UwyiJ0&dib_tag=se&keywords=spectacles&qid=1709706237&sprefix=specticle%2Caps%2C215&sr=8-1-spons&sp_csd=d2lkZ2V0TmFtZT1zcF9hdGY&psc=1");
    }

    public void G3BuyNow()
    {
       Application.OpenURL("https://www.amazon.in/Dervin-Raised-Glasses-Spectacle-Transparent/dp/B07YJ44KN8/ref=sr_1_6?crid=2UZ2WUPO540KJ&dib=eyJ2IjoiMSJ9.Dw3wFrC8608kkNV_XrDMkzK0wvOP_vfBr-g8WFj1MRTBFnB_bocWf64xiLihA45nvpvOfYEnLOVJ2qay09XbuBXNpscBDh3MY1lJv2QhCc4_tYxf1_4smi_ePbFgIjB2i4BJ4tjpxHNsO67XkPQ9w7rmNtQZ7c0z7yTp1OerkBkBVBuNdaX4Sh-x2mfsDJA8JcM_ca_GUR-dIFaiuKMMBWzlASc6vKRVWvWme1QsE00nf87Dgu7mhAm4U6vqqS8_N13tIpFGnL7CLavzPP-fj8cYIW2pa0R_no680GDPGW4.YS0Xglv-_MsCkVLSAg19ZV8Va5jwuwQX9_VI3UwyiJ0&dib_tag=se&keywords=spectacles&qid=1709706237&sprefix=specticle%2Caps%2C215&sr=8-6");
    }

}
