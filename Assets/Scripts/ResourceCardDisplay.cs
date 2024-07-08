using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceCardDisplay : MonoBehaviour
{
    public ResourceCardClass resourceCard;

    [SerializeField] private Image resourceCardImage;

    private void Update()
    {
        if (resourceCard != null)
        {
            resourceCardImage.sprite = resourceCard.resourceCardSprite;
        }
    }
}