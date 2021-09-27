using UnityEngine;

public class Food : MonoBehaviour
{
    public Collider2D gridArea;
    private Bounds bounds;

    private void Start()
    {
        bounds = this.gridArea.bounds;
        RandomizePosition();
    }

    public void RandomizePosition()
    {
        // Pick a random position inside the bounds
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        // Round the values to ensure it aligns with the grid
        x = Mathf.Round(x);
        y = Mathf.Round(y);

        this.transform.position = new Vector2(x, y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        RandomizePosition();
    }

}
