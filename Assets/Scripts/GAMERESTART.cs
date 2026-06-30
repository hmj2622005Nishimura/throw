using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GAMERESTART : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       if(Keyboard.current.escapeKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("TITLEscene");
		}
    }
}
