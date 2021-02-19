using UnityEngine;

public class LoudnessTester : MonoBehaviour
{
    public int sampleDataLength;
    public float clipLoudness;
    public float minSize;
    public float maxSize;
    public float sizeFactor;
    public float updateStep;
    public AudioSource audioSource;
    public GameObject sprite;

    private float currentUpdateTime = 0f;
    private float[] clipSampleData;

    private void Awake()
    {
        clipSampleData = new float[sampleDataLength];
    }

    private void Update()
    {
        if (audioSource.clip == null)
        {
            return;
        }

        currentUpdateTime += Time.deltaTime;

        if (currentUpdateTime >= updateStep)
        {
            currentUpdateTime = 0f;
            audioSource.clip.GetData(clipSampleData, audioSource.timeSamples);
            clipLoudness = 0f;

            foreach (var sample in clipSampleData)
            {
                clipLoudness += Mathf.Abs(sample);
            }
            
            clipLoudness /= sampleDataLength;
            clipLoudness *= sizeFactor;
            clipLoudness = Mathf.Clamp(clipLoudness, minSize, maxSize);
            sprite.transform.localScale = new Vector3(clipLoudness, clipLoudness, clipLoudness);

            Debug.Log("Volume: " + clipLoudness);
        }
    }
}
