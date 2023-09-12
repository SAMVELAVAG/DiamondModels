using UnityEngine;
using UnityEngine.Events;

public enum StoneValues
{
    Marquise = 10,
    Emerald = 5,
    Stone = -2,
    Pear = 3,
    Radiant = 2,
    Heart = 1,
    Trilliant = 2,
    Round = 3,
    Bomb = -6,
}
public class BoxMovement : MonoBehaviour
{
    public UnityEvent<int> OnBoxEntered { get; } = new UnityEvent<int>();
    public void UpdateFrame()
    {
        //TODO
        //Move box 
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            OnBoxEntered?.Invoke(2);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            OnBoxEntered?.Invoke(-2);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnBoxEntered?.Invoke(-6);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null)
            return;
        StoneValues value = default;
        switch (collision.gameObject.name)
        {
            case "Marquise": value = StoneValues.Marquise; break;
            case "Emerald": value = StoneValues.Emerald; break;
            case "Stone": value = StoneValues.Stone; break;
            case "Pear": value = StoneValues.Pear; break;
            case "Round": value = StoneValues.Round; break;
            case "Trilliant": value = StoneValues.Trilliant; break;
            case "Heart": value = StoneValues.Heart; break;
            case "Radiant": value = StoneValues.Radiant; break;
            case "Bomb": value = StoneValues.Bomb; break;
        }
        OnBoxEntered?.Invoke((int)value);
    }
}