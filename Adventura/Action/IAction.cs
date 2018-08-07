using Adventura.Character;

namespace Adventura.Action
{
    interface IAction
    {
        void ExecuteAction(Character.Character who,Character.Character target);
    }
}
