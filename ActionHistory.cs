using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_System
{

    public class ActionHistory
    {
       public Stack<Action> Actions { get; set; } = new Stack<Action>();
        
        public void PushAction(Action action)
        {
            Actions.Push(action);
        }

        public void UndolastAction(ShoppingCart cart) 
        {
            if (Actions.Any()) 
            {
                var LastAction = Actions.Pop();
                LastAction.Undo(cart);
            }
            else
            {
                Console.WriteLine("No Actions to Undo");
            }
        }
        

    }
}
