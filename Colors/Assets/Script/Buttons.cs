using UnityEngine;

public class Buttons : MonoBehaviour
{

    public Sprite Color_blue, Color_red;

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = Color_red;

    }
    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = Color_blue;

    }
    void OnMouseUpAsButton()
    {

        switch (gameObject.name)
        {
            case "Play":
                Application.LoadLevel(1);
                break;
            case "Rating":
                Application.OpenURL("html://google.com");
                break;
            case "Replay":
                Application.LoadLevel(1);
                break;
            case "Home":
                Application.LoadLevel(0);
                break;
            case "Exit":
                Application.Quit();
                break;           
        }
    }


}