using System.Collections;

using TMPro;
using UnityEngine;

public class DialogText : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private TextMeshProUGUI TextComponent;
    [SerializeField] private Behaviour component;
    [SerializeField] private GameObject DialogeBox;
    [Header("Parameters")]
    public string[] lines;
    [SerializeField] private float speedText = 0.2f;
    private int Index = 0;
    private bool isTyping = false;

    private void Start()
    {
        component.enabled = false;
        TextComponent.text = string.Empty;
        StartDialoge();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)&&!isTyping)
        {
            nextLineDialog();
        }
    }
    void StartDialoge()
    {
        
        Index = 0;
        StartCoroutine(TypeLine());
   
    }
    // next line //
    void nextLineDialog()
    {
        if (Index < lines.Length - 1)
        {
            Index++;
            TextComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            DialogeBox.SetActive(false);
            component.enabled = true;
        }

    }
    // character appeare in a second times //
    IEnumerator TypeLine()
    {
        isTyping = true;
        foreach (char c in lines[Index].ToCharArray())
        {
            TextComponent.text += c;
            yield return new WaitForSeconds(speedText);

        }
        isTyping = false;
    }

}
