using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    private Button exitGameButton;
    // Start is called before the first frame update
    void Start()
    {
        exitGameButton = this.gameObject.GetComponent<Button>();
        exitGameButton.onClick.AddListener(ExitClicked);

    }

    public void ExitClicked()
    {
        Application.Quit();
    }
}
