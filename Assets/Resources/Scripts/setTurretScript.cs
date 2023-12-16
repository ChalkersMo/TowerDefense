using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class setTurretScript : MonoBehaviour
{
    public TMP_Text[] setTurretButtonTexts;
    private TMP_Text currentTurretButtonText;

    public TMP_Text[] setTurretButtonPrices;
    private TMP_Text currentTurretButtonPrice;
    
    public TurretData[] turretData;
    private TurretData currentTurretDataObj;

    public Image[] setTurretSprites;
    private Image currentTurretSprite;


    public GameObject Base;

    
    void Start()
    {
        for(int i = 0; i < turretData.Length; i++)
        {
            currentTurretDataObj = turretData[i];

            currentTurretButtonText = setTurretButtonTexts[i];
            currentTurretButtonText.text = currentTurretDataObj.TurretName;

            currentTurretSprite = setTurretSprites[i];
            currentTurretSprite.sprite = currentTurretDataObj.TurretSprite;

            currentTurretButtonPrice = setTurretButtonPrices[i];
            currentTurretButtonPrice.text = currentTurretDataObj.Price.ToString();
        }
    }


    void Update()
    {
        
    }

    public void CreateTurret(GameObject Object)
    {
        if(Base.GetComponent<BaseScript>().baseMoney >= currentTurretDataObj.Price)
        {
            Instantiate(currentTurretDataObj.ModelTurret, new Vector3(
                Object.transform.position.x, 
                Object.transform.position.y + 1, 
                Object.transform.position.z), Quaternion.identity);
            Base.GetComponent<BaseScript>().baseMoney -= currentTurretDataObj.Price;
            Base.GetComponent<BaseScript>().ReloadText(); 
        }
        
    }


    public void turretFromButton1()
    {
        currentTurretDataObj = turretData[0];
    }


    public void turretFromButton2()
    {
        currentTurretDataObj = turretData[1];
    }


    public void setTurretFromButton()
    {

    }


}
