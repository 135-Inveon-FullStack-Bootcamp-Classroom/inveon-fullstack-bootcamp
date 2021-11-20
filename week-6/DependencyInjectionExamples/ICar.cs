namespace DependencyInjectionExamples
{
    public interface ICar
    {
        public string Type { get; set; }
        public void Start();
        public void ShotDown();
        public void GoForward();
        public void GoBack();
        public void Stop();
        public void ParkEt();

    }
}
