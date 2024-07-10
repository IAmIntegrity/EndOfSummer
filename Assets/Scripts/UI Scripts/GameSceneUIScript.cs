using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneUIScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup settingsPanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (settingsPanel.alpha == 1.0f)
            {
                settingsPanel.alpha = 0.0f;
                settingsPanel.interactable = false;
            }
            else
            {
                settingsPanel.alpha = 1.0f;
                settingsPanel.interactable = true;
            }
        }
    }
}
