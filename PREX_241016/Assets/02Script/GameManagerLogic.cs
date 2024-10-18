using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManagerLogic : MonoBehaviour
{
    public int totalItemCount;
    public int stage;
    public Text TotalItemText;
    public Text CurrentItemText;

    void Awake()
    {
        TotalItemText.text = "/ " + totalItemCount;
    }

    public void GetItem(int count)
    {
        CurrentItemText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(stage);
        }
    }
}
