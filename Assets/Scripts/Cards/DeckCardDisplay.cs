using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeckCardDisplay : MonoBehaviour
{
    public DeckCardClass deckCard;

    [SerializeField] private TMP_Text deckCardDescriptionText, deckCardCostText;
    [SerializeField] private Button deckButton;

    private void Update()
    {
        if (deckCard != null && deckCard.deckCardDescriptionString != deckCardDescriptionText.text)
        {
            deckCardDescriptionText.text = deckCard.deckCardDescriptionString;
            deckCardCostText.text = deckCard.deckCardCostString;
        }
    }

    public void GetDeckCardMethod()
    {
        deckCard.DeckCardMethod();
    }
}
