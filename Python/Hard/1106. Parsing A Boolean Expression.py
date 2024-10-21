class Solution:
    def parseBoolExpr(self, expression: str) -> bool:
        # Helper function to evaluate the boolean NOT operation
        def evaluate_not(expr):
            return not evaluate(expr)

        # Helper function to evaluate the boolean AND operation
        def evaluate_and(expr_list):
            return all(evaluate(e) for e in expr_list)

        def evaluate_or(expr_list):
            return any(evaluate(e) for e in expr_list)

        def evaluate(expr):
            if expr == 't':
                return True
            if expr == 'f':
                return False
            if expr[0] == '!':  
                return evaluate_not(expr[2:-1])e
            elif expr[0] == '&':
                sub_expressions = split_subexpressions(expr[2:-1])'
                return evaluate_and(sub_expressions)
            elif expr[0] == '|': 
                sub_expressions = split_subexpressions(expr[2:-1])
                return evaluate_or(sub_expressions)

        def split_subexpressions(expr):
            sub_exprs = []
            start, balance = 0, 0
            for i, c in enumerate(expr):
                if c == '(':
                    balance += 1
                elif c == ')':
                    balance -= 1
                elif c == ',' and balance == 0:
                    sub_exprs.append(expr[start:i])
                    start = i + 1
            sub_exprs.append(expr[start:])
            return sub_exprs

        return evaluate(expression)