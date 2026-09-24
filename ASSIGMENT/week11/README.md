### 1. Creating Variables

The following string variables are created to store the date information entered by the user.

```csharp
string DayoftheWeek, Month, Day, Year, FullDate;
```

![Creating Variables](Screenshots/creating_variable.png)

### 2. Assigning Variables

The values entered by the user in the TextBoxes are assigned to the corresponding variables.

```csharp
DayoftheWeek = dayOfWeekTextBox.Text;

Month = monthTextBox.Text;

Day = dayOfMonthTextBox.Text;

Year = yearTextBox.Text;
```

![Assigning Variables](Screenshots/Assigning.png)


### 3. Concatenation

The `+` operator is used to combine the values of the date variables into one complete date string.

```csharp
FullDate = DayoftheWeek + ", " + Month + " " + Day + ", " + Year;
```

![Concatenation](Screenshots/displaying.png)

### 4. Displaying the Result

The `FullDate` variable is assigned to the `Text` property of the `dateOutputLabel`. This displays the formatted date on the form.

```csharp
dateOutputLabel.Text = FullDate;
```

The `dateOutputLabel` is a Label control on `Form1` used to display the final date.

![Displaying Result](Screenshots/output.png)


### 5. Clearing the Input Fields

The input fields and the output label are cleared by setting their `Text` property to an empty string or by using the `Clear()` method.

```csharp
dayOfWeekTextBox.Text = "";

dayOfMonthTextBox.Clear();

monthTextBox.Text = string.Empty;

yearTextBox.Text = string.Empty;

dateOutputLabel.Text = string.Empty;
```

This allows the user to remove the previous input and output from the form.

![Clearing Input Fields](Screenshots/clear.png)

