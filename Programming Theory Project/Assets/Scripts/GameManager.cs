using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public GameObject pig;
    public GameObject cow;
    
    public GameObject noiseButton;
    public Text noiseLabel;

    public static GameManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
    }

    public int milkCounter;
    
    public void CreateCreature(string option)
    {
        if (option == "cow")
        {
            Debug.Log("Cow built!");
            pig.SetActive(false);
            cow.SetActive(true);
            noiseButton.SetActive(true);
        } else {
            Debug.Log("Pig built!");
            cow.SetActive(false);
            pig.SetActive(true);
            noiseButton.SetActive(true);
        }
    }
    IEnumerator WaitSomeTime() {
        Debug.Log("Co started");
        yield return new WaitForSeconds(2);
        Debug.Log("Co finished");
        noiseLabel.text = "And now?";
    }

    public void GetAnimalNoise() {
        string noiseText = "";
        if (cow.activeSelf) {
           noiseText = cow.gameObject.GetComponent<Cow>().MakeNoise();
        }
        else if (pig.activeSelf) {
           noiseText = pig.gameObject.GetComponent<Pig>().MakeNoise();
        }
        noiseLabel.text = noiseText;
        StartCoroutine(WaitSomeTime());
    }

}
