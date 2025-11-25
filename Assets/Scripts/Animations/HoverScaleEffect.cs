using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverScaleEffect : MonoBehaviour
{
    [SerializeField] public float hoverScale = 1.2f; // Scale when hovering
    [SerializeField] public float animationSpeed = 5f; // Speed of scaling effect

    private RectTransform rectTransform;
    private Vector3 originalScale;
    private Vector3 targetScale;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        originalScale = rectTransform.localScale;
        targetScale = originalScale;
    }

    void Update()
    {
        // Smoothly scale to the target scale
        rectTransform.localScale = Vector3.Lerp(rectTransform.localScale, targetScale, Time.deltaTime * animationSpeed);
    }

    public void OnMouseEnter()
    {
        targetScale = originalScale * hoverScale;
    }

    public void OnMouseExit()
    {
        targetScale = originalScale;
    }

    public void OnMouseUpAsButton()
    {
        Application.OpenURL("https://linktr.ee/PointSixGames");
    }
}
