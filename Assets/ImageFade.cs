using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFade : MonoBehaviour
{
    public Image blackoutImage; //���������� UI Image �� ���� ��������� ���� � ����������
    public float fadeDuration = 0.5f; //�����, �� ������� ������ ���������� ������������
    public float fadeTo = 0.8f; //������������ ������������, ������� ����� ����������

    private IEnumerator FadeToBlack()
    {
        float elapsedTime = 0f;
        Color color = blackoutImage.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);
            color.a = Mathf.Lerp(0f, fadeTo, t);
            blackoutImage.color = color;
            yield return null;
        }

        //����� ����� ������� ����� ��� ������������ ���������

        elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / fadeDuration);
            color.a = Mathf.Lerp(fadeTo, 0f, t);
            blackoutImage.color = color;
            yield return null;
        }
    }
    public void OnClick()
    {
        StartCoroutine(FadeToBlack());
    }
}
