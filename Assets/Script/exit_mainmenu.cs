using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exit_mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void restart_game()
    {
        SceneManager.LoadScene("main_menu");
    }
}
