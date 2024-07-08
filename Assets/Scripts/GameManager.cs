using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject otherCardPrefab, resourceCardPrefab;
    public Transform deckHand, playerHand;

    public List<OtherCardClass> deckStarterCards;
    public List<ResourceCardClass> playerStarterCards;

    void Start()
    {
        StartOtherDeckDeal();
        StartPlayerDeal();
    }

    private void StartOtherDeckDeal()
    {
        for (int i = 4; i > 0; i--)
        {
            GameObject clone = Instantiate(otherCardPrefab);
            clone.transform.SetParent(deckHand, false);

            if (i == 4)
            {
                clone.transform.localPosition = new Vector2(-600, 300);
                clone.GetComponent<OtherCardDisplay>().otherCard = deckStarterCards[0];
            }
            else if (i == 3)
            {
                clone.transform.localPosition = new Vector2(-200, 300);
                clone.GetComponent<OtherCardDisplay>().otherCard = deckStarterCards[1];
            }
            else if (i == 2)
            {
                clone.transform.localPosition = new Vector2(200, 300);
                clone.GetComponent<OtherCardDisplay>().otherCard = deckStarterCards[2];
            }
            else if (i == 1)
            {
                clone.transform.localPosition = new Vector2(600, 300);
                clone.GetComponent<OtherCardDisplay>().otherCard = deckStarterCards[3];
            }

            clone.name = clone.GetComponent<OtherCardDisplay>().otherCard.name;
        }
    }

    private void StartPlayerDeal()
    {
        for (int i = 4; i > 0; i--)
        {
            GameObject clone = Instantiate(resourceCardPrefab);
            clone.transform.SetParent(playerHand, false);

            if (i == 4)
            {
                clone.transform.localPosition = new Vector2(-600, -300);
                clone.GetComponent<ResourceCardDisplay>().resourceCard = playerStarterCards[0];
            }
            else if (i == 3)
            {
                clone.transform.localPosition = new Vector2(-200, -300);
                clone.GetComponent<ResourceCardDisplay>().resourceCard = playerStarterCards[1];
            }
            else if (i == 2)
            {
                clone.transform.localPosition = new Vector2(200, -300);
                clone.GetComponent<ResourceCardDisplay>().resourceCard = playerStarterCards[2];
            }
            else if (i == 1)
            {
                clone.transform.localPosition = new Vector2(600, -300);
                clone.GetComponent<ResourceCardDisplay>().resourceCard = playerStarterCards[3];
            }

            clone.name = clone.GetComponent<ResourceCardDisplay>().resourceCard.name;
        }
    }
}
