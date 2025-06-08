using App;
namespace SpaceBattle.Lib
{
    public class RegisterShootDependencies : ICommand
    {
        public void Execute()
        {
            Ioc.Resolve<App.ICommand>("IoC.Register", "Commands.Shoot", (object[] args) =>
            {
                return new ShootCommand((Vector)args[0], (Vector)args[1], (double)args[2]);
            }).Execute();
        }
    }
}
