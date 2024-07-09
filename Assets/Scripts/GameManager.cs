using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject deckCardPrefab, resourceCardPrefab;
    public Transform deckHand, playerHand;
    public List<DeckCardClass> deckStarterCards;
    public List<ResourceCardClass> resourceStarterCards;

    public int moneyCardsInt = 0, staminaCardsInt = 0, strengthCardsInt = 0, knowledgeCardsInt = 0, actionCardsInt = 0;

    void Start()
    {
        StartDeckDeal();
        StartPlayerDeal();
    }

    private void StartDeckDeal()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject clone = Instantiate(deckCardPrefab);
            clone.transform.SetParent(deckHand, false);
            clone.GetComponent<DeckCardDisplay>().deckCard = deckStarterCards[i];
            clone.transform.localPosition = new Vector2(-600 + (i * 400), 300);
            clone.name = clone.GetComponent<DeckCardDisplay>().deckCard.name;
        }
    }

    private void StartPlayerDeal()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject clone = Instantiate(resourceCardPrefab);
            clone.transform.SetParent(playerHand, false);
            clone.GetComponent<ResourceCardDisplay>().resourceCard = resourceStarterCards[i];
            clone.transform.localPosition = new Vector2(-600 + (i * 400), -300);
            clone.name = clone.GetComponent<ResourceCardDisplay>().resourceCard.name;

            GiveOrTakeResourceCard(clone.name, 1, true);
        }
    }

    public void GiveOrTakeResourceCard(string card, int num, bool isGiving)
    {
        if (isGiving)
        {
            if (card == "Money")
            {
                moneyCardsInt += num;
            }
            else if (card == "Stamina")
            {
                staminaCardsInt += num;
            }
            else if (card == "Strength")
            {
                strengthCardsInt += num;
            }
            else if (card == "Knowledge")
            {
                knowledgeCardsInt += num;
            }
            else if (card == "Action")
            {
                actionCardsInt += num;
            }
        }
        else
        {
            if (card == "Money")
            {
                moneyCardsInt -= num;
            }
            else if (card == "Stamina")
            {
                staminaCardsInt -= num;
            }
            else if (card == "Strength")
            {
                strengthCardsInt -= num;
            }
            else if (card == "Knowledge")
            {
                knowledgeCardsInt -= num;
            }
            else if (card == "Action")
            {
                actionCardsInt -= num;
            }
        }
    }
}
