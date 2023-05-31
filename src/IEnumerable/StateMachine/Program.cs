using StateMachine;
using StateMachine.Enums;

Working p = new();
WriteLine("Current State = " + p.CurrentState);
WriteLine("Command.Begin: Current State = " + p.MoveNext(Command.Begin));
WriteLine("Command.Pause: Current State = " + p.MoveNext(Command.Pause));
WriteLine("Command.Resume: Current State = " + p.MoveNext(Command.Resume));
WriteLine("Command.Pause: Current State = " + p.MoveNext(Command.Pause));
WriteLine("Command.End: Current State = " + p.MoveNext(Command.End));
WriteLine("Command.Exit: Current State = " + p.MoveNext(Command.Exit));

WriteLine();

try
{
    WriteLine("Command.End: Current State = " + p.MoveNext(Command.End));
}
catch (Exception e)
{
    WriteLine(e.Message);
}

ReadLine();