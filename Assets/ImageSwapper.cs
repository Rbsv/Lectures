using UnityEngine;
using UnityEngine.UI;

public class ImageSwapper : MonoBehaviour
{
    public Image controllableImage;
    public Sprite image1, image2;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(() =>
        {
            if (controllableImage.sprite == image1)
            {
                controllableImage.sprite = image2;
            }else if (controllableImage.sprite == image2)
            {
                controllableImage.sprite = image1;
            }
          
        });
       
    }
}
