﻿namespace Exo.Compiler.CodeAnalysis
{
    public struct TextSpan
    {
        public readonly int Start;
        public readonly int Length;
        public int End => Start + Length;
        public TextSpan(int start, int length)
        {
            Start = start;
            Length = length;
        }
    }
}