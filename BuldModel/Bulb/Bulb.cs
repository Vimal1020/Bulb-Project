namespace BulbModel.Bulb
{
    public class Bulb
    {
        public bool IsOn { get; private set; }

        public void Toggle()
        {
            IsOn = !IsOn;
        }
    }
}