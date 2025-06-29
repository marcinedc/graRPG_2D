using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;

    public GameObject dialogueBox;
    public Text dialogueText;

    private string[] lines;
    private int index;
    private bool isDialogueActive;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    void Update()
    {
        if (isDialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            index++;
            if (index < lines.Length)
            {
                dialogueText.text = lines[index];
            }
            else
            {
                EndDialogue();
            }
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        lines = dialogue.lines;
        index = 0;
        dialogueText.text = lines[index];
        dialogueBox.SetActive(true);
        isDialogueActive = true;
    }

    public void EndDialogue()
    {
        dialogueBox.SetActive(false);
        isDialogueActive = false;
    }
}