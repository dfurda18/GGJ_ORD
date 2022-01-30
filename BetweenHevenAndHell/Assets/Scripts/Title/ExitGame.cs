using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    private Button ExitGameButton;
    // Start is called before the first frame update
    void Start()
    {
        ExitGameButton = this.gameObject.GetComponent<Button>();
        ExitGameButton.onClick.AddListener(ExitClicked);

    }

    void ExitClicked()
    {
        Application.Quit();
    }
}
