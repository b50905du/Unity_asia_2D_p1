using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{
    public void nextlevel()
    {
        print("下一關卡");
        SceneManager.LoadScene("");
    }
    public void backmenu()
    {
        print("返回選單");
        SceneManager.LoadScene("選單");
    }
    public void quitgame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
