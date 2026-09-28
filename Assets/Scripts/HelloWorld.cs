using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [Header("Player Settings")]
    [Tooltip("The name of the player")]
    [SerializeField]
    private string playerName = "World";
    [Tooltip("The score of the player")]
    [SerializeField]
    [Range(0, 100)]
    private int playerScore = 0;

    [HideInInspector]
    public bool isPlayer;
    
    void Start()
    {
        Debug.Log("Hello, " + playerName + "!");
    }

    void Update()
    {
        
    }
}
