using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBehavior : MonoBehaviour {
    bool searchingForMatch;
    public Text buttonText;
	// Use this for initialization
	void Start () {
        searchingForMatch = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SearchButton_Click()
    {
        searchingForMatch = !searchingForMatch;
        switch (searchingForMatch)
        {
            case true:
                SearchQuickMatch();
                buttonText.text = "Cancel";
                break;
            case false:
                CancelQuickMatchSearching();
                buttonText.text = "Quick Match";
                break;
        }
    }
    private void SearchQuickMatch()
    {

    }
    private void CancelQuickMatchSearching()
    {

    }
}
