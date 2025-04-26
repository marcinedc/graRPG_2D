using UnityEngine;

public class NPC : MonoBehaviour
{
    public string npcName;
    public Vector2 location;
    [TextArea]
    public string dialog;

    public void Talk()
    {
        Debug.Log($"{npcName}: {dialog}");
    }
}
