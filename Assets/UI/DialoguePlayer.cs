using TMPro;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{

    public DialogueAsset dialogueAsset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;

    private int dialogueLineIndex;

    private void Start()
    {
        dialogueText.text = dialogueAsset.dialogue[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))// || Input.GetKeyDown(KeyCode.P)) ( || = Ou )
        {
            //dialogueLineIndex = dialogueLineIndex +1;
            //dialogueLineIndex += 1;
            dialogueLineIndex++;

            if (dialogueLineIndex < dialogueAsset.dialogue.Length)
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex];
            }
            else
            {
                dialogueBox.gameObject.SetActive(false);
            }
        }

    }
}
