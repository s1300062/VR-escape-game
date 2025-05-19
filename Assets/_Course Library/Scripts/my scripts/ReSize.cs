using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScaleOnSelect : MonoBehaviour
{
    public Vector3 targetScale = new Vector3(2f, 2f, 2f); // 拡大したい最大サイズ
    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    public void ScaleUp()
    {
        // 現在のサイズがtargetScaleより小さい場合のみ拡大
        if (transform.localScale.x < targetScale.x ||
            transform.localScale.y < targetScale.y ||
            transform.localScale.z < targetScale.z)
        {
            transform.localScale = targetScale;
        }
    }

    public void ResetScale()
    {
        transform.localScale = originalScale;
    }
}
