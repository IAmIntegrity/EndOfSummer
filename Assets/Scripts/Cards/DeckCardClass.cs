using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[CreateAssetMenu(menuName = "Deck Card", fileName = "New Deck Card")]
public class DeckCardClass : ScriptableObject
{
    public string deckCardDescriptionString, deckCardCostString, deckCardTagString;
    public int[] deckCardTakeIntArray = new int[5], deckCardGiveIntArray = new int[5]; //Action, Knowledge, Strength, Stamina, Money

    public void DeckCardMethod()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        string[] resourceNames = { "Money", "Stamina", "Strength", "Knowledge", "Action" };

        for (int i = 0; i < 5; i++)
        {
            if (deckCardTakeIntArray[i] != 0)
            {
                gameManager.GiveOrTakeResourceCard(resourceNames[i], deckCardTakeIntArray[i], false);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (deckCardGiveIntArray[i] != 0)
            {
                gameManager.GiveOrTakeResourceCard(resourceNames[i], deckCardGiveIntArray[i], true);
            }
        }
    }
}
