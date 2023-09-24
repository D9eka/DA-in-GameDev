using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textHandler;

    private void Start()
    {
        string message = "Hello World";
        textHandler.text = message;
        Debug.Log(message);
    }
}
