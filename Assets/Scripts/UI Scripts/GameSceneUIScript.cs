using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneUIScript : MonoBehaviour
{
    [SerializeField] private GameObject settingsPanel;

    bool settingsPanelIsActiveBool = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SettingsPanelBackButton();
        }
    }

    public void SettingsPanelBackButton()
    {
        settingsPanelIsActiveBool = !settingsPanelIsActiveBool;
        settingsPanel.SetActive(settingsPanelIsActiveBool);
    }
}
