using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public SpriteRenderer[] spriteRenderers; // An array of SpriteRenderer components
    public Sprite[] sprites; // An array of sprites to be displayed
    public float displayDuration = 3f; // Duration in seconds to display each sprite
    public Button[] backButtonArray; // An array of Button components for the back buttons
    public Button actionButton; // The action button to be shown when the last sprite is displayed

    private int currentIndex = 0; // Index of the currently displayed sprite

    private void Start()
    {
        currentIndex = 0;
        ShowSprite();
    }

    private void ShowSprite()
    {
        // Disable all sprite renderers
        for (int i = 0; i < spriteRenderers.Length; i++)
        {
            spriteRenderers[i].enabled = false;
        }

        // Enable the current sprite renderer and assign the sprite
        spriteRenderers[currentIndex].enabled = true;
        spriteRenderers[currentIndex].sprite = sprites[currentIndex];

        // Enable the back button for the current sprite and disable others
        for (int i = 0; i < backButtonArray.Length; i++)
        {
            backButtonArray[i].gameObject.SetActive(i == currentIndex);
        }

        // Show the action button when the last sprite is displayed
        actionButton.gameObject.SetActive(currentIndex == sprites.Length - 1);

        // Schedule the next sprite, except for the last sprite
        if (currentIndex < sprites.Length - 1)
        {
            Invoke("NextSprite", displayDuration);
        }
    }

    private void NextSprite()
    {
        currentIndex++;
        ShowSprite();
    }

    public void GoToPreviousSprite()
    {
        // Decrement the current index
        currentIndex--;

        // Ensure the current index stays within the valid range
        currentIndex = Mathf.Clamp(currentIndex, 0, sprites.Length - 1);

        // Show the previous sprite
        ShowSprite();
    }
}
