using System;

namespace AbstructTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bird penguin = new Penguin();
            var penguin2 = new Penguin();
            var markel = new Markel();
            var salmon = new Salmon();
            Bird parrot = new Parrot();

            Zoo.Swim(penguin2);
            Zoo.Swim(markel);
            Zoo.Swim(penguin2);
            Zoo.Swim(salmon);
            Zoo.Swim(penguin2);
            
            Bird chicken = new Chicken();

            parrot.Fly(parrot);
            chicken.Fly(chicken);
            penguin.Fly(penguin);
            /*
             * So it is start from Bird.Fly, then its like thinking "well Fly() is sexy juicy webcam virtual method"
             * so i should try to find override stuff, parrot does not have it so get what u deserve,
             * chicken and pinguin have override stuff so program did override stuff.
             * If we are change Bird to Animal nothing is gonna work couse Animal dose not have Fly() method so it basically
             * nothing to start from i think.
             */

            Referee referee = new Referee("Pier");
            Ball ball = new Ball();
            FieldPlayer fieldPlayerA1 = new FieldPlayer("Nick");
            FieldPlayer fieldPlayerA2 = new FieldPlayer("Mike");
            Goalkeeper goalKeeperA = new Goalkeeper("Kasper");
            FieldPlayer fieldPlayerB1 = new FieldPlayer("Vasya");
            FieldPlayer fieldPlayerB2 = new FieldPlayer("Kolya");
            Goalkeeper goalKeeperB = new Goalkeeper("Petya");

            referee.Whistle();

            Simulator.Move(Position.Center, ball);

            fieldPlayerA1.Pass(fieldPlayerA2);

            fieldPlayerA2.Pass(fieldPlayerA1);

            Simulator.Move(Position.PenaltyArea, ball, fieldPlayerA1, fieldPlayerA2);

            fieldPlayerA1.KickOnGoal();

            goalKeeperB.CatchBall();

            goalKeeperB.Pass(fieldPlayerB1);

            Simulator.Move(Position.Center, ball);

            Simulator.Move(Position.PenaltyArea, fieldPlayerB1);

            referee.Whistle();

            fieldPlayerB1.PickBooking();

            fieldPlayerA2.Pass(fieldPlayerA1);

            referee.Whistle();

            fieldPlayerA2.PickBooking();

            fieldPlayerB1.Pass(fieldPlayerB2);

            fieldPlayerB2.Pass(fieldPlayerB1);

            Simulator.Move(Position.PenaltyArea, fieldPlayerB1);

            fieldPlayerA2.CatchBall();

            referee.Whistle();

            fieldPlayerA2.PickBooking();

            fieldPlayerB1.KickOnGoal();

            goalKeeperA.MissBall();

            IDrink human = new Human();
            human.Sip();

            IDrinkTwo human2 = new Human();
            human2.Sip();
        }
    }
}
