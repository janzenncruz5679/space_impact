using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class restart_button : MonoBehaviour
{
    // Start is called before the first frame update
    public void restart_game()
    {
        SceneManager.LoadScene("Level_1");
    }
}
