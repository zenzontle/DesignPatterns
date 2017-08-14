using System;

namespace Concepts.Mediator
{
    public class NonBeatle : Participant
    {
        public NonBeatle(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
