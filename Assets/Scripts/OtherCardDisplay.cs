using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OtherCardDisplay : MonoBehaviour
{
    public OtherCardClass otherCard;

    [SerializeField] private TMP_Text otherCardDescriptionText, otherCardCostText;
    [SerializeField] private Button otherButton;

    private void Update()
    {
        if (otherCard != null && otherCard.otherCardDescriptionString != otherCardDescriptionText.text)
        {
            otherCardDescriptionText.text = otherCard.otherCardDescriptionString;
            otherCardCostText.text = otherCard.otherCardCostString;
        }
    }

    public void GetOtherCardMethod()
    {
        otherCard.OtherCardMethod();
    }
}
