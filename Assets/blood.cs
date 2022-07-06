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

        // load the blood overlay from assets
        var img = Resources.Load<Sprite>("Damage");

        //include the blood overlay into the canvas previously created
        GameObject go = new GameObject("Blood Image");
        go.transform.parent = canvasGO.transform;
        SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = img;
        renderer = renderer.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
    }
}
