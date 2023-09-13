using System;

namespace AD
{
    public static class BracketChecker
    {

        /// <summary>
        ///    Run over all characters in a string, push all '(' characters
        ///    found on a stack. When ')' is found, it shoud match a '(' on
        ///    the stack, which is then popped.
        ///
        ///    If ')' is found when no '(' is on the stack, this method will
        ///    terminate prematurely, no further inspection is needed.
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>Returns True if all '(' are matched by ')'.
        /// Returns False otherwise.</returns>
        public static bool CheckBrackets(string s)
        {
	        MyStack<char> bracketStack = new();
	        foreach (var c in s)
	        {
		        if (c.Equals('('))
			        bracketStack.Push(c);
		        else if (c.Equals(')'))
			        if (bracketStack.IsEmpty())
				        return false;
			        else
				        bracketStack.Pop();
		        else
			        throw new BracketCheckerInvalidInputException();
	        }

	        return bracketStack.IsEmpty();
        }


        /// <summary>
        ///    Run over all characters in a string, when an opening bracket is
		///    found the closing counterpart from closeChar is pushed on a Stack
        ///    When an closing bracket is found, it should match the top character
		///    from this stack.
		///    
        ///    This method will terminate prematurely if a wrong or missmatched
        ///    closing bracket is found and no further inspection is needed.
		/// </summary>
		/// <param name="s">The string to check</param>
		/// <returns>Returns True if all opening brackets are matched by
		/// it's correct counterpart in a correct order.
        /// Returns False otherwise.</returns>
        public static bool CheckBrackets2(string s)
        {
	        MyStack<char> bracketStack = new();
	        foreach (var c in s)
	        {
		        if (c == '[' || c == '{' || c == '(')
		        {
			       bracketStack.Push(c); 
		        }
		        else if (c == ']' || c == '}' || c == ')')
		        {
			        char top = bracketStack.Top();
			        if (
				        top == '[' && c == ']' ||
				        top == '{' && c == '}' ||
				        top == '(' && c == ')'
			        )
				        bracketStack.Pop();
			        else
				        return false;
		        }
		        else
		        {
			        throw new BracketCheckerInvalidInputException();
		        }
	        }

	        return bracketStack.IsEmpty();
        }

    }

    class BracketCheckerInvalidInputException : Exception
    {
    }

}
