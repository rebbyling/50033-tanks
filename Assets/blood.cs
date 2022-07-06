using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour
{

    private Sprite bloodImg;
    public Sprite sprite;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

        GameObject canvasGO = new GameObject();
        canvasGO.name = "Blood Overlay";
        canvasGO.AddComponent<Canvas>();
        canvasGO.AddComponent<CanvasScaler>();
        canvasGO.AddComponent<GraphicRaycaster>();

        // Get canvas from the GameObject.
        Canvas canvas;
        canvas = canvasGO.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        var img = Resources.Load<Sprite>("Damage");

        // GameObject overlayGO = new GameObject("Sprite");
        // overlayGO.transform.parent = canvasGO.transform;
        // overlayGO.AddComponent<SpriteRenderer>();

        GameObject go = new GameObject("Blood Image");
        go.transform.parent = canvasGO.transform;
        SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = img;
        renderer = renderer.GetComponent<SpriteRenderer>();

        // bloodImg = overlayGO.GetComponent<SpriteRenderer>();
        // bloodImg.sprite = img;
        RectTransform rectTransform;
        rectTransform = renderer.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 0);
        rectTransform.sizeDelta = new Vector2(600, 200);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
