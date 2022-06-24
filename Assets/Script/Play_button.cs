using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play_button : MonoBehaviour
{
    public void start_game()
    {
        SceneManager.LoadScene("Level_1");
    }
}
