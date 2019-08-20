using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lesson2_Game_Rental_App
{
    public partial class Form_Game_Rental : Form
    {
        public Form_Game_Rental()
        {
            InitializeComponent();
            btnadmin_Save.Enabled = false;
            btnadmin__Cancel.Enabled = false;
            ndadmin_checkedout.Enabled = false;
        }
        // Created a structure to store all the varialbes related to the game database.
        public struct GameDatabase
        {
            public string Name;
            public string Platform;
            public DateTime ReleaseDate;
            public string Rating;
            public string Genre;
            public int Inventorycopies;
            public int Gamescheckedout;
        }

        // Declared an array to store all variables related to the game database.
        public GameDatabase[] GameArray = new GameDatabase[100];

        // Declared a varialbe to keep track of the current index when editing and adding values into the database.
        public int iCurrentIndex = 0;
        public int iEditIndex = 0;

        // Declared method to clear the admin window, once all operations have been made.
        public void ClearAdminWindow()
        {
            txtadmin_name.Clear();
            cbadmin_platform.SelectedIndex = -1;
            cbadmin_rating.SelectedIndex = -1;
            cbadmin_genre.SelectedIndex = -1;
            nudadmin_inventory.Value = 0;
            ndadmin_checkedout.Value = 0;
        }

        // Declared a method to clear items in the search window, once all operations have been made.
        public void ClearSearchWindow()
        {
            txtsearch_inventory.Clear();
            txtsearch_available.Clear();
            txtsearch_genre.Clear();
            txtsearch_rating.Clear();
            txtsearch_releasedate.Clear();
        }

        // Declared a method to clear items in the check in/ check out window. 
        public void ClearCheckWindow()
        {
            txtcheck_copies.Clear();
            txtcheck_name.Clear();
            cbcheck_platform.SelectedIndex = -1;
            nudcheckinout_copies.Value = 0;
        }
        private void btnadmin_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPlatform;
                int i;

                // Checked to make sure that all required fields have data in them.
                if (txtadmin_name.Text.Trim() == " " || cbadmin_platform.SelectedIndex == -1 || cbadmin_rating.SelectedIndex == -1 || cbadmin_genre.SelectedIndex == -1 || nudadmin_inventory.Value == 0 || nudadmin_inventory.Value == 0)
                {
                    MessageBox.Show("All required fields must be filled in to proceed");
                    return;
                }

                // Checks to make sure th array has space to save the game.
                if(iCurrentIndex > 99)
                {
                    MessageBox.Show("Sorry, the database is full.");
                    ClearAdminWindow();
                    return;
                }

                // Save the inputs into local variables for easy manipulation. 
                strName = txtadmin_name.Text.Trim();
                strPlatform = cbadmin_platform.SelectedItem.ToString();

                // Loop is being used to search the array.
                for (i = 0; i < iCurrentIndex; i++)
                {
                    // Checks to see if game is already in the database
                    if (GameArray[i].Name.ToLower() == strName.ToLower() && GameArray[i].Platform == strPlatform)
                    {
                        MessageBox.Show("This game is already in the database, try again");
                        return;
                    }
                }

                // Saves the new game's information in the array
                GameArray[iCurrentIndex].Name = strName;
                GameArray[iCurrentIndex].ReleaseDate = datetime_admin.Value.Date;
                GameArray[iCurrentIndex].Platform = cbadmin_platform.SelectedItem.ToString();
                GameArray[iCurrentIndex].Rating = cbadmin_rating.SelectedItem.ToString();
                GameArray[iCurrentIndex].Genre = cbadmin_genre.SelectedItem.ToString();
                GameArray[iCurrentIndex].Inventorycopies = Convert.ToInt32(nudadmin_inventory.Value);
                GameArray[iCurrentIndex].Gamescheckedout = 0;

                iCurrentIndex = iCurrentIndex + 1;


                // Clears previous data entries to prepare for new entries
                ClearAdminWindow();
            }

            catch
            {
                MessageBox.Show("Error, please try again");
                ClearAdminWindow();
                return;
            }
        }

        private void btnsearch_Inventory_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPlatform;
                int iInventory, i;

                // Clears the search window before adding data into it.
                ClearSearchWindow();

                // Checks that all the required fields have been filled in
                if (txtsearch_name.Text.Trim() == " " || cbsearch_platform.SelectedIndex == -1)
                {
                    MessageBox.Show("To perform this operation, please enter all required fields.");
                    return;
                }

                // Saves the textbox values (input) into local varialbes for easily manupulation. 
                strName = txtsearch_name.Text.Trim().ToString();
                strPlatform = cbsearch_platform.SelectedItem.ToString();
                iInventory = 0;

                for (i = 0; i < iCurrentIndex; i++)
                {
                    // Checks to see if the game is in the array.
                    if (GameArray[i].Name.ToLower() == strName.ToLower() && GameArray[i].Platform == strPlatform)
                    {
                        // If so, saves the inventory value from the array, into a local variable.
                        iInventory = GameArray[i].Inventorycopies;

                        // Outputs the inventory value to a textbox (in the search window)
                        txtsearch_inventory.Text = iInventory.ToString();

                        return;
                    }
                }

                // Shows an error message to the user if the game is not located in the database. 
                MessageBox.Show("The game you are looking for does not exist in the database.");
                return;

            }

            catch
            {
                MessageBox.Show("Error, please try again");
                ClearSearchWindow();
                return;
            }
        }

        private void btnsearch_Gamesavailable_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPlatform;
                int iCopiesAvailable, i;

                // Clears the window before outputting data. 
                ClearSearchWindow();

                // Checks to make sure that all required fields have been filled by the user.
                if (txtsearch_name.Text.Trim() == "" || cbsearch_platform.SelectedIndex == -1)
                {
                    MessageBox.Show("To perform this operation, please enter all required fields.");
                    return;
                }

                // Saves the textbox values (input) into local varialbes for easily manupulation.
                strName = txtsearch_name.Text.Trim().ToString();
                strPlatform = cbsearch_platform.SelectedItem.ToString();
                iCopiesAvailable = 0;

                for (i = 0; i < iCurrentIndex; i++)
                {
                    // Checks to see if the game exists in the database.
                    if (GameArray[i].Name.ToLower() == strName.ToLower() && GameArray[i].Platform == strPlatform)
                    {
                        iCopiesAvailable = GameArray[i].Inventorycopies - GameArray[i].Gamescheckedout;
                        if (iCopiesAvailable < 0)
                        {
                            iCopiesAvailable = 0;
                        }
                        // Outputs the number of copies available to a text box located in the search window.
                        txtsearch_available.Text = iCopiesAvailable.ToString();
                        return;
                    }
                }

                // Shows an error message to the user if the game is not located in the database. 
                MessageBox.Show("The game you are looking for does not exist in the database.");
                return;
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                ClearSearchWindow();
                return;
            }
        }

        private void btnsearch_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPlatform;
                int i, iGamesAvailable;

                // Clears search window before outputting. 
                ClearSearchWindow();

                // Checks to see if the user has entered information in all the required fields.
                if (txtsearch_name.Text.Trim() == "" || cbsearch_platform.SelectedIndex == -1)
                {
                    MessageBox.Show("To perform this operation, please enter all required fields.");
                    return;
                }

                // Saves the inputted (textbox) variables into local varialbes. 
                strName = txtsearch_name.Text.Trim().ToString();
                strPlatform = cbsearch_platform.SelectedItem.ToString();

                // Checks the array to see where the game is located. Then outputs the game's information to the user (in textboxes located in the search window)
                for (i = 0; i < iCurrentIndex; i++)
                {
                    if (GameArray[i].Name.ToLower() == strName.ToLower() && GameArray[i].Platform == strPlatform)
                    {
                        txtsearch_releasedate.Text = GameArray[i].ReleaseDate.ToString();
                        txtsearch_rating.Text = GameArray[i].Rating.ToString();
                        txtsearch_genre.Text = GameArray[i].Genre.ToString();
                        iGamesAvailable = (GameArray[i].Inventorycopies - GameArray[i].Gamescheckedout);
                        if (iGamesAvailable < 0)
                        {
                            iGamesAvailable = 0;
                        }
                        txtsearch_available.Text = iGamesAvailable.ToString();
                        txtsearch_inventory.Text = GameArray[i].Inventorycopies.ToString();
                        return;
                    }

                }

                // Outputs an error message if the game does not exists in the database. 
                MessageBox.Show("This game does not exist in the database");
                return;
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                ClearSearchWindow();
                return;
            }
        }

        private void btncheck_checkin_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPlatform;
                int i, iNumberofCopies;

                txtcheck_copies.Clear();

                // Checks to make sure that all information has been entered by the user. If not, an error message pops up.
                if (txtcheck_name.Text.Trim() == "" || cbcheck_platform.SelectedIndex == -1 || nudcheckinout_copies.Value == 0)
                {
                    MessageBox.Show("Please enter all required values to complete this operation.");
                    return;
                }

                // Saves the inputted values into local variables, in order to easily compare the values.
                strName = txtcheck_name.Text.Trim().ToString();
                strPlatform = cbcheck_platform.SelectedItem.ToString();
                iNumberofCopies = Convert.ToInt16(nudcheckinout_copies.Value);


                for (i = 0; i < iCurrentIndex; i++)
                {
                    // Checks the array to see if the game exists in the array.
                    if (GameArray[i].Name.ToLower() == strName.ToLower() && GameArray[i].Platform == strPlatform)
                    {
                        // If there are no games checked out, and the user is trying to check in, an error message pops up.
                        if (GameArray[i].Gamescheckedout == 0)
                        {
                            MessageBox.Show("The store does not own all of these copies.");
                            ClearCheckWindow();
                            return;
                        }

                        // Checks to make sure that the number of copies the user inputted are owned by the store
                        if (iNumberofCopies > (GameArray[i].Inventorycopies + GameArray[i].Gamescheckedout))
                        {
                            MessageBox.Show("The store does not own these many copies.");
                            ClearCheckWindow();
                            return;
                        }


                        else
                        {
                            // The value keeping track of games checked out increases and the inventory decreases by the number of copies inputted from the user.
                            GameArray[i].Gamescheckedout = GameArray[i].Gamescheckedout - iNumberofCopies;
                            GameArray[i].Inventorycopies = GameArray[i].Inventorycopies + iNumberofCopies;

                            // The user is then told that the check-in was sucessful.
                            MessageBox.Show("The game has been checked in.");
                            ClearCheckWindow();
                            return;
                        }
                    }
                }

                // If the game does not exists in the database, a message pops up to tell the user.
                MessageBox.Show("This game does not exist in the database");
                ClearCheckWindow();
                return;
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                ClearCheckWindow();
                return;
            }

        }

        private void btncheck_Checkout_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPlatform;
                int i, iNumberofCopies;

                txtcheck_copies.Clear();

                // Checks to make sure that all information has been entered by the user. If not, an error message pops up.
                if (txtcheck_name.Text.Trim() == "" || cbcheck_platform.SelectedIndex == -1 || nudcheckinout_copies.Value == 0)
                {
                    MessageBox.Show("Please enter all required values to complete this operation.");
                    return;
                }

                // Saves the inputted values into local variables, in order to easily compare the values.
                strName = txtcheck_name.Text.Trim().ToString();
                strPlatform = cbcheck_platform.SelectedItem.ToString();
                iNumberofCopies = Convert.ToInt16(nudcheckinout_copies.Value);

                for (i = 0; i < iCurrentIndex; i++)
                {
                    // Checks the array to see if the game exists in the array.
                    if (GameArray[i].Name.ToLower() == strName.ToLower() && GameArray[i].Platform == strPlatform)
                    {
                        // Checks to make sure that there are games available for check-out
                        if (GameArray[i].Inventorycopies == 0)
                        {
                            MessageBox.Show("Sorry, there are no games left to check out");
                            ClearCheckWindow();
                            return;
                        }

                        else
                        {
                            // The value keeping track of games checked out increases by one, and the inventory decreses.
                            GameArray[i].Gamescheckedout = GameArray[i].Gamescheckedout + iNumberofCopies;
                            GameArray[i].Inventorycopies = GameArray[i].Inventorycopies - iNumberofCopies;

                            // The user is then told that the check-in was sucessful.
                            MessageBox.Show("The game has been checked out.");
                            ClearCheckWindow();
                            return;
                        }
                    }
                }

                // If the game does not exists in the database, a message pops up to tell the user.
                MessageBox.Show("This game does not exist in the database");
                ClearCheckWindow();
                return;
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                ClearCheckWindow();
                return;
            }

        }

        private void btnadmin_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPlatform;
                int i;

                // Checks to see if all the required fields have information. 
                if (txtadmin_name.Text.Trim() == "" || cbadmin_platform.SelectedIndex == -1)
                {
                    MessageBox.Show("Please enter all of the required values.");
                    return;
                }

                // Saves the name & platform of the game locally in order to easily manipulate data.
                strName = txtadmin_name.Text.Trim().ToString();
                strPlatform = cbadmin_platform.SelectedItem.ToString();

                // Searches the array for the game
                for (i = 0; i < iCurrentIndex; i++)
                {
                    // If the game is found in the array, all the game's info is outputted to the user. 
                    if (GameArray[i].Name.ToLower() == strName.ToLower() && GameArray[i].Platform == strPlatform)
                    {
                        // Enabling Add, Delete, edit button and name & platform input, in order to Save and Cancel the edit function
                        btnadmin_Add.Enabled = false;
                        btnadmin_delete.Enabled = false;
                        btnadmin_Edit.Enabled = false;
                        txtadmin_name.Enabled = false;
                        cbadmin_platform.Enabled = false;

                        cbadmin_genre.Text = GameArray[i].Genre.ToString();
                        cbadmin_rating.Text = GameArray[i].Rating.ToString();
                        datetime_admin.Value = GameArray[i].ReleaseDate;
                        nudadmin_inventory.Value = GameArray[i].Inventorycopies;
                        ndadmin_checkedout.Value = GameArray[i].Gamescheckedout;
                        iEditIndex = i;

                        // Enables functions used in the edit (Save & Cancel button, checked out index).
                        btnadmin_Save.Enabled = true;
                        btnadmin__Cancel.Enabled = true;
                        ndadmin_checkedout.Enabled = true;
                        return;
                    }
                }

                MessageBox.Show("The game does not exist in the database.");
                return;
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                ClearAdminWindow();
                return;
            }
        }

        private void btnadmin_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int iInventory, iCheckedOut;

                // Checked to make sure that all required fields have data in them.
                if (cbadmin_rating.SelectedIndex == -1 || cbadmin_genre.SelectedIndex == -1 || nudadmin_inventory.Value == 0)
                {
                    MessageBox.Show("All required fields must be filled in to proceed");
                    return;
                }
                // Locally saving inventory and checked out values to easily compare & manipulate
                iCheckedOut = Convert.ToInt32(ndadmin_checkedout.Value);
                iInventory = Convert.ToInt32(nudadmin_inventory.Value);

                // Ensuring that the checked out values, and inventory values make sense with one another.
                if (iCheckedOut > iInventory)
                {
                    MessageBox.Show("The number of games checked out, and inventory are not possible values, try again");
                    return;
                }

                // Once all errors have been checked for, re-saves new info in the array
                GameArray[iEditIndex].Name = Convert.ToString(txtadmin_name.Text);
                GameArray[iEditIndex].ReleaseDate = datetime_admin.Value.Date;
                GameArray[iEditIndex].Platform = cbadmin_platform.SelectedItem.ToString();
                GameArray[iEditIndex].Rating = cbadmin_rating.SelectedItem.ToString();
                GameArray[iEditIndex].Genre = cbadmin_genre.SelectedItem.ToString();
                GameArray[iEditIndex].Inventorycopies = Convert.ToInt32(nudadmin_inventory.Value);
                GameArray[iEditIndex].Gamescheckedout = Convert.ToInt32(ndadmin_checkedout.Value);

                // Displays message box to user. Indicates a sucessful SAVE.
                MessageBox.Show("Sucessful save.");

                // Clears Admin window for re-entry
                ClearAdminWindow();

                // Enables & disables buttons & input boxes
                btnadmin_Add.Enabled = true;
                btnadmin_delete.Enabled = true;
                btnadmin_Edit.Enabled = true;
                txtadmin_name.Enabled = true;
                cbadmin_platform.Enabled = true;
                btnadmin_Save.Enabled = false;
                btnadmin__Cancel.Enabled = false;
                ndadmin_checkedout.Enabled = false;
                return;
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                ClearAdminWindow();
                return;
            }
        }

        private void btnadmin__Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                // If user cancels the Edit, no operation is performed
                // The window is cleared, and all the buttons/inputs are enabled & disabled
                ClearAdminWindow();
                btnadmin_Add.Enabled = true;
                btnadmin_delete.Enabled = true;
                btnadmin_Edit.Enabled = true;
                txtadmin_name.Enabled = true;
                cbadmin_platform.Enabled = true;
                btnadmin_Save.Enabled = false;
                btnadmin__Cancel.Enabled = false;
                ndadmin_checkedout.Enabled = false;

                return;
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                ClearAdminWindow();
                return;
            }
        }

        private void btnadmin_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string strName, strPlatform;
                int i, j;

                // Checks to make sure the name and platform have been inputted
                if (txtadmin_name.Text.Trim() == "" || cbadmin_platform.SelectedIndex == -1)
                {
                    MessageBox.Show("To delete, you must enter the name and platform of the game.");
                    return;
                }

                // Save the inputs into local variables for easy manipulation. 
                strName = txtadmin_name.Text.Trim();
                strPlatform = cbadmin_platform.SelectedItem.ToString();

                // Checks to see if the game is in the database
                for (i = 0; i < iCurrentIndex; i++)
                {
                    // If the game is in the database, a second loop is used to replace all array elements. 
                    if (GameArray[i].Name.ToLower() == strName.ToLower() && GameArray[i].Platform == strPlatform)
                    {
                        for (j = i; j < iCurrentIndex - 1; j++)
                        {
                            // Saves the next index elements in the index that information is being removed from.
                            GameArray[j].Name = GameArray[j + 1].Name;
                            GameArray[j].ReleaseDate = GameArray[j + 1].ReleaseDate;
                            GameArray[j].Platform = GameArray[j + 1].Platform;
                            GameArray[j].Rating = GameArray[j + 1].Rating;
                            GameArray[j].Genre = GameArray[j + 1].Genre;
                            GameArray[j].Inventorycopies = GameArray[j + 1].Inventorycopies;
                            GameArray[j].Gamescheckedout = GameArray[j + 1].Gamescheckedout;
                            // Tells the user that the delete was sucessful


                        }
                        MessageBox.Show("The game " + strName + " ,on " + strPlatform + " has been sucessfully deleted from the database");
                        iCurrentIndex = iCurrentIndex - 1;
                        return;
                    }
                }
                // Tells the user that the game is not in the database
                MessageBox.Show("Error, the game is not in the database");
                return;
            }

            catch
            {
                MessageBox.Show("Error please try again");
                ClearAdminWindow();
                return;
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                string filename;

                // The Save file window pops up so the user can easily choose where the file will be saved
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";

                // Once the user decides to save their information in the file, the following occurs:
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // The file's name is saved in a local variable.
                    filename = saveFileDialog1.FileName;

                    // A writer is created in the file, in order for the program to save information in it.
                    TextWriter MyWriter = new StreamWriter(filename);

                    // A loop runs in order to save the array's items in the text file
                    for (i = 0; i < iCurrentIndex; i++)
                    {
                        MyWriter.Write(GameArray[i].Name + "*");
                        MyWriter.Write(GameArray[i].Platform + "*");
                        MyWriter.Write(GameArray[i].ReleaseDate.ToString() + "*");
                        MyWriter.Write(GameArray[i].Rating + "*");
                        MyWriter.Write(GameArray[i].Genre + "*");
                        MyWriter.Write(GameArray[i].Inventorycopies.ToString() + "*");
                        MyWriter.WriteLine(GameArray[i].Gamescheckedout.ToString() + "*");
                    }
                    // The text file is then closed after everything is saved
                    MyWriter.Close();

                    MessageBox.Show("Sucessful Save.");
                    return;
                }
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                return;
            }
        }

        private void readToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                string Filename, strInput;
                string[] splittedInput;

                // The open file dialog box pops up so the user can select which file they would like to open.
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                // Once the file has been chosen, it will only be accepted if it is a text file.
                openFileDialog1.Filter = "Text Files (.txt)|*.txt";

                // Once the user had clicked the OK button in th dialog box, the file's information is given to the program
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // The file name is saved locally, in orde to easily manipulate.
                    Filename = openFileDialog1.FileName;
                    // iCurrentIndex is set to 0 so that the Game database is filled from the bottom up.
                    iCurrentIndex = 0;

                    // A text reader is set up to read the information from the text file, and place all the data in the array.
                    TextReader MyReader = new StreamReader(Filename);

                    // Using a loop, the information of each game is placed in the array, at the designated index
                    while ((strInput = MyReader.ReadLine()) != null)
                    {
                        // The input from the reader is first split and stored into different indexes of the splittedindex array
                        // The information is split based off the the symbol (*) that was chosen to separate the different values of info.
                        splittedInput = strInput.Split('*');
                        // The information is then saved into the GameDatabase Array
                        GameArray[iCurrentIndex].Name = splittedInput[0];
                        GameArray[iCurrentIndex].Platform = splittedInput[1];
                        GameArray[iCurrentIndex].ReleaseDate = Convert.ToDateTime(splittedInput[2]);
                        GameArray[iCurrentIndex].Rating = splittedInput[3];
                        GameArray[iCurrentIndex].Genre = splittedInput[4];
                        GameArray[iCurrentIndex].Inventorycopies = Convert.ToInt32(splittedInput[5]);
                        GameArray[iCurrentIndex].Gamescheckedout = Convert.ToInt32(splittedInput[6]);
                        // iCurrentIndex is increased by one to prepare for the next line of the text file.
                        iCurrentIndex = iCurrentIndex + 1;
                    }
                    // The text reader is closed once all the information from the text file is in the game database. 
                    MyReader.Close();

                    MessageBox.Show("Sucessful open.");
                    return;
                }
            }

            catch
            {
                MessageBox.Show("Error, please try again.");
                return;
            }
        }

        private void saveToFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName;
                int i;

                // The save file dialog box pops up so the user can choose which file they would like to use.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Grewal files (*.gwl)|*.gwl|All files (*.*)|*.*";

                // Once the user is done with the dialog box, a binary file and write is created
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog1.FileName;

                    FileStream fstream = new FileStream(FileName, FileMode.Create);

                    BinaryWriter binWriter = new BinaryWriter(fstream);

                    // A loop is then used to save the elements of the array into the file.
                    for (i = 0; i < iCurrentIndex; i++)
                    {
                        binWriter.Write(GameArray[i].Name);
                        binWriter.Write(GameArray[i].Platform);
                        binWriter.Write(Convert.ToString(GameArray[i].ReleaseDate));
                        binWriter.Write(GameArray[i].Rating);
                        binWriter.Write(GameArray[i].Genre);
                        binWriter.Write(GameArray[i].Inventorycopies);
                        binWriter.Write(GameArray[i].Gamescheckedout);
                    }

                    // Once all the information has been inputted, the binary file is flushed and closed.
                    binWriter.Flush();
                    binWriter.Close();

                    MessageBox.Show("Sucessful save.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error, please try again.");
                return;
            }
        }

        private void readToFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string Filename;
                // The open file dialog box pops so that the user is able to choose which file to open.
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                // Files of the type .gwl are accepted. 
                openFileDialog1.Filter = "Grewal files (*.gwl)|*.gwl|All files (*.*)|*.*";

                // Once the user pressed ok on the dialog box, the following occurs.
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // The filename is retrieved from the dialog box, and is locally saved
                    Filename = openFileDialog1.FileName;

                    // The current index is set to 0 so that the array fills up from the bottom.
                    iCurrentIndex = 0;

                    // A filestream and binary reader are created to read the information from the file.
                    FileStream fstream = new FileStream(Filename, FileMode.Open);
                    BinaryReader BinReader = new BinaryReader(fstream);

                    //The length of the binary file is retrieved. 
                    long length;
                    length = fstream.Length;

                    // The length of the file is used to limit the reader so that it stops when everything has been read.
                    while (fstream.Position < length)
                    {
                        GameArray[iCurrentIndex].Name = BinReader.ReadString();
                        GameArray[iCurrentIndex].Platform = BinReader.ReadString();
                        GameArray[iCurrentIndex].ReleaseDate = Convert.ToDateTime(BinReader.ReadString());
                        GameArray[iCurrentIndex].Rating = BinReader.ReadString();
                        GameArray[iCurrentIndex].Genre = BinReader.ReadString();
                        GameArray[iCurrentIndex].Inventorycopies = BinReader.ReadInt32();
                        GameArray[iCurrentIndex].Gamescheckedout = BinReader.ReadInt32();
                        iCurrentIndex = iCurrentIndex + 1;
                    }
                    // Once all the information is put into the array, the reader is then closed. 
                    BinReader.Close();

                    MessageBox.Show("Sucessful open.");
                    return;
                }
            }

            catch
            {
                // If all else fails, the catch statement ensures that the program doesn't crash. 
                MessageBox.Show("Error, please try again.");
                return;
            }

        }

    

    private void tab_Admin_Click(object sender, EventArgs e)
    {

    }

    private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void cbcheck_platform_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

        private void txtcheck_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
