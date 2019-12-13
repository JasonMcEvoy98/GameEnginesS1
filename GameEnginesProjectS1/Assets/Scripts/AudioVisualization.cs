using UnityEngine;

public enum VisualizationMode
{
    Ring,
    RingWithBeat
}

public class AudioVisualization : MonoBehaviour
{
    public int bufferSampleSize;
    public float samplePercentage;
    public float emphasisMultiplier;
    public float retractionSpeed;

    public int amountOfSegments;
    public float radius;
    public float bufferSizeArea;
    public float maxiumExtendLength;

    public GameObject lineRenderPrefab;
    public Material lineRendererMaterial;
    public VisualizationMode visualizationMode;

    public Gradient colorGradientA = new Gradient();
    public Gradient colorGradientB = new Gradient();

    private Gradient currentColor = new Gradient();

    private float sampleRate;

    private float[] samples;
    private float[] spectrum;
    private float[] extendLengths;

    private LineRenderer[] lineRenderers;

    private AudioSource audiosource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        sampleRate = AudioSettngs.outputSampleRate;

        samples = new float[bufferSampleSize];
        samples = new float[bufferSampleSize];

        switch (visualizationMode)
        {
            case VisualizationMode.Ring:
                InitiateRing();
                break;
        }

          void InitiateRing()
        {
            extendLengths = new float[amountOfSegments + 1];
            lineRenderers = new LineRenderer[extendLengths.Length];

            for( int i = 0; i < lineRenderers.Length; i++)
            {
                GameObject go = Instantiate(lineRendererPrefab);
                go.transform.position = Vector3.zero;

                LineRenderer lineRenderer = go.GetComponent<LineRenderer>();

            }
        }
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
