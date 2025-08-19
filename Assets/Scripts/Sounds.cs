using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource walking, running;
    void Update()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && Time.timeScale == 1f)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                walking.enabled = false;
                running.enabled = true;
            }
            else
            {
                walking.enabled = true;
                running.enabled = false;
            }
            
        }
        else
        {
            walking.enabled = false;
            running.enabled = false;
        }
    }
}
