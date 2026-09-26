Chapter 2 — Processing Data

3.1 Reading Input with TextBox Controls

A TextBox is a control that allows the user to enter information using the keyboard.

The information entered is stored as text.

TextBox controls can also be cleared when needed.

3.2 A First Look at Variables
A variable is a storage location in memory used to hold data.
A variable must be declared before it can be used.

A data type determines what kind of data a variable can store.
Primitive data types are basic data types built into C#
Variable Names
A variable name identifies a variable.
It must begin with a letter or underscore.
It cannot contain spaces.
Reserved words and keywords cannot be used as variable names.
Meaningful names are recommended.
String Variables
A string is a sequence of characters.
Strings are used to store text such as names and other written information.
String Concatenation
Concatenation means joining strings together.
Strings can also be combined with numeric values when producing output.
Local Variables and Scope
A local variable belongs to the method in which it is declared.
Its scope is the part of the program where it can be accessed.
Its lifetime is the period during which it exists in memory.
A local variable is created when its method begins and destroyed when the method ends.
Duplicate Variable Names
Two variables cannot have the same name within the same scope.
Different methods can have variables with the same name.
Assignment Compatibility
The data assigned to a variable must be compatible with the variable's data type.
Initializing Variables
Variables must be given a value before they are used.
The compiler will not allow an unassigned local variable to be used.
Declaring Multiple Variables with One Statement
Multiple variables of the same data type can be declared together.
3.3 Numeric Data Types and Variables
Numeric data types are used to store numbers and perform calculations.
int stores whole numbers.
double stores real numbers, including fractional values.
decimal provides greater precision and is commonly used for financial values.
Numeric Literals
A numeric literal is a number written directly in a program.
Whole-number literals are treated as integers.
Numbers containing a decimal point are normally treated as doubles.
Decimal literals are identified using the appropriate decimal suffix.
Assignment Compatibility
An int cannot directly receive a double or decimal.
A double can receive an int, but not a decimal.
A decimal can receive an int, but not a double.
Explicit Conversion with Cast Operators
Casting means explicitly converting a value from one data type to another.
It is used when a specific type conversion is required.
Declaring Local Variables with the var Keyword
The var keyword allows the compiler to determine the variable's type from its initial value.
A var variable must be initialized.
var is used for local variables.
3.4 Performing Calculations

The main arithmetic operations are:

Addition — combines values.
Subtraction — finds the difference.
Multiplication — multiplies values.
Division — divides one value by another.
Modulus — gives the remainder after division.
Rules for Performing Calculations
Mathematical expressions follow the normal order of operations.
Parentheses can be used to control the order of calculations.
When different numeric types are used together, the result depends on the types involved.
An int and double generally produce a double.
An int and decimal generally produce a decimal.
double and decimal cannot be directly combined.
Integer Division
Dividing one integer by another produces an integer result.
Any fractional part can be lost.
A decimal-producing data type must be involved when a fractional result is required.
3.5 Inputting and Outputting Numeric Values
Data entered through a TextBox is treated as a string, even when the user enters a number.
A string must be converted into a numeric data type before mathematical calculations can be performed.
Parsing is used to convert strings into numeric values.
Displaying Numeric Values
TextBox and Label controls display text.
Numeric values therefore need to be converted to strings when displayed.
Numeric values can also be combined with strings when producing output.
3.6 Formatting Numbers with the ToString Method

Numbers can be formatted into different display styles.

N / n — number format
F / f — fixed-point format
E / e — exponential format
C / c — currency format
P / p — percentage format
3.7 Simple Exception Handling
An exception is an unexpected error that occurs while a program is running.
Examples include division by zero, missing files, and invalid input.
If an exception is not handled, the program may stop unexpectedly.
Exception handling allows a program to respond to errors instead of stopping abruptly.
Handling Exceptions with try-catch
The try section contains operations that might cause an exception.
The catch section handles the exception when it occurs.
Throwing an Exception
Throwing means that an error or exception has occurred.
Throwing vs. Catching
Throwing → the error occurs.
Catching → the program handles the error.
Real-Life Examples
An ATM may respond to an invalid PIN with a warning instead of stopping.
A car may warn the driver when fuel is empty or very low.
Displaying an Exception's Default Message
An exception is an object.
It has a Message property.
The Message property contains a description of the error.
3.8 Using Named Constants
A named constant is a name that represents a value that cannot change while the program is running.
Constants are useful for values that should remain fixed.
Uppercase names are traditionally used for constants, although this is not required.
3.9 Declaring Variables as Fields
A field is a variable declared at the class level.
It is inside the class but outside methods.
Its scope is the entire class.
A field is created in memory when the form is created.
3.10 Using the Math Class

The Math class provides mathematical operations and constants.

Math.Sqrt → calculates a square root.
Math.Pow → calculates a power.
Math.Max → determines the larger value.
Math.Min → determines the smaller value.
Math.Round → rounds a value.
Math.PI → represents pi.
Math.E → represents the mathematical constant e.
3.11 More GUI Details
Tab Order
Focus means that a control is currently receiving keyboard input.
Tab Order determines the sequence in which controls receive focus when the Tab key is pressed.
TabIndex determines a control's position in the tab order.
TabIndex begins at 0.
Labels cannot receive keyboard focus.
Focus Method
Focus can be moved from one control to another.
This is useful when you want the cursor to automatically move to a particular input control.
Assign Keyboard Access Key to Buttons
A keyboard access key is a shortcut used with the Alt key.
It allows users to access controls using the keyboard.
Setting Colors
BackColor controls the background color.
ForeColor controls the foreground/text color.
Color choices include Custom, Web, and System colors.
Background Images for Forms
Forms can have background images.
The background image layout determines how the image is displayed.
Available layouts include:
None
Tile
Center
Stretch
Zoom
GroupBoxes versus Panels
Both GroupBox and Panel are containers used to organize controls.
A GroupBox can have a border and title.
A Panel does not have a title.
A Panel can have a border through its border settings.
3.12 Using the Debugger to Locate Logic Errors
Logic Error
A logic error occurs when a program runs but produces an incorrect result.
Examples include incorrect mathematical operations or assigning the wrong value.
Breakpoints
A breakpoint is a selected point where program execution pauses.
When the program reaches it, it enters Break Mode.
The programmer can inspect variables and control properties.
Break Mode
The program is temporarily paused.
Variable values and control properties can be examined to find errors.
Locals and Watch Windows
Locals Window shows variables belonging to the current procedure, including their values and types.
Watch Window allows selected variables to be monitored while debugging.
Single-Stepping
Single-stepping means executing the program one statement at a time.
It allows the programmer to inspect values after each statement.
It helps identify the exact point where a logic error occurs