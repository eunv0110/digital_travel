using UnityEngine;
using UnityEngine.UI;

public class InputPanelController : MonoBehaviour
{
    public GameObject inputPanel;
    public InputField inputField;
    private bool isInputActive = false;

    private void Start()
    {
        // Disable the input panel initially
        inputPanel.SetActive(false);
    }

    private void Update()
    {
        if (isInputActive && Input.GetKeyDown(KeyCode.Return))
        {
            ProcessInputValue();
        }
    }

    public void ShowInputPanel()
    {
        // Enable the input panel and activate input
        inputPanel.SetActive(true);
        inputField.text = string.Empty;
        inputField.ActivateInputField();
        isInputActive = true;
    }

    public void ProcessInputValue()
    {
        if (int.TryParse(inputField.text, out int inputValue))
        {
            UnityEngine.Debug.Log("인원 입력: " + inputValue);
        }
        else
        {
            UnityEngine.Debug.Log("Invalid input value!");
        }

        inputField.text = string.Empty;
        inputPanel.SetActive(false);
        isInputActive = false;
    }
}
