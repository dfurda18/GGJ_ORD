using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnToMenu : MonoBehaviour
{
    private Button returnToMenu;
    public GameObject creditScreen;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        returnToMenu = this.gameObject.GetComponent<Button>();
        returnToMenu.onClick.AddListener(ReturnToMenuClicked);
    }

    void ReturnToMenuClicked()
    {
        creditScreen.SetActive(false);
        titleScreen.SetActive(true);
    }


}

