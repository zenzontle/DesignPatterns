using System;

namespace Concepts.Mediator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create the mediator
            Chatroom chatroom = new Chatroom();

            Participant george = new Beatle("George");
            Participant paul = new Beatle("Paul");
            Participant ringo = new Beatle("Ringo");
            Participant john = new Beatle("John");
            Participant yoko = new NonBeatle("Yoko");

            chatroom.Register(george);
            chatroom.Register(paul);
            chatroom.Register(ringo);
            chatroom.Register(john);
            chatroom.Register(yoko);

            yoko.Send("John", "Hi John!");
            paul.Send("Ringo", "All you need is love");
            ringo.Send("George", "My sweet Lord");
            paul.Send("John", "Can't buy me love");
            john.Send("Yoko", "My sweet love");

            Console.ReadKey();
        }
    }
}
