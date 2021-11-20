namespace DependencyInjectionExamples
{
    public class Driver
    {
        private ICar _car;
        public Driver(ICar car)
        {
            _car = car;
        }
        public void Drive()
        {
            _car.Start();
            _car.GoForward();
            _car.ParkEt();
            _car.ShotDown();
        }
    }
}
