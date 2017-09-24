using UnityEngine;

public class Quest001 : MonoBehaviour
{
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject NoticeCam;

    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject UIQuest;

    private void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;

    }

    private void OnMouseOver()
    {
        if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if (Input.GetButtonDown("Action"))
            if (TheDistance <= 3)
            {
                Screen.lockCursor = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                UIQuest.SetActive(true);
                NoticeCam.SetActive(true);
                ThePlayer.SetActive(false);
            }
    }

    private void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}