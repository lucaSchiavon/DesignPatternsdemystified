﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.BehavioralPatterns.Interpreter.NumberInterpreter
{
    // Non-Terminal Expression
    public class AddExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public AddExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return _left.Interpret(context) + _right.Interpret(context);
        }
    }
}
