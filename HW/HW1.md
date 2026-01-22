timelines : 10:00 - 30:00
link : https://www.youtube.com/watch?v=6wDoopbtEqk

# Refactoring to Fix Code Smells

Fowler highlights a major issue: Long Functions — functions that are too long and hard to read.
The goal is “to make the code cleaner without changing the program’s behavior.”

## 1. Extract Function

Break a large function into smaller helper functions, especially the parts that contain switch statements based on play types.

Why extract?

The main function becomes easier to read

Specialized logic is grouped clearly

Reduces overly long code

Caution: You must properly handle local variables such as perf and play that may be used across multiple lines.

## 2. Rename Variable

Change variable names so the code “communicates better.”

Examples from Fowler:

thisAmount → result (a common name for return values)

perf → aPerformance (more explicit and descriptive)

Outcome:
You can immediately understand what a variable stores just by reading the code.

## 3. Replace Temp with Query

Remove temporary variables (e.g., play) and replace them with function calls such as playFor(perf).

Why?

Reduces dependencies between variables

Makes Extract Function easier

Organizes logic more cleanly

Fowler emphasizes not to worry about performance at this stage:
→ Make the code clean first, then profile later to find performance bottlenecks.

## 4. Split Loop

Separate loops that perform multiple tasks (e.g., calculating price + calculating points).

Example:

Loop A → compute the price

Loop B → compute reward points

Why split?

Makes Extract Function easier

Removes mixed, tangled logic

Significantly improves readability

## "Refactoring should be done in small steps without changing the program’s behavior."

The ultimate goal is:

Clean, well-organized internal code

Ready to support future features, such as:

HTML rendering

New play types, etc.
