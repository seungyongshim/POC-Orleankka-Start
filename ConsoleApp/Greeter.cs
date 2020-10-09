using Orleankka;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public interface IGreeter : IActorGrain { }
    public class Greeter : ActorGrain, IGreeter
    {
        public override Task<object> Receive(object message)
        {
            switch (message)
            {
                case Greet greet:
                    return Result($"Hello, {greet.Who}");
                case Sleep _:
                    Console.WriteLine("Sleeeeeping ...");
                    return TaskResult.Done;
                default:
                    return TaskResult.Unhandled;
            }
        }
    }
}
