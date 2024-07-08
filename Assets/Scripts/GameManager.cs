using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject deckCardPrefab, resourceCardPrefab;
    public Transform deckHand, playerHand;

    public List<DeckCardClass> deckStarterCards;
    public List<ResourceCardClass> resourceStarterCards;

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
        }
    }
}
