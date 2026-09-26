Chapter 1 — C# Code and Explanations


1. Form1 Constructor

Purpose

The constructor initializes the Form when the program starts.

namespace hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}

Explanation

- "namespace hello_world": Defines the namespace name.
- "public partial class Form1 : Form": Defines the "Form1" class.
- "public Form1()": This is the constructor.
- "InitializeComponent();": Initializes the Form and its controls.

How It Works

When the program starts, the constructor runs and "InitializeComponent();" prepares the Form and its controls.

Screenshot

"Form1 Constructor" (Screenshots/form1_constructor.png)

---

2. MessageBox — Displaying a Message

Purpose

To display a message when a Button is clicked.

private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}

Explanation

- "private void": Defines a method that does not return a value.
- "myButton_Click": The event handler name.
- "object sender": Identifies the object that caused the event.
- "EventArgs e": Contains event information.
- "MessageBox.Show()": Displays a message.
- ""Thanks for clicking the button!"": The message displayed.

How It Works

The user clicks the Button, the event handler runs, and a message appears.

Screenshot

"MessageBox" (Screenshots/messagebox.png)

---

3. Hello World

Purpose

To display Hello World when a Button is clicked.

private void messageButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello World");
}

Explanation

- "messageButton_Click": Handles the Button click event.
- "MessageBox.Show()": Displays a message.
- ""Hello World"": The text displayed.

Output

A message box displays:

Hello World

Screenshot

"Hello World" (Screenshots/hello_world.png)

---

4. Label — Displaying Text

Purpose

To display text in a Label.

answerLabel.Text = "Hello World";

Explanation

- "answerLabel": The Label's name.
- ".Text": The text displayed in the Label.
- "=": The assignment operator.
- ""Hello World"": The text assigned to the Label.
- ";": Ends the statement.

Output

The Label displays:

Hello World

Screenshot

"Label Display" (Screenshots/label_display.png)

---

5. Clearing a Label

Purpose

To clear the text displayed in a Label.

answerLabel.Text = "";

Explanation

- "answerLabel": The Label's name.
- ".Text": The Label's Text property.
- """": An empty string.

Output

The Label becomes empty.

Screenshot

"Clear Label" (Screenshots/clear_label.png)

---

6. PictureBox — Showing and Hiding Images

Purpose

To show one image and hide another image.

cardBackPictureBox.Visible = true;
cardFacePictureBox.Visible = false;

Explanation

- "cardBackPictureBox": The PictureBox for the back image.
- "Visible = true": Makes the image visible.
- "cardFacePictureBox": The PictureBox for the front image.
- "Visible = false": Hides the image.

Output

The back image appears, and the front image is hidden.

Screenshot

"PictureBox Visible" (Screenshots/picturebox.png)

---

7. Closing a Form

Purpose

To close the current Form.

this.Close();

Explanation

- "this": Refers to the current Form.
- "Close()": Closes the Form.
- ";": Ends the statement.

Output

The current Form closes.

Screenshot

"Close Form" (Screenshots/close_form.png)

---

8. Closing the Entire Application

Purpose

To close the application.

Application.Exit();

Explanation

- "Application": Refers to the application.
- "Exit()": Requests the application to close.
- ";": Ends the statement.

Output

The application closes.

Difference Between "this.Close()" and "Application.Exit()"

Code| Purpose
"this.Close();"| Closes the current Form
"Application.Exit();"| Closes the entire application

---

9. Single-Line Comment

Purpose

To add a note inside the code.

// This is a comment.

Explanation

- "//" starts a single-line comment.
- The comment is not executed as program code.
- Comments help programmers understand the code.

Screenshot

"Single Line Comment" (Screenshots/single_line_comment.png)

---

10. Multi-Line Comment

Purpose

To write a comment on multiple lines.

/*
This is a comment.
It has multiple lines.
*/

Explanation

- "/*" starts the comment.
- "*/" ends the comment.
- The text inside the comment is not executed.

Screenshot

"Multi Line Comment" (Screenshots/multi_line_comment.png)

---

11. Syntax Error Example

Correct Code

MessageBox.Show("Hello World");

Incorrect Code

MessageBox.Show("Hello World"

Explanation

The incorrect code is missing:

- A closing parenthesis ")"
- A semicolon ";"

A Syntax Error is a mistake in the way code is written. Visual Studio helps identify these errors.

Screenshot

"Syntax Error" (Screenshots/syntax_error.png)

---
