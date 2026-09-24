### 1. Creating Variables

The following string variables are created to store the date information entered by the user.

![Creating Variables](Screenshots/creating_variable.png.png).

### 2. Assigning Variables

The values entered by the user in the TextBoxes are assigned to the corresponding variables.
![Assigning Variables](Screenshots/Assigning.png.png).


### 3. Concatenation

The `+` operator is used to combine the values of the date variables into one complete date string.
![Concatenation](Screenshots/displaying.png.png).

### 4. Displaying the Result

The `FullDate` variable is assigned to the `Text` property of the `dateOutputLabel`. This displays the formatted date on the form.
The `dateOutputLabel` is a Label control on `Form1` used to display the final date.
![Displaying ](Screenshots/output.png.png).


### 5. Clearing the Input Fields

The input fields and the output label are cleared by setting their `Text` property to an empty string or by using the `Clear()` method.
This allows the user to remove the previous input and output from the form
![Clearing ](Screenshots/clear.png.png).

