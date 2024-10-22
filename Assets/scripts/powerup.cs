using UnityEngine;
using TMPro; // TextMeshProUGUI
using System.Collections;

public class Powerup : MonoBehaviour
{
    public TextMeshProUGUI powerupText;  
    public float fadeDuration = 1f;      // Duration for fade
    public float moveSpeed = 20f;        // Speed of upward movement

    void Start()
    {
        powerupText.gameObject.SetActive(false);  
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            powerupText.text = "Powerup Collected!";
            powerupText.gameObject.SetActive(true);
            StartCoroutine(FadeAndMoveText());
            Destroy(gameObject); 
        }
    }

    IEnumerator FadeAndMoveText()
    {
        float elapsedTime = 0f;
        Color originalColor = powerupText.color;
        Vector3 originalPosition = powerupText.rectTransform.position;

        while (elapsedTime < fadeDuration)
        {
            // Fade out
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            powerupText.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);

            // Move upwards
            powerupText.rectTransform.position = originalPosition + Vector3.up * moveSpeed * (elapsedTime / fadeDuration);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        powerupText.gameObject.SetActive(false);  // Hide after fade out
    }
}
