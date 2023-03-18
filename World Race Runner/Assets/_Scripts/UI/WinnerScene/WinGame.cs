
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            WinnerGame();

        }
    }

    public void WinnerGame()
    {
        SceneManager.LoadScene("Win");

    }
}
