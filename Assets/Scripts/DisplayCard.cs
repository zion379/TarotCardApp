using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI romanNumeralText;
    public Image backgroundImageRefrence;
    public Image cardImageRefrence;

    public MajorArcana majorArcanaCardData;
    public MinorArcana minorArcanaCardData;

    // Start is called before the first frame update
    void Start()
    {
        if (majorArcanaCardData == null)
        {
            cardNameText.text = minorArcanaCardData.cardName;
            romanNumeralText.text = minorArcanaCardData.romanNumeral;
            backgroundImageRefrence.sprite = minorArcanaCardData.cardBackGround;
            cardImageRefrence.sprite = minorArcanaCardData.cardImage;
        }
        else if (minorArcanaCardData == null) 
        {
            cardNameText.text = majorArcanaCardData.cardName;
            romanNumeralText.text = majorArcanaCardData.romanNumeral;
            backgroundImageRefrence.sprite = majorArcanaCardData.cardBackGround;
            cardImageRefrence.sprite = majorArcanaCardData.cardImage;
        }
    }

}
