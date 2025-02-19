using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject infopanel;

    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void InfoButton()
    {
        menupanel.SetActive(false);
        infopanel.SetActive(true);
    }

    public void BackButton()
    {
        menupanel.SetActive(true);
        infopanel.SetActive(false);
    }
    public void ARBackButton(string menu)
    {
        SceneManager.LoadScene(menu);
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Keluar Aplikasi");
    }
    // Update is called once per frame

}
