# WindowPane
Performs similarly to a .NET MessageBox. Options to request/receive input from the user through controls such as a text box or drop down.
Access the single necessary class via MessageBox_.

## Example: REQUESTING A USER'S NAME

`private void button1_Click(object sender, EventArgs e)
{
    string response = MessageBox_._TextBox("What is your name?", "Name Request", "OK");
    textBox1.Text = response;
}`

## Example: REQUESTING A USER TO PICK THEIR NAME FROM A LIST OF NAMES

`private void PickAName(List<string> names)
{
    string chosenName = MessageBox_._DropDown_String("Pick your name from this list", names, "Pick a Name", "OK");
    textBox1.Text = chosenName;
}`

## Example: REQUESTING A USER TO PICK THEIR NAME FROM A LIST OF NAMES AND GETTING THE INDEX

`private void PickAName(List<string> names)
{
    int chosenNameIndex = MessageBox_._DropDown_Int("Pick your name from this list", names, "Pick a Name", "OK");
    numericUpDown1.Value = chosenNameIndex;
}`
