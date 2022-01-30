using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButton : MonoBehaviour
{
    private Button creditsButton;
    public GameObject titleMenu;
    public GameObject creditScreen;
    // Start is called before the first frame update
    void Start()
    {
        creditsButton = this.gameObject.GetComponent<Button>();
        creditsButton.onClick.AddListener(CreditsClicked);
    }

    void CreditsClicked()
    {
        titleMenu.SetActive(false);
        creditScreen.SetActive(true);
    }
}
