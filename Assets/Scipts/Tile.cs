using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] Color BaseColor, OffestColor;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] GameObject SpriteRenderer;

    Color[] colors = new Color[5];
    private void Start()
    {
        colors[0] = Color.black;
        colors[1] = Color.blue;
        colors[2] = Color.green;
        colors[3] = Color.yellow;
        colors[4] = Color.gray;
        GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
    }
    public void Init(bool isOffset)
    {
        //sprite.color = isOffset ? OffestColor : BaseColor;
    }
    private void OnMouseEnter()
    {
        SpriteRenderer.SetActive(true);
    }
    private void OnMouseExit()
    {
        SpriteRenderer.SetActive(false);
    }
    void OnMouseDown()
    {
        //GetComponent<Renderer>().material.color = Random.ColorHSV();
        GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
    }
}
