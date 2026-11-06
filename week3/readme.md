CHAPTER 3: MAKING DECISIONS



Book: Starting Out with Visual C# – Sixth Edition
Publisher: Pearson Education

1. Decision Structures and the if Statement

A control structure is a logical design that controls the order in which statements execute.

There are different types of control structures:

* Sequence Structure: A set of statements that execute in the order that they appear.
* Decision Structure: Executes statements only under certain circumstances.
* Selection Structure: Another name for a decision structure.

A decision structure performs a specific action only if a certain condition exists.

The if statement is used to create a simple decision structure. It evaluates a Boolean expression, which can be either True or False.

2. Relational Operators

A relational operator determines whether a specific relationship exists between two values.

The relational operators are:

* Greater than (>)
* Less than (<)
* Greater than or equal to (>=)
* Less than or equal to (<=)
* Equal to (==)
* Not equal to (!=)

These operators are used to compare two values and determine whether a condition is True or False.

3. The if-else Statement

An if-else statement executes one block of statements if its Boolean expression is True or another block if its Boolean expression is False.

It has two parts:

* if clause: Executes when the condition is True.
* else clause: Executes when the condition is False.

The if-else statement provides two alternative paths of execution.

4. Nested Decision Structures

Nested decision structures are used to test more than one condition.

The word Nested means one inside another.

A nested decision structure contains an if statement inside another if statement. It allows a program to make decisions based on multiple conditions.

5. The if-else-if Statement

The if-else-if statement is used to evaluate multiple conditions to make a final decision.

It checks conditions one by one.

When a condition is True, its statements are executed. If none of the conditions is True, the else section is executed.

6. Logical Operators

Logical operators allow you to connect multiple Boolean expressions to create a compound expression.

There are three main logical operators:

1. AND (&&)

Both subexpressions must be True for the compound expression to be True.

2. OR (||)

One or both subexpressions must be True for the compound expression to be True.

3. NOT (!)

It negates or reverses the value of a Boolean expression.

Logical operators are used to test multiple conditions in a program.

7. bool Variables and Flags

A bool variable stores one of two possible values: True or False.

Bool variables are commonly used as flags.

A flag is a variable that signals when some condition exists in a program.

* False indicates that the condition does not exist.
* True indicates that the condition exists.

8. Comparing Strings

Strings can be compared using certain relational operators and methods.

The == operator can compare two strings.

The != operator can determine whether two strings are different.

The String.Compare method can also be used to compare two strings.

String comparison helps a program determine whether two text values are equal or different.

9. Preventing Data Conversion Exceptions with the TryParse Method

Exceptions should be prevented when possible.

The TryParse methods can prevent exceptions caused by users entering invalid data.

Common TryParse methods include:

* int.TryParse
* double.TryParse
* decimal.TryParse

The out keyword is required in the TryParse method. It specifies that the target variable is an output variable.

TryParse checks whether the entered string can be converted into the required data type.

10. Input Validation

Input validation is the process of inspecting data that has been entered into a program to make sure it is valid before it is used.

TryParse checks whether the user enters data in the correct format, but it does not check the integrity of the data.

Data integrity means that the data is reasonable and trustworthy.

For example:

* The number of hours worked should be greater than 0 and less than or equal to 168.
* Test scores should be between 0 and 100.

A number can be valid but still be unreasonable.

Therefore, input validation checks both the validity and reasonableness of entered data.

11. Radio Buttons and Check Boxes

Radio Buttons

Radio buttons allow users to select one choice from several possible choices.

When a user clicks one radio button, the program automatically deselects the others.

This is known as mutually exclusive selection, meaning only one option can be selected at a time.

Common properties:

* Text: Holds the text displayed next to the radio button.
* Checked: A Boolean property that determines whether the control is selected or deselected.

Check Boxes

Check boxes allow users to select multiple options.

They provide the user with options such as True/False or Yes/No.

Common properties:

* Text: Holds the text displayed next to the check box.
* Checked: Determines whether the control is selected or deselected.

12. The CheckedChanged Event

Whenever a radio button or check box control’s Checked property changes, a CheckedChanged event is raised.

A CheckedChanged event handler allows the programmer to write code that responds when the selected state changes.

It is used to respond to changes in radio buttons and check boxes.

13. The switch Statement

The switch statement lets the value of a variable or an expression determine which path of execution the program will take.

It is a multiple-alternative decision structure.

It can be used as an alternative to an if-else-if statement that tests the same variable or expression for several different values.

The switch statement contains:

* switch: Evaluates the test expression.
* case: Represents an individual possible value.
* break: Ends the current case.
* default: Executes when no case matches the test expression.

The default section is optional.

The test expression can have an int, string, or bool value.

14. Introduction to List Boxes

A ListBox control displays a list of items and allows the user to select an item from the list.

Common ListBox properties include:

1. Text

Contains the text of the currently selected item in the ListBox.

2. Items

Contains the items of the ListBox.

3. Items.Count

Contains the total number of items in the ListBox.

4. SelectedItem

Gets or sets the currently selected item in a ListBox.

5. SelectedIndex

Gets or sets the zero-based index of the currently selected item in a ListBox.

The first item has index 0, and the nth item has index n - 1.

If no item is selected, the SelectedIndex value is -1.

15. Adding Items to a ListBox

The Items.Add method allows you to add a new item to a ListBox.

It is used to insert items into the list.

16. Removing Items from a ListBox

There are three important methods used to remove items from a ListBox.

1. Items.Remove

Removes a specific item from a ListBox.

2. Items.RemoveAt

Removes an item at a specific index from a ListBox.

The specified index must be valid. If the index is invalid, the method throws an exception.

3. Items.Clear

Erases all the items in a ListBox.

17. Difference Between Text and SelectedItem

* Text: Returns the selected text as a string. It is useful when you only need the displayed text.
* SelectedItem: Returns the selected item as an object. It is more flexible and can be used when working with real data.

Text is suitable for simple text-only lists, while SelectedItem is useful for more complex or data-bound lists.
