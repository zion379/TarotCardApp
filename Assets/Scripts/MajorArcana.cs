using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewMarjorArcanaCard",menuName ="Cards/MajorArcana")]
public class MajorArcana : ScriptableObject
{
    public string cardName;
    public string romanNumeral;
    public string backStory;

    public enum cardType {cups, pentacles, swords, wands, none};
    public cardType typeOfCard = cardType.none;

    public Sprite cardImage;
    public Sprite cardBackGround;
}
