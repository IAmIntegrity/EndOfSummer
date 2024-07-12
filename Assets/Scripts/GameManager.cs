using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject deckCardPrefab, resourceCardPrefab;
    public Transform deckHandTransform, playerHandTransform;
    public List<DeckCardClass> deckCardsAllList;
    public List<ResourceCardClass> resourceCardsAllList;

    public int moneyCardsInt = 0, staminaCardsInt = 0, strengthCardsInt = 0, knowledgeCardsInt = 0, actionCardsInt = 0;

    private void Start()
    {
        StartDeckDeal();
        StartPlayerDeal();
    }

    private void Update()
    {
        SetPlayerCardTransforms();
    }

    private void StartDeckDeal()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject clone = Instantiate(deckCardPrefab);
            clone.transform.SetParent(deckHandTransform, false);
            clone.GetComponent<DeckCardDisplay>().deckCard = GetCardsOfTag("Starter")[i];
            clone.transform.localPosition = new Vector2(-600 + (i * 400), 300);
            clone.name = clone.GetComponent<DeckCardDisplay>().deckCard.name;
        }
    }

    private void StartPlayerDeal()
    {
        GiveOrTakeResourceCard("Money", 2, true);
        GiveOrTakeResourceCard("Stamina", 1, true);
        GiveOrTakeResourceCard("Strength", 1, true);
        GiveOrTakeResourceCard("Knowledge", 1, true);
    }

    public void GiveOrTakeResourceCard(string card, int num, bool isGiving)
    {
        if (isGiving) //Giving card
        {
            for (int i = 0; i < num; i++)
            {
                GameObject clone = Instantiate(resourceCardPrefab);
                clone.transform.SetParent(playerHandTransform, false);

                if (card == "Money")
                {
                    moneyCardsInt++;
                    clone.GetComponent<ResourceCardDisplay>().resourceCard = resourceCardsAllList[0];
                }
                else if (card == "Stamina")
                {
                    staminaCardsInt++;
                    clone.GetComponent<ResourceCardDisplay>().resourceCard = resourceCardsAllList[1];
                }
                else if (card == "Strength")
                {
                    strengthCardsInt++;
                    clone.GetComponent<ResourceCardDisplay>().resourceCard = resourceCardsAllList[2];
                }
                else if (card == "Knowledge")
                {
                    knowledgeCardsInt++;
                    clone.GetComponent<ResourceCardDisplay>().resourceCard = resourceCardsAllList[3];
                }
                else if (card == "Action")
                {
                    actionCardsInt++;
                    clone.GetComponent<ResourceCardDisplay>().resourceCard = resourceCardsAllList[4];
                }

                clone.name = clone.GetComponent<ResourceCardDisplay>().resourceCard.name;
                clone.tag = $"{card} Card Tag";
                Debug.Log($"Plus 1 Card {clone.name}");
            }
        }
        else //Taking Card
        {
            GameObject[] cardsOfTag = GameObject.FindGameObjectsWithTag($"{card} Card Tag");

            if (cardsOfTag.Length < num)
            {
                num = cardsOfTag.Length;
            }

            for (int i = 0; i < num; i++)
            {
                if (card == "Money")
                {
                    moneyCardsInt--;
                }
                else if (card == "Stamina")
                {
                    staminaCardsInt--;
                }
                else if (card == "Strength")
                {
                    strengthCardsInt--;
                }
                else if (card == "Knowledge")
                {
                    knowledgeCardsInt--;
                }
                else if (card == "Action")
                {
                    actionCardsInt--;
                }

                Destroy(cardsOfTag[i]);
                Debug.Log($"Minus Card {card}");
            }
        }
    }

    public void SetPlayerCardTransforms()
    {
        int numCards = 0;

        foreach (Transform transform in playerHandTransform)
        {
            numCards++;
        }

        if (numCards % 2 != 0)
        {
            int xMovement = 0; //1 Card

            if (numCards == 3)
            {
                xMovement = -250;
            }
            else if (numCards == 5)
            {
                xMovement = -500;
            }
            else if (numCards == 7)
            {
                xMovement = -750;
            }
            else if (numCards == 9)
            {
                xMovement = -1000;
            }
            else if (numCards == 11)
            {
                xMovement = -1250;
            }

            foreach (Transform transform in playerHandTransform)
            {
                transform.localPosition = new Vector2(xMovement, -360);
                xMovement += 250;
            }
        }
        else
        {
            int xMovement = -125; //2 Cards

            if (numCards == 4)
            {
                xMovement = -375;
            }
            else if (numCards == 6)
            {
                xMovement = -625;
            }
            else if (numCards == 8)
            {
                xMovement = -875;
            }
            else if (numCards == 10)
            {
                xMovement = -1125;
            }

            foreach (Transform transform in playerHandTransform)
            {
                transform.localPosition = new Vector2(xMovement, -360);
                xMovement += 250;
            }
        }
    }

    public DeckCardClass[] GetCardsOfTag(string tag)
    {
        List<DeckCardClass> deckCards = new();

        for (int i = 0; i < deckCardsAllList.Count; i++)
        {
            if (deckCardsAllList[i].deckCardTagString == tag)
            {
                deckCards.Add(deckCardsAllList[i]);
            }
        }

        return deckCards.ToArray();
    }
}
