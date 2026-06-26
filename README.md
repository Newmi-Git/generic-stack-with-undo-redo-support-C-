# UndoableStack — C# Practice Project

## Overview
A small C# console application that implements a generic stack (`UndoableStack<T>`) with undo and redo functionality. The stack supports pushing and popping items, and tracks action history so that pops can be reversed and re-applied.

## What It Does
- **Push** — adds an item to the top of the stack
- **Pop** — removes and returns the top item, saving it to undo history
- **Undo** — restores the last popped item back onto the stack
- **Redo** — re-removes an item that was restored via undo

## What I Learnt
- **Generics (`<T>`)** — how to write a class that works with any data type without rewriting it for each one
- **Data structures** — what a stack is, how LIFO works, and how it differs from arrays and queues
- **Encapsulation** — keeping internal state private and only exposing controlled methods
- **Exception handling** — throwing meaningful errors instead of silently failing when the stack is empty
- **Stack logic** — how to use multiple stacks together to track history and enable undo/redo behaviour