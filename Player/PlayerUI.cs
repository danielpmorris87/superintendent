using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI messageText;

    private PlayerUI playerUI;

    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
    }

    void Update()
    {
        // Reset the text in the UI prompt
        playerUI.UpdatePromptText(string.Empty);
        playerUI.UpdateMessageText(string.Empty);
    }

    public void UpdatePromptText(string promptMessage)
    {
        promptText.text = promptMessage;
    }

    public void UpdateMessageText(string messageMessage)
    {
        messageText.text = messageMessage;
    }
}
