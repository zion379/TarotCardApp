using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewTarotCard", menuName ="TarotCard")]
public class TarotCard : ScriptableObject
{

    public enum cardType {MajorAcana, SuitOfWands, SuitOfCups, SuitOfSwords, SuitOfPentacles, none }
    public cardType typeOfCard = cardType.none;
    public string cardName;
    public string uprightMeaning;
    public Sprite cardImage;
    public Sprite cardBackgroundImage;

    
}
