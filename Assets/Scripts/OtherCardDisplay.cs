using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OtherCardDisplay : MonoBehaviour
{
    public OtherCardClass otherCard;

    [SerializeField] private TMP_Text otherCardDescriptionText, otherCardCostText;

    private void Update()
    {
        if (otherCard != null)
        {
            otherCardDescriptionText.text = otherCard.otherCardDescriptionString;
            otherCardCostText.text = otherCard.otherCardCostString;
        }
    }
}
