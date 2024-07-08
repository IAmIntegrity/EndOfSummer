using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[CreateAssetMenu(menuName = "Other Card", fileName = "New Other Card")]
public class OtherCardClass : ScriptableObject
{
    public string otherCardDescriptionString, otherCardCostString;

    /*

    Make better template, for cost and reusability, redo otherCardMethod so only methods needed are for giving and taking cards

    */

    public void OtherCardMethod()
    {
        switch (name)
        {
            case "Get Wife":
                GetWifeMethod();
                break;

            case "Pay Taxes":
                PayTaxeseMethod();
                break;

            case "Rich Family":
                RichFamilyMethod();
                break;

            default:
                Debug.Log("Default");
                break;
        }
    }

    private void GetWifeMethod()
    {
        Debug.Log("Wife XD");
    }

    private void PayTaxeseMethod()
    {
        Debug.Log("Taxes yay");
    }

    private void RichFamilyMethod()
    {
        Debug.Log("Chose rich family, -2 Money Cards");
    }
}
