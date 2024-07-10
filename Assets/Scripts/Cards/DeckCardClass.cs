using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[CreateAssetMenu(menuName = "Deck Card", fileName = "New Deck Card")]
public class DeckCardClass : ScriptableObject
{
    public string deckCardDescriptionString, deckCardCostString, deckCardTagString;
    public int deckCardTakeInt, deckCardGiveInt; //Action, Knowledge, Strength, Stamina, Money

    public void DeckCardMethod()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (deckCardTakeInt != 0)
        {
            if ((deckCardTakeInt / (int)Mathf.Pow(10, 0)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Money", (deckCardTakeInt / (int)Mathf.Pow(10, 0)) % 10, false);
            }
            if ((deckCardTakeInt / (int)Mathf.Pow(10, 1)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Stamina", (deckCardTakeInt / (int)Mathf.Pow(10, 1)) % 10, false);
            }
            if ((deckCardTakeInt / (int)Mathf.Pow(10, 2)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Strength", (deckCardTakeInt / (int)Mathf.Pow(10, 2)) % 10, false);
            }
            if ((deckCardTakeInt / (int)Mathf.Pow(10, 3)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Knowledge", (deckCardTakeInt / (int)Mathf.Pow(10, 3)) % 10, false);
            }
            if ((deckCardTakeInt / (int)Mathf.Pow(10, 4)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Action", (deckCardTakeInt / (int)Mathf.Pow(10, 4)) % 10, false);
            }
        }

        if (deckCardGiveInt != 0)
        {
            if ((deckCardGiveInt / (int)Mathf.Pow(10, 0)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Money", (deckCardGiveInt / (int)Mathf.Pow(10, 0)) % 10, true);
            }
            if ((deckCardGiveInt / (int)Mathf.Pow(10, 1)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Stamina", (deckCardGiveInt / (int)Mathf.Pow(10, 1)) % 10, true);
            }
            if ((deckCardGiveInt / (int)Mathf.Pow(10, 2)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Strength", (deckCardGiveInt / (int)Mathf.Pow(10, 2)) % 10, true);
            }
            if ((deckCardGiveInt / (int)Mathf.Pow(10, 3)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Knowledge", (deckCardGiveInt / (int)Mathf.Pow(10, 3)) % 10, true);
            }
            if ((deckCardGiveInt / (int)Mathf.Pow(10, 4)) % 10 != 0)
            {
                gameManager.GiveOrTakeResourceCard("Action", (deckCardGiveInt / (int)Mathf.Pow(10, 4)) % 10, true);
            }
        }
    }
}
