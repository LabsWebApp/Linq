using StateMachine.Enums;

namespace StateMachine;

internal record struct StateTransition(State State, Command Command);

internal class Working
{
    /// <summary>
    ///  (Состояние - Переход) -> Новое Состояние
    /// </summary>
    public Dictionary<StateTransition, State> Transitions { private get; init; }
    public State CurrentState { get; private set; }

    public Working()
    {
        CurrentState = State.Inactive;
        Transitions = new Dictionary<StateTransition, State>
            {
                { new StateTransition(State.Inactive, Command.Begin), State.Active },
                { new StateTransition(State.Inactive, Command.Exit), State.Terminated },
                { new StateTransition(State.Active, Command.End), State.Inactive },
                { new StateTransition(State.Active, Command.Pause), State.Paused },
                { new StateTransition(State.Paused, Command.End), State.Inactive },
                { new StateTransition(State.Paused, Command.Resume), State.Active }
            };
    }

    public State GetNext(Command command)
    {
        var transition = new StateTransition(CurrentState, command);
        if (!Transitions.TryGetValue(transition, out var nextState))
            throw new Exception("Invalid transition: " + CurrentState + " -> " + command);
        return nextState;
    }

    public State MoveNext(Command command)
    {
        CurrentState = GetNext(command);
        return CurrentState;
    }
}